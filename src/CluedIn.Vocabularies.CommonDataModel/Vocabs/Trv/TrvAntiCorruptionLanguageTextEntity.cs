using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvAntiCorruptionLanguageTextEntityVocabulary : SimpleVocabulary
    {
        public TrvAntiCorruptionLanguageTextEntityVocabulary()
        {
            VocabularyName = "TrvAntiCorruptionLanguageTextEntity";
            KeyPrefix = "commonDataModel.trvanticorruptionlanguagetextentity";
            KeySeparator = ".";
            Grouping = "/TrvAntiCorruptionLanguageTextEntity";

            AddGroup("TrvAntiCorruptionLanguageTextEntity Details", group =>
            {
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AttestationMessage = group.Add(new VocabularyKey(nameof(AttestationMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverMessage = group.Add(new VocabularyKey(nameof(ApproverMessage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey AttestationMessage { get; private set; }
        public VocabularyKey ApproverMessage { get; private set; }


    }
}