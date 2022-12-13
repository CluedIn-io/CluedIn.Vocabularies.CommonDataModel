using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class CheckInVocabulary : SimpleVocabulary
    {
        public CheckInVocabulary()
        {
            VocabularyName = "Check In";
            KeyPrefix = "commonDataModel.checkin";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.CheckIn;

            AddGroup("CheckIn Details for EventManagement", group =>
            {
                CheckInId = group.Add(new VocabularyKey(nameof(CheckInId), "Check-in", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AudienceType = group.Add(new VocabularyKey(nameof(AudienceType), "Audience Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Checkintime = group.Add(new VocabularyKey(nameof(Checkintime), "Check-in time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckInType = group.Add(new VocabularyKey(nameof(CheckInType), "Check-in Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckOutTime = group.Add(new VocabularyKey(nameof(CheckOutTime), "Check-out time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfQuestionsAsked = group.Add(new VocabularyKey(nameof(NumberOfQuestionsAsked), "Number of interactions", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                SessionCode = group.Add(new VocabularyKey(nameof(SessionCode), "Session Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionType = group.Add(new VocabularyKey(nameof(SessionType), "Session Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), "Currency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ViewingDurationInMins = group.Add(new VocabularyKey(nameof(ViewingDurationInMins), "Viewing Duration in mins", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="PurchasedPassesId"/> to Vocab 'AttendeePass.cdm.json/AttendeePass' with Property 'AttendeePassId'
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
            ///Property <see cref="Event"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="RegistrationId"/> to Vocab 'EventRegistration.cdm.json/EventRegistration' with Property 'EventRegistrationId'
            ///Property <see cref="SessionAttended"/> to Vocab 'Session.cdm.json/Session' with Property 'SessionId'
            ///Property <see cref="SessionRegistration"/> to Vocab 'SessionRegistration.cdm.json/SessionRegistration' with Property 'SessionRegistrationId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="CheckInId"/> from Vocab '/core/applicationCommon/foundationCommon/crmCommon/solutions/marketing/Contact.cdm.json/Contact' with Property 'CheckInId'
            #endregion
        }

        public VocabularyKey AudienceType { get; private set; }
        public VocabularyKey CheckInId { get; private set; }
        public VocabularyKey Checkintime { get; private set; }
        public VocabularyKey CheckInType { get; private set; }
        public VocabularyKey CheckOutTime { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NumberOfQuestionsAsked { get; private set; }
        public VocabularyKey SessionCode { get; private set; }
        public VocabularyKey SessionType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey ViewingDurationInMins { get; private set; }
    }
}