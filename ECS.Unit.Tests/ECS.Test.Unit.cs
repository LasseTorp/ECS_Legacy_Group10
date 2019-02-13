using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy.refacored;
using NUnit.Framework;

namespace ECS.Unit.Tests
{
    [TestFixture]
    public class ECS_Test_Unit
    {
        private ECSRefactored UUT_;
        private FakeHeater fakeHeater_;
        private FakeTempSensor fakeTempSensor_;

        [SetUp]
        public void setUp()
        {
            
            fakeHeater_ = new FakeHeater();
            fakeTempSensor_ = new FakeTempSensor();
            UUT_ = new ECSRefactored(28, fakeHeater_, fakeTempSensor_);
        }

        [Test]
        public void regulate_30degrees_false()  //Mock
        {
            fakeTempSensor_._temp = 30;
            UUT_.Regulate();
            Assert.That(fakeHeater_._on, Is.EqualTo(false));
        }

        [Test]
        public void regulate_25degrees_true()  //Mock
        {
            fakeTempSensor_._temp = 25;
            UUT_.Regulate();
            Assert.That(fakeHeater_._on, Is.EqualTo(true));
        }

    }
}
