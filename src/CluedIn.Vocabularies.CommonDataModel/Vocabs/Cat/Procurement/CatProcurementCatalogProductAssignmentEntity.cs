using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CatProcurementCatalogProductAssignmentEntityVocabulary : SimpleVocabulary
    {
        public CatProcurementCatalogProductAssignmentEntityVocabulary()
        {
            VocabularyName = "Cat Procurement Catalog Product Assignment Entity";
            KeyPrefix = "commonDataModel.catprocurementcatalogproductassignmententity";
            KeySeparator = ".";
            Grouping = "/CatProcurementCatalogProductAssignmentEntity";

            AddGroup("CatProcurementCatalogProductAssignmentEntity Details", group =>
            {
                ProcurementCatalogName = group.Add(new VocabularyKey(nameof(ProcurementCatalogName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcurementCatalogCategoryName = group.Add(new VocabularyKey(nameof(ProcurementCatalogCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDisplayed = group.Add(new VocabularyKey(nameof(IsDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductRecId = group.Add(new VocabularyKey(nameof(ProductRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SharedDataRecId = group.Add(new VocabularyKey(nameof(SharedDataRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Origin = group.Add(new VocabularyKey(nameof(Origin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProcurementCatalogName { get; private set; }
        public VocabularyKey ProcurementCatalogCategoryName { get; private set; }
        public VocabularyKey ProductNumber { get; private set; }
        public VocabularyKey IsDisplayed { get; private set; }
        public VocabularyKey ProductRecId { get; private set; }
        public VocabularyKey SharedDataRecId { get; private set; }
        public VocabularyKey Origin { get; private set; }
    }
}