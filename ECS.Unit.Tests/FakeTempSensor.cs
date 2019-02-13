using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy.refacored;

namespace ECS.Unit.Tests
{
    class FakeTempSensor : ITempSensor
    {
        public int _temp { get; set; }
        public bool _status { get; set; }
        public int GetTemp()
        {
            return _temp;
        }

        public bool RunSelfTest()
        {
            return _status;
        }
    }
}
