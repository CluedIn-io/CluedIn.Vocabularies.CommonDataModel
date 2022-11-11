using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendFormletterVendorFacingFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public VendFormletterVendorFacingFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "VendFormletterVendorFacingFormPrintingConfigurationEntity";
            KeyPrefix = "commonDataModel.vendformlettervendorfacingformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/VendFormletterVendorFacingFormPrintingConfigurationEntity";

            AddGroup("VendFormletterVendorFacingFormPrintingConfigurationEntity Details", group =>
            {
                AreEuroAmountsDisplayed = group.Add(new VocabularyKey(nameof(AreEuroAmountsDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalAmountDisplayRule = group.Add(new VocabularyKey(nameof(TotalAmountDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxDisplayRule = group.Add(new VocabularyKey(nameof(SalesTaxDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesTaxExemptBalanceAmountDisplayedSeparately = group.Add(new VocabularyKey(nameof(IsSalesTaxExemptBalanceAmountDisplayedSeparately), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorProductDescriptionDisplayRule = group.Add(new VocabularyKey(nameof(VendorProductDescriptionDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDimensionsDisplayRule = group.Add(new VocabularyKey(nameof(ProductDimensionsDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDimensionsDisplaySeparator = group.Add(new VocabularyKey(nameof(ProductDimensionsDisplaySeparator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDisplayedProductDescriptionIncludingProductName = group.Add(new VocabularyKey(nameof(IsDisplayedProductDescriptionIncludingProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumberDisplayRule = group.Add(new VocabularyKey(nameof(ProductNumberDisplayRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AreEuroAmountsDisplayed { get; private set; }
        public VocabularyKey TotalAmountDisplayRule { get; private set; }
        public VocabularyKey SalesTaxDisplayRule { get; private set; }
        public VocabularyKey IsSalesTaxExemptBalanceAmountDisplayedSeparately { get; private set; }
        public VocabularyKey VendorProductDescriptionDisplayRule { get; private set; }
        public VocabularyKey ProductDimensionsDisplayRule { get; private set; }
        public VocabularyKey ProductDimensionsDisplaySeparator { get; private set; }
        public VocabularyKey IsDisplayedProductDescriptionIncludingProductName { get; private set; }
        public VocabularyKey ProductNumberDisplayRule { get; private set; }


    }
}