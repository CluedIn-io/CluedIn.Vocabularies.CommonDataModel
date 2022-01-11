using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CatVendorCatalogMaintenanceRequestEntityVocabulary : SimpleVocabulary
    {
        public CatVendorCatalogMaintenanceRequestEntityVocabulary()
        {
            VocabularyName = "Common Data Model CatVendorCatalogMaintenanceRequestEntity";
            KeyPrefix = "commonDataModel.catvendorcatalogmaintenancerequestentity";
            KeySeparator = ".";
            Grouping = "/CatVendorCatalogMaintenanceRequestEntity";

            AddGroup("Common Data Model CatVendorCatalogMaintenanceRequestEntity Details", group =>
            {
                UploadDateTime = group.Add(new VocabularyKey(nameof(UploadDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Vendor = group.Add(new VocabularyKey(nameof(Vendor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorPartyNumber = group.Add(new VocabularyKey(nameof(VendorPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey UploadDateTime { get; private set; }
public VocabularyKey Vendor { get; private set; }
public VocabularyKey VendorPartyNumber { get; private set; }


    }
}