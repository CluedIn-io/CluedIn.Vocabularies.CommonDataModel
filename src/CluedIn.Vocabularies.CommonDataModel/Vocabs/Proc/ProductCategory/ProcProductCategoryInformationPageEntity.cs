using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProcProductCategoryInformationPageEntityVocabulary : SimpleVocabulary
    {
        public ProcProductCategoryInformationPageEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProcProductCategoryInformationPageEntity";
            KeyPrefix = "commonDataModel.procproductcategoryinformationpageentity";
            KeySeparator = ".";
            Grouping = "/ProcProductCategoryInformationPageEntity";

            AddGroup("Common Data Model ProcProductCategoryInformationPageEntity Details", group =>
            {
                ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InformationPageName = group.Add(new VocabularyKey(nameof(InformationPageName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DescriptionInHTML = group.Add(new VocabularyKey(nameof(DescriptionInHTML), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductCategoryHierarchyName { get; private set; }
public VocabularyKey ProductCategoryName { get; private set; }
public VocabularyKey InformationPageName { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey DescriptionInHTML { get; private set; }


    }
}