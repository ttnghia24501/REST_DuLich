using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace REST_DuLich
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IProvinceCityImp" in both code and config file together.
    [ServiceContract]
    public interface IProvinceCityImp
    {
        //hiển thị
        [OperationContract]
        [WebInvoke(Method ="GET",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate ="api/v1/GetProvinceCityList")]
        List<ProvinceCity> GetProvinceCities();
        //thêm
        [OperationContract]
        [WebInvoke(Method = "POST",
        RequestFormat = WebMessageFormat.Json,
        ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.Bare,
        UriTemplate = "api/v1/CreateProvinceCity")]

        bool CreateProvinceCity(ProvinceCity city);
        //sửa
        [OperationContract]
        [WebInvoke(Method = "PUT",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/EditProvinceCity")]

        bool UpdateProvinceCity(ProvinceCity city);

        // xóa
        [OperationContract]
        [WebInvoke(Method = "DELETE",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare,
            UriTemplate = "api/v1/DeleteProvinceCity")]

        bool DeleteProvinceCity(int id);
    }
}
