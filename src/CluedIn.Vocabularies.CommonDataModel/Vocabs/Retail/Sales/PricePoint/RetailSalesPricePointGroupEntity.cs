using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailSalesPricePointGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailSalesPricePointGroupEntityVocabulary()
        {
            VocabularyName = "Retail Sales Price Point Group Entity";
            KeyPrefix = "commonDataModel.retailsalespricepointgroupentity";
            KeySeparator = ".";
            Grouping = "/RetailSalesPricePointGroupEntity";

            AddGroup("RetailSalesPricePointGroupEntity Details", group =>
            {
                PricePointGroupId_DEL = group.Add(new VocabularyKey(nameof(PricePointGroupId_DEL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingType = group.Add(new VocabularyKey(nameof(RoundingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PricePointGroupId_DEL { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey RoundingType { get; private set; }
    }
}