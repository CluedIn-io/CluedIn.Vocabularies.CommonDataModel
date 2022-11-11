using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankStatementDocumentEntityVocabulary : SimpleVocabulary
    {
        public BankStatementDocumentEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankStatementDocumentEntity";
            KeyPrefix = "commonDataModel.bankstatementdocumententity";
            KeySeparator = ".";
            Grouping = "/BankStatementDocumentEntity";

            AddGroup("Common Data Model BankStatementDocumentEntity Details", group =>
            {
                FormatName = group.Add(new VocabularyKey(nameof(FormatName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormatVersion = group.Add(new VocabularyKey(nameof(FormatVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupHeader = group.Add(new VocabularyKey(nameof(GroupHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BlockSize = group.Add(new VocabularyKey(nameof(BlockSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreationDateTime = group.Add(new VocabularyKey(nameof(CreationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MessageIdentification = group.Add(new VocabularyKey(nameof(MessageIdentification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MessageRecipient = group.Add(new VocabularyKey(nameof(MessageRecipient), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MessageSender = group.Add(new VocabularyKey(nameof(MessageSender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhysicalRecordLength = group.Add(new VocabularyKey(nameof(PhysicalRecordLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecipientId = group.Add(new VocabularyKey(nameof(RecipientId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecipientName = group.Add(new VocabularyKey(nameof(RecipientName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentLineNum = group.Add(new VocabularyKey(nameof(DocumentLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankStatementDocumentRecId = group.Add(new VocabularyKey(nameof(BankStatementDocumentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SenderName = group.Add(new VocabularyKey(nameof(SenderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SenderId = group.Add(new VocabularyKey(nameof(SenderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FormatName { get; private set; }
        public VocabularyKey FormatVersion { get; private set; }
        public VocabularyKey GroupHeader { get; private set; }
        public VocabularyKey BlockSize { get; private set; }
        public VocabularyKey CreationDateTime { get; private set; }
        public VocabularyKey MessageIdentification { get; private set; }
        public VocabularyKey MessageRecipient { get; private set; }
        public VocabularyKey MessageSender { get; private set; }
        public VocabularyKey PhysicalRecordLength { get; private set; }
        public VocabularyKey RecipientId { get; private set; }
        public VocabularyKey RecipientName { get; private set; }
        public VocabularyKey DocumentLineNum { get; private set; }
        public VocabularyKey BankAccount { get; private set; }
        public VocabularyKey BankStatementDocumentRecId { get; private set; }
        public VocabularyKey SenderName { get; private set; }
        public VocabularyKey SenderId { get; private set; }


    }
}