using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmComplimentaryClosingEntityVocabulary : SimpleVocabulary
    {
        public smmComplimentaryClosingEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmComplimentaryClosingEntity";
            KeyPrefix = "commonDataModel.smmcomplimentaryclosingentity";
            KeySeparator = ".";
            Grouping = "/smmComplimentaryClosingEntity";

            AddGroup("Common Data Model smmComplimentaryClosingEntity Details", group =>
            {
                ClosingPhrase = group.Add(new VocabularyKey(nameof(ClosingPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ClosingPhrase { get; private set; }


    }
}