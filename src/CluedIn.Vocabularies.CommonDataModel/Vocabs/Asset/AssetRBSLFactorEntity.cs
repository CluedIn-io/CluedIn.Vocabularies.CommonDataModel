using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetRBSLFactorEntityVocabulary : SimpleVocabulary
    {
        public AssetRBSLFactorEntityVocabulary()
        {
            VocabularyName = "AssetRBSLFactorEntity";
            KeyPrefix = "commonDataModel.assetrbslfactorentity";
            KeySeparator = ".";
            Grouping = "/AssetRBSLFactorEntity";

            AddGroup("AssetRBSLFactorEntity Details", group =>
            {
                AssetRBSLFactor = group.Add(new VocabularyKey(nameof(AssetRBSLFactor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Years = group.Add(new VocabularyKey(nameof(Years), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Months = group.Add(new VocabularyKey(nameof(Months), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AssetRBSLFactor { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey Years { get; private set; }
        public VocabularyKey Months { get; private set; }


    }
}