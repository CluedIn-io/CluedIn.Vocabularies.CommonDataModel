using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscMultilineDiscountProductGroupEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscMultilineDiscountProductGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model PriceDiscMultilineDiscountProductGroupEntity";
            KeyPrefix = "commonDataModel.pricediscmultilinediscountproductgroupentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscMultilineDiscountProductGroupEntity";

            AddGroup("Common Data Model PriceDiscMultilineDiscountProductGroupEntity Details", group =>
            {
                GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupCode { get; private set; }
public VocabularyKey GroupName { get; private set; }


    }
}