using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class SalesContractDetailVocabulary : SimpleVocabulary
    {
        public SalesContractDetailVocabulary()
        {
            VocabularyName = "Sales Contract Detail";
            KeyPrefix = "commonDataModel.salescontractdetail";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SalesContractDetail;

            AddGroup("SalesContractDetail Details for Automotive", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    BuybackDate = group.Add(new VocabularyKey(nameof(BuybackDate), "Buyback Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BuybackValue = group.Add(new VocabularyKey(nameof(BuybackValue), "Buyback Value", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BuybackValueBase = group.Add(new VocabularyKey(nameof(BuybackValueBase), "Buyback Value (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SalesContractDetailId = group.Add(new VocabularyKey(nameof(SalesContractDetailId), "Sales Contract Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="DeviceId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="SalesContractId"/> to Vocab 'SalesContract.cdm.json/SalesContract' with Property 'SalesContractId'
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
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey BuybackDate { get; private set; }
        public VocabularyKey BuybackValue { get; private set; }
        public VocabularyKey BuybackValueBase { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SalesContractDetailId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}