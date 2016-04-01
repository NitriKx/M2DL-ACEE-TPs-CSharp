using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MeteoService : ServiceContract.MeteoServiceContract
    {
        public int GetTemperature()
        {
            return new Random().Next(0, 50);
        }
    }
}
