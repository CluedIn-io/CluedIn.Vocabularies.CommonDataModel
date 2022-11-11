using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchRequestForQuotationReplyScoringCriterionEntityVocabulary : SimpleVocabulary
    {
        public PurchRequestForQuotationReplyScoringCriterionEntityVocabulary()
        {
            VocabularyName = "PurchRequestForQuotationReplyScoringCriterionEntity";
            KeyPrefix = "commonDataModel.purchrequestforquotationreplyscoringcriterionentity";
            KeySeparator = ".";
            Grouping = "/PurchRequestForQuotationReplyScoringCriterionEntity";

            AddGroup("PurchRequestForQuotationReplyScoringCriterionEntity Details", group =>
            {
                RFQNumber = group.Add(new VocabularyKey(nameof(RFQNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CriterionScore = group.Add(new VocabularyKey(nameof(CriterionScore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CriterionName = group.Add(new VocabularyKey(nameof(CriterionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorRFQReplyStatusCode = group.Add(new VocabularyKey(nameof(VendorRFQReplyStatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorScoringStatusComment = group.Add(new VocabularyKey(nameof(VendorScoringStatusComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CriterionId = group.Add(new VocabularyKey(nameof(CriterionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RFQNumber { get; private set; }
        public VocabularyKey CriterionScore { get; private set; }
        public VocabularyKey CriterionName { get; private set; }
        public VocabularyKey VendorRFQReplyStatusCode { get; private set; }
        public VocabularyKey VendorScoringStatusComment { get; private set; }
        public VocabularyKey CriterionId { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }


    }
}