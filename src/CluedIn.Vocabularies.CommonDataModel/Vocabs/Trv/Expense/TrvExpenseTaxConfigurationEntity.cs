using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvExpenseTaxConfigurationEntityVocabulary : SimpleVocabulary
    {
        public TrvExpenseTaxConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvExpenseTaxConfigurationEntity";
            KeyPrefix = "commonDataModel.trvexpensetaxconfigurationentity";
            KeySeparator = ".";
            Grouping = "/TrvExpenseTaxConfigurationEntity";

            AddGroup("Common Data Model TrvExpenseTaxConfigurationEntity Details", group =>
            {
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Instructions = group.Add(new VocabularyKey(nameof(Instructions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxGroup = group.Add(new VocabularyKey(nameof(TaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CountryRegionId { get; private set; }
public VocabularyKey Instructions { get; private set; }
public VocabularyKey TaxGroup { get; private set; }


    }
}