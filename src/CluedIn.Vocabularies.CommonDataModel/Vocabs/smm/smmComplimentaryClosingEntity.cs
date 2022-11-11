using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmComplimentaryClosingEntityVocabulary : SimpleVocabulary
    {
        public smmComplimentaryClosingEntityVocabulary()
        {
            VocabularyName = "smmComplimentaryClosingEntity";
            KeyPrefix = "commonDataModel.smmcomplimentaryclosingentity";
            KeySeparator = ".";
            Grouping = "/smmComplimentaryClosingEntity";

            AddGroup("smmComplimentaryClosingEntity Details", group =>
            {
                ClosingPhrase = group.Add(new VocabularyKey(nameof(ClosingPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ClosingPhrase { get; private set; }


    }
}