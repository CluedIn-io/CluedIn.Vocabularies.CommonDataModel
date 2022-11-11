using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcProcurementProductCategoryEntityVocabulary : SimpleVocabulary
    {
        public ProcProcurementProductCategoryEntityVocabulary()
        {
            VocabularyName = "ProcProcurementProductCategoryEntity";
            KeyPrefix = "commonDataModel.procprocurementproductcategoryentity";
            KeySeparator = ".";
            Grouping = "/ProcProcurementProductCategoryEntity";

            AddGroup("ProcProcurementProductCategoryEntity Details", group =>
            {
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryRecordId = group.Add(new VocabularyKey(nameof(CategoryRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryRecordId { get; private set; }


    }
}