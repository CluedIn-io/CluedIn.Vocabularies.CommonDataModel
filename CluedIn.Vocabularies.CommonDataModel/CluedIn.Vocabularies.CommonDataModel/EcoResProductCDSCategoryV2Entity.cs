using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EcoResProductCDSCategoryV2EntityVocabulary : SimpleVocabulary
    {
        public EcoResProductCDSCategoryV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model EcoResProductCDSCategoryV2Entity";
            KeyPrefix = "commonDataModel.ecoresproductcdscategoryv2entity";
            KeySeparator = ".";
            Grouping = "/EcoResProductCDSCategoryV2Entity";

            AddGroup("Common Data Model EcoResProductCDSCategoryV2Entity Details", group =>
            {
                FreindlyProductCategoryName = group.Add(new VocabularyKey(nameof(FreindlyProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentProductCategoryName = group.Add(new VocabularyKey(nameof(ParentProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductCategoryName = group.Add(new VocabularyKey(nameof(ProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FreindlyProductCategoryName { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey ParentProductCategoryName { get; private set; }
public VocabularyKey ProductCategoryName { get; private set; }


    }
}