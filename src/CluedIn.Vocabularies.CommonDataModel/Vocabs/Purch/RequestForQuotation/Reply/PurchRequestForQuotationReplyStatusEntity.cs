using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchRequestForQuotationReplyStatusEntityVocabulary : SimpleVocabulary
    {
        public PurchRequestForQuotationReplyStatusEntityVocabulary()
        {
            VocabularyName = "Purch Request For Quotation Reply Status Entity";
            KeyPrefix = "commonDataModel.purchrequestforquotationreplystatusentity";
            KeySeparator = ".";
            Grouping = "/PurchRequestForQuotationReplyStatusEntity";

            AddGroup("PurchRequestForQuotationReplyStatusEntity Details", group =>
            {
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusDescription = group.Add(new VocabularyKey(nameof(StatusDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StatusDescription { get; private set; }
    }
}