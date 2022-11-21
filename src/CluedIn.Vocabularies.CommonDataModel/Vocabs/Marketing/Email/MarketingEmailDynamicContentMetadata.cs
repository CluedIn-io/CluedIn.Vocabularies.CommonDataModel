using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingEmailDynamicContentMetadataVocabulary : SimpleVocabulary
    {
        public MarketingEmailDynamicContentMetadataVocabulary()
        {
            VocabularyName = "Marketing Email Dynamic Content Metadata";
            KeyPrefix = "commonDataModel.marketingemaildynamiccontentmetadata";
            KeySeparator = ".";
            Grouping = "/MarketingEmailDynamicContentMetadata";

            AddGroup("MarketingEmailDynamicContentMetadata Details", group =>
            {
                Fields = group.Add(new VocabularyKey(nameof(Fields), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsContextEntity = group.Add(new VocabularyKey(nameof(IsContextEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayName = group.Add(new VocabularyKey(nameof(DisplayName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemType = group.Add(new VocabularyKey(nameof(ItemType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingEmailDynamicContentMetadataId = group.Add(new VocabularyKey(nameof(MarketingEmailDynamicContentMetadataId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Syntax = group.Add(new VocabularyKey(nameof(Syntax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Fields { get; private set; }
        public VocabularyKey IsContextEntity { get; private set; }
        public VocabularyKey DisplayName { get; private set; }
        public VocabularyKey ItemType { get; private set; }
        public VocabularyKey MarketingEmailDynamicContentMetadataId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Syntax { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}