using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CostProductionGroupEntityVocabulary : SimpleVocabulary
    {
        public CostProductionGroupEntityVocabulary()
        {
            VocabularyName = "Cost Production Group Entity";
            KeyPrefix = "commonDataModel.costproductiongroupentity";
            KeySeparator = ".";
            Grouping = "/CostProductionGroupEntity";

            AddGroup("CostProductionGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedCostOfMaterialsConsumedMainAccountId = group.Add(new VocabularyKey(nameof(EstimatedCostOfMaterialsConsumedMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedCostOfMaterialsConsumedMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(EstimatedCostOfMaterialsConsumedMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedCostOfMaterialsConsumedWIPMainAccountId = group.Add(new VocabularyKey(nameof(EstimatedCostOfMaterialsConsumedWIPMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedCostOfMaterialsConsumedWIPMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(EstimatedCostOfMaterialsConsumedWIPMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedManufacturedCostMainAccountId = group.Add(new VocabularyKey(nameof(EstimatedManufacturedCostMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedManufacturedCostMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(EstimatedManufacturedCostMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedManufacturedCostWIPMainAccountId = group.Add(new VocabularyKey(nameof(EstimatedManufacturedCostWIPMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedManufacturedCostWIPMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(EstimatedManufacturedCostWIPMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedCostOfMaterialsConsumedMainAccountId = group.Add(new VocabularyKey(nameof(RealizedCostOfMaterialsConsumedMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedCostOfMaterialsConsumedMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(RealizedCostOfMaterialsConsumedMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedCostOfMaterialsConsumedWIPMainAccountId = group.Add(new VocabularyKey(nameof(RealizedCostOfMaterialsConsumedWIPMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedCostOfMaterialsConsumedWIPMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(RealizedCostOfMaterialsConsumedWIPMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedManufacturedCostMainAccountId = group.Add(new VocabularyKey(nameof(RealizedManufacturedCostMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedManufacturedCostMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(RealizedManufacturedCostMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedManufacturedCostWIPMainAccountId = group.Add(new VocabularyKey(nameof(RealizedManufacturedCostWIPMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedManufacturedCostWIPMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(RealizedManufacturedCostWIPMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedManufacturingCostAbsorbedMainAccountId = group.Add(new VocabularyKey(nameof(EstimatedManufacturingCostAbsorbedMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedManufacturingCostAbsorbedMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(EstimatedManufacturingCostAbsorbedMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedCostOfManufacturingConsumedMainAccountId = group.Add(new VocabularyKey(nameof(EstimatedCostOfManufacturingConsumedMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedCostOfManufacturingConsumedMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(EstimatedCostOfManufacturingConsumedMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedManufacturingCostAbsorbedMainAccountId = group.Add(new VocabularyKey(nameof(RealizedManufacturingCostAbsorbedMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedManufacturingCostAbsorbedMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(RealizedManufacturingCostAbsorbedMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedCostOfManufacturingConsumedMainAccountId = group.Add(new VocabularyKey(nameof(RealizedCostOfManufacturingConsumedMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedCostOfManufacturingConsumedMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(RealizedCostOfManufacturingConsumedMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPServiceReceiptMainAccountId = group.Add(new VocabularyKey(nameof(WIPServiceReceiptMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPServiceReceiptMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(WIPServiceReceiptMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPServiceClearingMainAccountId = group.Add(new VocabularyKey(nameof(WIPServiceClearingMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WIPServiceClearingMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(WIPServiceClearingMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedCostOfIndirectCostConsumedMainAccountId = group.Add(new VocabularyKey(nameof(RealizedCostOfIndirectCostConsumedMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RealizedCostOfIndirectCostConsumedMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(RealizedCostOfIndirectCostConsumedMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedCostOfIndirectCostConsumedMainAccountId = group.Add(new VocabularyKey(nameof(EstimatedCostOfIndirectCostConsumedMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedCostOfIndirectCostConsumedMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(EstimatedCostOfIndirectCostConsumedMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupName { get; private set; }
        public VocabularyKey EstimatedCostOfMaterialsConsumedMainAccountId { get; private set; }
        public VocabularyKey EstimatedCostOfMaterialsConsumedMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey EstimatedCostOfMaterialsConsumedWIPMainAccountId { get; private set; }
        public VocabularyKey EstimatedCostOfMaterialsConsumedWIPMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey EstimatedManufacturedCostMainAccountId { get; private set; }
        public VocabularyKey EstimatedManufacturedCostMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey EstimatedManufacturedCostWIPMainAccountId { get; private set; }
        public VocabularyKey EstimatedManufacturedCostWIPMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey RealizedCostOfMaterialsConsumedMainAccountId { get; private set; }
        public VocabularyKey RealizedCostOfMaterialsConsumedMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey RealizedCostOfMaterialsConsumedWIPMainAccountId { get; private set; }
        public VocabularyKey RealizedCostOfMaterialsConsumedWIPMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey RealizedManufacturedCostMainAccountId { get; private set; }
        public VocabularyKey RealizedManufacturedCostMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey RealizedManufacturedCostWIPMainAccountId { get; private set; }
        public VocabularyKey RealizedManufacturedCostWIPMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey EstimatedManufacturingCostAbsorbedMainAccountId { get; private set; }
        public VocabularyKey EstimatedManufacturingCostAbsorbedMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey EstimatedCostOfManufacturingConsumedMainAccountId { get; private set; }
        public VocabularyKey EstimatedCostOfManufacturingConsumedMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey RealizedManufacturingCostAbsorbedMainAccountId { get; private set; }
        public VocabularyKey RealizedManufacturingCostAbsorbedMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey RealizedCostOfManufacturingConsumedMainAccountId { get; private set; }
        public VocabularyKey RealizedCostOfManufacturingConsumedMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey WIPServiceReceiptMainAccountId { get; private set; }
        public VocabularyKey WIPServiceReceiptMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey WIPServiceClearingMainAccountId { get; private set; }
        public VocabularyKey WIPServiceClearingMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey RealizedCostOfIndirectCostConsumedMainAccountId { get; private set; }
        public VocabularyKey RealizedCostOfIndirectCostConsumedMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey EstimatedCostOfIndirectCostConsumedMainAccountId { get; private set; }
        public VocabularyKey EstimatedCostOfIndirectCostConsumedMainAccountIdDisplayValue { get; private set; }
    }
}