using ServiceContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataContrats;
using System.ServiceModel;

namespace Services
{
    public class MeteoService : IMeteoService
    {
        public void AskTemperatures()
        {
            System.Threading.Thread.Sleep(5000);

            var lst = GetTemperatures();

            var cbChannel = OperationContext.Current.GetCallbackChannel<IMeteoServiceCBC>();
            
            if (cbChannel != null)
            {
                cbChannel.PushData(lst);
            }     
        }

        public int GetTemperature(string city)
        {
            if (city.ToLower() == "toulouse")
                return 24;

            return 0;
        }

        public List<MeteoData> GetTemperatures()
        {
            return new List<MeteoData>()
            {
                new MeteoData()
                {
                    City="Toulouse",
                    Temperature=24
                },
                new MeteoData()
                {
                    City="Lyon",
                    Temperature=20
                }
            };
        }
    }
}
