using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmComplimentaryClosingEntityVocabulary : SimpleVocabulary
    {
        public SmmComplimentaryClosingEntityVocabulary()
        {
            VocabularyName = "Smm Complimentary Closing Entity";
            KeyPrefix = "commonDataModel.smmcomplimentaryclosingentity";
            KeySeparator = ".";
            Grouping = "/SmmComplimentaryClosingEntity";

            AddGroup("SmmComplimentaryClosingEntity Details", group =>
            {
                ClosingPhrase = group.Add(new VocabularyKey(nameof(ClosingPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ClosingPhrase { get; private set; }
    }
}