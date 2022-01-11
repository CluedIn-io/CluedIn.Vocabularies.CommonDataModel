using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsRegionalRestrictedProductListEntityVocabulary : SimpleVocabulary
    {
        public PdsRegionalRestrictedProductListEntityVocabulary()
        {
            VocabularyName = "Common Data Model PdsRegionalRestrictedProductListEntity";
            KeyPrefix = "commonDataModel.pdsregionalrestrictedproductlistentity";
            KeySeparator = ".";
            Grouping = "/PdsRegionalRestrictedProductListEntity";

            AddGroup("Common Data Model PdsRegionalRestrictedProductListEntity Details", group =>
            {
                RestrictingCountryRegionId = group.Add(new VocabularyKey(nameof(RestrictingCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RestrictingStateId = group.Add(new VocabularyKey(nameof(RestrictingStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ListId = group.Add(new VocabularyKey(nameof(ListId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ListDescription = group.Add(new VocabularyKey(nameof(ListDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductRestrictionListType = group.Add(new VocabularyKey(nameof(ProductRestrictionListType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey RestrictingCountryRegionId { get; private set; }
public VocabularyKey RestrictingStateId { get; private set; }
public VocabularyKey ListId { get; private set; }
public VocabularyKey ListDescription { get; private set; }
public VocabularyKey ProductRestrictionListType { get; private set; }


    }
}