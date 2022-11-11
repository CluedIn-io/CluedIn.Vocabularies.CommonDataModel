using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendRequestForQuotationJournalHeaderEntityVocabulary : SimpleVocabulary
    {
        public VendRequestForQuotationJournalHeaderEntityVocabulary()
        {
            VocabularyName = "VendRequestForQuotationJournalHeaderEntity";
            KeyPrefix = "commonDataModel.vendrequestforquotationjournalheaderentity";
            KeySeparator = ".";
            Grouping = "/VendRequestForQuotationJournalHeaderEntity";

            AddGroup("VendRequestForQuotationJournalHeaderEntity Details", group =>
            {
                PurchaseAgreementId = group.Add(new VocabularyKey(nameof(PurchaseAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalRFQAmount = group.Add(new VocabularyKey(nameof(TotalRFQAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorCashDiscountCode = group.Add(new VocabularyKey(nameof(VendorCashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressDate = group.Add(new VocabularyKey(nameof(DeliveryAddressDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryAddressName = group.Add(new VocabularyKey(nameof(DeliveryAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountPercentage = group.Add(new VocabularyKey(nameof(TotalDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorEmailAddress = group.Add(new VocabularyKey(nameof(VendorEmailAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQExpirationDateTime = group.Add(new VocabularyKey(nameof(RFQExpirationDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePricesIncludingSalesTax = group.Add(new VocabularyKey(nameof(ArePricesIncludingSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalRFQJournalNumber = group.Add(new VocabularyKey(nameof(InternalRFQJournalNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuyerGroupId = group.Add(new VocabularyKey(nameof(BuyerGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeVendorGroupId = group.Add(new VocabularyKey(nameof(ChargeVendorGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultilineDiscountVendorGroupCode = group.Add(new VocabularyKey(nameof(MultilineDiscountVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceGroupId = group.Add(new VocabularyKey(nameof(NumberSequenceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentScheduleName = group.Add(new VocabularyKey(nameof(PaymentScheduleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentMethodName = group.Add(new VocabularyKey(nameof(VendorPaymentMethodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorPaymentMethodSpecificationName = group.Add(new VocabularyKey(nameof(VendorPaymentMethodSpecificationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPhoneNumber = group.Add(new VocabularyKey(nameof(ContactPhoneNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceVendorGroupCode = group.Add(new VocabularyKey(nameof(PriceVendorGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ArePricesDisplayed = group.Add(new VocabularyKey(nameof(ArePricesDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReplySheetIncluded = group.Add(new VocabularyKey(nameof(IsReplySheetIncluded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseOrderNumber = group.Add(new VocabularyKey(nameof(PurchaseOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalBalance = group.Add(new VocabularyKey(nameof(TotalBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQCaseNumber = group.Add(new VocabularyKey(nameof(RFQCaseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQJournalDate = group.Add(new VocabularyKey(nameof(RFQJournalDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQNumber = group.Add(new VocabularyKey(nameof(RFQNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQName = group.Add(new VocabularyKey(nameof(RFQName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderCurrencyCodeDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderCurrencyCodeDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderDeliveryDateDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderDeliveryDateDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderDeliveryTermsDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderDeliveryTermsDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderDocumentationDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderDocumentationDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderTotalDiscountPercentageDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderTotalDiscountPercentageDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderPurchaseChargeDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderPurchaseChargeDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderPaymentTermsDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderPaymentTermsDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderValidFromDateDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderValidFromDateDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderValidToDateDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderValidToDateDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderVendReferenceDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderVendReferenceDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineDeliveryDateDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineDeliveryDateDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineDocumentationDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineDocumentationDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineExternalItemDescriptionDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineExternalItemDescriptionDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineExternalItemNumberDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineExternalItemNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineLeadTimeDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineLeadTimeDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineLineDiscountAmountDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineLineDiscountAmountDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLinePurchaseChargeDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLinePurchaseChargeDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineMultilineDiscountAmountDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineMultilineDiscountAmountDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineMultilineDiscountPercentageDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineMultilineDiscountPercentageDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineDiscountPercentDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineDiscountPercentDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLinePriceQuantityDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLinePriceQuantityDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineQuantityDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineQuantityDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineUnitSymbolDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineUnitSymbolDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineValidFromDateDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineValidFromDateDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineValidToDateDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineValidToDateDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineWorkingDaysDisplayed = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineWorkingDaysDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResultingPurchaseDocumentType = group.Add(new VocabularyKey(nameof(ResultingPurchaseDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalRoundOffAmount = group.Add(new VocabularyKey(nameof(TotalRoundOffAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RFQStatus = group.Add(new VocabularyKey(nameof(RFQStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalLineDiscountAmount = group.Add(new VocabularyKey(nameof(TotalLineDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalChargeAmount = group.Add(new VocabularyKey(nameof(TotalChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalTaxAmount = group.Add(new VocabularyKey(nameof(TotalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroupCode = group.Add(new VocabularyKey(nameof(TaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResultingPurchaseAgreementExpirationDate = group.Add(new VocabularyKey(nameof(ResultingPurchaseAgreementExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResultingPurchaseAgreementEffectiveDate = group.Add(new VocabularyKey(nameof(ResultingPurchaseAgreementEffectiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorOrderReference = group.Add(new VocabularyKey(nameof(VendorOrderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestingWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(RequestingWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorReasonCode = group.Add(new VocabularyKey(nameof(VendorReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorReasonComment = group.Add(new VocabularyKey(nameof(VendorReasonComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderingWorkerPersonnelNumber = group.Add(new VocabularyKey(nameof(OrderingWorkerPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryPostalAddressRecId = group.Add(new VocabularyKey(nameof(DeliveryPostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                BidSubmittedBy = group.Add(new VocabularyKey(nameof(BidSubmittedBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BidSubmittingPersonPartyNumber = group.Add(new VocabularyKey(nameof(BidSubmittingPersonPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PurchaseAgreementId { get; private set; }
        public VocabularyKey TotalRFQAmount { get; private set; }
        public VocabularyKey VendorCashDiscountCode { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey DeliveryAddressDate { get; private set; }
        public VocabularyKey DeliveryAddressName { get; private set; }
        public VocabularyKey TotalDiscountPercentage { get; private set; }
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey VendorEmailAddress { get; private set; }
        public VocabularyKey TotalDiscountAmount { get; private set; }
        public VocabularyKey RFQExpirationDateTime { get; private set; }
        public VocabularyKey ArePricesIncludingSalesTax { get; private set; }
        public VocabularyKey InternalRFQJournalNumber { get; private set; }
        public VocabularyKey BuyerGroupId { get; private set; }
        public VocabularyKey LanguageId { get; private set; }
        public VocabularyKey ChargeVendorGroupId { get; private set; }
        public VocabularyKey MultilineDiscountVendorGroupCode { get; private set; }
        public VocabularyKey NumberSequenceGroupId { get; private set; }
        public VocabularyKey PaymentTermsName { get; private set; }
        public VocabularyKey PaymentScheduleName { get; private set; }
        public VocabularyKey VendorPaymentMethodName { get; private set; }
        public VocabularyKey VendorPaymentMethodSpecificationName { get; private set; }
        public VocabularyKey ContactPhoneNumber { get; private set; }
        public VocabularyKey PriceVendorGroupCode { get; private set; }
        public VocabularyKey ArePricesDisplayed { get; private set; }
        public VocabularyKey IsReplySheetIncluded { get; private set; }
        public VocabularyKey PurchaseOrderNumber { get; private set; }
        public VocabularyKey TotalBalance { get; private set; }
        public VocabularyKey RFQCaseNumber { get; private set; }
        public VocabularyKey RFQJournalDate { get; private set; }
        public VocabularyKey RFQNumber { get; private set; }
        public VocabularyKey RFQName { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderCurrencyCodeDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderDeliveryDateDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderDeliveryTermsDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderDocumentationDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderTotalDiscountPercentageDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderPurchaseChargeDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderPaymentTermsDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderValidFromDateDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderValidToDateDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderVendReferenceDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineDeliveryDateDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineDocumentationDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineExternalItemDescriptionDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineExternalItemNumberDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineLeadTimeDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineLineDiscountAmountDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLinePurchaseChargeDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineMultilineDiscountAmountDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineMultilineDiscountPercentageDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineDiscountPercentDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLinePriceQuantityDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineQuantityDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineUnitSymbolDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineValidFromDateDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineValidToDateDisplayed { get; private set; }
        public VocabularyKey IsQuotationReplyLineWorkingDaysDisplayed { get; private set; }
        public VocabularyKey ResultingPurchaseDocumentType { get; private set; }
        public VocabularyKey TotalRoundOffAmount { get; private set; }
        public VocabularyKey RFQStatus { get; private set; }
        public VocabularyKey TotalLineDiscountAmount { get; private set; }
        public VocabularyKey TotalChargeAmount { get; private set; }
        public VocabularyKey TotalTaxAmount { get; private set; }
        public VocabularyKey TaxGroupCode { get; private set; }
        public VocabularyKey ResultingPurchaseAgreementExpirationDate { get; private set; }
        public VocabularyKey ResultingPurchaseAgreementEffectiveDate { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
        public VocabularyKey VendorOrderReference { get; private set; }
        public VocabularyKey RequestingWorkerPersonnelNumber { get; private set; }
        public VocabularyKey VendorReasonCode { get; private set; }
        public VocabularyKey VendorReasonComment { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey OrderingWorkerPersonnelNumber { get; private set; }
        public VocabularyKey DeliveryPostalAddressRecId { get; private set; }
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
        public VocabularyKey BidSubmittedBy { get; private set; }
        public VocabularyKey BidSubmittingPersonPartyNumber { get; private set; }


    }
}