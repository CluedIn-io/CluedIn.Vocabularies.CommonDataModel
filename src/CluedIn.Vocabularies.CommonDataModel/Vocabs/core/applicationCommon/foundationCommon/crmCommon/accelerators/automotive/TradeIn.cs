using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class TradeInVocabulary : SimpleVocabulary
    {
        public TradeInVocabulary()
        {
            VocabularyName = "Trade In";
            KeyPrefix = "commonDataModel.tradein";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.TradeIn;

            AddGroup("TradeIn Details for Automotive", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AppraisalSource = group.Add(new VocabularyKey(nameof(AppraisalSource), "Appraisal Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AppraisedValue = group.Add(new VocabularyKey(nameof(AppraisedValue), "Appraised Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AppraisedValueBase = group.Add(new VocabularyKey(nameof(AppraisedValueBase), "Appraised Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OfferPrice = group.Add(new VocabularyKey(nameof(OfferPrice), "Offer Price", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OfferPriceBase = group.Add(new VocabularyKey(nameof(OfferPriceBase), "Offer Price (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TradeInId = group.Add(new VocabularyKey(nameof(TradeInId), "Trade In", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="LeadId"/> to Vocab 'Lead.cdm.json/Lead' with Property 'LeadId'
            ///Property <see cref="DealId"/> to Vocab 'Deal.cdm.json/Deal' with Property 'DealId'
            ///Property <see cref="DeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="CustomerId"/> to Vocab '/core/applicationCommon/Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey AppraisalSource { get; private set; }
        public VocabularyKey AppraisedValue { get; private set; }
        public VocabularyKey AppraisedValueBase { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OfferPrice { get; private set; }
        public VocabularyKey OfferPriceBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TradeInId { get; private set; }
    }
}