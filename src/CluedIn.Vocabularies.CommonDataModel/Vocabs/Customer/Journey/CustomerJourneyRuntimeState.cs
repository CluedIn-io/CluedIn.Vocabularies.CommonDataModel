using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerJourneyRuntimeStateVocabulary : SimpleVocabulary
    {
        public CustomerJourneyRuntimeStateVocabulary()
        {
            VocabularyName = "Common Data Model CustomerJourneyRuntimeState";
            KeyPrefix = "commonDataModel.customerjourneyruntimestate";
            KeySeparator = ".";
            Grouping = "/CustomerJourneyRuntimeState";

            AddGroup("Common Data Model CustomerJourneyRuntimeState Details", group =>
            {
                customerJourneyRuntimeStateId = group.Add(new VocabularyKey(nameof(customerJourneyRuntimeStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                runtimeState = group.Add(new VocabularyKey(nameof(runtimeState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                runtimeStateTimestamp = group.Add(new VocabularyKey(nameof(runtimeStateTimestamp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey customerJourneyRuntimeStateId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey runtimeState { get; private set; }
        public VocabularyKey runtimeStateTimestamp { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}