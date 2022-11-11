using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustFormletterCustomerFacingFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public CustFormletterCustomerFacingFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "CustFormletterCustomerFacingFormPrintingConfigurationEntity";
            KeyPrefix = "commonDataModel.custformlettercustomerfacingformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/CustFormletterCustomerFacingFormPrintingConfigurationEntity";

            AddGroup("CustFormletterCustomerFacingFormPrintingConfigurationEntity Details", group =>
            {
                NotDisplayedItemNumber = group.Add(new VocabularyKey(nameof(NotDisplayedItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreEuroAmountsDisplayed = group.Add(new VocabularyKey(nameof(AreEuroAmountsDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTaxExemptBalanceAmountDisplayedSeparately = group.Add(new VocabularyKey(nameof(IsTaxExemptBalanceAmountDisplayedSeparately), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxDisplayRule = group.Add(new VocabularyKey(nameof(SalesTaxDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalAmountDisplayRule = group.Add(new VocabularyKey(nameof(TotalAmountDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumberDisplayRule = group.Add(new VocabularyKey(nameof(ProductNumberDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDisplayedProductDescriptionIncludingProductName = group.Add(new VocabularyKey(nameof(IsDisplayedProductDescriptionIncludingProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerProductDescriptionDisplayRule = group.Add(new VocabularyKey(nameof(CustomerProductDescriptionDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDimensionsDisplayRule = group.Add(new VocabularyKey(nameof(ProductDimensionsDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDimensionsDisplaySeparator = group.Add(new VocabularyKey(nameof(ProductDimensionsDisplaySeparator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey NotDisplayedItemNumber { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey AreEuroAmountsDisplayed { get; private set; }
        public VocabularyKey IsTaxExemptBalanceAmountDisplayedSeparately { get; private set; }
        public VocabularyKey SalesTaxDisplayRule { get; private set; }
        public VocabularyKey TotalAmountDisplayRule { get; private set; }
        public VocabularyKey ProductNumberDisplayRule { get; private set; }
        public VocabularyKey IsDisplayedProductDescriptionIncludingProductName { get; private set; }
        public VocabularyKey CustomerProductDescriptionDisplayRule { get; private set; }
        public VocabularyKey ProductDimensionsDisplayRule { get; private set; }
        public VocabularyKey ProductDimensionsDisplaySeparator { get; private set; }


    }
}