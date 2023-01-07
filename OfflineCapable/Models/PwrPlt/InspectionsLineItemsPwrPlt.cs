using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OfflineCapable.Models.PwrPlt
{
    public class InspectionsLineItemsPwrPlt
    {
        [JsonPropertyName("@odata.context")]
        public string odatacontext { get; set; }
        [JsonPropertyName("value")]
        public List<InspectionLineItemPwrPlt> InspectionLineItems { get; set; }
    }

    public class InspectionLineItemPwrPlt
    {
        public string odataetag { get; set; }
        public string _cr71b_facilityaccountkeylookup_value { get; set; }
        public string _owningbusinessunit_value { get; set; }
        public string _cr71b_account_value { get; set; }
        public int statecode { get; set; }
        public int statuscode { get; set; }
        public string _createdby_value { get; set; }
        public string cr71b_businesskey { get; set; }
        public string _ownerid_value { get; set; }
        public DateTime modifiedon { get; set; }
        public string _owninguser_value { get; set; }
        public bool cr71b_personalsafetyindicator { get; set; }
        public string _modifiedby_value { get; set; }
        public int versionnumber { get; set; }
        public DateTime createdon { get; set; }
        public string cr71b_businessid { get; set; }
        public object cr71b_parentbusinesskey { get; set; }
        public object cr71b_stateid { get; set; }
        public object cr71b_createddate { get; set; }
        public object cr71b_businessidcode { get; set; }
        public object cr71b_owneraccountkey { get; set; }
        public object _cr71b_owneraccountkeylookup_value { get; set; }
        public object overriddencreatedon { get; set; }
        public object cr71b_federalid { get; set; }
        public object importsequencenumber { get; set; }
        public object _modifiedonbehalfby_value { get; set; }
        public object cr71b_franchisekey { get; set; }
        public object cr71b_anticipatedopeningdate { get; set; }
        public object cr71b_facilityaccountkey { get; set; }
        public object cr71b_externalbusinessid { get; set; }
        public object cr71b_createdbyusername { get; set; }
        public object cr71b_effectivedate { get; set; }
        public object utcconversiontimezonecode { get; set; }
        public object cr71b_usfsbusinessid { get; set; }
        public object cr71b_numberfarmsinbtu { get; set; }
        public object _createdonbehalfby_value { get; set; }
        public object cr71b_lastupdateddate { get; set; }
        public object cr71b_fein { get; set; }
        public object cr71b_lastupdatedbyusername { get; set; }
        public object cr71b_fipsnumber { get; set; }
        public object _owningteam_value { get; set; }
        public object cr71b_organizationtypekey { get; set; }
        public object timezoneruleversionnumber { get; set; }
    }

}
