using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataContract
{
    [System.Runtime.Serialization.DataContract()]
    public class MeteoData
    {
        [System.Runtime.Serialization.DataMember()]
        public int temperature;
        [System.Runtime.Serialization.DataMember()]
        public string ville;

        public MeteoData(int temperature, string ville)
        {
            this.temperature = temperature;
            this.ville = ville;
        }

    }
}
