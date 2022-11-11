using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MainAccountLegalEntityOverrideEntityVocabulary : SimpleVocabulary
    {
        public MainAccountLegalEntityOverrideEntityVocabulary()
        {
            VocabularyName = "MainAccountLegalEntityOverrideEntity";
            KeyPrefix = "commonDataModel.mainaccountlegalentityoverrideentity";
            KeySeparator = ".";
            Grouping = "/MainAccountLegalEntityOverrideEntity";

            AddGroup("MainAccountLegalEntityOverrideEntity Details", group =>
            {
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccounts = group.Add(new VocabularyKey(nameof(ChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountRecId = group.Add(new VocabularyKey(nameof(MainAccountRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccountsRecId = group.Add(new VocabularyKey(nameof(ChartOfAccountsRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityRecId = group.Add(new VocabularyKey(nameof(LegalEntityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutoAllocate = group.Add(new VocabularyKey(nameof(AutoAllocate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedDimensions = group.Add(new VocabularyKey(nameof(FixedDimensions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedDimensionsDisplayValue = group.Add(new VocabularyKey(nameof(FixedDimensionsDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxCode = group.Add(new VocabularyKey(nameof(SalesTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxDirection = group.Add(new VocabularyKey(nameof(SalesTaxDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsExempt = group.Add(new VocabularyKey(nameof(IsExempt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroup = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesTaxGroupHeadingLegalEntity = group.Add(new VocabularyKey(nameof(ItemSalesTaxGroupHeadingLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxTableLegalEntity = group.Add(new VocabularyKey(nameof(TaxTableLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateSalesTax = group.Add(new VocabularyKey(nameof(ValidateSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveFrom = group.Add(new VocabularyKey(nameof(ActiveFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveTo = group.Add(new VocabularyKey(nameof(ActiveTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSuspended = group.Add(new VocabularyKey(nameof(IsSuspended), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeAdjustmentRateType = group.Add(new VocabularyKey(nameof(ExchangeAdjustmentRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingExchangeAdjustmentRateType = group.Add(new VocabularyKey(nameof(ReportingExchangeAdjustmentRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey ChartOfAccounts { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey MainAccountRecId { get; private set; }
        public VocabularyKey ChartOfAccountsRecId { get; private set; }
        public VocabularyKey LegalEntityRecId { get; private set; }
        public VocabularyKey AutoAllocate { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey FixedDimensions { get; private set; }
        public VocabularyKey FixedDimensionsDisplayValue { get; private set; }
        public VocabularyKey SalesTaxCode { get; private set; }
        public VocabularyKey SalesTaxDirection { get; private set; }
        public VocabularyKey IsExempt { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey ItemSalesTaxGroup { get; private set; }
        public VocabularyKey ItemSalesTaxGroupHeadingLegalEntity { get; private set; }
        public VocabularyKey TaxTableLegalEntity { get; private set; }
        public VocabularyKey ValidateSalesTax { get; private set; }
        public VocabularyKey ActiveFrom { get; private set; }
        public VocabularyKey ActiveTo { get; private set; }
        public VocabularyKey IsSuspended { get; private set; }
        public VocabularyKey ExchangeAdjustmentRateType { get; private set; }
        public VocabularyKey ReportingExchangeAdjustmentRateType { get; private set; }


    }
}