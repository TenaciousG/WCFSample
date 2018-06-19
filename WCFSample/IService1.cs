using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WCFSample
{
    
    /// <summary>
    /// By default, WebInvokeAttribute maps POST calls to the operation.
    /// You can, however, specify the HTTP method(for example, HEAD, PUT, or DELETE) to map to the operation by specifying a "method=" parameter.
    /// WebGetAttribute does not have a "method=" parameter and only maps GET calls to the service operation.
    /// </summary>


    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        //[WebGet]  //ikke nødvendig, mest brukt av REST-tjenester?
        string GetData(int value);

        [OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);

        // TODO: Add your service operations here
    }
    
    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WCFSample.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
