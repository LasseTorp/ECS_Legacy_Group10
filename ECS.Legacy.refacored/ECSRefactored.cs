using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECS.Legacy.refacored
{
    public class ECSRefactored
    {
        private int _threshold;
        private readonly ITempSensor _tempSensor;
        private readonly IHeater _heater;

        public ECSRefactored(int thr, IHeater IH, ITempSensor ITS)
        {
            SetThreshold(thr);
            _tempSensor = ITS;
            _heater = IH;
        }

        public void Regulate()
        {
            var t = _tempSensor.GetTemp();
            if (t < _threshold)
                _heater.TurnOn();
            else
                _heater.TurnOff();

        }

        public void SetThreshold(int thr)
        {
            _threshold = thr;
        }

        public int GetThreshold()
        {
            return _threshold;
        }

        public int GetCurTemp()
        {
            return _tempSensor.GetTemp();
        }

        public bool RunSelfTest()
        {
            return _tempSensor.RunSelfTest() && _heater.RunSelfTest();
        }
    }
}
