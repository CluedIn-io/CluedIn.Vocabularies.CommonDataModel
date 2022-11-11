using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CostSheetNodeCalculationFactorV2EntityVocabulary : SimpleVocabulary
    {
        public CostSheetNodeCalculationFactorV2EntityVocabulary()
        {
            VocabularyName = "CostSheetNodeCalculationFactorV2Entity";
            KeyPrefix = "commonDataModel.costsheetnodecalculationfactorv2entity";
            KeySeparator = ".";
            Grouping = "/CostSheetNodeCalculationFactorV2Entity";

            AddGroup("CostSheetNodeCalculationFactorV2Entity Details", group =>
            {
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceSiteId = group.Add(new VocabularyKey(nameof(PriceSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SurchargePercentage = group.Add(new VocabularyKey(nameof(SurchargePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingVersionId = group.Add(new VocabularyKey(nameof(CostingVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostSheetNodeName = group.Add(new VocabularyKey(nameof(CostSheetNodeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCode = group.Add(new VocabularyKey(nameof(ItemCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemRelation = group.Add(new VocabularyKey(nameof(ItemRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrencyRateAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyRateAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingCurrencyUnitBasedAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyUnitBasedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostSheetNodeType = group.Add(new VocabularyKey(nameof(CostSheetNodeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostingVersionStatus = group.Add(new VocabularyKey(nameof(CostingVersionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey PriceSiteId { get; private set; }
        public VocabularyKey SurchargePercentage { get; private set; }
        public VocabularyKey CostingVersionId { get; private set; }
        public VocabularyKey CostSheetNodeName { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey ItemCode { get; private set; }
        public VocabularyKey ItemRelation { get; private set; }
        public VocabularyKey AccountingCurrencyRateAmount { get; private set; }
        public VocabularyKey AccountingCurrencyUnitBasedAmount { get; private set; }
        public VocabularyKey CostSheetNodeType { get; private set; }
        public VocabularyKey CostingVersionStatus { get; private set; }
        public VocabularyKey Amount { get; private set; }


    }
}