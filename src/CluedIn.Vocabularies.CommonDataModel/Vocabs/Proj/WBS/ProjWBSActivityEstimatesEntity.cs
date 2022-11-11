using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjWBSActivityEstimatesEntityVocabulary : SimpleVocabulary
    {
        public ProjWBSActivityEstimatesEntityVocabulary()
        {
            VocabularyName = "ProjWBSActivityEstimatesEntity";
            KeyPrefix = "commonDataModel.projwbsactivityestimatesentity";
            KeySeparator = ".";
            Grouping = "/ProjWBSActivityEstimatesEntity";

            AddGroup("ProjWBSActivityEstimatesEntity Details", group =>
            {
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyId = group.Add(new VocabularyKey(nameof(HierarchyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskId = group.Add(new VocabularyKey(nameof(TaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WBSId = group.Add(new VocabularyKey(nameof(WBSId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskName = group.Add(new VocabularyKey(nameof(TaskName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineProperty = group.Add(new VocabularyKey(nameof(LineProperty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCategoryRecId = group.Add(new VocabularyKey(nameof(ResourceCategoryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesCategoryRecId = group.Add(new VocabularyKey(nameof(SalesCategoryRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitCostPrice = group.Add(new VocabularyKey(nameof(UnitCostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitSalesPrice = group.Add(new VocabularyKey(nameof(UnitSalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCategory = group.Add(new VocabularyKey(nameof(ResourceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesCategory = group.Add(new VocabularyKey(nameof(SalesCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalCostPrice = group.Add(new VocabularyKey(nameof(TotalCostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalSalesPrice = group.Add(new VocabularyKey(nameof(TotalSalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey HierarchyId { get; private set; }
        public VocabularyKey TaskId { get; private set; }
        public VocabularyKey WBSId { get; private set; }
        public VocabularyKey TaskName { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey LineProperty { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey ResourceCategoryRecId { get; private set; }
        public VocabularyKey SalesCategoryRecId { get; private set; }
        public VocabularyKey UnitCostPrice { get; private set; }
        public VocabularyKey UnitSalesPrice { get; private set; }
        public VocabularyKey ResourceCategory { get; private set; }
        public VocabularyKey SalesCategory { get; private set; }
        public VocabularyKey TotalCostPrice { get; private set; }
        public VocabularyKey TotalSalesPrice { get; private set; }


    }
}