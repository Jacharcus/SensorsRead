using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Bll
{
    using ConsoleApp.Dal;

    class SensorsBll
    {
        SetTemperature()
        {
            var currentTemperature = SensorsDal.Instance.GetTemperature();
            SensorsDal.SetTemperature(currentTemperature);
        }
    }
}
