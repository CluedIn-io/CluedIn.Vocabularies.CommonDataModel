using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductCategoryHierarchyEntityVocabulary : SimpleVocabulary
    {
        public EcoResProductCategoryHierarchyEntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductCategoryHierarchyEntity";
            KeyPrefix = "commonDataModel.ecoresproductcategoryhierarchyentity";
            KeySeparator = ".";
            Grouping = "/EcoResProductCategoryHierarchyEntity";

            AddGroup("Common Data Model EcoResProductCategoryHierarchyEntity Details", group =>
            {
                HierarchyName = group.Add(new VocabularyKey(nameof(HierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HierarchyDescription = group.Add(new VocabularyKey(nameof(HierarchyDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey HierarchyName { get; private set; }
public VocabularyKey HierarchyDescription { get; private set; }


    }
}