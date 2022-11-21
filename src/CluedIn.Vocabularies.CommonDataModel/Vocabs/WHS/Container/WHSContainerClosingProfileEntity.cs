using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSContainerClosingProfileEntityVocabulary : SimpleVocabulary
    {
        public WHSContainerClosingProfileEntityVocabulary()
        {
            VocabularyName = "WHS Container Closing Profile Entity";
            KeyPrefix = "commonDataModel.whscontainerclosingprofileentity";
            KeySeparator = ".";
            Grouping = "/WHSContainerClosingProfileEntity";

            AddGroup("WHSContainerClosingProfileEntity Details", group =>
            {
                ProfileId = group.Add(new VocabularyKey(nameof(ProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinalShipmentWarehouseLocationId = group.Add(new VocabularyKey(nameof(FinalShipmentWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileDescription = group.Add(new VocabularyKey(nameof(ProfileDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileWarehouseId = group.Add(new VocabularyKey(nameof(ProfileWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessAt = group.Add(new VocabularyKey(nameof(ProcessAt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsContainerContentPrintingEnabled = group.Add(new VocabularyKey(nameof(IsContainerContentPrintingEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPackingSlipPrintingEnabled = group.Add(new VocabularyKey(nameof(IsPackingSlipPrintingEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WeightUnitSymbol = group.Add(new VocabularyKey(nameof(WeightUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerClosingWorkCreationProcess = group.Add(new VocabularyKey(nameof(ContainerClosingWorkCreationProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManifestingShipmentPolicy = group.Add(new VocabularyKey(nameof(ManifestingShipmentPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsContainerManifestedAtClosing = group.Add(new VocabularyKey(nameof(IsContainerManifestedAtClosing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManifestingContainerPolicy = group.Add(new VocabularyKey(nameof(ManifestingContainerPolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerClosingAutoReleasePolicy = group.Add(new VocabularyKey(nameof(ContainerClosingAutoReleasePolicy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackedContainerPickingWarehouseWorkTemplateId = group.Add(new VocabularyKey(nameof(PackedContainerPickingWarehouseWorkTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManifestRequirementsForContainerGroup = group.Add(new VocabularyKey(nameof(ManifestRequirementsForContainerGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackedContainerPickingWarehouseWorkTemplateWorkOrderType = group.Add(new VocabularyKey(nameof(PackedContainerPickingWarehouseWorkTemplateWorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOutboundSortingWarehouseLocationId = group.Add(new VocabularyKey(nameof(DefaultOutboundSortingWarehouseLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintContainerShippingLabelRule = group.Add(new VocabularyKey(nameof(PrintContainerShippingLabelRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContainerShippingLabelPrinterName = group.Add(new VocabularyKey(nameof(ContainerShippingLabelPrinterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProfileId { get; private set; }
        public VocabularyKey FinalShipmentWarehouseLocationId { get; private set; }
        public VocabularyKey ProfileDescription { get; private set; }
        public VocabularyKey ProfileWarehouseId { get; private set; }
        public VocabularyKey ProcessAt { get; private set; }
        public VocabularyKey IsContainerContentPrintingEnabled { get; private set; }
        public VocabularyKey IsPackingSlipPrintingEnabled { get; private set; }
        public VocabularyKey WeightUnitSymbol { get; private set; }
        public VocabularyKey ContainerClosingWorkCreationProcess { get; private set; }
        public VocabularyKey ManifestingShipmentPolicy { get; private set; }
        public VocabularyKey IsContainerManifestedAtClosing { get; private set; }
        public VocabularyKey ManifestingContainerPolicy { get; private set; }
        public VocabularyKey ContainerClosingAutoReleasePolicy { get; private set; }
        public VocabularyKey PackedContainerPickingWarehouseWorkTemplateId { get; private set; }
        public VocabularyKey ManifestRequirementsForContainerGroup { get; private set; }
        public VocabularyKey PackedContainerPickingWarehouseWorkTemplateWorkOrderType { get; private set; }
        public VocabularyKey DefaultOutboundSortingWarehouseLocationId { get; private set; }
        public VocabularyKey PrintContainerShippingLabelRule { get; private set; }
        public VocabularyKey ContainerShippingLabelPrinterName { get; private set; }
    }
}