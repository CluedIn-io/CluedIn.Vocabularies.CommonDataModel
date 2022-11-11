using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetStatementRowEntityVocabulary : SimpleVocabulary
    {
        public AssetStatementRowEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetStatementRowEntity";
            KeyPrefix = "commonDataModel.assetstatementrowentity";
            KeySeparator = ".";
            Grouping = "/AssetStatementRowEntity";

            AddGroup("Common Data Model AssetStatementRowEntity Details", group =>
            {
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowName = group.Add(new VocabularyKey(nameof(RowName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowType = group.Add(new VocabularyKey(nameof(RowType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetIntervalRelation = group.Add(new VocabularyKey(nameof(AssetIntervalRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromFixedAssetNumber = group.Add(new VocabularyKey(nameof(FromFixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToFixedAssetNumber = group.Add(new VocabularyKey(nameof(ToFixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey RowName { get; private set; }
        public VocabularyKey RowType { get; private set; }
        public VocabularyKey AssetIntervalRelation { get; private set; }
        public VocabularyKey FromFixedAssetNumber { get; private set; }
        public VocabularyKey ToFixedAssetNumber { get; private set; }


    }
}