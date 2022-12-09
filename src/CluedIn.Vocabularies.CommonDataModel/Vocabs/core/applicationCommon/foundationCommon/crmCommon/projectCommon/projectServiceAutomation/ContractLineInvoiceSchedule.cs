using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ContractLineInvoiceScheduleVocabulary : SimpleVocabulary
    {
        public ContractLineInvoiceScheduleVocabulary()
        {
            VocabularyName = "Contract Line Invoice Schedule";
            KeyPrefix = "commonDataModel.contractlineinvoiceschedule";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ContractLineInvoiceSchedule;

            AddGroup("ContractLineInvoiceSchedule Details for ProjectServiceAutomation", group =>
            {
			    ContractLineInvoiceScheduleId = group.Add(new VocabularyKey(nameof(ContractLineInvoiceScheduleId), "Project Contract Line Invoice Schedule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContractLine = group.Add(new VocabularyKey(nameof(ContractLine), "(Deprecated) Project Contract Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InvoiceRunDate = group.Add(new VocabularyKey(nameof(InvoiceRunDate), "Invoice Run Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InvoiceRunStatus = group.Add(new VocabularyKey(nameof(InvoiceRunStatus), "Invoice Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionCutOffDate = group.Add(new VocabularyKey(nameof(TransactionCutOffDate), "Transaction Cut Off Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="ContractLineId"/> to Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'SalesOrderDetailId'
            ///Property <see cref="ContractLineScheduleOfValue"/> to Vocab 'ContractLineScheduleOfValue.cdm.json/ContractLineScheduleOfValue' with Property 'ContractLineScheduleOfValueId'
            ///Property <see cref="Invoice"/> to Vocab 'Invoice.cdm.json/Invoice' with Property 'InvoiceId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ContractLine { get; private set; }
        public VocabularyKey ContractLineInvoiceScheduleId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey InvoiceRunDate { get; private set; }
        public VocabularyKey InvoiceRunStatus { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey TransactionCutOffDate { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}