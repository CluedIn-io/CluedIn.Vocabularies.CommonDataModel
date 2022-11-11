using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetLocationTransferHistoryEntityVocabulary : SimpleVocabulary
    {
        public AssetLocationTransferHistoryEntityVocabulary()
        {
            VocabularyName = "AssetLocationTransferHistoryEntity";
            KeyPrefix = "commonDataModel.assetlocationtransferhistoryentity";
            KeySeparator = ".";
            Grouping = "/AssetLocationTransferHistoryEntity";

            AddGroup("AssetLocationTransferHistoryEntity Details", group =>
            {
                FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromLocation = group.Add(new VocabularyKey(nameof(FromLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Id = group.Add(new VocabularyKey(nameof(Id), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToLocation = group.Add(new VocabularyKey(nameof(ToLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferComments = group.Add(new VocabularyKey(nameof(TransferComments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferDate = group.Add(new VocabularyKey(nameof(TransferDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FixedAssetNumber { get; private set; }
        public VocabularyKey FromLocation { get; private set; }
        public VocabularyKey Id { get; private set; }
        public VocabularyKey ToLocation { get; private set; }
        public VocabularyKey TransferComments { get; private set; }
        public VocabularyKey TransferDate { get; private set; }


    }
}