using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxVatReportCategoryEntityVocabulary : SimpleVocabulary
    {
        public TaxVatReportCategoryEntityVocabulary()
        {
            VocabularyName = "Tax Vat Report Category Entity";
            KeyPrefix = "commonDataModel.taxvatreportcategoryentity";
            KeySeparator = ".";
            Grouping = "/TaxVatReportCategoryEntity";

            AddGroup("TaxVatReportCategoryEntity Details", group =>
            {
                CategoryCodeID = group.Add(new VocabularyKey(nameof(CategoryCodeID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CategoryCodeID { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}