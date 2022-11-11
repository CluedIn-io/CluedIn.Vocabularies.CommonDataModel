using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CdnConfigurationVocabulary : SimpleVocabulary
    {
        public CdnConfigurationVocabulary()
        {
            VocabularyName = "Common Data Model CdnConfiguration";
            KeyPrefix = "commonDataModel.cdnconfiguration";
            KeySeparator = ".";
            Grouping = "/CdnConfiguration";

            AddGroup("Common Data Model CdnConfiguration Details", group =>
            {
                CDNConfigurationId = group.Add(new VocabularyKey(nameof(CDNConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CDNEnabled = group.Add(new VocabularyKey(nameof(CDNEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                publicAssetsCDN = group.Add(new VocabularyKey(nameof(publicAssetsCDN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CDNConfigurationId { get; private set; }
        public VocabularyKey CDNEnabled { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey publicAssetsCDN { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}