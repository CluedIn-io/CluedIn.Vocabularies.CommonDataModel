using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerInsightsInfoVocabulary : SimpleVocabulary
    {
        public CustomerInsightsInfoVocabulary()
        {
            VocabularyName = "CustomerInsightsInfo";
            KeyPrefix = "commonDataModel.customerinsightsinfo";
            KeySeparator = ".";
            Grouping = "/CustomerInsightsInfo";

            AddGroup("CustomerInsightsInfo Details", group =>
            {
                audienceType = group.Add(new VocabularyKey(nameof(audienceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                connectorsSuffix = group.Add(new VocabularyKey(nameof(connectorsSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                dciwebendpoint = group.Add(new VocabularyKey(nameof(dciwebendpoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                usePlanB = group.Add(new VocabularyKey(nameof(usePlanB), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overrideuiwithdciwebendpoint = group.Add(new VocabularyKey(nameof(overrideuiwithdciwebendpoint), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                uiVersion = group.Add(new VocabularyKey(nameof(uiVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                configCacheExpirationDate = group.Add(new VocabularyKey(nameof(configCacheExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                customerinsightsinfoId = group.Add(new VocabularyKey(nameof(customerinsightsinfoId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey audienceType { get; private set; }
        public VocabularyKey connectorsSuffix { get; private set; }
        public VocabularyKey dciwebendpoint { get; private set; }
        public VocabularyKey usePlanB { get; private set; }
        public VocabularyKey overrideuiwithdciwebendpoint { get; private set; }
        public VocabularyKey uiVersion { get; private set; }
        public VocabularyKey configCacheExpirationDate { get; private set; }
        public VocabularyKey customerinsightsinfoId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}