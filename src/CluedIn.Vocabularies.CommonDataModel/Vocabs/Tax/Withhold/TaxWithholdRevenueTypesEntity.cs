using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdRevenueTypesEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdRevenueTypesEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdRevenueTypesEntity";
            KeyPrefix = "commonDataModel.taxwithholdrevenuetypesentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdRevenueTypesEntity";

            AddGroup("Common Data Model TaxWithholdRevenueTypesEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SortingNumber = group.Add(new VocabularyKey(nameof(SortingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxWithholdRevenueCode = group.Add(new VocabularyKey(nameof(TaxWithholdRevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey SortingNumber { get; private set; }
public VocabularyKey TaxWithholdRevenueCode { get; private set; }


    }
}