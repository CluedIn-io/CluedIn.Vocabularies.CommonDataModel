using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscLineDiscountVendorGroupEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscLineDiscountVendorGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model PriceDiscLineDiscountVendorGroupEntity";
            KeyPrefix = "commonDataModel.pricedisclinediscountvendorgroupentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscLineDiscountVendorGroupEntity";

            AddGroup("Common Data Model PriceDiscLineDiscountVendorGroupEntity Details", group =>
            {
                GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupCode { get; private set; }
public VocabularyKey GroupName { get; private set; }


    }
}