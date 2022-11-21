using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetValueModelSetupDerivedValueModelEntityVocabulary : SimpleVocabulary
    {
        public AssetValueModelSetupDerivedValueModelEntityVocabulary()
        {
            VocabularyName = "Asset Value Model Setup Derived Value Model Entity";
            KeyPrefix = "commonDataModel.assetvaluemodelsetupderivedvaluemodelentity";
            KeySeparator = ".";
            Grouping = "/AssetValueModelSetupDerivedValueModelEntity";

            AddGroup("AssetValueModelSetupDerivedValueModelEntity Details", group =>
            {
                ValueModelId = group.Add(new VocabularyKey(nameof(ValueModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DerivedValueModelId = group.Add(new VocabularyKey(nameof(DerivedValueModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ValueModelId { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey DerivedValueModelId { get; private set; }
    }
}