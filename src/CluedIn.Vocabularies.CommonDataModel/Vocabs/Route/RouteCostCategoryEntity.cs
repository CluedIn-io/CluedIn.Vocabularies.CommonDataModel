using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RouteCostCategoryEntityVocabulary : SimpleVocabulary
    {
        public RouteCostCategoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model RouteCostCategoryEntity";
            KeyPrefix = "commonDataModel.routecostcategoryentity";
            KeySeparator = ".";
            Grouping = "/RouteCostCategoryEntity";

            AddGroup("Common Data Model RouteCostCategoryEntity Details", group =>
            {
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostGroupId = group.Add(new VocabularyKey(nameof(CostGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitCost = group.Add(new VocabularyKey(nameof(UnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AbsorbedManufacturingCostMainAccountId = group.Add(new VocabularyKey(nameof(AbsorbedManufacturingCostMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AbsorbedWIPManufacturingCostMainAccountId = group.Add(new VocabularyKey(nameof(AbsorbedWIPManufacturingCostMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedAbsorbedManufacturingCostMainAccountId = group.Add(new VocabularyKey(nameof(EstimatedAbsorbedManufacturingCostMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedAbsorbedWIPManufacturingCostMainAccountId = group.Add(new VocabularyKey(nameof(EstimatedAbsorbedWIPManufacturingCostMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AbsorbedManufacturingCostMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(AbsorbedManufacturingCostMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AbsorbedWIPManufacturingCostMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(AbsorbedWIPManufacturingCostMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedAbsorbedManufacturingCostMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(EstimatedAbsorbedManufacturingCostMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EstimatedAbsorbedWIPManufacturingCostMainAccountIdDisplayValue = group.Add(new VocabularyKey(nameof(EstimatedAbsorbedWIPManufacturingCostMainAccountIdDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey CostGroupId { get; private set; }
        public VocabularyKey UnitCost { get; private set; }
        public VocabularyKey AbsorbedManufacturingCostMainAccountId { get; private set; }
        public VocabularyKey AbsorbedWIPManufacturingCostMainAccountId { get; private set; }
        public VocabularyKey EstimatedAbsorbedManufacturingCostMainAccountId { get; private set; }
        public VocabularyKey EstimatedAbsorbedWIPManufacturingCostMainAccountId { get; private set; }
        public VocabularyKey AbsorbedManufacturingCostMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey AbsorbedWIPManufacturingCostMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey EstimatedAbsorbedManufacturingCostMainAccountIdDisplayValue { get; private set; }
        public VocabularyKey EstimatedAbsorbedWIPManufacturingCostMainAccountIdDisplayValue { get; private set; }


    }
}