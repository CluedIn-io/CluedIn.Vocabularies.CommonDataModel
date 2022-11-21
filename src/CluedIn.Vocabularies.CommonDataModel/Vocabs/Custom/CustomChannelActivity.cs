using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomChannelActivityVocabulary : SimpleVocabulary
    {
        public CustomChannelActivityVocabulary()
        {
            VocabularyName = "Custom Channel Activity";
            KeyPrefix = "commonDataModel.customchannelactivity";
            KeySeparator = ".";
            Grouping = "/CustomChannelActivity";

            AddGroup("CustomChannelActivity Details", group =>
            {
                ActivityID = group.Add(new VocabularyKey(nameof(ActivityID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerJourneyId = group.Add(new VocabularyKey(nameof(CustomerJourneyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerjourneycustomchannelactivityId = group.Add(new VocabularyKey(nameof(CustomerjourneycustomchannelactivityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactId = group.Add(new VocabularyKey(nameof(ContactId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityID = group.Add(new VocabularyKey(nameof(EntityID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityType = group.Add(new VocabularyKey(nameof(EntityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ActivityID { get; private set; }
        public VocabularyKey CustomerJourneyId { get; private set; }
        public VocabularyKey CustomerjourneycustomchannelactivityId { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey EntityID { get; private set; }
        public VocabularyKey EntityType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}