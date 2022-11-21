using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCDXDataStoreChannelEntityVocabulary : SimpleVocabulary
    {
        public RetailCDXDataStoreChannelEntityVocabulary()
        {
            VocabularyName = "Retail CDX Data Store Channel Entity";
            KeyPrefix = "commonDataModel.retailcdxdatastorechannelentity";
            KeySeparator = ".";
            Grouping = "/RetailCDXDataStoreChannelEntity";

            AddGroup("RetailCDXDataStoreChannelEntity Details", group =>
            {
                ChannelId = group.Add(new VocabularyKey(nameof(ChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChannelDatabaseId = group.Add(new VocabularyKey(nameof(ChannelDatabaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ChannelId { get; private set; }
        public VocabularyKey ChannelDatabaseId { get; private set; }
    }
}