using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class OpportunityProductVocabulary : SimpleVocabulary
    {
        public OpportunityProductVocabulary()
        {
            VocabularyName = "Opportunity Product";
            KeyPrefix = "commonDataModel.opportunityproduct";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.OpportunityProduct;

            AddGroup("OpportunityProduct Details for ProjectServiceAutomation", group =>
            {
                BillingMethod = group.Add(new VocabularyKey(nameof(BillingMethod), "Billing Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetAmount = group.Add(new VocabularyKey(nameof(BudgetAmount), "Budget Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                BudgetAmountBase = group.Add(new VocabularyKey(nameof(BudgetAmountBase), "Budget Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), "Cost Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                CostAmountBase = group.Add(new VocabularyKey(nameof(CostAmountBase), "Cost Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPricePerUnit = group.Add(new VocabularyKey(nameof(CostPricePerUnit), "Cost Price Per Unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                CostPricePerUnitBase = group.Add(new VocabularyKey(nameof(CostPricePerUnitBase), "Cost Price Per Unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), "Line Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
            AddGroup("OpportunityProduct Details for Sales", group =>
            {
                OpportunityProductId = group.Add(new VocabularyKey(nameof(OpportunityProductId), "Opportunity Product", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseAmount = group.Add(new VocabularyKey(nameof(BaseAmount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                BaseAmountBase = group.Add(new VocabularyKey(nameof(BaseAmountBase), "Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExtendedAmount = group.Add(new VocabularyKey(nameof(ExtendedAmount), "Extended Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ExtendedAmountBase = group.Add(new VocabularyKey(nameof(ExtendedAmountBase), "Extended Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPriceOverridden = group.Add(new VocabularyKey(nameof(IsPriceOverridden), "Price Overridden", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                IsProductOverridden = group.Add(new VocabularyKey(nameof(IsProductOverridden), "Select Product", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
                LineItemNumber = group.Add(new VocabularyKey(nameof(LineItemNumber), "Line Item Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ManualDiscountAmount = group.Add(new VocabularyKey(nameof(ManualDiscountAmount), "Manual Discount Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                ManualDiscountAmountBase = group.Add(new VocabularyKey(nameof(ManualDiscountAmountBase), "Manual Discount Amount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpportunityStateCode = group.Add(new VocabularyKey(nameof(OpportunityStateCode), "Opportunity Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductTypeCode = group.Add(new VocabularyKey(nameof(ProductTypeCode), "Product type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PricePerUnit = group.Add(new VocabularyKey(nameof(PricePerUnit), "Price Per Unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                PricePerUnitBase = group.Add(new VocabularyKey(nameof(PricePerUnitBase), "Price Per Unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PricingErrorCode = group.Add(new VocabularyKey(nameof(PricingErrorCode), "Pricing Error ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), "Write-In Product", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductName = group.Add(new VocabularyKey(nameof(ProductName), "Product Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                Tax = group.Add(new VocabularyKey(nameof(Tax), "Tax", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                TaxBase = group.Add(new VocabularyKey(nameof(TaxBase), "Tax (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VolumeDiscountAmount = group.Add(new VocabularyKey(nameof(VolumeDiscountAmount), "Volume Discount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));
                VolumeDiscountAmountBase = group.Add(new VocabularyKey(nameof(VolumeDiscountAmountBase), "Volume Discount (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), "Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                PropertyConfigurationStatus = group.Add(new VocabularyKey(nameof(PropertyConfigurationStatus), "Property Configuration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OpportunityProductName = group.Add(new VocabularyKey(nameof(OpportunityProductName), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
            ///Property <see cref="OpportunityId"/> to Vocab 'Opportunity.cdm.json/Opportunity' with Property 'OpportunityId'
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
            ///Property <see cref="ParentBundleId"/> to Vocab 'OpportunityProduct.cdm.json/OpportunityProduct' with Property 'OpportunityProductId'
            ///Property <see cref="ProductAssociationId"/> to Vocab '/core/applicationCommon/foundationCommon/ProductAssociation.cdm.json/ProductAssociation' with Property 'ProductAssociationId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="UoMId"/> to Vocab '/core/applicationCommon/foundationCommon/Unit.cdm.json/Unit' with Property 'UoMId'
            ///Property <see cref="ParentBundleIdRef"/> to Vocab 'OpportunityProduct.cdm.json/OpportunityProduct' with Property 'OpportunityProductId'
            ///Property <see cref="Project"/> to Vocab 'Project.cdm.json/Project' with Property 'ProjectId'
            ///Property <see cref="ParentBundleId"/> to Vocab 'OpportunityProduct.cdm.json/OpportunityProduct' with Property 'OpportunityProductId'
            ///Property <see cref="ParentBundleIdRef"/> to Vocab 'OpportunityProduct.cdm.json/OpportunityProduct' with Property 'OpportunityProductId'
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="OpportunityProductId"/> from Vocab 'OpportunityProduct.cdm.json/OpportunityProduct' with Property 'ParentBundleId'
            ///Property <see cref="OpportunityProductId"/> from Vocab 'OpportunityProduct.cdm.json/OpportunityProduct' with Property 'ParentBundleIdRef'
            ///Property <see cref="OpportunityProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'ParentBundleId'
            ///Property <see cref="OpportunityProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/OpportunityProduct.cdm.json/OpportunityProduct' with Property 'ParentBundleIdRef'
            ///Property <see cref="OpportunityProductId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/sales/PropertyInstance.cdm.json/PropertyInstance' with Property 'RegardingObjectId'
            #endregion
        }

        public VocabularyKey BaseAmount { get; private set; }
        public VocabularyKey BaseAmountBase { get; private set; }
        public VocabularyKey BillingMethod { get; private set; }
        public VocabularyKey BudgetAmount { get; private set; }
        public VocabularyKey BudgetAmountBase { get; private set; }
        public VocabularyKey CostAmount { get; private set; }
        public VocabularyKey CostAmountBase { get; private set; }
        public VocabularyKey CostPricePerUnit { get; private set; }
        public VocabularyKey CostPricePerUnitBase { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExtendedAmount { get; private set; }
        public VocabularyKey ExtendedAmountBase { get; private set; }
        public VocabularyKey IsPriceOverridden { get; private set; }
        public VocabularyKey IsProductOverridden { get; private set; }
        public VocabularyKey LineItemNumber { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey ManualDiscountAmount { get; private set; }
        public VocabularyKey ManualDiscountAmountBase { get; private set; }
        public VocabularyKey OpportunityProductId { get; private set; }
        public VocabularyKey OpportunityProductName { get; private set; }
        public VocabularyKey OpportunityStateCode { get; private set; }
        public VocabularyKey PricePerUnit { get; private set; }
        public VocabularyKey PricePerUnitBase { get; private set; }
        public VocabularyKey PricingErrorCode { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey ProductName { get; private set; }
        public VocabularyKey ProductTypeCode { get; private set; }
        public VocabularyKey PropertyConfigurationStatus { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey Tax { get; private set; }
        public VocabularyKey TaxBase { get; private set; }
        public VocabularyKey VolumeDiscountAmount { get; private set; }
        public VocabularyKey VolumeDiscountAmountBase { get; private set; }
    }
}