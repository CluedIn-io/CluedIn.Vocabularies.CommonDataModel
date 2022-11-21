using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BarcodeSetupEntityVocabulary : SimpleVocabulary
    {
        public BarcodeSetupEntityVocabulary()
        {
            VocabularyName = "Barcode Setup Entity";
            KeyPrefix = "commonDataModel.barcodesetupentity";
            KeySeparator = ".";
            Grouping = "/BarcodeSetupEntity";

            AddGroup("BarcodeSetupEntity Details", group =>
            {
                BarcodeDescription = group.Add(new VocabularyKey(nameof(BarcodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarcodeMaskId = group.Add(new VocabularyKey(nameof(BarcodeMaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarcodeSetupId = group.Add(new VocabularyKey(nameof(BarcodeSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BarcodeType = group.Add(new VocabularyKey(nameof(BarcodeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FontName = group.Add(new VocabularyKey(nameof(FontName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FontSize = group.Add(new VocabularyKey(nameof(FontSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumBarcodeLength = group.Add(new VocabularyKey(nameof(MaximumBarcodeLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumBarcodeLength = group.Add(new VocabularyKey(nameof(MinimumBarcodeLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BarcodeDescription { get; private set; }
        public VocabularyKey BarcodeMaskId { get; private set; }
        public VocabularyKey BarcodeSetupId { get; private set; }
        public VocabularyKey BarcodeType { get; private set; }
        public VocabularyKey FontName { get; private set; }
        public VocabularyKey FontSize { get; private set; }
        public VocabularyKey MaximumBarcodeLength { get; private set; }
        public VocabularyKey MinimumBarcodeLength { get; private set; }
    }
}