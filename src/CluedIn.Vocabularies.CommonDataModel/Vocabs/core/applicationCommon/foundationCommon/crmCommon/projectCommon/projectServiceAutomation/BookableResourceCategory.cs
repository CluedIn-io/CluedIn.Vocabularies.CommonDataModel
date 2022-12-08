using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectServiceAutomation
{
    public class BookableResourceCategoryVocabulary : SimpleVocabulary
    {
        public BookableResourceCategoryVocabulary()
        {
            VocabularyName = "Bookable Resource Category";
            KeyPrefix = "commonDataModel.bookableresourcecategory.projectserviceautomation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.BookableResourceCategory;

            AddGroup("BookableResourceCategory Details for ProjectServiceAutomation", group =>
            {
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TargetUtilization = group.Add(new VocabularyKey(nameof(TargetUtilization), "Target Utilization", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="TransactionCategory"/> to Vocab 'TransactionCategory.cdm.json/TransactionCategory' with Property 'TransactionCategoryId'
            ///Property <see cref="ResourceCategory"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="ResourceCategory"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Resource"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResourceBooking.cdm.json/BookableResourceBooking' with Property 'ResourceCategoryId'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab '/core/applicationCommon/foundationCommon/BookableResourceCategoryAssn.cdm.json/BookableResourceCategoryAssn' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResourceBookingHeader.cdm.json/BookableResourceBookingHeader' with Property 'ResourceCategoryId'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'BookableResourceCategoryAssn.cdm.json/BookableResourceCategoryAssn' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'EstimateLine.cdm.json/EstimateLine' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'Fact.cdm.json/Fact' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'InvoiceLineTransaction.cdm.json/InvoiceLineTransaction' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'JournalLine.cdm.json/JournalLine' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'OpportunityLineResourceCategory.cdm.json/OpportunityLineResourceCategory' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'OpportunityLineTransaction.cdm.json/OpportunityLineTransaction' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'OrderLineResourceCategory.cdm.json/OrderLineResourceCategory' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'OrderLineTransaction.cdm.json/OrderLineTransaction' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'ProjectApproval.cdm.json/ProjectApproval' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'ProjectParameter.cdm.json/ProjectParameter' with Property 'ProjectManagerRole'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'ProjectParameter.cdm.json/ProjectParameter' with Property 'TeamMemberRole'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'ProjectTask.cdm.json/ProjectTask' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'ProjectTeam.cdm.json/ProjectTeam' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'QuoteLineAnalyticsBreakdown.cdm.json/QuoteLineAnalyticsBreakdown' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'QuoteLineResourceCategory.cdm.json/QuoteLineResourceCategory' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'ResourceCategoryPriceLevel.cdm.json/ResourceCategoryPriceLevel' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'ResourceRequest.cdm.json/ResourceRequest' with Property 'Roleid'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'RoleCompetencyRequirement.cdm.json/RoleCompetencyRequirement' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'RolePriceMarkup.cdm.json/RolePriceMarkup' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'RoleUtilization.cdm.json/RoleUtilization' with Property 'Role'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab 'TimeEntry.cdm.json/TimeEntry' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/Actual.cdm.json/Actual' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/RequirementResourceCategory.cdm.json/RequirementResourceCategory' with Property 'ResourceCategory'
            ///Property <see cref="BookableResourceCategoryId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/ResourceRequirement.cdm.json/ResourceRequirement' with Property 'DeprecatedRole'
            #endregion
        }

        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey TargetUtilization { get; private set; }
    }
}