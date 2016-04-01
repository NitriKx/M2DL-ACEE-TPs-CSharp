using DataContrats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceContracts
{
    [ServiceContract(CallbackContract =typeof(IMeteoServiceCBC))]
    public interface IMeteoService
    {
        [OperationContract()]
        Int32 GetTemperature(String city);

        [OperationContract()]
        List<MeteoData> GetTemperatures();

        [OperationContract(IsOneWay=true)]
        void AskTemperatures();
    }
}
