using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventWarehouseCurrentPostalAddressV2EntityVocabulary : SimpleVocabulary
    {
        public InventWarehouseCurrentPostalAddressV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model InventWarehouseCurrentPostalAddressV2Entity";
            KeyPrefix = "commonDataModel.inventwarehousecurrentpostaladdressv2entity";
            KeySeparator = ".";
            Grouping = "/InventWarehouseCurrentPostalAddressV2Entity";

            AddGroup("Common Data Model InventWarehouseCurrentPostalAddressV2Entity Details", group =>
            {
                IsPrimaryAddress = group.Add(new VocabularyKey(nameof(IsPrimaryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseLegalEntityId = group.Add(new VocabularyKey(nameof(WarehouseLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLocationSalesTaxGroupCode = group.Add(new VocabularyKey(nameof(AddressLocationSalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormattedAddress = group.Add(new VocabularyKey(nameof(FormattedAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCityInKana = group.Add(new VocabularyKey(nameof(AddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressCountyId = group.Add(new VocabularyKey(nameof(AddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStateId = group.Add(new VocabularyKey(nameof(AddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreetInKana = group.Add(new VocabularyKey(nameof(AddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressStreetNumber = group.Add(new VocabularyKey(nameof(AddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressBuildingCompliment = group.Add(new VocabularyKey(nameof(AddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressPostBox = group.Add(new VocabularyKey(nameof(AddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AddressLocationRoles = group.Add(new VocabularyKey(nameof(AddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsPrimaryAddress { get; private set; }
public VocabularyKey WarehouseLegalEntityId { get; private set; }
public VocabularyKey WarehouseId { get; private set; }
public VocabularyKey AddressLocationId { get; private set; }
public VocabularyKey AddressDescription { get; private set; }
public VocabularyKey AddressLocationSalesTaxGroupCode { get; private set; }
public VocabularyKey ValidFrom { get; private set; }
public VocabularyKey ValidTo { get; private set; }
public VocabularyKey FormattedAddress { get; private set; }
public VocabularyKey AddressCity { get; private set; }
public VocabularyKey AddressCityInKana { get; private set; }
public VocabularyKey AddressCountryRegionId { get; private set; }
public VocabularyKey AddressCountyId { get; private set; }
public VocabularyKey AddressDistrictName { get; private set; }
public VocabularyKey AddressLatitude { get; private set; }
public VocabularyKey AddressLongitude { get; private set; }
public VocabularyKey AddressStateId { get; private set; }
public VocabularyKey AddressStreet { get; private set; }
public VocabularyKey AddressStreetInKana { get; private set; }
public VocabularyKey AddressStreetNumber { get; private set; }
public VocabularyKey AddressTimeZone { get; private set; }
public VocabularyKey AddressZipCode { get; private set; }
public VocabularyKey AddressBuildingCompliment { get; private set; }
public VocabularyKey AddressPostBox { get; private set; }
public VocabularyKey AddressLocationRoles { get; private set; }


    }
}