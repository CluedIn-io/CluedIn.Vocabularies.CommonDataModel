using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CatProcurementCatalogCategoryEntityVocabulary : SimpleVocabulary
    {
        public CatProcurementCatalogCategoryEntityVocabulary()
        {
            VocabularyName = "CatProcurementCatalogCategoryEntity";
            KeyPrefix = "commonDataModel.catprocurementcatalogcategoryentity";
            KeySeparator = ".";
            Grouping = "/CatProcurementCatalogCategoryEntity";

            AddGroup("CatProcurementCatalogCategoryEntity Details", group =>
            {
                ProcurementCatalogName = group.Add(new VocabularyKey(nameof(ProcurementCatalogName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDisabled = group.Add(new VocabularyKey(nameof(IsDisabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementSiteUpdateType = group.Add(new VocabularyKey(nameof(ProcurementSiteUpdateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProcurementCatalogName { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey IsDisabled { get; private set; }
        public VocabularyKey ProcurementSiteUpdateType { get; private set; }


    }
}