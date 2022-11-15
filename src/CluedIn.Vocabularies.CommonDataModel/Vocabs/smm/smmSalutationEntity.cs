using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmSalutationEntityVocabulary : SimpleVocabulary
    {
        public SmmSalutationEntityVocabulary()
        {
            VocabularyName = "Smm Salutation Entity";
            KeyPrefix = "commonDataModel.smmsalutationentity";
            KeySeparator = ".";
            Grouping = "/SmmSalutationEntity";

            AddGroup("SmmSalutationEntity Details", group =>
            {
                SalutationPhrase = group.Add(new VocabularyKey(nameof(SalutationPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SalutationPhrase { get; private set; }
    }
}