using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjectItemJournalTransEntityVocabulary : SimpleVocabulary
    {
        public ProjectItemJournalTransEntityVocabulary()
        {
            VocabularyName = "Project Item Journal Trans Entity";
            KeyPrefix = "commonDataModel.projectitemjournaltransentity";
            KeySeparator = ".";
            Grouping = "/ProjectItemJournalTransEntity";

            AddGroup("ProjectItemJournalTransEntity Details", group =>
            {
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostPrice = group.Add(new VocabularyKey(nameof(CostPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventDimensionId = group.Add(new VocabularyKey(nameof(InventDimensionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemId = group.Add(new VocabularyKey(nameof(ItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalId = group.Add(new VocabularyKey(nameof(JournalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectDate = group.Add(new VocabularyKey(nameof(ProjectDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectUnitID = group.Add(new VocabularyKey(nameof(ProjectUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTaxItemGroupId = group.Add(new VocabularyKey(nameof(ProjectTaxItemGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTaxGroupId = group.Add(new VocabularyKey(nameof(ProjectTaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesPrice = group.Add(new VocabularyKey(nameof(ProjectSalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectSalesCurrencyId = group.Add(new VocabularyKey(nameof(ProjectSalesCurrencyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectLinePropertyId = group.Add(new VocabularyKey(nameof(ProjectLinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CWQuantity = group.Add(new VocabularyKey(nameof(CWQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceUnit = group.Add(new VocabularyKey(nameof(PriceUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostMarkup = group.Add(new VocabularyKey(nameof(CostMarkup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventTransactionId = group.Add(new VocabularyKey(nameof(InventTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventTransactionReturnId = group.Add(new VocabularyKey(nameof(InventTransactionReturnId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectTransactionId = group.Add(new VocabularyKey(nameof(ProjectTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageSiteId = group.Add(new VocabularyKey(nameof(StorageSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageWarehouseId = group.Add(new VocabularyKey(nameof(StorageWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StorageLocationId = group.Add(new VocabularyKey(nameof(StorageLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventSerialId = group.Add(new VocabularyKey(nameof(InventSerialId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey CostAmount { get; private set; }
        public VocabularyKey CostPrice { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey InventDimensionId { get; private set; }
        public VocabularyKey ItemId { get; private set; }
        public VocabularyKey JournalId { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey ProjectDate { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey ProjectUnitID { get; private set; }
        public VocabularyKey ProjectTaxItemGroupId { get; private set; }
        public VocabularyKey ProjectTaxGroupId { get; private set; }
        public VocabularyKey ProjectSalesPrice { get; private set; }
        public VocabularyKey ProjectSalesCurrencyId { get; private set; }
        public VocabularyKey ProjectLinePropertyId { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ProjectCategoryId { get; private set; }
        public VocabularyKey CWQuantity { get; private set; }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey PriceUnit { get; private set; }
        public VocabularyKey CostMarkup { get; private set; }
        public VocabularyKey InventTransactionId { get; private set; }
        public VocabularyKey InventTransactionReturnId { get; private set; }
        public VocabularyKey ProjectTransactionId { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey ProductColorId { get; private set; }
        public VocabularyKey ProductConfigurationId { get; private set; }
        public VocabularyKey ProductSizeId { get; private set; }
        public VocabularyKey ProductStyleId { get; private set; }
        public VocabularyKey ProductVersionId { get; private set; }
        public VocabularyKey StorageSiteId { get; private set; }
        public VocabularyKey StorageWarehouseId { get; private set; }
        public VocabularyKey StorageLocationId { get; private set; }
        public VocabularyKey InventSerialId { get; private set; }
    }
}