using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class DisbursementVocabulary : SimpleVocabulary
    {
        public DisbursementVocabulary()
        {
            VocabularyName = "Disbursement";
            KeyPrefix = "commonDataModel.disbursement.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Disbursement";

            AddGroup("Disbursement Details for NonProfitCore", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AdjustmentComment = group.Add(new VocabularyKey(nameof(AdjustmentComment), "Adjustment Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdjustmentReason = group.Add(new VocabularyKey(nameof(AdjustmentReason), "Adjustment Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AdjustmentType = group.Add(new VocabularyKey(nameof(AdjustmentType), "Adjustment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmountBase = group.Add(new VocabularyKey(nameof(AmountBase), "amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Amouont = group.Add(new VocabularyKey(nameof(Amouont), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    AmouontBase = group.Add(new VocabularyKey(nameof(AmouontBase), "Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    BookDate = group.Add(new VocabularyKey(nameof(BookDate), "Book Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Comment = group.Add(new VocabularyKey(nameof(Comment), "Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DisbursementId = group.Add(new VocabularyKey(nameof(DisbursementId), "Disbursement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsAdjusted = group.Add(new VocabularyKey(nameof(IsAdjusted), "Is Adjusted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostedDate = group.Add(new VocabularyKey(nameof(PostedDate), "Posted Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestDate = group.Add(new VocabularyKey(nameof(RequestDate), "Request Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledDisbursementDate = group.Add(new VocabularyKey(nameof(ScheduledDisbursementDate), "Scheduled Disbursement Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SentDate = group.Add(new VocabularyKey(nameof(SentDate), "Sent Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
        public VocabularyKey Amouont { get; private set; }
        public VocabularyKey AmouontBase { get; private set; }
        public VocabularyKey BookDate { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisbursementId { get; private set; }
        public VocabularyKey IsAdjusted { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PostedDate { get; private set; }
        public VocabularyKey RequestDate { get; private set; }
        public VocabularyKey ScheduledDisbursementDate { get; private set; }
        public VocabularyKey SentDate { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}