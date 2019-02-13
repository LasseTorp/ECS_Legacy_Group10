using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ECS.Legacy.refacored;

namespace ECS.Unit.Tests
{
    class FakeHeater : IHeater
    {
        public bool _on { set; get; }
        public bool _status { get; set; }
        public void TurnOn()
        {
            _on = true;
        }

        public void TurnOff()
        {
            _on = false;
        }

        public bool RunSelfTest()
        {
            return _status;
        }
    }
}
