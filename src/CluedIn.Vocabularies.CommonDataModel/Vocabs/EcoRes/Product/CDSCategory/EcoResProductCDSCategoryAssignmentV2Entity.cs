using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductCDSCategoryAssignmentV2EntityVocabulary : SimpleVocabulary
    {
        public EcoResProductCDSCategoryAssignmentV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductCDSCategoryAssignmentV2Entity";
            KeyPrefix = "commonDataModel.ecoresproductcdscategoryassignmentv2entity";
            KeySeparator = ".";
            Grouping = "/EcoResProductCDSCategoryAssignmentV2Entity";

            AddGroup("Common Data Model EcoResProductCDSCategoryAssignmentV2Entity Details", group =>
            {
                ProductNumber = group.Add(new VocabularyKey(nameof(ProductNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCategoryHierarchyName = group.Add(new VocabularyKey(nameof(ProductCategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProductNumber { get; private set; }
public VocabularyKey ProductCategoryName { get; private set; }
public VocabularyKey ProductCategoryHierarchyName { get; private set; }


    }
}