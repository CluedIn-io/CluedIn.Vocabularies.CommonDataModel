using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmSalutationEntityVocabulary : SimpleVocabulary
    {
        public smmSalutationEntityVocabulary()
        {
            VocabularyName = "smmSalutationEntity";
            KeyPrefix = "commonDataModel.smmsalutationentity";
            KeySeparator = ".";
            Grouping = "/smmSalutationEntity";

            AddGroup("smmSalutationEntity Details", group =>
            {
                SalutationPhrase = group.Add(new VocabularyKey(nameof(SalutationPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SalutationPhrase { get; private set; }


    }
}