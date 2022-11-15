using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPublishedRequestForQuotationAmendmentEntityVocabulary : SimpleVocabulary
    {
        public PurchPublishedRequestForQuotationAmendmentEntityVocabulary()
        {
            VocabularyName = "Purch Published Request For Quotation Amendment Entity";
            KeyPrefix = "commonDataModel.purchpublishedrequestforquotationamendmententity";
            KeySeparator = ".";
            Grouping = "/PurchPublishedRequestForQuotationAmendmentEntity";

            AddGroup("PurchPublishedRequestForQuotationAmendmentEntity Details", group =>
            {
                AmendmentNumber = group.Add(new VocabularyKey(nameof(AmendmentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmendmentRecId = group.Add(new VocabularyKey(nameof(AmendmentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCaseNumber = group.Add(new VocabularyKey(nameof(RFQCaseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmendmentName = group.Add(new VocabularyKey(nameof(AmendmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmendmentDescription = group.Add(new VocabularyKey(nameof(AmendmentDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmendmentRequesterName = group.Add(new VocabularyKey(nameof(AmendmentRequesterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AmendmentNumber { get; private set; }
        public VocabularyKey AmendmentRecId { get; private set; }
        public VocabularyKey RFQCaseNumber { get; private set; }
        public VocabularyKey AmendmentName { get; private set; }
        public VocabularyKey AmendmentDescription { get; private set; }
        public VocabularyKey AmendmentRequesterName { get; private set; }
    }
}