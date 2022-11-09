using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchRequestForQuotationReplyLineEntityVocabulary : SimpleVocabulary
    {
        public PurchRequestForQuotationReplyLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchRequestForQuotationReplyLineEntity";
            KeyPrefix = "commonDataModel.purchrequestforquotationreplylineentity";
            KeySeparator = ".";
            Grouping = "/PurchRequestForQuotationReplyLineEntity";

            AddGroup("Common Data Model PurchRequestForQuotationReplyLineEntity Details", group =>
            {
                ProjectSalesCurrencyCode = group.Add(new VocabularyKey(nameof(ProjectSalesCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectActivityNumber = group.Add(new VocabularyKey(nameof(ProjectActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResultingPurchaseAgreementId = group.Add(new VocabularyKey(nameof(ResultingPurchaseAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AssetValueModelId = group.Add(new VocabularyKey(nameof(AssetValueModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedAssetTransactionType = group.Add(new VocabularyKey(nameof(FixedAssetTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfirmedDeliveryDate = group.Add(new VocabularyKey(nameof(ConfirmedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedDeliveryDate = group.Add(new VocabularyKey(nameof(RequestedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQCaseLineExpirationDateTime = group.Add(new VocabularyKey(nameof(RFQCaseLineExpirationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsAlternateProduct = group.Add(new VocabularyKey(nameof(IsAlternateProduct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemName = group.Add(new VocabularyKey(nameof(ItemName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineAmount = group.Add(new VocabularyKey(nameof(LineAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscountAmount = group.Add(new VocabularyKey(nameof(LineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscountPercentage = group.Add(new VocabularyKey(nameof(LineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MultilineDiscountAmount = group.Add(new VocabularyKey(nameof(MultilineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MultilineDiscountPercentage = group.Add(new VocabularyKey(nameof(MultilineDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDescription = group.Add(new VocabularyKey(nameof(LineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedCatchWeightQuantity = group.Add(new VocabularyKey(nameof(RequestedCatchWeightQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchasePriceQuantity = group.Add(new VocabularyKey(nameof(PurchasePriceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectCategoryId = group.Add(new VocabularyKey(nameof(ProjectCategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectLinePropertyId = group.Add(new VocabularyKey(nameof(ProjectLinePropertyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectSalesPrice = group.Add(new VocabularyKey(nameof(ProjectSalesPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectSalesUnitSymbol = group.Add(new VocabularyKey(nameof(ProjectSalesUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectTaxGroupCode = group.Add(new VocabularyKey(nameof(ProjectTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectTaxItemGroupCode = group.Add(new VocabularyKey(nameof(ProjectTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectTransactionId = group.Add(new VocabularyKey(nameof(ProjectTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResultingPurchaseOrderNumber = group.Add(new VocabularyKey(nameof(ResultingPurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedPriceCharges = group.Add(new VocabularyKey(nameof(FixedPriceCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchasePrice = group.Add(new VocabularyKey(nameof(PurchasePrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedPurchaseQuantity = group.Add(new VocabularyKey(nameof(RequestedPurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedQuantityUnitSymbol = group.Add(new VocabularyKey(nameof(RequestedQuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedQuantity = group.Add(new VocabularyKey(nameof(RequestedQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQCasePlannedOrderRequirementPlanId = group.Add(new VocabularyKey(nameof(RFQCasePlannedOrderRequirementPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlannedPurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PlannedPurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQCaseLineLineNumber = group.Add(new VocabularyKey(nameof(RFQCaseLineLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQNumber = group.Add(new VocabularyKey(nameof(RFQNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultRFQPurchaseOrderType = group.Add(new VocabularyKey(nameof(DefaultRFQPurchaseOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineStatus = group.Add(new VocabularyKey(nameof(LineStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxItemGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDistributionTemplateName = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDistributionTemplateLegalEntityPartyNumber = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateLegalEntityPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDistributionTemplateLegalEntityId = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementProductCategoryName = group.Add(new VocabularyKey(nameof(ProcurementProductCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQCaseNumber = group.Add(new VocabularyKey(nameof(RFQCaseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressLocationId = group.Add(new VocabularyKey(nameof(DeliveryAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FormattedDeliveryAddress = group.Add(new VocabularyKey(nameof(FormattedDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressZipCode = group.Add(new VocabularyKey(nameof(DeliveryAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(DeliveryAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCity = group.Add(new VocabularyKey(nameof(DeliveryAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCityInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCountryRegionId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(DeliveryAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressCountyId = group.Add(new VocabularyKey(nameof(DeliveryAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressDescription = group.Add(new VocabularyKey(nameof(DeliveryAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressDistrictName = group.Add(new VocabularyKey(nameof(DeliveryAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressDunsNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressLatitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDeliveryAddressPrivate = group.Add(new VocabularyKey(nameof(IsDeliveryAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressLongitude = group.Add(new VocabularyKey(nameof(DeliveryAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressPostBox = group.Add(new VocabularyKey(nameof(DeliveryAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStateId = group.Add(new VocabularyKey(nameof(DeliveryAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStreet = group.Add(new VocabularyKey(nameof(DeliveryAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStreetInKana = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressStreetNumber = group.Add(new VocabularyKey(nameof(DeliveryAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressValidFrom = group.Add(new VocabularyKey(nameof(DeliveryAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressValidTo = group.Add(new VocabularyKey(nameof(DeliveryAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressTimeZone = group.Add(new VocabularyKey(nameof(DeliveryAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineVendorReasonComment = group.Add(new VocabularyKey(nameof(LineVendorReasonComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineVendorReasonCode = group.Add(new VocabularyKey(nameof(LineVendorReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductColorId = group.Add(new VocabularyKey(nameof(ProductColorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivingSiteId = group.Add(new VocabularyKey(nameof(ReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivingWarehouseId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductConfigurationId = group.Add(new VocabularyKey(nameof(ProductConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductSizeId = group.Add(new VocabularyKey(nameof(ProductSizeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductStyleId = group.Add(new VocabularyKey(nameof(ProductStyleId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductVersionId = group.Add(new VocabularyKey(nameof(ProductVersionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProcurementUsingWorkingDays = group.Add(new VocabularyKey(nameof(IsProcurementUsingWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsRFQLineAccepted = group.Add(new VocabularyKey(nameof(IsRFQLineAccepted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsRFQReplyLineSelected = group.Add(new VocabularyKey(nameof(IsRFQReplyLineSelected), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQReplyLineEffectiveDate = group.Add(new VocabularyKey(nameof(RFQReplyLineEffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQReplyLineExpirationDate = group.Add(new VocabularyKey(nameof(RFQReplyLineExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementLeadTimeDays = group.Add(new VocabularyKey(nameof(ProcurementLeadTimeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ProjectSalesCurrencyCode { get; private set; }
public VocabularyKey ProjectActivityNumber { get; private set; }
public VocabularyKey ResultingPurchaseAgreementId { get; private set; }
public VocabularyKey AssetValueModelId { get; private set; }
public VocabularyKey FixedAssetNumber { get; private set; }
public VocabularyKey FixedAssetTransactionType { get; private set; }
public VocabularyKey ConfirmedDeliveryDate { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey DefaultDimension { get; private set; }
public VocabularyKey RequestedDeliveryDate { get; private set; }
public VocabularyKey DeliveryAddressName { get; private set; }
public VocabularyKey RFQCaseLineExpirationDateTime { get; private set; }
public VocabularyKey ExternalItemNumber { get; private set; }
public VocabularyKey IsAlternateProduct { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ItemName { get; private set; }
public VocabularyKey LineAmount { get; private set; }
public VocabularyKey LineDiscountAmount { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey LineDiscountPercentage { get; private set; }
public VocabularyKey LineType { get; private set; }
public VocabularyKey MultilineDiscountAmount { get; private set; }
public VocabularyKey MultilineDiscountPercentage { get; private set; }
public VocabularyKey LineDescription { get; private set; }
public VocabularyKey RequestedCatchWeightQuantity { get; private set; }
public VocabularyKey PurchasePriceQuantity { get; private set; }
public VocabularyKey ProjectCategoryId { get; private set; }
public VocabularyKey ProjectId { get; private set; }
public VocabularyKey ProjectLinePropertyId { get; private set; }
public VocabularyKey ProjectSalesPrice { get; private set; }
public VocabularyKey ProjectSalesUnitSymbol { get; private set; }
public VocabularyKey ProjectTaxGroupCode { get; private set; }
public VocabularyKey ProjectTaxItemGroupCode { get; private set; }
public VocabularyKey ProjectTransactionId { get; private set; }
public VocabularyKey ResultingPurchaseOrderNumber { get; private set; }
public VocabularyKey FixedPriceCharges { get; private set; }
public VocabularyKey PurchasePrice { get; private set; }
public VocabularyKey RequestedPurchaseQuantity { get; private set; }
public VocabularyKey RequestedQuantityUnitSymbol { get; private set; }
public VocabularyKey RequestedQuantity { get; private set; }
public VocabularyKey RFQCasePlannedOrderRequirementPlanId { get; private set; }
public VocabularyKey PlannedPurchaseOrderNumber { get; private set; }
public VocabularyKey RFQCaseLineLineNumber { get; private set; }
public VocabularyKey RFQNumber { get; private set; }
public VocabularyKey DefaultRFQPurchaseOrderType { get; private set; }
public VocabularyKey LineStatus { get; private set; }
public VocabularyKey SalesTaxGroupCode { get; private set; }
public VocabularyKey SalesTaxItemGroupCode { get; private set; }
public VocabularyKey AccountingDistributionTemplateName { get; private set; }
public VocabularyKey AccountingDistributionTemplateLegalEntityPartyNumber { get; private set; }
public VocabularyKey AccountingDistributionTemplateLegalEntityId { get; private set; }
public VocabularyKey ProcurementProductCategoryName { get; private set; }
public VocabularyKey RFQCaseNumber { get; private set; }
public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
public VocabularyKey DeliveryAddressLocationId { get; private set; }
public VocabularyKey FormattedDeliveryAddress { get; private set; }
public VocabularyKey DeliveryAddressZipCode { get; private set; }
public VocabularyKey DeliveryAddressBuildingCompliment { get; private set; }
public VocabularyKey DeliveryAddressCity { get; private set; }
public VocabularyKey DeliveryAddressCityInKana { get; private set; }
public VocabularyKey DeliveryAddressCountryRegionId { get; private set; }
public VocabularyKey DeliveryAddressCountryRegionISOCode { get; private set; }
public VocabularyKey DeliveryAddressCountyId { get; private set; }
public VocabularyKey DeliveryAddressDescription { get; private set; }
public VocabularyKey DeliveryAddressDistrictName { get; private set; }
public VocabularyKey DeliveryAddressDunsNumber { get; private set; }
public VocabularyKey DeliveryAddressLatitude { get; private set; }
public VocabularyKey IsDeliveryAddressPrivate { get; private set; }
public VocabularyKey DeliveryAddressLongitude { get; private set; }
public VocabularyKey DeliveryAddressPostBox { get; private set; }
public VocabularyKey DeliveryAddressStateId { get; private set; }
public VocabularyKey DeliveryAddressStreet { get; private set; }
public VocabularyKey DeliveryAddressStreetInKana { get; private set; }
public VocabularyKey DeliveryAddressStreetNumber { get; private set; }
public VocabularyKey DeliveryAddressValidFrom { get; private set; }
public VocabularyKey DeliveryAddressValidTo { get; private set; }
public VocabularyKey DeliveryAddressTimeZone { get; private set; }
public VocabularyKey LineVendorReasonComment { get; private set; }
public VocabularyKey LineVendorReasonCode { get; private set; }
public VocabularyKey ProductColorId { get; private set; }
public VocabularyKey ReceivingSiteId { get; private set; }
public VocabularyKey ReceivingWarehouseId { get; private set; }
public VocabularyKey ProductConfigurationId { get; private set; }
public VocabularyKey ProductSizeId { get; private set; }
public VocabularyKey ProductStyleId { get; private set; }
public VocabularyKey ProductVersionId { get; private set; }
public VocabularyKey IsProcurementUsingWorkingDays { get; private set; }
public VocabularyKey IsRFQLineAccepted { get; private set; }
public VocabularyKey IsRFQReplyLineSelected { get; private set; }
public VocabularyKey RFQReplyLineEffectiveDate { get; private set; }
public VocabularyKey RFQReplyLineExpirationDate { get; private set; }
public VocabularyKey ProcurementLeadTimeDays { get; private set; }
public VocabularyKey VendorAccountNumber { get; private set; }
public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }


    }
}