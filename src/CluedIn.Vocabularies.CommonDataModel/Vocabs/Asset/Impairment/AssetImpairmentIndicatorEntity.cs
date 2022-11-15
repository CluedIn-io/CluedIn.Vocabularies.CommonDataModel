using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetImpairmentIndicatorEntityVocabulary : SimpleVocabulary
    {
        public AssetImpairmentIndicatorEntityVocabulary()
        {
            VocabularyName = "Asset Impairment Indicator Entity";
            KeyPrefix = "commonDataModel.assetimpairmentindicatorentity";
            KeySeparator = ".";
            Grouping = "/AssetImpairmentIndicatorEntity";

            AddGroup("AssetImpairmentIndicatorEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFinalized = group.Add(new VocabularyKey(nameof(IsFinalized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssessmentLevel = group.Add(new VocabularyKey(nameof(AssessmentLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifyDate = group.Add(new VocabularyKey(nameof(ModifyDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecoverableAmount = group.Add(new VocabularyKey(nameof(RecoverableAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UndiscountedCashFlow = group.Add(new VocabularyKey(nameof(UndiscountedCashFlow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceBook = group.Add(new VocabularyKey(nameof(ReferenceBook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceFixedAssetNumber = group.Add(new VocabularyKey(nameof(ReferenceFixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsFinalized { get; private set; }
        public VocabularyKey AssessmentLevel { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey ModifyDate { get; private set; }
        public VocabularyKey RecoverableAmount { get; private set; }
        public VocabularyKey UndiscountedCashFlow { get; private set; }
        public VocabularyKey ReferenceBook { get; private set; }
        public VocabularyKey ReferenceFixedAssetNumber { get; private set; }
    }
}