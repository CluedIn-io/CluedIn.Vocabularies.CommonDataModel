using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class TransactionVocabulary : SimpleVocabulary
    {
        public TransactionVocabulary()
        {
            VocabularyName = "Transaction";
            KeyPrefix = "commonDataModel.transaction";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Transaction;

            AddGroup("Transaction Details for NonProfitCore", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AdjustmentComment = group.Add(new VocabularyKey(nameof(AdjustmentComment), "Adjustment Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdjustmentReason = group.Add(new VocabularyKey(nameof(AdjustmentReason), "Adjustment Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdjustmentType = group.Add(new VocabularyKey(nameof(AdjustmentType), "Adjustment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Anonymity = group.Add(new VocabularyKey(nameof(Anonymity), "Anonymity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BookDate = group.Add(new VocabularyKey(nameof(BookDate), "Book Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataEntryReference = group.Add(new VocabularyKey(nameof(DataEntryReference), "Data Entry Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataEntrySource = group.Add(new VocabularyKey(nameof(DataEntrySource), "Data Entry Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectiveSourceCode = group.Add(new VocabularyKey(nameof(EffectiveSourceCode), "Effective Source Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRateDate = group.Add(new VocabularyKey(nameof(ExchangeRateDate), "Exchange Rate Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsAdjusted = group.Add(new VocabularyKey(nameof(IsAdjusted), "Is Adjusted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OriginatingSourceCode = group.Add(new VocabularyKey(nameof(OriginatingSourceCode), "Originating Source Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostedDate = group.Add(new VocabularyKey(nameof(PostedDate), "Posted Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReceivedDate = group.Add(new VocabularyKey(nameof(ReceivedDate), "Received Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TransactionId = group.Add(new VocabularyKey(nameof(TransactionId), "Transaction", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Transaction Details for NonProfitForSales", group =>
            {
			    OriginalTxnAdjustedId = group.Add(new VocabularyKey(nameof(OriginalTxnAdjustedId), "Original Transaction Adjusted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            AddGroup("Transaction Details for NonProfitIati", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CurrencyValueDate = group.Add(new VocabularyKey(nameof(CurrencyValueDate), "Currency Value Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Humanitarian = group.Add(new VocabularyKey(nameof(Humanitarian), "Humanitarian", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ProviderActivityIdentifier = group.Add(new VocabularyKey(nameof(ProviderActivityIdentifier), "Provider Activity Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientActivityIdentifier = group.Add(new VocabularyKey(nameof(RecipientActivityIdentifier), "Recipient Activity Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientCountryDescription = group.Add(new VocabularyKey(nameof(RecipientCountryDescription), "Recipient Country Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecipientRegionDescription = group.Add(new VocabularyKey(nameof(RecipientRegionDescription), "Recipient Region Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Reference = group.Add(new VocabularyKey(nameof(Reference), "Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Amount_Base = group.Add(new VocabularyKey(nameof(Amount_Base), "Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="TransactionReceiptOnAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="TransactionReceiptOnAccountId"/> to Vocab 'Account.cdm.json/Account' with Property 'AccountId'
            ///Property <see cref="ReceiptOnContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="ReceiptOnContactId"/> to Vocab 'Contact.cdm.json/Contact' with Property 'ContactId'
            ///Property <see cref="TransactionPaymentMethodId"/> to Vocab 'PaymentMethod.cdm.json/PaymentMethod' with Property 'PaymentMethodId'
            ///Property <see cref="TransactionPaymentMethodId"/> to Vocab 'PaymentMethod.cdm.json/PaymentMethod' with Property 'PaymentMethodId'
            ///Property <see cref="TransactionPaymentScheduleId"/> to Vocab 'PaymentSchedule.cdm.json/PaymentSchedule' with Property 'PaymentScheduleId'
            ///Property <see cref="TransactionPaymentScheduleId"/> to Vocab 'PaymentSchedule.cdm.json/PaymentSchedule' with Property 'PaymentScheduleId'
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
            ///Property <see cref="OriginalTxnAdjustedId"/> to Vocab 'Transaction.cdm.json/Transaction' with Property 'TransactionId'
            ///Property <see cref="TransactionCurrencyId"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="TransactionId"/> from Vocab 'DesignatedCredit.cdm.json/DesignatedCredit' with Property 'TransactionId'
            ///Property <see cref="TransactionId"/> from Vocab 'PaymentAsset.cdm.json/PaymentAsset' with Property 'TransferredOnTransactionId'
            ///Property <see cref="TransactionId"/> from Vocab 'PaymentMethod.cdm.json/PaymentMethod' with Property 'TransactionId'
            ///Property <see cref="TransactionId"/> from Vocab 'Transaction.cdm.json/Transaction' with Property 'OriginalTxnAdjustedId'
            #endregion
        }

        public VocabularyKey AdjustmentComment { get; private set; }
        public VocabularyKey AdjustmentReason { get; private set; }
        public VocabularyKey AdjustmentType { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Amount_Base { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey Anonymity { get; private set; }
        public VocabularyKey BookDate { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey CurrencyValueDate { get; private set; }
        public VocabularyKey DataEntryReference { get; private set; }
        public VocabularyKey DataEntrySource { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EffectiveSourceCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey ExchangeRateDate { get; private set; }
        public VocabularyKey Humanitarian { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey IsAdjusted { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OriginalTxnAdjustedId { get; private set; }
        public VocabularyKey OriginatingSourceCode { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey PostedDate { get; private set; }
        public VocabularyKey ProviderActivityIdentifier { get; private set; }
        public VocabularyKey ReceivedDate { get; private set; }
        public VocabularyKey RecipientActivityIdentifier { get; private set; }
        public VocabularyKey RecipientCountryDescription { get; private set; }
        public VocabularyKey RecipientRegionDescription { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TransactionId { get; private set; }
    }
}