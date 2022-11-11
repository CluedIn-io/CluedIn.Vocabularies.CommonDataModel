using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOpenSalesLineDiscountJournalLineCDSEntityVocabulary : SimpleVocabulary
    {
        public SalesOpenSalesLineDiscountJournalLineCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesOpenSalesLineDiscountJournalLineCDSEntity";
            KeyPrefix = "commonDataModel.salesopensaleslinediscountjournallinecdsentity";
            KeySeparator = ".";
            Grouping = "/SalesOpenSalesLineDiscountJournalLineCDSEntity";

            AddGroup("Common Data Model SalesOpenSalesLineDiscountJournalLineCDSEntity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountApplicableFromDate = group.Add(new VocabularyKey(nameof(DiscountApplicableFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountApplicableToDate = group.Add(new VocabularyKey(nameof(DiscountApplicableToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountCurrencyCode = group.Add(new VocabularyKey(nameof(DiscountCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage1 = group.Add(new VocabularyKey(nameof(DiscountPercentage1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountPercentage2 = group.Add(new VocabularyKey(nameof(DiscountPercentage2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountSiteId = group.Add(new VocabularyKey(nameof(DiscountSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountWarehouseId = group.Add(new VocabularyKey(nameof(DiscountWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromQuantity = group.Add(new VocabularyKey(nameof(FromQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsGenericCurrencySearchEnabled = group.Add(new VocabularyKey(nameof(IsGenericCurrencySearchEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountCustomerGroupCode = group.Add(new VocabularyKey(nameof(LineDiscountCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscountProductGroupCode = group.Add(new VocabularyKey(nameof(LineDiscountProductGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessingLog = group.Add(new VocabularyKey(nameof(ProcessingLog), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuantityUnitSymbol = group.Add(new VocabularyKey(nameof(QuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToQuantity = group.Add(new VocabularyKey(nameof(ToQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAgreementJournalNumber = group.Add(new VocabularyKey(nameof(TradeAgreementJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSearchContinue = group.Add(new VocabularyKey(nameof(WillSearchContinue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey DiscountAmount { get; private set; }
        public VocabularyKey DiscountApplicableFromDate { get; private set; }
        public VocabularyKey DiscountApplicableToDate { get; private set; }
        public VocabularyKey DiscountCurrencyCode { get; private set; }
        public VocabularyKey DiscountPercentage1 { get; private set; }
        public VocabularyKey DiscountPercentage2 { get; private set; }
        public VocabularyKey DiscountSiteId { get; private set; }
        public VocabularyKey DiscountWarehouseId { get; private set; }
        public VocabularyKey FromQuantity { get; private set; }
        public VocabularyKey IsGenericCurrencySearchEnabled { get; private set; }
        public VocabularyKey LineDiscountCustomerGroupCode { get; private set; }
        public VocabularyKey LineDiscountProductGroupCode { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey ProcessingLog { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey QuantityUnitSymbol { get; private set; }
        public VocabularyKey ToQuantity { get; private set; }
        public VocabularyKey TradeAgreementJournalNumber { get; private set; }
        public VocabularyKey WillSearchContinue { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }


    }
}