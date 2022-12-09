using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class EstimateLineVocabulary : SimpleVocabulary
    {
        public EstimateLineVocabulary()
        {
            VocabularyName = "Estimate Line";
            KeyPrefix = "commonDataModel.estimateline";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.EstimateLine;

            AddGroup("EstimateLine Details for ProjectServiceAutomation", group =>
            {
			    EstimateLineId = group.Add(new VocabularyKey(nameof(EstimateLineId), "Estimate Line", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), "Accounting Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AmountMethod = group.Add(new VocabularyKey(nameof(AmountMethod), "Amount Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BasisAmount = group.Add(new VocabularyKey(nameof(BasisAmount), "Basis Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BasisAmountBase = group.Add(new VocabularyKey(nameof(BasisAmountBase), "Basis Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BasisPrice = group.Add(new VocabularyKey(nameof(BasisPrice), "Basis Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BasisPriceBase = group.Add(new VocabularyKey(nameof(BasisPriceBase), "Basis Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BasisQuantity = group.Add(new VocabularyKey(nameof(BasisQuantity), "Basis Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerType = group.Add(new VocabularyKey(nameof(CustomerType), "Customer Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), "Document Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), "End Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatePerDayLines = group.Add(new VocabularyKey(nameof(EstimatePerDayLines), "Estimate Per Day Lines", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRateDate = group.Add(new VocabularyKey(nameof(ExchangeRateDate), "Exchange Rate Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfResources = group.Add(new VocabularyKey(nameof(NumberOfResources), "Number of resources", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Percent = group.Add(new VocabularyKey(nameof(Percent), "Percent", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Price = group.Add(new VocabularyKey(nameof(Price), "Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PriceBase = group.Add(new VocabularyKey(nameof(PriceBase), "Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), "Start Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionClassification = group.Add(new VocabularyKey(nameof(TransactionClassification), "Transaction Class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionTypeCode = group.Add(new VocabularyKey(nameof(TransactionTypeCode), "Transaction Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VendorType = group.Add(new VocabularyKey(nameof(VendorType), "Vendor Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="AccountCustomer"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="AccountVendor"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ResourceCategory"/> to Vocab 'BookableResourceCategory.cdm.json/BookableResourceCategory' with Property 'BookableResourceCategoryId'
            ///Property <see cref="Estimate"/> to Vocab 'Estimate.cdm.json/Estimate' with Property 'EstimateId'
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
            ///Property <see cref="PriceList"/> to Vocab 'PriceList.cdm.json/PriceList' with Property 'PriceLevelId'
            ///Property <see cref="Product"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="ResourceOrganizationalUnitId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/scheduling/OrganizationalUnit.cdm.json/OrganizationalUnit' with Property 'OrganizationalUnitId'
            ///Property <see cref="Task"/> to Vocab 'ProjectTask.cdm.json/ProjectTask' with Property 'ProjectTaskId'
            ///Property <see cref="TransactionCategory"/> to Vocab 'TransactionCategory.cdm.json/TransactionCategory' with Property 'TransactionCategoryId'
            ///Property <see cref="Unit"/> to Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="UnitSchedule"/> to Vocab '/core/applicationCommon/foundationCommon/UnitGroup.cdm.json/UnitGroup' with Property 'UoMScheduleId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="EstimateLineId"/> from Vocab 'Fact.cdm.json/Fact' with Property 'EstimateLineId'
            #endregion
        }

        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey AmountMethod { get; private set; }
        public VocabularyKey BasisAmount { get; private set; }
        public VocabularyKey BasisAmountBase { get; private set; }
        public VocabularyKey BasisPrice { get; private set; }
        public VocabularyKey BasisPriceBase { get; private set; }
        public VocabularyKey BasisQuantity { get; private set; }
        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey CustomerType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey EndDateTime { get; private set; }
        public VocabularyKey EstimateLineId { get; private set; }
        public VocabularyKey EstimatePerDayLines { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExchangeRateDate { get; private set; }
        public VocabularyKey NumberOfResources { get; private set; }
        public VocabularyKey Percent { get; private set; }
        public VocabularyKey Price { get; private set; }
        public VocabularyKey PriceBase { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TransactionClassification { get; private set; }
        public VocabularyKey TransactionTypeCode { get; private set; }
        public VocabularyKey VendorType { get; private set; }
    }
}