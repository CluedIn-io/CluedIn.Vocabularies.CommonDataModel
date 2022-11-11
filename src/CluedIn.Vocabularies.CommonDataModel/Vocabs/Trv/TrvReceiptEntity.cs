using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvReceiptEntityVocabulary : SimpleVocabulary
    {
        public TrvReceiptEntityVocabulary()
        {
            VocabularyName = "TrvReceiptEntity";
            KeyPrefix = "commonDataModel.trvreceiptentity";
            KeySeparator = ".";
            Grouping = "/TrvReceiptEntity";

            AddGroup("TrvReceiptEntity Details", group =>
            {
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentId = group.Add(new VocabularyKey(nameof(DocumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileName = group.Add(new VocabularyKey(nameof(FileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileContents = group.Add(new VocabularyKey(nameof(FileContents), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FileType = group.Add(new VocabularyKey(nameof(FileType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocuRefId = group.Add(new VocabularyKey(nameof(DocuRefId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resource = group.Add(new VocabularyKey(nameof(Resource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActualCompanyId = group.Add(new VocabularyKey(nameof(ActualCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCreditCardExpense = group.Add(new VocabularyKey(nameof(IsCreditCardExpense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey DocumentId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey FileName { get; private set; }
        public VocabularyKey FileContents { get; private set; }
        public VocabularyKey FileType { get; private set; }
        public VocabularyKey DocuRefId { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey ActualCompanyId { get; private set; }
        public VocabularyKey IsCreditCardExpense { get; private set; }


    }
}