using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class SpeakerVocabulary : SimpleVocabulary
    {
        public SpeakerVocabulary()
        {
            VocabularyName = "Speaker";
            KeyPrefix = "commonDataModel.speaker";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Speaker;

            AddGroup("Speaker Details for EventManagement", group =>
            {
			    SpeakerId = group.Add(new VocabularyKey(nameof(SpeakerId), "Speaker", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntityImageId = group.Add(new VocabularyKey(nameof(EntityImageId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    About = group.Add(new VocabularyKey(nameof(About), "About", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Accomplishments = group.Add(new VocabularyKey(nameof(Accomplishments), "Accomplishments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Blog = group.Add(new VocabularyKey(nameof(Blog), "Blog", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Email = group.Add(new VocabularyKey(nameof(Email), "Email", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    EventRegistration = group.Add(new VocabularyKey(nameof(EventRegistration), "Event Registration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedIn = group.Add(new VocabularyKey(nameof(LinkedIn), "LinkedIn", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Publications = group.Add(new VocabularyKey(nameof(Publications), "Publications", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Speakercost = group.Add(new VocabularyKey(nameof(Speakercost), "Speaker Cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SpeakercostBase = group.Add(new VocabularyKey(nameof(SpeakercostBase), "Speaker Cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), "Currency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Twitter = group.Add(new VocabularyKey(nameof(Twitter), "Twitter", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Website = group.Add(new VocabularyKey(nameof(Website), "Website", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="EventId"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="Event"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="Session"/> to Vocab 'Session.cdm.json/Session' with Property 'SessionId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Contact"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="Speaker"/> to Vocab 'Speaker.cdm.json/Speaker' with Property 'SpeakerId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="SpeakerId"/> from Vocab 'SpeakerEngagement.cdm.json/SpeakerEngagement' with Property 'Speaker'
            #endregion
        }

        public VocabularyKey About { get; private set; }
        public VocabularyKey Accomplishments { get; private set; }
        public VocabularyKey Blog { get; private set; }
        public VocabularyKey Email { get; private set; }
        public VocabularyKey EntityImageId { get; private set; }
        public VocabularyKey EventRegistration { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey LinkedIn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey Publications { get; private set; }
        public VocabularyKey Speakercost { get; private set; }
        public VocabularyKey SpeakercostBase { get; private set; }
        public VocabularyKey SpeakerId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey Twitter { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Website { get; private set; }
    }
}