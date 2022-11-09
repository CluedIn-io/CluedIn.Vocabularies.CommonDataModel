using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchRequestForQuotationReplyHeaderEntityVocabulary : SimpleVocabulary
    {
        public PurchRequestForQuotationReplyHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchRequestForQuotationReplyHeaderEntity";
            KeyPrefix = "commonDataModel.purchrequestforquotationreplyheaderentity";
            KeySeparator = ".";
            Grouping = "/PurchRequestForQuotationReplyHeaderEntity";

            AddGroup("Common Data Model PurchRequestForQuotationReplyHeaderEntity Details", group =>
            {
                ResultingPurchaseAgreementId = group.Add(new VocabularyKey(nameof(ResultingPurchaseAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQBidType = group.Add(new VocabularyKey(nameof(RFQBidType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorCashDiscountCode = group.Add(new VocabularyKey(nameof(VendorCashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestedDeliveryDate = group.Add(new VocabularyKey(nameof(RequestedDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalDiscountPercentage = group.Add(new VocabularyKey(nameof(TotalDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorEmailAddress = group.Add(new VocabularyKey(nameof(VendorEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(TotalDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQExpirationDateTime = group.Add(new VocabularyKey(nameof(RFQExpirationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ArePricesIncludingSalesTax = group.Add(new VocabularyKey(nameof(ArePricesIncludingSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivingWarehouseId = group.Add(new VocabularyKey(nameof(ReceivingWarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivingSiteId = group.Add(new VocabularyKey(nameof(ReceivingSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BuyerGroupId = group.Add(new VocabularyKey(nameof(BuyerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(LineDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChargeVendorGroupId = group.Add(new VocabularyKey(nameof(ChargeVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MultiLineDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(MultiLineDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQCaseTitle = group.Add(new VocabularyKey(nameof(RFQCaseTitle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberSequenceGroupId = group.Add(new VocabularyKey(nameof(NumberSequenceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentScheduleName = group.Add(new VocabularyKey(nameof(PaymentScheduleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorPaymentMethodName = group.Add(new VocabularyKey(nameof(VendorPaymentMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorPaymentMethodSpecificationName = group.Add(new VocabularyKey(nameof(VendorPaymentMethodSpecificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPhoneNumber = group.Add(new VocabularyKey(nameof(ContactPhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceVendorGroupCode = group.Add(new VocabularyKey(nameof(PriceVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResultingPurchaseOrderNumber = group.Add(new VocabularyKey(nameof(ResultingPurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderingWorkeId = group.Add(new VocabularyKey(nameof(OrderingWorkeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestingWorkerId = group.Add(new VocabularyKey(nameof(RequestingWorkerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQCaseNumber = group.Add(new VocabularyKey(nameof(RFQCaseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQNumber = group.Add(new VocabularyKey(nameof(RFQNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQName = group.Add(new VocabularyKey(nameof(RFQName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQType = group.Add(new VocabularyKey(nameof(RFQType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQReplyURLAddress = group.Add(new VocabularyKey(nameof(RFQReplyURLAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
HighestRFQStatus = group.Add(new VocabularyKey(nameof(HighestRFQStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LowestRFQStatus = group.Add(new VocabularyKey(nameof(LowestRFQStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroupCode = group.Add(new VocabularyKey(nameof(SalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResultingPurchaseAgreementExpirationDate = group.Add(new VocabularyKey(nameof(ResultingPurchaseAgreementExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResultingPurchaseAgreementEffectiveDate = group.Add(new VocabularyKey(nameof(ResultingPurchaseAgreementEffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorReplySubmissionDateTime = group.Add(new VocabularyKey(nameof(VendorReplySubmissionDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReplySubmittedBy = group.Add(new VocabularyKey(nameof(ReplySubmittedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestingDepartmentName = group.Add(new VocabularyKey(nameof(RequestingDepartmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsRFQBidInProgress = group.Add(new VocabularyKey(nameof(IsRFQBidInProgress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderingWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(OrderingWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RequestingWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(RequestingWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BidSubmittingPersonPartyNumber = group.Add(new VocabularyKey(nameof(BidSubmittingPersonPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorReasonCode = group.Add(new VocabularyKey(nameof(VendorReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorReasonComment = group.Add(new VocabularyKey(nameof(VendorReasonComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQSolicitationTypeName = group.Add(new VocabularyKey(nameof(RFQSolicitationTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDistributionTemplateId = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDistributionLegalEntityId = group.Add(new VocabularyKey(nameof(AccountingDistributionLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountingDistributionTemplateLegalEntityPartyNumber = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateLegalEntityPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsRFQAccepted = group.Add(new VocabularyKey(nameof(IsRFQAccepted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsRFQSealed = group.Add(new VocabularyKey(nameof(IsRFQSealed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorOrderReference = group.Add(new VocabularyKey(nameof(VendorOrderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TotalRFQScore = group.Add(new VocabularyKey(nameof(TotalRFQScore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQScoreRank = group.Add(new VocabularyKey(nameof(RFQScoreRank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDeliveryAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsDeliveryAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ResultingPurchaseAgreementId { get; private set; }
public VocabularyKey RFQBidType { get; private set; }
public VocabularyKey VendorCashDiscountCode { get; private set; }
public VocabularyKey ContactPersonId { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey RequestedDeliveryDate { get; private set; }
public VocabularyKey DeliveryAddressName { get; private set; }
public VocabularyKey TotalDiscountPercentage { get; private set; }
public VocabularyKey DeliveryModeCode { get; private set; }
public VocabularyKey DeliveryTermsCode { get; private set; }
public VocabularyKey VendorEmailAddress { get; private set; }
public VocabularyKey TotalDiscountVendorGroupCode { get; private set; }
public VocabularyKey RFQExpirationDateTime { get; private set; }
public VocabularyKey ArePricesIncludingSalesTax { get; private set; }
public VocabularyKey ReceivingWarehouseId { get; private set; }
public VocabularyKey ReceivingSiteId { get; private set; }
public VocabularyKey BuyerGroupId { get; private set; }
public VocabularyKey LanguageId { get; private set; }
public VocabularyKey LineDiscountVendorGroupCode { get; private set; }
public VocabularyKey ChargeVendorGroupId { get; private set; }
public VocabularyKey MultiLineDiscountVendorGroupCode { get; private set; }
public VocabularyKey RFQCaseTitle { get; private set; }
public VocabularyKey NumberSequenceGroupId { get; private set; }
public VocabularyKey PaymentTermsName { get; private set; }
public VocabularyKey PaymentScheduleName { get; private set; }
public VocabularyKey VendorPaymentMethodName { get; private set; }
public VocabularyKey VendorPaymentMethodSpecificationName { get; private set; }
public VocabularyKey ContactPhoneNumber { get; private set; }
public VocabularyKey PriceVendorGroupCode { get; private set; }
public VocabularyKey ProjectId { get; private set; }
public VocabularyKey ResultingPurchaseOrderNumber { get; private set; }
public VocabularyKey OrderingWorkeId { get; private set; }
public VocabularyKey RequestingWorkerId { get; private set; }
public VocabularyKey RFQCaseNumber { get; private set; }
public VocabularyKey RFQNumber { get; private set; }
public VocabularyKey RFQName { get; private set; }
public VocabularyKey RFQType { get; private set; }
public VocabularyKey RFQReplyURLAddress { get; private set; }
public VocabularyKey HighestRFQStatus { get; private set; }
public VocabularyKey LowestRFQStatus { get; private set; }
public VocabularyKey SalesTaxGroupCode { get; private set; }
public VocabularyKey ResultingPurchaseAgreementExpirationDate { get; private set; }
public VocabularyKey ResultingPurchaseAgreementEffectiveDate { get; private set; }
public VocabularyKey TaxExemptNumber { get; private set; }
public VocabularyKey VendorAccountNumber { get; private set; }
public VocabularyKey VendorReplySubmissionDateTime { get; private set; }
public VocabularyKey ReplySubmittedBy { get; private set; }
public VocabularyKey RequestingDepartmentName { get; private set; }
public VocabularyKey IsRFQBidInProgress { get; private set; }
public VocabularyKey OrderingWorkerPersonnelNumber { get; private set; }
public VocabularyKey RequestingWorkerPersonnelNumber { get; private set; }
public VocabularyKey BidSubmittingPersonPartyNumber { get; private set; }
public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
public VocabularyKey VendorReasonCode { get; private set; }
public VocabularyKey VendorReasonComment { get; private set; }
public VocabularyKey RFQSolicitationTypeName { get; private set; }
public VocabularyKey AccountingDistributionTemplateId { get; private set; }
public VocabularyKey AccountingDistributionLegalEntityId { get; private set; }
public VocabularyKey AccountingDistributionTemplateLegalEntityPartyNumber { get; private set; }
public VocabularyKey IsRFQAccepted { get; private set; }
public VocabularyKey IsRFQSealed { get; private set; }
public VocabularyKey VendorOrderReference { get; private set; }
public VocabularyKey TotalRFQScore { get; private set; }
public VocabularyKey RFQScoreRank { get; private set; }
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
public VocabularyKey DefaultDimension { get; private set; }
public VocabularyKey IsDeliveryAddressOrderSpecific { get; private set; }


    }
}