using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxVatReportCategoryEntityVocabulary : SimpleVocabulary
    {
        public TaxVatReportCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxVatReportCategoryEntity";
            KeyPrefix = "commonDataModel.taxvatreportcategoryentity";
            KeySeparator = ".";
            Grouping = "/TaxVatReportCategoryEntity";

            AddGroup("Common Data Model TaxVatReportCategoryEntity Details", group =>
            {
                CategoryCodeID = group.Add(new VocabularyKey(nameof(CategoryCodeID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CategoryCodeID { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}