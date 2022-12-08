using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Scheduling
{
    public class OrganizationalUnitVocabulary : SimpleVocabulary
    {
        public OrganizationalUnitVocabulary()
        {
            VocabularyName = "Organizational Unit";
            KeyPrefix = "commonDataModel.organizationalunit.scheduling";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.OrganizationalUnit;

            AddGroup("OrganizationalUnit Details for Scheduling", group =>
            {
			    OrganizationalUnitId = group.Add(new VocabularyKey(nameof(OrganizationalUnitId), "Organizational Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
			    Latitude = group.Add(new VocabularyKey(nameof(Latitude), "Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Longitude = group.Add(new VocabularyKey(nameof(Longitude), "Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="OrganizationId"/> to Vocab 'Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="Currency"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="OrganizationalUnitId"/> from Vocab 'Actual.cdm.json/Actual' with Property 'ContractingUnit'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab 'Actual.cdm.json/Actual' with Property 'ResourceOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/accelerators/nonProfit/nonProfitVolunteers/Project.cdm.json/Project' with Property 'ContractOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResource.cdm.json/BookableResource' with Property 'OrganizationalUnit'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/EstimateLine.cdm.json/EstimateLine' with Property 'ResourceOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Expense.cdm.json/Expense' with Property 'ResourceOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'ContractingUnit'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'ResourceOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/JournalLine.cdm.json/JournalLine' with Property 'ContractingUnit'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/JournalLine.cdm.json/JournalLine' with Property 'ResourceOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Opportunity.cdm.json/Opportunity' with Property 'ContractOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OpportunityLineTransaction.cdm.json/OpportunityLineTransaction' with Property 'ResourceOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Order.cdm.json/Order' with Property 'ContractOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'ResourceOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Project.cdm.json/Project' with Property 'ContractOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectParameter.cdm.json/ProjectParameter' with Property 'DefaultOrganizationalUnit'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectTask.cdm.json/ProjectTask' with Property 'ResourceOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ProjectTeam.cdm.json/ProjectTeam' with Property 'ResourcingUnit'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/Quote.cdm.json/Quote' with Property 'ContractOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'ResourceOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/ResourceCategoryPriceLevel.cdm.json/ResourceCategoryPriceLevel' with Property 'ResourcingUnit'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/RolePriceMarkup.cdm.json/RolePriceMarkup' with Property 'ResourcingUnit'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/projectServiceAutomation/TimeEntry.cdm.json/TimeEntry' with Property 'ResourceOrganizationalUnitId'
            ///Property <see cref="OrganizationalUnitId"/> from Vocab 'RequirementOrganizationUnit.cdm.json/RequirementOrganizationUnit' with Property 'OrganizationalUnit'
            #endregion
        }

        public VocabularyKey OrganizationalUnitId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}