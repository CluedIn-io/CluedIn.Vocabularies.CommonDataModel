using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.Interactions
{
    public class LeadScoreBoostVocabulary : SimpleVocabulary
    {
        public LeadScoreBoostVocabulary()
        {
            VocabularyName = "Lead Score Boost";
            KeyPrefix = "commonDataModel.leadscoreboost.interactions";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.LeadScoreBoost;

            AddGroup("LeadScoreBoost Details for Interactions", group =>
            {
			    InteractionId = group.Add(new VocabularyKey(nameof(InteractionId), "Interaction Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationId = group.Add(new VocabularyKey(nameof(OrganizationId), "Organization ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityId = group.Add(new VocabularyKey(nameof(ActivityId), "Activity ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerJourneyId = group.Add(new VocabularyKey(nameof(CustomerJourneyId), "Customer Journey ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerJourneyIterationId = group.Add(new VocabularyKey(nameof(CustomerJourneyIterationId), "Customer journey iteration ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BoostValue = group.Add(new VocabularyKey(nameof(BoostValue), "Boost value", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    InteractionType = group.Add(new VocabularyKey(nameof(InteractionType), "Interaction type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timestamp = group.Add(new VocabularyKey(nameof(Timestamp), "Timestamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey InteractionId { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
        public VocabularyKey ActivityId { get; private set; }
        public VocabularyKey CustomerJourneyId { get; private set; }
        public VocabularyKey CustomerJourneyIterationId { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey BoostValue { get; private set; }
        public VocabularyKey InteractionType { get; private set; }
        public VocabularyKey Timestamp { get; private set; }
    }
}