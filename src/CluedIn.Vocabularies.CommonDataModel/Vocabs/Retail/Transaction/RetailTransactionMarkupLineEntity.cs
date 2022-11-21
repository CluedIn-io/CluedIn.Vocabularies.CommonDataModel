using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionMarkupLineEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionMarkupLineEntityVocabulary()
        {
            VocabularyName = "Retail Transaction Markup Line Entity";
            KeyPrefix = "commonDataModel.retailtransactionmarkuplineentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionMarkupLineEntity";

            AddGroup("RetailTransactionMarkupLineEntity Details", group =>
            {
                CalculatedAmount = group.Add(new VocabularyKey(nameof(CalculatedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarkupCode = group.Add(new VocabularyKey(nameof(MarkupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarkupCategoryType = group.Add(new VocabularyKey(nameof(MarkupCategoryType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesLineNumber = group.Add(new VocabularyKey(nameof(SalesLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmount = group.Add(new VocabularyKey(nameof(TaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountExclusive = group.Add(new VocabularyKey(nameof(TaxAmountExclusive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmountInclusive = group.Add(new VocabularyKey(nameof(TaxAmountInclusive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemTaxGroup = group.Add(new VocabularyKey(nameof(ItemTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarkupValue = group.Add(new VocabularyKey(nameof(MarkupValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelTableOMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModuleType = group.Add(new VocabularyKey(nameof(ModuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Store = group.Add(new VocabularyKey(nameof(Store), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Keep = group.Add(new VocabularyKey(nameof(Keep), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarkupAutoTableRecId = group.Add(new VocabularyKey(nameof(MarkupAutoTableRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonGST = group.Add(new VocabularyKey(nameof(NonGST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Exempt = group.Add(new VocabularyKey(nameof(Exempt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HSNCode = group.Add(new VocabularyKey(nameof(HSNCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAccountingCode = group.Add(new VocabularyKey(nameof(ServiceAccountingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceCategory = group.Add(new VocabularyKey(nameof(ServiceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ITCCategory = group.Add(new VocabularyKey(nameof(ITCCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRateType = group.Add(new VocabularyKey(nameof(TaxRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOverriddenLine = group.Add(new VocabularyKey(nameof(IsOverriddenLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptPriceInclusiveOriginalPrice = group.Add(new VocabularyKey(nameof(TaxExemptPriceInclusiveOriginalPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptPriceInclusiveReductionAmount = group.Add(new VocabularyKey(nameof(TaxExemptPriceInclusiveReductionAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CalculatedAmount { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey MarkupCode { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey MarkupCategoryType { get; private set; }
        public VocabularyKey SalesLineNumber { get; private set; }
        public VocabularyKey TaxAmount { get; private set; }
        public VocabularyKey TaxAmountExclusive { get; private set; }
        public VocabularyKey TaxAmountInclusive { get; private set; }
        public VocabularyKey SalesTaxGroup { get; private set; }
        public VocabularyKey ItemTaxGroup { get; private set; }
        public VocabularyKey Terminal { get; private set; }
        public VocabularyKey TransactionNumber { get; private set; }
        public VocabularyKey MarkupValue { get; private set; }
        public VocabularyKey RetailChannelTableOMOperatingUnitID { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }
        public VocabularyKey ModuleType { get; private set; }
        public VocabularyKey Store { get; private set; }
        public VocabularyKey Keep { get; private set; }
        public VocabularyKey MarkupAutoTableRecId { get; private set; }
        public VocabularyKey NonGST { get; private set; }
        public VocabularyKey Exempt { get; private set; }
        public VocabularyKey HSNCode { get; private set; }
        public VocabularyKey ServiceAccountingCode { get; private set; }
        public VocabularyKey ServiceCategory { get; private set; }
        public VocabularyKey ITCCategory { get; private set; }
        public VocabularyKey TaxRateType { get; private set; }
        public VocabularyKey IsOverriddenLine { get; private set; }
        public VocabularyKey TaxExemptPriceInclusiveOriginalPrice { get; private set; }
        public VocabularyKey TaxExemptPriceInclusiveReductionAmount { get; private set; }
    }
}