using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using WMSServiceWebRole.DataModel;
using System.Data.Entity.Core.Objects;
using WMSServiceWebRole.DataContract;


namespace WMSServiceWebRole
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IWMSService
    {
        [OperationContract ]
        [WebInvoke(Method = "POST",
                 ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "/DeliveryArrival/Add")]
        string AddDeliveryArrival ( DeliveryTruckArrival  truckArrival);
        


        [OperationContract]
        [WebInvoke(Method = "POST",
                 ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "LoadAllDeliveryArrivals")]
        ObjectResult<spFindAllDeliveries_Result> LoadAllDeliveries(Duration duration);




        [OperationContract]
        [WebInvoke(Method = "GET",
                 ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "LoadAllWorkers()")]
        ObjectResult<spFindAllWorkers_Result> LoadAllWorkers();



        [OperationContract]
        [WebInvoke(Method = "POST",
                 ResponseFormat = WebMessageFormat.Json,
                  UriTemplate = "TokenAuthorization")]
        List<string> Login(Credential credential);


        [OperationContract]
        [WebInvoke(Method = "POST",
                         ResponseFormat = WebMessageFormat.Json,
                          UriTemplate = "AddUser")]
        int RegisterUser (Credential credential);

       




        // TODO: Add your service operations here
    }


    // Use a data contract as ill
}
