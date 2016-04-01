using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContract
{
    [System.ServiceModel.ServiceContract]
    public interface MeteoServiceContract
    {
        [System.ServiceModel.OperationContract]
        Int32 GetTemperature();
    }
}
