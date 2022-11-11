using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResStorageDimensionGroupEntityVocabulary : SimpleVocabulary
    {
        public EcoResStorageDimensionGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResStorageDimensionGroupEntity";
            KeyPrefix = "commonDataModel.ecoresstoragedimensiongroupentity";
            KeySeparator = ".";
            Grouping = "/EcoResStorageDimensionGroupEntity";

            AddGroup("Common Data Model EcoResStorageDimensionGroupEntity Details", group =>
            {
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehouseMandatory = group.Add(new VocabularyKey(nameof(IsWarehouseMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsWarehousePrimaryStorageDimension = group.Add(new VocabularyKey(nameof(IsWarehousePrimaryStorageDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreAdvancedWarehouseManagementProcessesEnabled = group.Add(new VocabularyKey(nameof(AreAdvancedWarehouseManagementProcessesEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchasePriceSearchUseSite = group.Add(new VocabularyKey(nameof(WillPurchasePriceSearchUseSite), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesPriceSearchUseSite = group.Add(new VocabularyKey(nameof(WillSalesPriceSearchUseSite), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCoveragePlanningUseWarehouse = group.Add(new VocabularyKey(nameof(WillCoveragePlanningUseWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFinancialInventoryEnabledForWarehouse = group.Add(new VocabularyKey(nameof(IsFinancialInventoryEnabledForWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPhysicalInventoryEnabledForWarehouse = group.Add(new VocabularyKey(nameof(IsPhysicalInventoryEnabledForWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchasePriceSearchUseWarehouse = group.Add(new VocabularyKey(nameof(WillPurchasePriceSearchUseWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesPriceSearchUseWarehouse = group.Add(new VocabularyKey(nameof(WillSalesPriceSearchUseWarehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLocationActive = group.Add(new VocabularyKey(nameof(IsLocationActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBlankIssueAllowedForLocation = group.Add(new VocabularyKey(nameof(IsBlankIssueAllowedForLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBlankReceiptAllowedForLocation = group.Add(new VocabularyKey(nameof(IsBlankReceiptAllowedForLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCoveragePlanningUseLocation = group.Add(new VocabularyKey(nameof(WillCoveragePlanningUseLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPhysicalInventoryEnabledForLocation = group.Add(new VocabularyKey(nameof(IsPhysicalInventoryEnabledForLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillCoveragePlanningUseInventoryStatus = group.Add(new VocabularyKey(nameof(WillCoveragePlanningUseInventoryStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPurchasePriceSearchUseInventoryStatus = group.Add(new VocabularyKey(nameof(WillPurchasePriceSearchUseInventoryStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesPriceSearchUseInventoryStatus = group.Add(new VocabularyKey(nameof(WillSalesPriceSearchUseInventoryStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey IsWarehouseMandatory { get; private set; }
        public VocabularyKey IsWarehousePrimaryStorageDimension { get; private set; }
        public VocabularyKey AreAdvancedWarehouseManagementProcessesEnabled { get; private set; }
        public VocabularyKey WillPurchasePriceSearchUseSite { get; private set; }
        public VocabularyKey WillSalesPriceSearchUseSite { get; private set; }
        public VocabularyKey WillCoveragePlanningUseWarehouse { get; private set; }
        public VocabularyKey IsFinancialInventoryEnabledForWarehouse { get; private set; }
        public VocabularyKey IsPhysicalInventoryEnabledForWarehouse { get; private set; }
        public VocabularyKey WillPurchasePriceSearchUseWarehouse { get; private set; }
        public VocabularyKey WillSalesPriceSearchUseWarehouse { get; private set; }
        public VocabularyKey IsLocationActive { get; private set; }
        public VocabularyKey IsBlankIssueAllowedForLocation { get; private set; }
        public VocabularyKey IsBlankReceiptAllowedForLocation { get; private set; }
        public VocabularyKey WillCoveragePlanningUseLocation { get; private set; }
        public VocabularyKey IsPhysicalInventoryEnabledForLocation { get; private set; }
        public VocabularyKey WillCoveragePlanningUseInventoryStatus { get; private set; }
        public VocabularyKey WillPurchasePriceSearchUseInventoryStatus { get; private set; }
        public VocabularyKey WillSalesPriceSearchUseInventoryStatus { get; private set; }


    }
}