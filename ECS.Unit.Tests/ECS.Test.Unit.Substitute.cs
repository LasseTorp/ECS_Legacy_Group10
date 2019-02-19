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
    }
}
