using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailSpecialCategoryMemberEntityVocabulary : SimpleVocabulary
    {
        public RetailSpecialCategoryMemberEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailSpecialCategoryMemberEntity";
            KeyPrefix = "commonDataModel.retailspecialcategorymemberentity";
            KeySeparator = ".";
            Grouping = "/RetailSpecialCategoryMemberEntity";

            AddGroup("Common Data Model RetailSpecialCategoryMemberEntity Details", group =>
            {
                HeaderProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(HeaderProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HeaderProductCategoryName = group.Add(new VocabularyKey(nameof(HeaderProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(LineProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineProductCategoryName = group.Add(new VocabularyKey(nameof(LineProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVariantNumber = group.Add(new VocabularyKey(nameof(ProductVariantNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey HeaderProductCategoryHierarchyName { get; private set; }
public VocabularyKey HeaderProductCategoryName { get; private set; }
public VocabularyKey LineProductCategoryHierarchyName { get; private set; }
public VocabularyKey LineProductCategoryName { get; private set; }
public VocabularyKey ProductNumber { get; private set; }
public VocabularyKey ProductVariantNumber { get; private set; }
public VocabularyKey ProductName { get; private set; }


    }
}