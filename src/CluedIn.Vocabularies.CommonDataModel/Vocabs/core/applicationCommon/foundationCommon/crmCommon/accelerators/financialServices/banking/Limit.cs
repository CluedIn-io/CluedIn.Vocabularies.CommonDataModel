using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class LimitVocabulary : SimpleVocabulary
    {
        public LimitVocabulary()
        {
            VocabularyName = "Limit";
            KeyPrefix = "commonDataModel.limit";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Limit;

            AddGroup("Limit Details for Banking", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AvailableLimit = group.Add(new VocabularyKey(nameof(AvailableLimit), "Available Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AvailableLimitBase = group.Add(new VocabularyKey(nameof(AvailableLimitBase), "Available Limit (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ImplementedLimit = group.Add(new VocabularyKey(nameof(ImplementedLimit), "Implemented Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ImplementedLimitBase = group.Add(new VocabularyKey(nameof(ImplementedLimitBase), "Implemented Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    LimitExpiry = group.Add(new VocabularyKey(nameof(LimitExpiry), "Limit Expiry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LimitId = group.Add(new VocabularyKey(nameof(LimitId), "Limit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LimitName = group.Add(new VocabularyKey(nameof(LimitName), "Limit Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LimitType = group.Add(new VocabularyKey(nameof(LimitType), "Limit Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UtilizedLimit = group.Add(new VocabularyKey(nameof(UtilizedLimit), "Utilized Limit", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    UtilizedLimitBase = group.Add(new VocabularyKey(nameof(UtilizedLimitBase), "Utilized Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CompanyId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
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
            ///Property <see cref="ProductId"/> to Vocab 'Product.cdm.json/Product' with Property 'ProductId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="LimitId"/> from Vocab 'FinancialProduct.cdm.json/FinancialProduct' with Property 'LimitId'
            #endregion
        }

        public VocabularyKey AvailableLimit { get; private set; }
        public VocabularyKey AvailableLimitBase { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ImplementedLimit { get; private set; }
        public VocabularyKey ImplementedLimitBase { get; private set; }
        public VocabularyKey LimitExpiry { get; private set; }
        public VocabularyKey LimitId { get; private set; }
        public VocabularyKey LimitName { get; private set; }
        public VocabularyKey LimitType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey UtilizedLimit { get; private set; }
        public VocabularyKey UtilizedLimitBase { get; private set; }
    }
}