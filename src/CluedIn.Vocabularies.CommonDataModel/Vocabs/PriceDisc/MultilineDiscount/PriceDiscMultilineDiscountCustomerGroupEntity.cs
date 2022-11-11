using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscMultilineDiscountCustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscMultilineDiscountCustomerGroupEntityVocabulary()
        {
            VocabularyName = "PriceDiscMultilineDiscountCustomerGroupEntity";
            KeyPrefix = "commonDataModel.pricediscmultilinediscountcustomergroupentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscMultilineDiscountCustomerGroupEntity";

            AddGroup("PriceDiscMultilineDiscountCustomerGroupEntity Details", group =>
            {
                GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupCode { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}