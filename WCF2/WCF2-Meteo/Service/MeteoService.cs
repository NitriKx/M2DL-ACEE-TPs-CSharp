using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MeteoService : ServiceContract.MeteoServiceContract
    {
        public List<DataContract.MeteoData> GetMeteoData()
        {
            List<DataContract.MeteoData> meteoDataList = new List<DataContract.MeteoData>();
            meteoDataList.Add(new DataContract.MeteoData(new Random().Next(0, 40), "Toulouse"));
            return meteoDataList;
        }
    }
}
