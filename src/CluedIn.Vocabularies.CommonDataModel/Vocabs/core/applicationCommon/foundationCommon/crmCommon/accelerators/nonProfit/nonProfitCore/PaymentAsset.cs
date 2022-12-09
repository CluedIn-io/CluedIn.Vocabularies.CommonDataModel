using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class PaymentAssetVocabulary : SimpleVocabulary
    {
        public PaymentAssetVocabulary()
        {
            VocabularyName = "Payment Asset";
            KeyPrefix = "commonDataModel.paymentasset";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.PaymentAsset;

            AddGroup("PaymentAsset Details for NonProfitCore", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AssetType = group.Add(new VocabularyKey(nameof(AssetType), "Asset Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BookDate = group.Add(new VocabularyKey(nameof(BookDate), "Book Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaymentAssetCategory = group.Add(new VocabularyKey(nameof(PaymentAssetCategory), "Payment Asset Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaymentAssetId = group.Add(new VocabularyKey(nameof(PaymentAssetId), "Payment Asset", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PaymentAssetSubcategory = group.Add(new VocabularyKey(nameof(PaymentAssetSubcategory), "Payment Asset Subcategory", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Symbol = group.Add(new VocabularyKey(nameof(Symbol), "Symbol", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
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
            ///Property <see cref="OriginalAssetAdjustedId"/> to Vocab 'PaymentAsset.cdm.json/PaymentAsset' with Property 'PaymentAssetId'
            ///Property <see cref="PaymentassetPlannedgivingId"/> to Vocab 'PlannedGiving.cdm.json/PlannedGiving' with Property 'PlannedGivingId'
            ///Property <see cref="PaymentAssetPledgedAssetId"/> to Vocab 'PaymentAsset.cdm.json/PaymentAsset' with Property 'PaymentAssetId'
            ///Property <see cref="PledgedOnPaymentScheduleId"/> to Vocab 'PaymentSchedule.cdm.json/PaymentSchedule' with Property 'PaymentScheduleId'
            ///Property <see cref="TransferredOnTransactionId"/> to Vocab 'Transaction.cdm.json/Transaction' with Property 'TransactionId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="PaymentAssetId"/> from Vocab 'PaymentAsset.cdm.json/PaymentAsset' with Property 'OriginalAssetAdjustedId'
            ///Property <see cref="PaymentAssetId"/> from Vocab 'PaymentAsset.cdm.json/PaymentAsset' with Property 'PaymentAssetPledgedAssetId'
            #endregion
        }

        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey AssetType { get; private set; }
        public VocabularyKey BookDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PaymentAssetCategory { get; private set; }
        public VocabularyKey PaymentAssetId { get; private set; }
        public VocabularyKey PaymentAssetSubcategory { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Symbol { get; private set; }
    }
}