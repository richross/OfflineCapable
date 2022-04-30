using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OfflineCapable.Models
{
    public class InspectionsPwrPlt
    {
        [JsonPropertyName("@odata.context")]
        public string odatacontext { get; set; }
        [JsonPropertyName("value")]
        public InspectionPwrPlt[] Inspections { get; set; }
    }

    public class InspectionPwrPlt
    {
        [JsonPropertyName("@odata.etag")]
        public string odataetag { get; set; }
        public string _owningbusinessunit_value { get; set; }
        public int statecode { get; set; }
        public int statuscode { get; set; }
        public string crb24_name { get; set; }
        public string _ownerid_value { get; set; }
        public DateTime modifiedon { get; set; }
        public string _modifiedby_value { get; set; }
        public string _owninguser_value { get; set; }
        public string crb24_inspectionid { get; set; }
        public int versionnumber { get; set; }
        public DateTime createdon { get; set; }
        public string _createdby_value { get; set; }
        public object utcconversiontimezonecode { get; set; }
        public object overriddencreatedon { get; set; }
        public object importsequencenumber { get; set; }
        public object _createdonbehalfby_value { get; set; }
        public object timezoneruleversionnumber { get; set; }
        public object _modifiedonbehalfby_value { get; set; }
        public object _owningteam_value { get; set; }
    }


}
