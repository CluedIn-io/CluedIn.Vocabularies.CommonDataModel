using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerInsightsInfoVocabulary : SimpleVocabulary
    {
        public CustomerInsightsInfoVocabulary()
        {
            VocabularyName = "Customer Insights Info";
            KeyPrefix = "commonDataModel.customerinsightsinfo";
            KeySeparator = ".";
            Grouping = "/CustomerInsightsInfo";

            AddGroup("CustomerInsightsInfo Details", group =>
            {
                AudienceType = group.Add(new VocabularyKey(nameof(AudienceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConnectorsSuffix = group.Add(new VocabularyKey(nameof(ConnectorsSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dciwebendpoint = group.Add(new VocabularyKey(nameof(Dciwebendpoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsePlanB = group.Add(new VocabularyKey(nameof(UsePlanB), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Overrideuiwithdciwebendpoint = group.Add(new VocabularyKey(nameof(Overrideuiwithdciwebendpoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UiVersion = group.Add(new VocabularyKey(nameof(UiVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfigCacheExpirationDate = group.Add(new VocabularyKey(nameof(ConfigCacheExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerinsightsinfoId = group.Add(new VocabularyKey(nameof(CustomerinsightsinfoId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AudienceType { get; private set; }
        public VocabularyKey ConnectorsSuffix { get; private set; }
        public VocabularyKey Dciwebendpoint { get; private set; }
        public VocabularyKey UsePlanB { get; private set; }
        public VocabularyKey Overrideuiwithdciwebendpoint { get; private set; }
        public VocabularyKey UiVersion { get; private set; }
        public VocabularyKey ConfigCacheExpirationDate { get; private set; }
        public VocabularyKey CustomerinsightsinfoId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}