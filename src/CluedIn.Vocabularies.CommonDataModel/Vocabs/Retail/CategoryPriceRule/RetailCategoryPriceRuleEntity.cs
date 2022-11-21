using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCategoryPriceRuleEntityVocabulary : SimpleVocabulary
    {
        public RetailCategoryPriceRuleEntityVocabulary()
        {
            VocabularyName = "Retail Category Price Rule Entity";
            KeyPrefix = "commonDataModel.retailcategorypriceruleentity";
            KeySeparator = ".";
            Grouping = "/RetailCategoryPriceRuleEntity";

            AddGroup("RetailCategoryPriceRuleEntity Details", group =>
            {
                AccountCode = group.Add(new VocabularyKey(nameof(AccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountRelation = group.Add(new VocabularyKey(nameof(AccountRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountPercent = group.Add(new VocabularyKey(nameof(AmountPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceBasis = group.Add(new VocabularyKey(nameof(PriceBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceSetupType = group.Add(new VocabularyKey(nameof(PriceSetupType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SmartRoundingGroup = group.Add(new VocabularyKey(nameof(SmartRoundingGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitId = group.Add(new VocabularyKey(nameof(UnitId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccount = group.Add(new VocabularyKey(nameof(VendorAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryName = group.Add(new VocabularyKey(nameof(CategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPriceGroupCode = group.Add(new VocabularyKey(nameof(CustomerPriceGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountCode { get; private set; }
        public VocabularyKey AccountRelation { get; private set; }
        public VocabularyKey AmountPercent { get; private set; }
        public VocabularyKey PriceBasis { get; private set; }
        public VocabularyKey PriceSetupType { get; private set; }
        public VocabularyKey SmartRoundingGroup { get; private set; }
        public VocabularyKey UnitId { get; private set; }
        public VocabularyKey VendorAccount { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey CategoryName { get; private set; }
        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey CustomerPriceGroupCode { get; private set; }
    }
}