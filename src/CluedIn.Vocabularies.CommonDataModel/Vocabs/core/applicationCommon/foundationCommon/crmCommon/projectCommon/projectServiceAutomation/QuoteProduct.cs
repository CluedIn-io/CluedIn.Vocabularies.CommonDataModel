using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectServiceAutomation
{
    public class QuoteProductVocabulary : SimpleVocabulary
    {
        public QuoteProductVocabulary()
        {
            VocabularyName = "Quote Product";
            KeyPrefix = "commonDataModel.quoteproduct.projectserviceautomation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.QuoteProduct;

            AddGroup("QuoteProduct Details for ProjectServiceAutomation", group =>
            {
			    BillingMethod = group.Add(new VocabularyKey(nameof(BillingMethod), "Billing Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingStartDate = group.Add(new VocabularyKey(nameof(BillingStartDate), "Billing Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BudgetAmount = group.Add(new VocabularyKey(nameof(BudgetAmount), "Customer Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BudgetAmountBase = group.Add(new VocabularyKey(nameof(BudgetAmountBase), "Budget Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), "Cost Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostAmountBase = group.Add(new VocabularyKey(nameof(CostAmountBase), "CostAmount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostPricePerUnit = group.Add(new VocabularyKey(nameof(CostPricePerUnit), "Cost Per Unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    CostPricePerUnitBase = group.Add(new VocabularyKey(nameof(CostPricePerUnitBase), "Cost Price Per Unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IncludeExpense = group.Add(new VocabularyKey(nameof(IncludeExpense), "Include Expense", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IncludeFee = group.Add(new VocabularyKey(nameof(IncludeFee), "Include Fee", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IncludeMaterial = group.Add(new VocabularyKey(nameof(IncludeMaterial), "Include Material", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IncludeTime = group.Add(new VocabularyKey(nameof(IncludeTime), "Include Time", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LineType = group.Add(new VocabularyKey(nameof(LineType), "Line Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OpportunityLine = group.Add(new VocabularyKey(nameof(OpportunityLine), "Opportunity Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    QuoteLineDescription = group.Add(new VocabularyKey(nameof(QuoteLineDescription), "Quote Line Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="InvoiceFrequency"/> to Vocab 'InvoiceFrequency.cdm.json/InvoiceFrequency' with Property 'InvoiceFrequencyId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="QuoteId"/> to Vocab 'Quote.cdm.json/Quote' with Property 'QuoteId'
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
            ///Property <see cref="ParentBundleId"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            ///Property <see cref="ProductAssociationId"/> to Vocab '/core/applicationCommon/foundationCommon/ProductAssociation.cdm.json/ProductAssociation' with Property 'ProductAssociationId'
            ///Property <see cref="SalesRepId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="UoMId"/> to Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="ParentBundleIdRef"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            ///Property <see cref="ParentBundleId"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            ///Property <see cref="ParentBundleIdRef"/> to Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'QuoteDetailId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="QuoteDetailId"/> from Vocab 'OrderProduct.cdm.json/OrderProduct' with Property 'QuoteDetailId'
            ///Property <see cref="QuoteDetailId"/> from Vocab 'QuoteLineResourceCategory.cdm.json/QuoteLineResourceCategory' with Property 'QuoteLineId'
            ///Property <see cref="QuoteDetailId"/> from Vocab 'QuoteLineTransactionCategory.cdm.json/QuoteLineTransactionCategory' with Property 'QuoteLineId'
            ///Property <see cref="QuoteDetailId"/> from Vocab 'QuoteLineTransactionClassification.cdm.json/QuoteLineTransactionClassification' with Property 'QuoteLineId'
            ///Property <see cref="QuoteDetailId"/> from Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'ParentBundleId'
            ///Property <see cref="QuoteDetailId"/> from Vocab 'QuoteProduct.cdm.json/QuoteProduct' with Property 'ParentBundleIdRef'
            ///Property <see cref="QuoteDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OrderProduct.cdm.json/OrderProduct' with Property 'QuoteDetailId'
            ///Property <see cref="QuoteDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/PropertyInstance.cdm.json/PropertyInstance' with Property 'RegardingObjectId'
            ///Property <see cref="QuoteDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteProduct.cdm.json/QuoteProduct' with Property 'ParentBundleId'
            ///Property <see cref="QuoteDetailId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/QuoteProduct.cdm.json/QuoteProduct' with Property 'ParentBundleIdRef'
            #endregion
        }

        public VocabularyKey BillingMethod { get; private set; }
        public VocabularyKey BillingStartDate { get; private set; }
        public VocabularyKey BudgetAmount { get; private set; }
        public VocabularyKey BudgetAmountBase { get; private set; }
        public VocabularyKey CostAmount { get; private set; }
        public VocabularyKey CostAmountBase { get; private set; }
        public VocabularyKey CostPricePerUnit { get; private set; }
        public VocabularyKey CostPricePerUnitBase { get; private set; }
        public VocabularyKey IncludeExpense { get; private set; }
        public VocabularyKey IncludeFee { get; private set; }
        public VocabularyKey IncludeMaterial { get; private set; }
        public VocabularyKey IncludeTime { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey OpportunityLine { get; private set; }
        public VocabularyKey QuoteLineDescription { get; private set; }
    }
}