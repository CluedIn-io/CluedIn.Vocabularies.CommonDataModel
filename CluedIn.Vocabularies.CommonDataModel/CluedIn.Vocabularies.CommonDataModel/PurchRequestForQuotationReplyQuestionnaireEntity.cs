using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchRequestForQuotationReplyQuestionnaireEntityVocabulary : SimpleVocabulary
    {
        public PurchRequestForQuotationReplyQuestionnaireEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchRequestForQuotationReplyQuestionnaireEntity";
            KeyPrefix = "commonDataModel.purchrequestforquotationreplyquestionnaireentity";
            KeySeparator = ".";
            Grouping = "/PurchRequestForQuotationReplyQuestionnaireEntity";

            AddGroup("Common Data Model PurchRequestForQuotationReplyQuestionnaireEntity Details", group =>
            {
                KMVirtualNetworkAnswerTableId = group.Add(new VocabularyKey(nameof(KMVirtualNetworkAnswerTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuestionnaireId = group.Add(new VocabularyKey(nameof(QuestionnaireId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQNumber = group.Add(new VocabularyKey(nameof(RFQNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuestionnaireQuestionId = group.Add(new VocabularyKey(nameof(QuestionnaireQuestionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AnswerText = group.Add(new VocabularyKey(nameof(AnswerText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuestionSequenceNumber = group.Add(new VocabularyKey(nameof(QuestionSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuestionInstruction = group.Add(new VocabularyKey(nameof(QuestionInstruction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuestionText = group.Add(new VocabularyKey(nameof(QuestionText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuestionInputType = group.Add(new VocabularyKey(nameof(QuestionInputType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AnswerComment = group.Add(new VocabularyKey(nameof(AnswerComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
QuestionnaireStatus = group.Add(new VocabularyKey(nameof(QuestionnaireStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResponseRecId = group.Add(new VocabularyKey(nameof(ResponseRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey KMVirtualNetworkAnswerTableId { get; private set; }
public VocabularyKey QuestionnaireId { get; private set; }
public VocabularyKey RFQNumber { get; private set; }
public VocabularyKey VendorAccountNumber { get; private set; }
public VocabularyKey QuestionnaireQuestionId { get; private set; }
public VocabularyKey AnswerText { get; private set; }
public VocabularyKey QuestionSequenceNumber { get; private set; }
public VocabularyKey QuestionInstruction { get; private set; }
public VocabularyKey QuestionText { get; private set; }
public VocabularyKey QuestionInputType { get; private set; }
public VocabularyKey AnswerComment { get; private set; }
public VocabularyKey QuestionnaireStatus { get; private set; }
public VocabularyKey ResponseRecId { get; private set; }


    }
}