using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscLineDiscountProductGroupEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscLineDiscountProductGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model PriceDiscLineDiscountProductGroupEntity";
            KeyPrefix = "commonDataModel.pricedisclinediscountproductgroupentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscLineDiscountProductGroupEntity";

            AddGroup("Common Data Model PriceDiscLineDiscountProductGroupEntity Details", group =>
            {
                GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupCode { get; private set; }
public VocabularyKey GroupName { get; private set; }


    }
}