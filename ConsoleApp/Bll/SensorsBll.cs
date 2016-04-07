using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp.Bll
{
    using ConsoleApp.Dal;

    class SensorsBll
    {
        InsertTemperature()
        {
            string currentTemperature = SensorsGPIODal.Instance.GetTemperature();
            SensorsDBDal.InsertTemperature(currentTemperature, DateTime.Now);
        }
    }
}
