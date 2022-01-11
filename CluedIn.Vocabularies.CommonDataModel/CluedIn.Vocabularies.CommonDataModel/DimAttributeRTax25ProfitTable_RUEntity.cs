using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimAttributeRTax25ProfitTable_RUEntityVocabulary : SimpleVocabulary
    {
        public DimAttributeRTax25ProfitTable_RUEntityVocabulary()
        {
            VocabularyName = "Common Data Model DimAttributeRTax25ProfitTable_RUEntity";
            KeyPrefix = "commonDataModel.dimattributertax25profittable_ruentity";
            KeySeparator = ".";
            Grouping = "/DimAttributeRTax25ProfitTable_RUEntity";

            AddGroup("Common Data Model DimAttributeRTax25ProfitTable_RUEntity Details", group =>
            {
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Value { get; private set; }
public VocabularyKey Name { get; private set; }


    }
}