using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventOperationalSiteEntityVocabulary : SimpleVocabulary
    {
        public InventOperationalSiteEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventOperationalSiteEntity";
            KeyPrefix = "commonDataModel.inventoperationalsiteentity";
            KeySeparator = ".";
            Grouping = "/InventOperationalSiteEntity";

            AddGroup("Common Data Model InventOperationalSiteEntity Details", group =>
            {
                SiteId = group.Add(new VocabularyKey(nameof(SiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SiteName = group.Add(new VocabularyKey(nameof(SiteName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SiteTimezone = group.Add(new VocabularyKey(nameof(SiteTimezone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderEntryDeadlineGroupId = group.Add(new VocabularyKey(nameof(OrderEntryDeadlineGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillMasterPlannedIntraSiteMovementsUseTransferJournals = group.Add(new VocabularyKey(nameof(WillMasterPlannedIntraSiteMovementsUseTransferJournals), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultInventoryStatusId = group.Add(new VocabularyKey(nameof(DefaultInventoryStatusId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsReceivingWarehouseOverrideAllowed = group.Add(new VocabularyKey(nameof(IsReceivingWarehouseOverrideAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventSiteDefaultDimension = group.Add(new VocabularyKey(nameof(InventSiteDefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultFinancialDimensionValue = group.Add(new VocabularyKey(nameof(DefaultFinancialDimensionValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalEstablishment = group.Add(new VocabularyKey(nameof(FiscalEstablishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressDescription = group.Add(new VocabularyKey(nameof(PrimaryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressCity = group.Add(new VocabularyKey(nameof(PrimaryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressCityInKana = group.Add(new VocabularyKey(nameof(PrimaryAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(PrimaryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressCountyId = group.Add(new VocabularyKey(nameof(PrimaryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressDistrictName = group.Add(new VocabularyKey(nameof(PrimaryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressLatitude = group.Add(new VocabularyKey(nameof(PrimaryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressLocationRoles = group.Add(new VocabularyKey(nameof(PrimaryAddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressLocationSalesTaxGroupCode = group.Add(new VocabularyKey(nameof(PrimaryAddressLocationSalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressLongitude = group.Add(new VocabularyKey(nameof(PrimaryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressStateId = group.Add(new VocabularyKey(nameof(PrimaryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressStreet = group.Add(new VocabularyKey(nameof(PrimaryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressStreetInKana = group.Add(new VocabularyKey(nameof(PrimaryAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressStreetNumber = group.Add(new VocabularyKey(nameof(PrimaryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressTimeZone = group.Add(new VocabularyKey(nameof(PrimaryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressZipCode = group.Add(new VocabularyKey(nameof(PrimaryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressPostBox = group.Add(new VocabularyKey(nameof(PrimaryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(PrimaryAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormattedPrimaryAddress = group.Add(new VocabularyKey(nameof(FormattedPrimaryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressValidFrom = group.Add(new VocabularyKey(nameof(PrimaryAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryAddressValidTo = group.Add(new VocabularyKey(nameof(PrimaryAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPrimaryAddressAssigned = group.Add(new VocabularyKey(nameof(IsPrimaryAddressAssigned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxBranchCode = group.Add(new VocabularyKey(nameof(TaxBranchCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SiteId { get; private set; }
public VocabularyKey SiteName { get; private set; }
public VocabularyKey SiteTimezone { get; private set; }
public VocabularyKey OrderEntryDeadlineGroupId { get; private set; }
public VocabularyKey WillMasterPlannedIntraSiteMovementsUseTransferJournals { get; private set; }
public VocabularyKey DefaultInventoryStatusId { get; private set; }
public VocabularyKey IsReceivingWarehouseOverrideAllowed { get; private set; }
public VocabularyKey InventSiteDefaultDimension { get; private set; }
public VocabularyKey DefaultFinancialDimensionValue { get; private set; }
public VocabularyKey FiscalEstablishmentId { get; private set; }
public VocabularyKey FiscalEstablishment { get; private set; }
public VocabularyKey PrimaryAddressDescription { get; private set; }
public VocabularyKey PrimaryAddressCity { get; private set; }
public VocabularyKey PrimaryAddressCityInKana { get; private set; }
public VocabularyKey PrimaryAddressCountryRegionId { get; private set; }
public VocabularyKey PrimaryAddressCountyId { get; private set; }
public VocabularyKey PrimaryAddressDistrictName { get; private set; }
public VocabularyKey PrimaryAddressLatitude { get; private set; }
public VocabularyKey PrimaryAddressLocationRoles { get; private set; }
public VocabularyKey PrimaryAddressLocationSalesTaxGroupCode { get; private set; }
public VocabularyKey PrimaryAddressLongitude { get; private set; }
public VocabularyKey PrimaryAddressStateId { get; private set; }
public VocabularyKey PrimaryAddressStreet { get; private set; }
public VocabularyKey PrimaryAddressStreetInKana { get; private set; }
public VocabularyKey PrimaryAddressStreetNumber { get; private set; }
public VocabularyKey PrimaryAddressTimeZone { get; private set; }
public VocabularyKey PrimaryAddressZipCode { get; private set; }
public VocabularyKey PrimaryAddressPostBox { get; private set; }
public VocabularyKey PrimaryAddressBuildingCompliment { get; private set; }
public VocabularyKey FormattedPrimaryAddress { get; private set; }
public VocabularyKey PrimaryAddressValidFrom { get; private set; }
public VocabularyKey PrimaryAddressValidTo { get; private set; }
public VocabularyKey IsPrimaryAddressAssigned { get; private set; }
public VocabularyKey TaxBranchCode { get; private set; }


    }
}