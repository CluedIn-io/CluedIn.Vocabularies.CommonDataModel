using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxRateTypeEntityVocabulary : SimpleVocabulary
    {
        public TaxRateTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxRateTypeEntity";
            KeyPrefix = "commonDataModel.taxratetypeentity";
            KeySeparator = ".";
            Grouping = "/TaxRateTypeEntity";

            AddGroup("Common Data Model TaxRateTypeEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}