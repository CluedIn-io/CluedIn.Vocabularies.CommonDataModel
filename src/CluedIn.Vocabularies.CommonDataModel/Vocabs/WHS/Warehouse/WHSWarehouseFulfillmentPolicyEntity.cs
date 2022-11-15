using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseFulfillmentPolicyEntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseFulfillmentPolicyEntityVocabulary()
        {
            VocabularyName = "WHS Warehouse Fulfillment Policy Entity";
            KeyPrefix = "commonDataModel.whswarehousefulfillmentpolicyentity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseFulfillmentPolicyEntity";

            AddGroup("WHSWarehouseFulfillmentPolicyEntity Details", group =>
            {
                PolicyName = group.Add(new VocabularyKey(nameof(PolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PolicyDescription = group.Add(new VocabularyKey(nameof(PolicyDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FulfillmentViolationToleranceType = group.Add(new VocabularyKey(nameof(FulfillmentViolationToleranceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FulfillmentRatePercentage = group.Add(new VocabularyKey(nameof(FulfillmentRatePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FulfillmentType = group.Add(new VocabularyKey(nameof(FulfillmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PolicyName { get; private set; }
        public VocabularyKey PolicyDescription { get; private set; }
        public VocabularyKey FulfillmentViolationToleranceType { get; private set; }
        public VocabularyKey FulfillmentRatePercentage { get; private set; }
        public VocabularyKey FulfillmentType { get; private set; }
    }
}