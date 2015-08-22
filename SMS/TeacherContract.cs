using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace SMS
{
    [DataContract]
    public class TeacherContract
    {
        [DataMember]
        public int teacherId { get; set; }
        [DataMember]
        public string firstName { get; set; }
        [DataMember]
        public string lastName { get; set; }
    }
}