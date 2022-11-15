using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmMarketingMailPolicyEntityVocabulary : SimpleVocabulary
    {
        public SmmMarketingMailPolicyEntityVocabulary()
        {
            VocabularyName = "Smm Marketing Mail Policy Entity";
            KeyPrefix = "commonDataModel.smmmarketingmailpolicyentity";
            KeySeparator = ".";
            Grouping = "/SmmMarketingMailPolicyEntity";

            AddGroup("SmmMarketingMailPolicyEntity Details", group =>
            {
                GroupEmailRecipientType = group.Add(new VocabularyKey(nameof(GroupEmailRecipientType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentAgeLimitDays = group.Add(new VocabularyKey(nameof(DocumentAgeLimitDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultMailingFileFolder = group.Add(new VocabularyKey(nameof(DefaultMailingFileFolder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncomingEmailDocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(IncomingEmailDocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OutgoingEmailDocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(OutgoingEmailDocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileDocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(FileDocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupEmailRecipientType { get; private set; }
        public VocabularyKey DocumentAgeLimitDays { get; private set; }
        public VocabularyKey DefaultMailingFileFolder { get; private set; }
        public VocabularyKey IncomingEmailDocumentAttachmentTypeCode { get; private set; }
        public VocabularyKey OutgoingEmailDocumentAttachmentTypeCode { get; private set; }
        public VocabularyKey FileDocumentAttachmentTypeCode { get; private set; }
    }
}