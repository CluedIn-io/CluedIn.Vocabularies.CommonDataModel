using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RoutePendingRouteCostCategoryUnitCostEntityVocabulary : SimpleVocabulary
    {
        public RoutePendingRouteCostCategoryUnitCostEntityVocabulary()
        {
            VocabularyName = "RoutePendingRouteCostCategoryUnitCostEntity";
            KeyPrefix = "commonDataModel.routependingroutecostcategoryunitcostentity";
            KeySeparator = ".";
            Grouping = "/RoutePendingRouteCostCategoryUnitCostEntity";

            AddGroup("RoutePendingRouteCostCategoryUnitCostEntity Details", group =>
            {
                RouteCostCategoryId = group.Add(new VocabularyKey(nameof(RouteCostCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffectiveDate = group.Add(new VocabularyKey(nameof(EffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitCost = group.Add(new VocabularyKey(nameof(UnitCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingVersionId = group.Add(new VocabularyKey(nameof(CostingVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RouteCostCategoryId { get; private set; }
        public VocabularyKey EffectiveDate { get; private set; }
        public VocabularyKey ProductionSiteId { get; private set; }
        public VocabularyKey UnitCost { get; private set; }
        public VocabularyKey CostingVersionId { get; private set; }


    }
}