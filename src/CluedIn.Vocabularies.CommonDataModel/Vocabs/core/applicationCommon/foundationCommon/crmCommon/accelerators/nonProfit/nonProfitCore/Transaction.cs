using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class TransactionVocabulary : SimpleVocabulary
    {
        public TransactionVocabulary()
        {
            VocabularyName = "Transaction";
            KeyPrefix = "commonDataModel.transaction.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Transaction";

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
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AdjustmentComment { get; private set; }
        public VocabularyKey AdjustmentReason { get; private set; }
        public VocabularyKey AdjustmentType { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey AmountBase { get; private set; }
        public VocabularyKey Anonymity { get; private set; }
        public VocabularyKey BookDate { get; private set; }
        public VocabularyKey DataEntryReference { get; private set; }
        public VocabularyKey DataEntrySource { get; private set; }
        public VocabularyKey EffectiveSourceCode { get; private set; }
        public VocabularyKey ExchangeRateDate { get; private set; }
        public VocabularyKey IsAdjusted { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OriginatingSourceCode { get; private set; }
        public VocabularyKey PostedDate { get; private set; }
        public VocabularyKey ReceivedDate { get; private set; }
        public VocabularyKey TransactionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}