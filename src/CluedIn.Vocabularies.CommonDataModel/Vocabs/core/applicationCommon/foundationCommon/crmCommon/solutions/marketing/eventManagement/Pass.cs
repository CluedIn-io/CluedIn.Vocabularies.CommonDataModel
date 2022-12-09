using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class PassVocabulary : SimpleVocabulary
    {
        public PassVocabulary()
        {
            VocabularyName = "Pass";
            KeyPrefix = "commonDataModel.pass";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Pass;

            AddGroup("Pass Details for EventManagement", group =>
            {
			    PassId = group.Add(new VocabularyKey(nameof(PassId), "Pass", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CostPerUnit = group.Add(new VocabularyKey(nameof(CostPerUnit), "Cost per unit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CostPerUnitBase = group.Add(new VocabularyKey(nameof(CostPerUnitBase), "Cost per unit (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NoOfPassesAllocated = group.Add(new VocabularyKey(nameof(NoOfPassesAllocated), "No of passes allocated", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    NoOfPassesSold = group.Add(new VocabularyKey(nameof(NoOfPassesSold), "No of passes sold", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    PassPrice = group.Add(new VocabularyKey(nameof(PassPrice), "Pass Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    PassPriceBase = group.Add(new VocabularyKey(nameof(PassPriceBase), "Pass Price (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NoOfPassesLeft = group.Add(new VocabularyKey(nameof(NoOfPassesLeft), "No of passes left", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    TotalCost = group.Add(new VocabularyKey(nameof(TotalCost), "Total cost", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalcostBase = group.Add(new VocabularyKey(nameof(TotalcostBase), "Total cost (Base)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
            ///Property <see cref="EventId"/> to Vocab 'Event.cdm.json/Event' with Property 'EventId'
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
            ///Property <see cref="Track"/> to Vocab 'SessionTrack.cdm.json/SessionTrack' with Property 'SessionTrackId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="PassId"/> from Vocab 'AttendeePass.cdm.json/AttendeePass' with Property 'Pass'
            ///Property <see cref="AttendeePassId"/> from Vocab 'CheckIn.cdm.json/CheckIn' with Property 'PurchasedPassesId'
            ///Property <see cref="PassId"/> from Vocab 'Session.cdm.json/Session' with Property 'PassSessions'
            #endregion
        }

        public VocabularyKey CostPerUnit { get; private set; }
        public VocabularyKey CostPerUnitBase { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NoOfPassesAllocated { get; private set; }
        public VocabularyKey NoOfPassesLeft { get; private set; }
        public VocabularyKey NoOfPassesSold { get; private set; }
        public VocabularyKey PassId { get; private set; }
        public VocabularyKey PassPrice { get; private set; }
        public VocabularyKey PassPriceBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TotalCost { get; private set; }
        public VocabularyKey TotalcostBase { get; private set; }
    }
}