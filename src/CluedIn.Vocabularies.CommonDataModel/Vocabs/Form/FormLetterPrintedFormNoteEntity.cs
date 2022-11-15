using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FormLetterPrintedFormNoteEntityVocabulary : SimpleVocabulary
    {
        public FormLetterPrintedFormNoteEntityVocabulary()
        {
            VocabularyName = "Form Letter Printed Form Note Entity";
            KeyPrefix = "commonDataModel.formletterprintedformnoteentity";
            KeySeparator = ".";
            Grouping = "/FormLetterPrintedFormNoteEntity";

            AddGroup("FormLetterPrintedFormNoteEntity Details", group =>
            {
                FormLetterType = group.Add(new VocabularyKey(nameof(FormLetterType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormNote = group.Add(new VocabularyKey(nameof(FormNote), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FormLetterType { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey FormNote { get; private set; }
    }
}