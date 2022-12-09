using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class SurveyResponseVocabulary : SimpleVocabulary
    {
        public SurveyResponseVocabulary()
        {
            VocabularyName = "Survey Response";
            KeyPrefix = "commonDataModel.surveyresponse";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SurveyResponse;

            AddGroup("SurveyResponse Details for Interactions", group =>
            {
			    InteractionId = group.Add(new VocabularyKey(nameof(InteractionId), "Interaction Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationId = group.Add(new VocabularyKey(nameof(OrganizationId), "Organization ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SurveyId = group.Add(new VocabularyKey(nameof(SurveyId), "Survey ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AccountId = group.Add(new VocabularyKey(nameof(AccountId), "Account ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Score = group.Add(new VocabularyKey(nameof(Score), "Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    InteractionType = group.Add(new VocabularyKey(nameof(InteractionType), "Interaction type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timestamp = group.Add(new VocabularyKey(nameof(Timestamp), "Timestamp", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerJourneyId = group.Add(new VocabularyKey(nameof(CustomerJourneyId), "Customer Journey ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey AccountId { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey CustomerJourneyId { get; private set; }
        public VocabularyKey InteractionId { get; private set; }
        public VocabularyKey InteractionType { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
        public VocabularyKey Score { get; private set; }
        public VocabularyKey SurveyId { get; private set; }
        public VocabularyKey Timestamp { get; private set; }
    }
}