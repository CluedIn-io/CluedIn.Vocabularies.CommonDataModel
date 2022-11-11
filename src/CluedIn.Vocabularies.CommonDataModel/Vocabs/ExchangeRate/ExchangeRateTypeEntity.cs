using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ExchangeRateTypeEntityVocabulary : SimpleVocabulary
    {
        public ExchangeRateTypeEntityVocabulary()
        {
            VocabularyName = "ExchangeRateTypeEntity";
            KeyPrefix = "commonDataModel.exchangeratetypeentity";
            KeySeparator = ".";
            Grouping = "/ExchangeRateTypeEntity";

            AddGroup("ExchangeRateTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}