using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectServiceAutomation
{
    public class QuoteVocabulary : SimpleVocabulary
    {
        public QuoteVocabulary()
        {
            VocabularyName = "Quote";
            KeyPrefix = "commonDataModel.quote.projectserviceautomation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Quote;

            AddGroup("Quote Details for ProjectServiceAutomation", group =>
            {
			    Feasible = group.Add(new VocabularyKey(nameof(Feasible), "Feasibility", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrderType = group.Add(new VocabularyKey(nameof(OrderType), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdjustedGrossMargin = group.Add(new VocabularyKey(nameof(AdjustedGrossMargin), "Adjusted Gross Margin (%)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Competitive = group.Add(new VocabularyKey(nameof(Competitive), "Competitive", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerBudgetRollUp = group.Add(new VocabularyKey(nameof(CustomerBudgetRollUp), "Customer Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CustomerBudgetRollupBase = group.Add(new VocabularyKey(nameof(CustomerBudgetRollupBase), "Customer Budget (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedBudget = group.Add(new VocabularyKey(nameof(EstimatedBudget), "Estimated Budget", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedCompletionRollUp = group.Add(new VocabularyKey(nameof(EstimatedCompletionRollUp), "Estimated Completion", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedSchedule = group.Add(new VocabularyKey(nameof(EstimatedSchedule), "Estimated Schedule", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GrossMargin = group.Add(new VocabularyKey(nameof(GrossMargin), "Gross Margin (%)", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Profitability = group.Add(new VocabularyKey(nameof(Profitability), "Profitability", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalChargeableCostRollup = group.Add(new VocabularyKey(nameof(TotalChargeableCostRollup), "Total Chargeable Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalChargeableCostRollupBase = group.Add(new VocabularyKey(nameof(TotalChargeableCostRollupBase), "Total Chargeable Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalNonchargeableCostRollup = group.Add(new VocabularyKey(nameof(TotalNonchargeableCostRollup), "Total Non-chargeable Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalNonchargeableCostRollupBase = group.Add(new VocabularyKey(nameof(TotalNonchargeableCostRollupBase), "Total Non-chargeable Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="CustomerId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AccountCustomer"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AccountVendor"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ResourceCategory"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="ResourceCategory"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="ResourceCategory"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="InvoiceFrequency"/> to Vocab 'InvoiceFrequency.cdm.json/InvoiceFrequency' with Property 'InvoiceFrequencyId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="PriceLevelId"/> to Vocab 'PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="PriceLevelId"/> to Vocab 'PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="PriceList"/> to Vocab 'PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="PriceList"/> to Vocab 'PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="Product"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="ProjectTask"/> to Vocab 'ProjectTask.cdm.json/ProjectTask' with Property 'ProjectTaskId'
            ///Property <see cref="Task"/> to Vocab 'ProjectTask.cdm.json/ProjectTask' with Property 'ProjectTaskId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="SLAId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="SLAInvokedId"/> to Vocab '/core/applicationCommon/SLA.cdm.json/SLA' with Property 'SLAId'
            ///Property <see cref="CampaignId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/Campaign.cdm.json/Campaign' with Property 'CampaignId'
            ///Property <see cref="AccountManagerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ContractOrganizationalUnitId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/OrganizationalUnit.cdm.json/OrganizationalUnit' with Property 'OrganizationalUnitId'
            ///Property <see cref="QuoteId"/> to Vocab 'Quote.cdm.json/Quote' with Property 'QuoteId'
            ///Property <see cref="RegardingObjectId"/> to Vocab 'Quote.cdm.json/Quote' with Property 'QuoteId'
            ///Property <see cref="QuoteId"/> to Vocab 'Quote.cdm.json/Quote' with Property 'QuoteId'
            ///Property <see cref="Quote"/> to Vocab 'Quote.cdm.json/Quote' with Property 'QuoteId'
            ///Property <see cref="QuoteId"/> to Vocab 'Quote.cdm.json/Quote' with Property 'QuoteId'
            ///Property <see cref="Quote"/> to Vocab 'Quote.cdm.json/Quote' with Property 'QuoteId'
            ///Property <see cref="QuoteId"/> to Vocab 'Quote.cdm.json/Quote' with Property 'QuoteId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="QuoteLineDetail"/> to Vocab 'QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'QuoteLineTransactionId'
            ///Property <see cref="QuoteLineScheduleOfValue"/> to Vocab 'QuoteLineScheduleOfValue.cdm.json/QuoteLineScheduleOfValue' with Property 'QuoteLineScheduleOfValueId'
            ///Property <see cref="TransactionCategory"/> to Vocab 'TransactionCategory.cdm.json/TransactionCategory' with Property 'TransactionCategoryId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="QuoteLineScheduleOfValue"/> to Vocab 'QuoteLineScheduleOfValue.cdm.json/QuoteLineScheduleOfValue' with Property 'QuoteLineScheduleOfValueId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="QuoteLineId"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            ///Property <see cref="QuoteLineTransactionClassification"/> to Vocab 'QuoteLineTransactionClassification.cdm.json/QuoteLineTransactionClassification' with Property 'QuoteLineTransactionClassificationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="BookableResource"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            ///Property <see cref="ContactCustomer"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ContactVendor"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Origin"/> to Vocab 'QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'QuoteLineTransactionId'
            ///Property <see cref="ResourceOrganizationalUnitId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/OrganizationalUnit.cdm.json/OrganizationalUnit' with Property 'OrganizationalUnitId'
            ///Property <see cref="TransactionCategory"/> to Vocab 'TransactionCategory.cdm.json/TransactionCategory' with Property 'TransactionCategoryId'
            ///Property <see cref="Unit"/> to Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="UnitSchedule"/> to Vocab '/core/applicationCommon/foundationCommon/UnitGroup.cdm.json/UnitGroup' with Property 'UoMScheduleId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="QuoteLineId"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            ///Property <see cref="QuoteLineTransactionClassification"/> to Vocab 'QuoteLineTransactionClassification.cdm.json/QuoteLineTransactionClassification' with Property 'QuoteLineTransactionClassificationId'
            ///Property <see cref="TransactionCategory"/> to Vocab 'TransactionCategory.cdm.json/TransactionCategory' with Property 'TransactionCategoryId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="QuoteLineId"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            ///Property <see cref="ParentBundleId"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            ///Property <see cref="ProductAssociationId"/> to Vocab '/core/applicationCommon/foundationCommon/ProductAssociation.cdm.json/ProductAssociation' with Property 'ProductAssociationId'
            ///Property <see cref="SalesRepId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="UoMId"/> to Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="ParentBundleIdRef"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            ///Property <see cref="ParentBundleId"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            ///Property <see cref="ParentBundleIdRef"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="QuoteId"/> from Vocab 'Order.cdm.json/Order' with Property 'QuoteId'
            ///Property <see cref="QuoteDetailId"/> from Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'QuoteDetailId'
            ///Property <see cref="QuoteId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/ContactQuotes.cdm.json/ContactQuotes' with Property 'QuoteId'
            ///Property <see cref="QuoteId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/Order.cdm.json/Order' with Property 'QuoteId'
            ///Property <see cref="QuoteId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteClose.cdm.json/QuoteClose' with Property 'RegardingObjectId'
            ///Property <see cref="QuoteId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteId'
            ///Property <see cref="QuoteId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/portals/InviteRedemption.cdm.json/InviteRedemption' with Property 'RegardingObjectId'
            ///Property <see cref="QuoteId"/> from Vocab 'QuoteLineAnalyticsBreakdown.cdm.json/QuoteLineAnalyticsBreakdown' with Property 'Quote'
            ///Property <see cref="QuoteId"/> from Vocab 'QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'QuoteId'
            ///Property <see cref="QuoteId"/> from Vocab 'QuotePriceList.cdm.json/QuotePriceList' with Property 'Quote'
            ///Property <see cref="QuoteId"/> from Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteId'
            ///Property <see cref="QuoteLineTransactionId"/> from Vocab 'QuoteLineAnalyticsBreakdown.cdm.json/QuoteLineAnalyticsBreakdown' with Property 'QuoteLineDetail'
            ///Property <see cref="QuoteLineScheduleOfValueId"/> from Vocab 'QuoteLineAnalyticsBreakdown.cdm.json/QuoteLineAnalyticsBreakdown' with Property 'QuoteLineScheduleOfValue'
            ///Property <see cref="QuoteLineScheduleOfValueId"/> from Vocab 'QuoteLineInvoiceSchedule.cdm.json/QuoteLineInvoiceSchedule' with Property 'QuoteLineScheduleOfValue'
            ///Property <see cref="QuoteDetailId"/> from Vocab 'QuoteLineResourceCategory.cdm.json/QuoteLineResourceCategory' with Property 'QuoteLineId'
            ///Property <see cref="QuoteLineTransactionClassificationId"/> from Vocab 'QuoteLineResourceCategory.cdm.json/QuoteLineResourceCategory' with Property 'QuoteLineTransactionClassification'
            ///Property <see cref="QuoteLineTransactionId"/> from Vocab 'QuoteLineTransaction.cdm.json/QuoteLineTransaction' with Property 'Origin'
            ///Property <see cref="QuoteDetailId"/> from Vocab 'QuoteLineTransactionCategory.cdm.json/QuoteLineTransactionCategory' with Property 'QuoteLineId'
            ///Property <see cref="QuoteLineTransactionClassificationId"/> from Vocab 'QuoteLineTransactionCategory.cdm.json/QuoteLineTransactionCategory' with Property 'QuoteLineTransactionClassification'
            ///Property <see cref="QuoteDetailId"/> from Vocab 'QuoteLineTransactionClassification.cdm.json/QuoteLineTransactionClassification' with Property 'QuoteLineId'
            ///Property <see cref="QuoteDetailId"/> from Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'ParentBundleId'
            ///Property <see cref="QuoteDetailId"/> from Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'ParentBundleIdRef'
            ///Property <see cref="QuoteDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderProduct.cdm.json/OrderProduct' with Property 'QuoteDetailId'
            ///Property <see cref="QuoteDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/PropertyInstance.cdm.json/PropertyInstance' with Property 'RegardingObjectId'
            ///Property <see cref="QuoteDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteProduct.cdm.json/QuoteProduct' with Property 'ParentBundleId'
            ///Property <see cref="QuoteDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteProduct.cdm.json/QuoteProduct' with Property 'ParentBundleIdRef'
            #endregion
        }

        public VocabularyKey Feasible { get; private set; }
        public VocabularyKey OrderType { get; private set; }
        public VocabularyKey AdjustedGrossMargin { get; private set; }
        public VocabularyKey Competitive { get; private set; }
        public VocabularyKey CustomerBudgetRollUp { get; private set; }
        public VocabularyKey CustomerBudgetRollupBase { get; private set; }
        public VocabularyKey EstimatedBudget { get; private set; }
        public VocabularyKey EstimatedCompletionRollUp { get; private set; }
        public VocabularyKey EstimatedSchedule { get; private set; }
        public VocabularyKey GrossMargin { get; private set; }
        public VocabularyKey Profitability { get; private set; }
        public VocabularyKey TotalChargeableCostRollup { get; private set; }
        public VocabularyKey TotalChargeableCostRollupBase { get; private set; }
        public VocabularyKey TotalNonchargeableCostRollup { get; private set; }
        public VocabularyKey TotalNonchargeableCostRollupBase { get; private set; }
    }
}