using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomerJourneyRuntimeStateVocabulary : SimpleVocabulary
    {
        public CustomerJourneyRuntimeStateVocabulary()
        {
            VocabularyName = "Customer Journey Runtime State";
            KeyPrefix = "commonDataModel.customerjourneyruntimestate";
            KeySeparator = ".";
            Grouping = "/CustomerJourneyRuntimeState";

            AddGroup("CustomerJourneyRuntimeState Details", group =>
            {
                CustomerJourneyRuntimeStateId = group.Add(new VocabularyKey(nameof(CustomerJourneyRuntimeStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuntimeState = group.Add(new VocabularyKey(nameof(RuntimeState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuntimeStateTimestamp = group.Add(new VocabularyKey(nameof(RuntimeStateTimestamp), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerJourneyRuntimeStateId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RuntimeState { get; private set; }
        public VocabularyKey RuntimeStateTimestamp { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}