using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailCategoryPriceRuleGroupEntityVocabulary : SimpleVocabulary
    {
        public RetailCategoryPriceRuleGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailCategoryPriceRuleGroupEntity";
            KeyPrefix = "commonDataModel.retailcategorypricerulegroupentity";
            KeySeparator = ".";
            Grouping = "/RetailCategoryPriceRuleGroupEntity";

            AddGroup("Common Data Model RetailCategoryPriceRuleGroupEntity Details", group =>
            {
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EcoResCategoryHierarchy = group.Add(new VocabularyKey(nameof(EcoResCategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceGroupId = group.Add(new VocabularyKey(nameof(PriceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SaveAddData = group.Add(new VocabularyKey(nameof(SaveAddData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SaveBasePrice = group.Add(new VocabularyKey(nameof(SaveBasePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SaveInventoryCost = group.Add(new VocabularyKey(nameof(SaveInventoryCost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SaveOtherGroupPrice = group.Add(new VocabularyKey(nameof(SaveOtherGroupPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SaveSalesPrice = group.Add(new VocabularyKey(nameof(SaveSalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Code { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey EcoResCategoryHierarchy { get; private set; }
public VocabularyKey PriceGroupId { get; private set; }
public VocabularyKey SaveAddData { get; private set; }
public VocabularyKey SaveBasePrice { get; private set; }
public VocabularyKey SaveInventoryCost { get; private set; }
public VocabularyKey SaveOtherGroupPrice { get; private set; }
public VocabularyKey SaveSalesPrice { get; private set; }
public VocabularyKey CategoryHierarchyName { get; private set; }


    }
}