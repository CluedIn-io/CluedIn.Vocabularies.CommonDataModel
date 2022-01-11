using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ExchangeRateTypeEntityVocabulary : SimpleVocabulary
    {
        public ExchangeRateTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model ExchangeRateTypeEntity";
            KeyPrefix = "commonDataModel.exchangeratetypeentity";
            KeySeparator = ".";
            Grouping = "/ExchangeRateTypeEntity";

            AddGroup("Common Data Model ExchangeRateTypeEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}