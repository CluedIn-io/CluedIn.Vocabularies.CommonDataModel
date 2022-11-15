using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchRFQVendPostedQuestionAnswerEntityVocabulary : SimpleVocabulary
    {
        public PurchRFQVendPostedQuestionAnswerEntityVocabulary()
        {
            VocabularyName = "Purch RFQ Vend Posted Question Answer Entity";
            KeyPrefix = "commonDataModel.purchrfqvendpostedquestionanswerentity";
            KeySeparator = ".";
            Grouping = "/PurchRFQVendPostedQuestionAnswerEntity";

            AddGroup("PurchRFQVendPostedQuestionAnswerEntity Details", group =>
            {
                RFQNumber = group.Add(new VocabularyKey(nameof(RFQNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Question = group.Add(new VocabularyKey(nameof(Question), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAnswer = group.Add(new VocabularyKey(nameof(CustomerAnswer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuestionReceived = group.Add(new VocabularyKey(nameof(QuestionReceived), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AnswerReceived = group.Add(new VocabularyKey(nameof(AnswerReceived), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCaseNumber = group.Add(new VocabularyKey(nameof(RFQCaseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDirectResponse = group.Add(new VocabularyKey(nameof(IsDirectResponse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostedGroupQuestionAnswerId = group.Add(new VocabularyKey(nameof(PostedGroupQuestionAnswerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupQuestion = group.Add(new VocabularyKey(nameof(GroupQuestion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupAnswer = group.Add(new VocabularyKey(nameof(GroupAnswer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuestionNumber = group.Add(new VocabularyKey(nameof(QuestionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RFQNumber { get; private set; }
        public VocabularyKey Question { get; private set; }
        public VocabularyKey CustomerAnswer { get; private set; }
        public VocabularyKey QuestionReceived { get; private set; }
        public VocabularyKey AnswerReceived { get; private set; }
        public VocabularyKey RFQCaseNumber { get; private set; }
        public VocabularyKey IsDirectResponse { get; private set; }
        public VocabularyKey PostedGroupQuestionAnswerId { get; private set; }
        public VocabularyKey GroupCode { get; private set; }
        public VocabularyKey GroupQuestion { get; private set; }
        public VocabularyKey GroupAnswer { get; private set; }
        public VocabularyKey QuestionNumber { get; private set; }
    }
}