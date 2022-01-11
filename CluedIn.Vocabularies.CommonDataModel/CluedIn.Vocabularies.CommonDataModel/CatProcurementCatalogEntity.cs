using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CatProcurementCatalogEntityVocabulary : SimpleVocabulary
    {
        public CatProcurementCatalogEntityVocabulary()
        {
            VocabularyName = "Common Data Model CatProcurementCatalogEntity";
            KeyPrefix = "commonDataModel.catprocurementcatalogentity";
            KeySeparator = ".";
            Grouping = "/CatProcurementCatalogEntity";

            AddGroup("Common Data Model CatProcurementCatalogEntity Details", group =>
            {
                CatalogDescription = group.Add(new VocabularyKey(nameof(CatalogDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CatalogName = group.Add(new VocabularyKey(nameof(CatalogName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PublishingStatus = group.Add(new VocabularyKey(nameof(PublishingStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultProcurementSiteUpdateType = group.Add(new VocabularyKey(nameof(DefaultProcurementSiteUpdateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CatalogOwnerPersonnelNumber = group.Add(new VocabularyKey(nameof(CatalogOwnerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CatalogDescription { get; private set; }
public VocabularyKey CatalogName { get; private set; }
public VocabularyKey PublishingStatus { get; private set; }
public VocabularyKey DefaultProcurementSiteUpdateType { get; private set; }
public VocabularyKey CatalogOwnerPersonnelNumber { get; private set; }


    }
}