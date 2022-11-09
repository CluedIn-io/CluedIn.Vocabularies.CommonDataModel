using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchRequestForQuotationReplyStatusEntityVocabulary : SimpleVocabulary
    {
        public PurchRequestForQuotationReplyStatusEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchRequestForQuotationReplyStatusEntity";
            KeyPrefix = "commonDataModel.purchrequestforquotationreplystatusentity";
            KeySeparator = ".";
            Grouping = "/PurchRequestForQuotationReplyStatusEntity";

            AddGroup("Common Data Model PurchRequestForQuotationReplyStatusEntity Details", group =>
            {
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StatusDescription = group.Add(new VocabularyKey(nameof(StatusDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey StatusCode { get; private set; }
public VocabularyKey StatusDescription { get; private set; }


    }
}