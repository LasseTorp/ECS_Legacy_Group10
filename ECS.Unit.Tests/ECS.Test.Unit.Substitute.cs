using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy.refacored;
using NSubstitute;
using NUnit.Framework;

namespace ECS.Unit.Tests
{
    [TestFixture]
    class ECS
    {
        private ECSRefactored UUT_;
        private IHeater heater_;
        private ITempSensor tempSensor_;

        [SetUp]
        public void setUp()
        {
            heater_ = Substitute.For<IHeater>();
            tempSensor_ = Substitute.For<ITempSensor>();

            UUT_ = new ECSRefactored(25,heater_,tempSensor_);
        }

        [Test]
        public void RunSelfTest_TempSensorFails_SelfTestFails()
        {
            tempSensor_.RunSelfTest().Returns(false);
            heater_.RunSelfTest().Returns(true);
            Assert.IsFalse(UUT_.RunSelfTest());
        }

        [Test]
        public void Regulate_TempBelowThreshold_HeaterTurnedOn()
        {
            tempSensor_.GetTemp().Returns(UUT_.GetThreshold() - 10);
            UUT_.Regulate();
            heater_.Received(1).TurnOn();
        }
    }
}
