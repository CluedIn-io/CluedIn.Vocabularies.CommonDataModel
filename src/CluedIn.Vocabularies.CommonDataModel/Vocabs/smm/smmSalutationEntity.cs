using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmSalutationEntityVocabulary : SimpleVocabulary
    {
        public smmSalutationEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmSalutationEntity";
            KeyPrefix = "commonDataModel.smmsalutationentity";
            KeySeparator = ".";
            Grouping = "/smmSalutationEntity";

            AddGroup("Common Data Model smmSalutationEntity Details", group =>
            {
                SalutationPhrase = group.Add(new VocabularyKey(nameof(SalutationPhrase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SalutationPhrase { get; private set; }


    }
}