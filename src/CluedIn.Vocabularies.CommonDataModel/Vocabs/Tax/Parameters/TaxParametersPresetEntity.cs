using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxParametersPresetEntityVocabulary : SimpleVocabulary
    {
        public TaxParametersPresetEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxParametersPresetEntity";
            KeyPrefix = "commonDataModel.taxparameterspresetentity";
            KeySeparator = ".";
            Grouping = "/TaxParametersPresetEntity";

            AddGroup("Common Data Model TaxParametersPresetEntity Details", group =>
            {
                CalculationMethod = group.Add(new VocabularyKey(nameof(CalculationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CalculationMethod { get; private set; }
public VocabularyKey ID { get; private set; }


    }
}