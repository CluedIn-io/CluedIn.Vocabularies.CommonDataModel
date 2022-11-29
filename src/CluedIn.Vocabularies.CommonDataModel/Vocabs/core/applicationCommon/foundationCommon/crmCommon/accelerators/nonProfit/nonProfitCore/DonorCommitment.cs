using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class DonorCommitmentVocabulary : SimpleVocabulary
    {
        public DonorCommitmentVocabulary()
        {
            VocabularyName = "Donor Commitment";
            KeyPrefix = "commonDataModel.donorcommitment.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/DonorCommitment";

            AddGroup("DonorCommitment Details for NonProfitCore", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Anonymity = group.Add(new VocabularyKey(nameof(Anonymity), "Anonymity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BookDate = group.Add(new VocabularyKey(nameof(BookDate), "Book Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommitmentDate = group.Add(new VocabularyKey(nameof(CommitmentDate), "Commitment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CommitmentType = group.Add(new VocabularyKey(nameof(CommitmentType), "Commitment Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataEntryReference = group.Add(new VocabularyKey(nameof(DataEntryReference), "Data Entry Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataEntrySource = group.Add(new VocabularyKey(nameof(DataEntrySource), "Data Entry Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DonorCommitmentId = group.Add(new VocabularyKey(nameof(DonorCommitmentId), "Donor Commitment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedByDate = group.Add(new VocabularyKey(nameof(ExpectedByDate), "Expected By Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsBookable = group.Add(new VocabularyKey(nameof(IsBookable), "Is Bookable", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NextPaymentAmount = group.Add(new VocabularyKey(nameof(NextPaymentAmount), "Next Payment Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    NextPaymentAmountBase = group.Add(new VocabularyKey(nameof(NextPaymentAmountBase), "Next Payment Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    NextPaymentDate = group.Add(new VocabularyKey(nameof(NextPaymentDate), "Next Payment Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReceivedDate = group.Add(new VocabularyKey(nameof(ReceivedDate), "Received Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalAmount = group.Add(new VocabularyKey(nameof(TotalAmount), "Total Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalAmountBase = group.Add(new VocabularyKey(nameof(TotalAmountBase), "Total Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Anonymity { get; private set; }
        public VocabularyKey BookDate { get; private set; }
        public VocabularyKey CommitmentDate { get; private set; }
        public VocabularyKey CommitmentType { get; private set; }
        public VocabularyKey DataEntryReference { get; private set; }
        public VocabularyKey DataEntrySource { get; private set; }
        public VocabularyKey DonorCommitmentId { get; private set; }
        public VocabularyKey ExpectedByDate { get; private set; }
        public VocabularyKey IsBookable { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NextPaymentAmount { get; private set; }
        public VocabularyKey NextPaymentAmountBase { get; private set; }
        public VocabularyKey NextPaymentDate { get; private set; }
        public VocabularyKey ReceivedDate { get; private set; }
        public VocabularyKey TotalAmount { get; private set; }
        public VocabularyKey TotalAmountBase { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}