using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsRegionalRestrictedProductEntityVocabulary : SimpleVocabulary
    {
        public PdsRegionalRestrictedProductEntityVocabulary()
        {
            VocabularyName = "Common Data Model PdsRegionalRestrictedProductEntity";
            KeyPrefix = "commonDataModel.pdsregionalrestrictedproductentity";
            KeySeparator = ".";
            Grouping = "/PdsRegionalRestrictedProductEntity";

            AddGroup("Common Data Model PdsRegionalRestrictedProductEntity Details", group =>
            {
                RegionalRestrictedProductListRestrictingCountryRegionId = group.Add(new VocabularyKey(nameof(RegionalRestrictedProductListRestrictingCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RegionalRestrictedProductListRestrictingStateId = group.Add(new VocabularyKey(nameof(RegionalRestrictedProductListRestrictingStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RegionalRestrictedProductListId = group.Add(new VocabularyKey(nameof(RegionalRestrictedProductListId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RestrictedItemNumber = group.Add(new VocabularyKey(nameof(RestrictedItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey RegionalRestrictedProductListRestrictingCountryRegionId { get; private set; }
public VocabularyKey RegionalRestrictedProductListRestrictingStateId { get; private set; }
public VocabularyKey RegionalRestrictedProductListId { get; private set; }
public VocabularyKey RestrictedItemNumber { get; private set; }


    }
}