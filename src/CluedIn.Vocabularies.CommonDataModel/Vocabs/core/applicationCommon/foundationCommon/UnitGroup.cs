using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.FoundationCommon
{
    public class UnitGroupVocabulary : SimpleVocabulary
    {
        public UnitGroupVocabulary()
        {
            VocabularyName = "Unit Group";
            KeyPrefix = "commonDataModel.unitgroup.foundationcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.UnitGroup;

            AddGroup("UnitGroup Details for FoundationCommon", group =>
            {
			    UoMScheduleId = group.Add(new VocabularyKey(nameof(UoMScheduleId), "Unit Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BaseUoMName = group.Add(new VocabularyKey(nameof(BaseUoMName), "Base Unit name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedByExternalParty = group.Add(new VocabularyKey(nameof(CreatedByExternalParty), "Created By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedByExternalParty = group.Add(new VocabularyKey(nameof(ModifiedByExternalParty), "Modified By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="UoMScheduleId"/> from Vocab 'PriceListItem.cdm.json/PriceListItem' with Property 'UoMScheduleId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'Product.cdm.json/Product' with Property 'DefaultUoMScheduleId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'Unit.cdm.json/Unit' with Property 'UoMScheduleId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/accelerators/automotive/Unit.cdm.json/Unit' with Property 'UoMScheduleId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/accelerators/financialServices/banking/Product.cdm.json/Product' with Property 'DefaultUoMScheduleId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/EstimateLine.cdm.json/EstimateLine' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/Expense.cdm.json/Expense' with Property 'UnitGroup'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/JournalLine.cdm.json/JournalLine' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/OpportunityLineTransaction.cdm.json/OpportunityLineTransaction' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/Product.cdm.json/Product' with Property 'DefaultUoMScheduleId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/ResourceCategoryPriceLevel.cdm.json/ResourceCategoryPriceLevel' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/TransactionCategory.cdm.json/TransactionCategory' with Property 'UnitGroup'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/TransactionCategoryPriceLevel.cdm.json/TransactionCategoryPriceLevel' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/projectServiceAutomation/TransactionType.cdm.json/TransactionType' with Property 'UnitGroup'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/projectCommon/scheduling/Actual.cdm.json/Actual' with Property 'UnitSchedule'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/sales/PriceListItem.cdm.json/PriceListItem' with Property 'UoMScheduleId'
            ///Property <see cref="UoMScheduleId"/> from Vocab 'crmCommon/service/ContractLine.cdm.json/ContractLine' with Property 'UoMScheduleId'
            #endregion
        }

        public VocabularyKey UoMScheduleId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey BaseUoMName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey CreatedByExternalParty { get; private set; }
        public VocabularyKey ModifiedByExternalParty { get; private set; }
    }
}