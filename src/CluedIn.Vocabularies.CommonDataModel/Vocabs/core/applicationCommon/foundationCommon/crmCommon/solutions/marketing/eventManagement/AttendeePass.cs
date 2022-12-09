using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class AttendeePassVocabulary : SimpleVocabulary
    {
        public AttendeePassVocabulary()
        {
            VocabularyName = "Attendee Pass";
            KeyPrefix = "commonDataModel.attendeepass";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.AttendeePass;

            AddGroup("AttendeePass Details for EventManagement", group =>
            {
			    AttendeePassId = group.Add(new VocabularyKey(nameof(AttendeePassId), "Atendee Pass", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PassPrice = group.Add(new VocabularyKey(nameof(PassPrice), "Pass Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PassPriceBase = group.Add(new VocabularyKey(nameof(PassPriceBase), "Pass Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="EventId"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
            ///Property <see cref="EventRegistrationId"/> to Vocab 'EventRegistration.cdm.json/EventRegistration' with Property 'EventRegistrationId'
            ///Property <see cref="Pass"/> to Vocab 'Pass.cdm.json/Pass' with Property 'PassId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="AttendeePassId"/> from Vocab 'CheckIn.cdm.json/CheckIn' with Property 'PurchasedPassesId'
            #endregion
        }

        public VocabularyKey AttendeePassId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PassPrice { get; private set; }
        public VocabularyKey PassPriceBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}