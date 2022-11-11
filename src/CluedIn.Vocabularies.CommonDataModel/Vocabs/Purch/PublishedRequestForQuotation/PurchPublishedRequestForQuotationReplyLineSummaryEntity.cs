using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPublishedRequestForQuotationReplyLineSummaryEntityVocabulary : SimpleVocabulary
    {
        public PurchPublishedRequestForQuotationReplyLineSummaryEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPublishedRequestForQuotationReplyLineSummaryEntity";
            KeyPrefix = "commonDataModel.purchpublishedrequestforquotationreplylinesummaryentity";
            KeySeparator = ".";
            Grouping = "/PurchPublishedRequestForQuotationReplyLineSummaryEntity";

            AddGroup("Common Data Model PurchPublishedRequestForQuotationReplyLineSummaryEntity Details", group =>
            {
                RFQNumber = group.Add(new VocabularyKey(nameof(RFQNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCaseNumber = group.Add(new VocabularyKey(nameof(RFQCaseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCaseRequestingWorkerName = group.Add(new VocabularyKey(nameof(RFQCaseRequestingWorkerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBidAwarded = group.Add(new VocabularyKey(nameof(IsBidAwarded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HighestRFQStatus = group.Add(new VocabularyKey(nameof(HighestRFQStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowestRFQStatus = group.Add(new VocabularyKey(nameof(LowestRFQStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorName = group.Add(new VocabularyKey(nameof(VendorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalVendorScore = group.Add(new VocabularyKey(nameof(TotalVendorScore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalVendorScoreComment = group.Add(new VocabularyKey(nameof(TotalVendorScoreComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorReplyStatus = group.Add(new VocabularyKey(nameof(VendorReplyStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQRecId = group.Add(new VocabularyKey(nameof(RFQRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RFQNumber { get; private set; }
        public VocabularyKey RFQCaseNumber { get; private set; }
        public VocabularyKey RFQCaseRequestingWorkerName { get; private set; }
        public VocabularyKey IsBidAwarded { get; private set; }
        public VocabularyKey HighestRFQStatus { get; private set; }
        public VocabularyKey LowestRFQStatus { get; private set; }
        public VocabularyKey LineAmount { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey VendorName { get; private set; }
        public VocabularyKey TotalVendorScore { get; private set; }
        public VocabularyKey TotalVendorScoreComment { get; private set; }
        public VocabularyKey VendorReplyStatus { get; private set; }
        public VocabularyKey RFQRecId { get; private set; }


    }
}