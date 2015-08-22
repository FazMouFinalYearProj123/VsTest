using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SMS
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ITeacherService" in both code and config file together.
    [ServiceContract]
    public interface ITeacherService
    {
        [OperationContract]
        [WebGet(UriTemplate = "/teacher",RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json)]
        Teacher GetTeachers();

        [OperationContract]
        [WebGet(UriTemplate = "/teachers/all",RequestFormat = WebMessageFormat.Json,ResponseFormat = WebMessageFormat.Json)]
        List<Teacher> GetAllTeacher();

        [OperationContract]
        [WebInvoke(UriTemplate = "/add/teacher", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json, Method = "POST")]
        bool addTeacher(Teacher teacher);
    }
}
