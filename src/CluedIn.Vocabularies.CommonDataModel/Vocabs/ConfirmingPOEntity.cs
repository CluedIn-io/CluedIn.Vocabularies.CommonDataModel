using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ConfirmingPOEntityVocabulary : SimpleVocabulary
    {
        public ConfirmingPOEntityVocabulary()
        {
            VocabularyName = "Confirming PO Entity";
            KeyPrefix = "commonDataModel.confirmingpoentity";
            KeySeparator = ".";
            Grouping = "/ConfirmingPOEntity";

            AddGroup("ConfirmingPOEntity Details", group =>
            {
                ConfirmingPOID = group.Add(new VocabularyKey(nameof(ConfirmingPOID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConfirmingPOMessage = group.Add(new VocabularyKey(nameof(ConfirmingPOMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LabelFile = group.Add(new VocabularyKey(nameof(LabelFile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ConfirmingPOID { get; private set; }
        public VocabularyKey ConfirmingPOMessage { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LabelFile { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
    }
}