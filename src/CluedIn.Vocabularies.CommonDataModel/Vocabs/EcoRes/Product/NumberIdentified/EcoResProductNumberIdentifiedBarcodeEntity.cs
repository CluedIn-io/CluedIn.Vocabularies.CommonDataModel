using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductNumberIdentifiedBarcodeEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductNumberIdentifiedBarcodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductNumberIdentifiedBarcodeEntity";
            KeyPrefix = "commonDataModel.ecoresproductnumberidentifiedbarcodeentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductNumberIdentifiedBarcodeEntity";

            AddGroup("Common Data Model EcoResProductNumberIdentifiedBarcodeEntity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductQuantity = group.Add(new VocabularyKey(nameof(ProductQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductQuantityUnitSymbol = group.Add(new VocabularyKey(nameof(ProductQuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarcodeSetupId = group.Add(new VocabularyKey(nameof(BarcodeSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Barcode = group.Add(new VocabularyKey(nameof(Barcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductDescription = group.Add(new VocabularyKey(nameof(ProductDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultScannedBarcode = group.Add(new VocabularyKey(nameof(IsDefaultScannedBarcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultPrintedBarcode = group.Add(new VocabularyKey(nameof(IsDefaultPrintedBarcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDefaultDisplayedBarcode = group.Add(new VocabularyKey(nameof(IsDefaultDisplayedBarcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey ProductQuantity { get; private set; }
        public VocabularyKey ProductQuantityUnitSymbol { get; private set; }
        public VocabularyKey BarcodeSetupId { get; private set; }
        public VocabularyKey Barcode { get; private set; }
        public VocabularyKey ProductDescription { get; private set; }
        public VocabularyKey IsDefaultScannedBarcode { get; private set; }
        public VocabularyKey IsDefaultPrintedBarcode { get; private set; }
        public VocabularyKey IsDefaultDisplayedBarcode { get; private set; }


    }
}