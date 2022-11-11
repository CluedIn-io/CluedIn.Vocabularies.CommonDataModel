using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscPriceVendorGroupEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscPriceVendorGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model PriceDiscPriceVendorGroupEntity";
            KeyPrefix = "commonDataModel.pricediscpricevendorgroupentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscPriceVendorGroupEntity";

            AddGroup("Common Data Model PriceDiscPriceVendorGroupEntity Details", group =>
            {
                GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupCode { get; private set; }
        public VocabularyKey GroupName { get; private set; }


    }
}