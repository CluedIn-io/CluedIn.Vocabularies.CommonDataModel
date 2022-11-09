using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PriceDiscLineDiscountCustomerGroupEntityVocabulary : SimpleVocabulary
    {
        public PriceDiscLineDiscountCustomerGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model PriceDiscLineDiscountCustomerGroupEntity";
            KeyPrefix = "commonDataModel.pricedisclinediscountcustomergroupentity";
            KeySeparator = ".";
            Grouping = "/PriceDiscLineDiscountCustomerGroupEntity";

            AddGroup("Common Data Model PriceDiscLineDiscountCustomerGroupEntity Details", group =>
            {
                GroupCode = group.Add(new VocabularyKey(nameof(GroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GroupName = group.Add(new VocabularyKey(nameof(GroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GroupCode { get; private set; }
public VocabularyKey GroupName { get; private set; }


    }
}