using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class UICConfigVocabulary : SimpleVocabulary
    {
        public UICConfigVocabulary()
        {
            VocabularyName = "UIC Config";
            KeyPrefix = "commonDataModel.uicconfig";
            KeySeparator = ".";
            Grouping = "/UICConfig";

            AddGroup("UICConfig Details", group =>
            {
                EventHubAccessKey = group.Add(new VocabularyKey(nameof(EventHubAccessKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventHubName = group.Add(new VocabularyKey(nameof(EventHubName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageAccountAccessKey = group.Add(new VocabularyKey(nameof(StorageAccountAccessKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageAccountName = group.Add(new VocabularyKey(nameof(StorageAccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UICConfigId = group.Add(new VocabularyKey(nameof(UICConfigId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey EventHubAccessKey { get; private set; }
        public VocabularyKey EventHubName { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StorageAccountAccessKey { get; private set; }
        public VocabularyKey StorageAccountName { get; private set; }
        public VocabularyKey UICConfigId { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}