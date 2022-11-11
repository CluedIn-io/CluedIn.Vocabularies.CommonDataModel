using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvCardTypesEntityVocabulary : SimpleVocabulary
    {
        public TrvCardTypesEntityVocabulary()
        {
            VocabularyName = "TrvCardTypesEntity";
            KeyPrefix = "commonDataModel.trvcardtypesentity";
            KeySeparator = ".";
            Grouping = "/TrvCardTypesEntity";

            AddGroup("TrvCardTypesEntity Details", group =>
            {
                TrvCreditCardDesc = group.Add(new VocabularyKey(nameof(TrvCreditCardDesc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrvCreditCardType = group.Add(new VocabularyKey(nameof(TrvCreditCardType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TrvCreditCardDesc { get; private set; }
        public VocabularyKey TrvCreditCardType { get; private set; }


    }
}