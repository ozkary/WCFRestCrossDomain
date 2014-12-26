using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace ogbit.web.WcfRestCrossDomainSupport
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICars" in both code and config file together.
    [ServiceContract]
    public interface ICarService
    {
        [OperationContract(Name = "GetCars")]
        [WebInvoke(UriTemplate = "/GetCars", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(FaultException))]  
        Model.CarResponse GetCars(Model.CarRequest req);

        [OperationContract(Name = "GetCarsXdr")]
        [WebInvoke(UriTemplate = "/GetCarsXdr", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [FaultContract(typeof(FaultException))]        
        Model.CarResponse GetCarsXdr(Stream req);

    }
}
