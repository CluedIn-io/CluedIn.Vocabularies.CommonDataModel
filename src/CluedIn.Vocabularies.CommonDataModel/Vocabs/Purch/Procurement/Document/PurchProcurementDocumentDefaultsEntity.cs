using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchProcurementDocumentDefaultsEntityVocabulary : SimpleVocabulary
    {
        public PurchProcurementDocumentDefaultsEntityVocabulary()
        {
            VocabularyName = "PurchProcurementDocumentDefaultsEntity";
            KeyPrefix = "commonDataModel.purchprocurementdocumentdefaultsentity";
            KeySeparator = ".";
            Grouping = "/PurchProcurementDocumentDefaultsEntity";

            AddGroup("PurchProcurementDocumentDefaultsEntity Details", group =>
            {
                ArePurchaseOrderAmountsPrintedByDefault = group.Add(new VocabularyKey(nameof(ArePurchaseOrderAmountsPrintedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPurchaseOrderPoolId = group.Add(new VocabularyKey(nameof(DefaultPurchaseOrderPoolId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPurchaseOrderType = group.Add(new VocabularyKey(nameof(DefaultPurchaseOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRFQDeliveryModeCode = group.Add(new VocabularyKey(nameof(DefaultRFQDeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRFQDeliveryTermsCode = group.Add(new VocabularyKey(nameof(DefaultRFQDeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRFQExpirationTime = group.Add(new VocabularyKey(nameof(DefaultRFQExpirationTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRFQPaymentTermsName = group.Add(new VocabularyKey(nameof(DefaultRFQPaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRFQPurchaseDocumentType = group.Add(new VocabularyKey(nameof(DefaultRFQPurchaseDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRFQSolicitationTypeRecId = group.Add(new VocabularyKey(nameof(DefaultRFQSolicitationTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRFQSolicitationTypeName = group.Add(new VocabularyKey(nameof(DefaultRFQSolicitationTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRFQValidityPeriodDays = group.Add(new VocabularyKey(nameof(DefaultRFQValidityPeriodDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultReturnOrderReturnActionId = group.Add(new VocabularyKey(nameof(DefaultReturnOrderReturnActionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderCurrencyCodeDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderCurrencyCodeDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderDeliveryDateDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderDeliveryDateDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderDeliveryTermsDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderDeliveryTermsDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderDocumentationDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderDocumentationDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderTotalDiscountPercentageDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderTotalDiscountPercentageDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderPurchaseChargeDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderPurchaseChargeDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderPaymentTermsDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderPaymentTermsDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderValidFromDateDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderValidFromDateDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderValidToDateDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderValidToDateDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyHeaderVendReferenceDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyHeaderVendReferenceDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineDeliveryDateDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineDeliveryDateDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineDocumentationDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineDocumentationDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineExternalItemDescriptionDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineExternalItemDescriptionDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineExternalItemNumberDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineExternalItemNumberDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineLeadTimeDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineLeadTimeDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineLineDiscountAmountDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineLineDiscountAmountDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLinePurchaseChargeDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLinePurchaseChargeDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineMultilineDiscountAmountDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineMultilineDiscountAmountDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineMultilineDiscountPercentageDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineMultilineDiscountPercentageDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineLineDiscountPercentDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineLineDiscountPercentDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLinePriceQuantityDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLinePriceQuantityDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineQuantityDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineQuantityDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineUnitSymbolDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineUnitSymbolDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineValidFromDateDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineValidFromDateDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineValidToDateDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineValidToDateDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuotationReplyLineWorkingDaysDisplayedByDefault = group.Add(new VocabularyKey(nameof(IsQuotationReplyLineWorkingDaysDisplayedByDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsRFQValidityPeriodUsingWorkingDays = group.Add(new VocabularyKey(nameof(IsRFQValidityPeriodUsingWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateDate = group.Add(new VocabularyKey(nameof(ExchangeRateDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ArePurchaseOrderAmountsPrintedByDefault { get; private set; }
        public VocabularyKey DefaultPurchaseOrderPoolId { get; private set; }
        public VocabularyKey DefaultPurchaseOrderType { get; private set; }
        public VocabularyKey DefaultRFQDeliveryModeCode { get; private set; }
        public VocabularyKey DefaultRFQDeliveryTermsCode { get; private set; }
        public VocabularyKey DefaultRFQExpirationTime { get; private set; }
        public VocabularyKey DefaultRFQPaymentTermsName { get; private set; }
        public VocabularyKey DefaultRFQPurchaseDocumentType { get; private set; }
        public VocabularyKey DefaultRFQSolicitationTypeRecId { get; private set; }
        public VocabularyKey DefaultRFQSolicitationTypeName { get; private set; }
        public VocabularyKey DefaultRFQValidityPeriodDays { get; private set; }
        public VocabularyKey DefaultReturnOrderReturnActionId { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderCurrencyCodeDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderDeliveryDateDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderDeliveryTermsDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderDocumentationDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderTotalDiscountPercentageDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderPurchaseChargeDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderPaymentTermsDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderValidFromDateDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderValidToDateDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyHeaderVendReferenceDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineDeliveryDateDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineDocumentationDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineExternalItemDescriptionDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineExternalItemNumberDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineLeadTimeDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineLineDiscountAmountDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLinePurchaseChargeDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineMultilineDiscountAmountDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineMultilineDiscountPercentageDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineLineDiscountPercentDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLinePriceQuantityDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineQuantityDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineUnitSymbolDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineValidFromDateDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineValidToDateDisplayedByDefault { get; private set; }
        public VocabularyKey IsQuotationReplyLineWorkingDaysDisplayedByDefault { get; private set; }
        public VocabularyKey IsRFQValidityPeriodUsingWorkingDays { get; private set; }
        public VocabularyKey ExchangeRateDate { get; private set; }


    }
}