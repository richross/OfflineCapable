using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace OfflineCapable.Models.PwrPlt
{
    public class InspectionsPwrPlt
    {
        [JsonPropertyName("@odata.context")]
        public string odatacontext { get; set; }
        [JsonPropertyName("value")]
        public List<InspectionPwrPlt> Inspections { get; set; }
    }

    public class InspectionPwrPlt
    {
        [JsonPropertyName("@odata.etag")]
        public string odataetag { get; set; }
        [JsonPropertyName("cr71b_InspectionKey")]
        public string InspectionName { get; set; }
        [JsonPropertyName("cr71b_InspectionId")]
        public string InspectionId { get; set; }
        public bool cr71b_requestfecwarningletter { get; set; }
        public int statecode { get; set; }
        public bool cr71b_requestfeccivilpenalty { get; set; }
        public bool cr71b_approveviolationwarningletter { get; set; }
        public bool cr71b_isunofficialinspection { get; set; }
        public bool cr71b_submittedtofda { get; set; }
        public DateTime createdon { get; set; }
        public bool cr71b_fdatopmanagementofficalnotdesignated { get; set; }
        public bool cr71b_issupervisorreviewrequested { get; set; }
        public bool cr71b_isoverallcompliancein { get; set; }
        public string _ownerid_value { get; set; }
        public DateTime modifiedon { get; set; }
        public bool cr71b_requestprosecution { get; set; }
        public bool cr71b_isprogramposted { get; set; }
        public bool cr71b_isinvoicegenerated { get; set; }
        public int versionnumber { get; set; }
        public string _cr71b_fdainspectionformtypekey_value { get; set; }
        public bool cr71b_approveregulatorycivilpenalty { get; set; }
        public bool cr71b_approveadministrativehearing { get; set; }
        public bool cr71b_approvefecwarningletter { get; set; }
        public int statuscode { get; set; }
        public bool cr71b_isprogramaccurate { get; set; }
        public string _modifiedby_value { get; set; }
        public bool cr71b_requestregulatorycivilpenalty { get; set; }
        public bool cr71b_snapshotprocessed { get; set; }
        public bool cr71b_requestviolationwarningletter { get; set; }
        public bool cr71b_approvefeccivilpenalty { get; set; }
        public string _createdby_value { get; set; }
        public bool cr71b_fdaintentionaladulteration { get; set; }
        public string _owningbusinessunit_value { get; set; }
        public bool cr71b_isinspectionreviewed { get; set; }
        public string _owninguser_value { get; set; }
        public bool cr71b_iscontractinspection { get; set; }
        public bool cr71b_sendemail { get; set; }
        public bool cr71b_approveprosecution { get; set; }
        public bool cr71b_requestadministrativehearing { get; set; }
        public object cr71b_lastupdateddate { get; set; }
        public object cr71b_fee { get; set; }
        public object cr71b_inspectionformtypekey { get; set; }
        public object cr71b_businesskey { get; set; }
        public object cr71b_fdainspectionbasistypekey { get; set; }
        public object cr71b_recalleventkey { get; set; }
        public object cr71b_registeredproductlabelstatustypekey { get; set; }
        public object cr71b_registeredproductkey { get; set; }
        public object cr71b_fdatopmanagementofficalnotdesignatedreason { get; set; }
        public object cr71b_unofficialreasoncomment { get; set; }
        [JsonPropertyName("_cr71b_business_value")]
        public string BusinessFkId { get; set; }
        public object cr71b_fdasamplenumber { get; set; }
        public object cr71b_fdaintentionaladulterationcomment { get; set; }
        public object cr71b_fdainspectiontypekey { get; set; }
        public object cr71b_fddaendorsementtext { get; set; }
        public object cr71b_fdainspectionrefusaltypekey { get; set; }
        public object _modifiedonbehalfby_value { get; set; }
        public object cr71b_unitkey { get; set; }
        public object cr71b_inspectionreasontypekey { get; set; }
        public object cr71b_fdasampledescription { get; set; }
        public object cr71b_mynewchoicefield { get; set; }
        public object cr71b_businessprogramkey { get; set; }
        public object cr71b_fdaconsumercomplaintid { get; set; }
        public object cr71b_createdbyusername { get; set; }
        public object importsequencenumber { get; set; }
        public object cr71b_revieweddate { get; set; }
        public object cr71b_repeatriskfactors { get; set; }
        public object utcconversiontimezonecode { get; set; }
        public DateTime? cr71b_inspectiondate { get; set; }
        public object cr71b_lastupdatedbyusername { get; set; }
        public object _createdonbehalfby_value { get; set; }
        public object cr71b_lastfdamessagedate { get; set; }
        public object cr71b_firstfdamessagedate { get; set; }
        public object cr71b_attachmentcode { get; set; }
        public object _owningteam_value { get; set; }
        public object cr71b_riskfactors { get; set; }
        public object cr71b_usfsinspectionid { get; set; }
        public object cr71b_fdainspectionstatustypekey { get; set; }
        public object cr71b_emailaddress { get; set; }
        public object cr71b_fdaassignmentid { get; set; }
        public object cr71b_overallscore { get; set; }
        public object cr71b_inspectionstatustypekey { get; set; }
        public object cr71b_requestreinspectdate { get; set; }
        public object overriddencreatedon { get; set; }
        public int? timezoneruleversionnumber { get; set; }
        public object cr71b_requestedinspectionreasontypekey { get; set; }
        public object cr71b_createddate { get; set; }
        public object cr71b_fdaoperationid { get; set; }
        public object cr71b_supervisorreviewcomment { get; set; }
        public object cr71b_organizationtypekey { get; set; }
    }
}
