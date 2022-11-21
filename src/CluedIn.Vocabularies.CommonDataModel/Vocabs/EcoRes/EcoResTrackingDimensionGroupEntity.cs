using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResTrackingDimensionGroupEntityVocabulary : SimpleVocabulary
    {
        public EcoResTrackingDimensionGroupEntityVocabulary()
        {
            VocabularyName = "Eco Res Tracking Dimension Group Entity";
            KeyPrefix = "commonDataModel.ecorestrackingdimensiongroupentity";
            KeySeparator = ".";
            Grouping = "/EcoResTrackingDimensionGroupEntity";

            AddGroup("EcoResTrackingDimensionGroupEntity Details", group =>
            {
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SerialNumberCapturingOperation = group.Add(new VocabularyKey(nameof(SerialNumberCapturingOperation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSerialNumberControlEnabled = group.Add(new VocabularyKey(nameof(IsSerialNumberControlEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSerialNumberActive = group.Add(new VocabularyKey(nameof(IsSerialNumberActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSerialNumberEnabledForSalesProcess = group.Add(new VocabularyKey(nameof(IsSerialNumberEnabledForSalesProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSerialNumberEnabledForProductionConsumptionProcess = group.Add(new VocabularyKey(nameof(IsSerialNumberEnabledForProductionConsumptionProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBlankIssueAllowedForSerialNumber = group.Add(new VocabularyKey(nameof(IsBlankIssueAllowedForSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBlankReceiptAllowedForSerialNumber = group.Add(new VocabularyKey(nameof(IsBlankReceiptAllowedForSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCoveragePlanEnabledForSerialNumber = group.Add(new VocabularyKey(nameof(IsCoveragePlanEnabledForSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFinancialInventoryEnabledForSerialNumber = group.Add(new VocabularyKey(nameof(IsFinancialInventoryEnabledForSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPhysicalInventoryEnabledForSerialNumber = group.Add(new VocabularyKey(nameof(IsPhysicalInventoryEnabledForSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryStockingEnabledForSerialNumber = group.Add(new VocabularyKey(nameof(IsPrimaryStockingEnabledForSerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchasePriceBySerialNumber = group.Add(new VocabularyKey(nameof(IsPurchasePriceBySerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesPriceBySerialNumber = group.Add(new VocabularyKey(nameof(IsSalesPriceBySerialNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBatchNumberActive = group.Add(new VocabularyKey(nameof(IsBatchNumberActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBlankIssueAllowedForBatchNumber = group.Add(new VocabularyKey(nameof(IsBlankIssueAllowedForBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBlankReceiptAllowedForBatchNumber = group.Add(new VocabularyKey(nameof(IsBlankReceiptAllowedForBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCoveragePlanEnabledForBatchNumber = group.Add(new VocabularyKey(nameof(IsCoveragePlanEnabledForBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFinancialInventoryEnabledForBatchNumber = group.Add(new VocabularyKey(nameof(IsFinancialInventoryEnabledForBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPhysicalInventoryEnabledForBatchNumber = group.Add(new VocabularyKey(nameof(IsPhysicalInventoryEnabledForBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryStockingEnabledForBatchNumber = group.Add(new VocabularyKey(nameof(IsPrimaryStockingEnabledForBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPurchasePriceByBatchNumber = group.Add(new VocabularyKey(nameof(IsPurchasePriceByBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesPriceByBatchNumber = group.Add(new VocabularyKey(nameof(IsSalesPriceByBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryOwnerActive = group.Add(new VocabularyKey(nameof(IsInventoryOwnerActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInventoryProfileActive = group.Add(new VocabularyKey(nameof(IsInventoryProfileActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsGTDActive = group.Add(new VocabularyKey(nameof(IsGTDActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCoveragePlanEnabledForInventoryProfile = group.Add(new VocabularyKey(nameof(IsCoveragePlanEnabledForInventoryProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey SerialNumberCapturingOperation { get; private set; }
        public VocabularyKey IsSerialNumberControlEnabled { get; private set; }
        public VocabularyKey IsSerialNumberActive { get; private set; }
        public VocabularyKey IsSerialNumberEnabledForSalesProcess { get; private set; }
        public VocabularyKey IsSerialNumberEnabledForProductionConsumptionProcess { get; private set; }
        public VocabularyKey IsBlankIssueAllowedForSerialNumber { get; private set; }
        public VocabularyKey IsBlankReceiptAllowedForSerialNumber { get; private set; }
        public VocabularyKey IsCoveragePlanEnabledForSerialNumber { get; private set; }
        public VocabularyKey IsFinancialInventoryEnabledForSerialNumber { get; private set; }
        public VocabularyKey IsPhysicalInventoryEnabledForSerialNumber { get; private set; }
        public VocabularyKey IsPrimaryStockingEnabledForSerialNumber { get; private set; }
        public VocabularyKey IsPurchasePriceBySerialNumber { get; private set; }
        public VocabularyKey IsSalesPriceBySerialNumber { get; private set; }
        public VocabularyKey IsBatchNumberActive { get; private set; }
        public VocabularyKey IsBlankIssueAllowedForBatchNumber { get; private set; }
        public VocabularyKey IsBlankReceiptAllowedForBatchNumber { get; private set; }
        public VocabularyKey IsCoveragePlanEnabledForBatchNumber { get; private set; }
        public VocabularyKey IsFinancialInventoryEnabledForBatchNumber { get; private set; }
        public VocabularyKey IsPhysicalInventoryEnabledForBatchNumber { get; private set; }
        public VocabularyKey IsPrimaryStockingEnabledForBatchNumber { get; private set; }
        public VocabularyKey IsPurchasePriceByBatchNumber { get; private set; }
        public VocabularyKey IsSalesPriceByBatchNumber { get; private set; }
        public VocabularyKey IsInventoryOwnerActive { get; private set; }
        public VocabularyKey IsInventoryProfileActive { get; private set; }
        public VocabularyKey IsGTDActive { get; private set; }
        public VocabularyKey IsCoveragePlanEnabledForInventoryProfile { get; private set; }
    }
}