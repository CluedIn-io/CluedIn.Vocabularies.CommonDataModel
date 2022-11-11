using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesDocumentEntryPolicyEntityVocabulary : SimpleVocabulary
    {
        public SalesDocumentEntryPolicyEntityVocabulary()
        {
            VocabularyName = "SalesDocumentEntryPolicyEntity";
            KeyPrefix = "commonDataModel.salesdocumententrypolicyentity";
            KeySeparator = ".";
            Grouping = "/SalesDocumentEntryPolicyEntity";

            AddGroup("SalesDocumentEntryPolicyEntity Details", group =>
            {
                AcceptablePriceMarginPercentage = group.Add(new VocabularyKey(nameof(AcceptablePriceMarginPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillDocumentEntryAutomaticallyAllocateHeaderLevelCharges = group.Add(new VocabularyKey(nameof(WillDocumentEntryAutomaticallyAllocateHeaderLevelCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillDocumentEntryAutomaticallyAllocateLineLevelCharges = group.Add(new VocabularyKey(nameof(WillDocumentEntryAutomaticallyAllocateLineLevelCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreNoteTypeDocumentAttachmentsCopied = group.Add(new VocabularyKey(nameof(AreNoteTypeDocumentAttachmentsCopied), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillDocumentEntryDisplayPriceMarginAlerts = group.Add(new VocabularyKey(nameof(WillDocumentEntryDisplayPriceMarginAlerts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderEntryStatisticsRecorded = group.Add(new VocabularyKey(nameof(AreSalesOrderEntryStatisticsRecorded), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseSalesPriceConversionExchangeRateTypeName = group.Add(new VocabularyKey(nameof(BaseSalesPriceConversionExchangeRateTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseSalesPriceConversionExchangeRateTypeRecId = group.Add(new VocabularyKey(nameof(BaseSalesPriceConversionExchangeRateTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseSalesPriceGenericCurrencyCode = group.Add(new VocabularyKey(nameof(BaseSalesPriceGenericCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralATPBackwardDemandTimeFenceDays = group.Add(new VocabularyKey(nameof(GeneralATPBackwardDemandTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralATPBackwardSupplyTimeFenceDays = group.Add(new VocabularyKey(nameof(GeneralATPBackwardSupplyTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralATPDelayedDemandOffsetDays = group.Add(new VocabularyKey(nameof(GeneralATPDelayedDemandOffsetDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralATPDelayedSupplyOffsetDays = group.Add(new VocabularyKey(nameof(GeneralATPDelayedSupplyOffsetDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralATPTimeFenceDays = group.Add(new VocabularyKey(nameof(GeneralATPTimeFenceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralSalesLeadTimeDays = group.Add(new VocabularyKey(nameof(GeneralSalesLeadTimeDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralSalesOrderPromisingMethod = group.Add(new VocabularyKey(nameof(GeneralSalesOrderPromisingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoicedSalesOrderMaintenanceRule = group.Add(new VocabularyKey(nameof(InvoicedSalesOrderMaintenanceRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsATPGenerallyIncludingPlannedOrders = group.Add(new VocabularyKey(nameof(IsATPGenerallyIncludingPlannedOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillBaseSalesPriceConversionApplySmartRoundingRules = group.Add(new VocabularyKey(nameof(WillBaseSalesPriceConversionApplySmartRoundingRules), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCustomerInformationTransferBeingPrompted = group.Add(new VocabularyKey(nameof(IsCustomerInformationTransferBeingPrompted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesOrderDeletionVoidOrder = group.Add(new VocabularyKey(nameof(WillSalesOrderDeletionVoidOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesOrderPromissingUsingWorkingDays = group.Add(new VocabularyKey(nameof(IsSalesOrderPromissingUsingWorkingDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesProductListBeingPrompted = group.Add(new VocabularyKey(nameof(IsSalesProductListBeingPrompted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineLevelDiscountCalculationRule = group.Add(new VocabularyKey(nameof(LineLevelDiscountCalculationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnHoldSalesOrderDisplayedRGBColor = group.Add(new VocabularyKey(nameof(OnHoldSalesOrderDisplayedRGBColor), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                QuestionablePriceMarginPercentage = group.Add(new VocabularyKey(nameof(QuestionablePriceMarginPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderHoldCommentDocumentAttachmentTypeCode = group.Add(new VocabularyKey(nameof(SalesOrderHoldCommentDocumentAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderLineDeliveryDateUpdateRule = group.Add(new VocabularyKey(nameof(SalesOrderLineDeliveryDateUpdateRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAgreementSearchDateType = group.Add(new VocabularyKey(nameof(TradeAgreementSearchDateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesAgreementCustomerAccountNumberUniquenessRequired = group.Add(new VocabularyKey(nameof(IsSalesAgreementCustomerAccountNumberUniquenessRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesAgreementClassificationUniquenessRequired = group.Add(new VocabularyKey(nameof(IsSalesAgreementClassificationUniquenessRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesAgreementCurrencyUniquenessRequired = group.Add(new VocabularyKey(nameof(IsSalesAgreementCurrencyUniquenessRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesAgreementDocumentTitleUniquenessRequired = group.Add(new VocabularyKey(nameof(IsSalesAgreementDocumentTitleUniquenessRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesAgreementExternalDocumentReferenceUniquenessRequired = group.Add(new VocabularyKey(nameof(IsSalesAgreementExternalDocumentReferenceUniquenessRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesAgreementYearUniquenessRequired = group.Add(new VocabularyKey(nameof(IsSalesAgreementYearUniquenessRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcisePosting = group.Add(new VocabularyKey(nameof(ExcisePosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DomesticSalesTaxGroupCode = group.Add(new VocabularyKey(nameof(DomesticSalesTaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AcceptablePriceMarginPercentage { get; private set; }
        public VocabularyKey WillDocumentEntryAutomaticallyAllocateHeaderLevelCharges { get; private set; }
        public VocabularyKey WillDocumentEntryAutomaticallyAllocateLineLevelCharges { get; private set; }
        public VocabularyKey AreNoteTypeDocumentAttachmentsCopied { get; private set; }
        public VocabularyKey WillDocumentEntryDisplayPriceMarginAlerts { get; private set; }
        public VocabularyKey AreSalesOrderEntryStatisticsRecorded { get; private set; }
        public VocabularyKey BaseSalesPriceConversionExchangeRateTypeName { get; private set; }
        public VocabularyKey BaseSalesPriceConversionExchangeRateTypeRecId { get; private set; }
        public VocabularyKey BaseSalesPriceGenericCurrencyCode { get; private set; }
        public VocabularyKey GeneralATPBackwardDemandTimeFenceDays { get; private set; }
        public VocabularyKey GeneralATPBackwardSupplyTimeFenceDays { get; private set; }
        public VocabularyKey GeneralATPDelayedDemandOffsetDays { get; private set; }
        public VocabularyKey GeneralATPDelayedSupplyOffsetDays { get; private set; }
        public VocabularyKey GeneralATPTimeFenceDays { get; private set; }
        public VocabularyKey GeneralSalesLeadTimeDays { get; private set; }
        public VocabularyKey GeneralSalesOrderPromisingMethod { get; private set; }
        public VocabularyKey InvoicedSalesOrderMaintenanceRule { get; private set; }
        public VocabularyKey IsATPGenerallyIncludingPlannedOrders { get; private set; }
        public VocabularyKey WillBaseSalesPriceConversionApplySmartRoundingRules { get; private set; }
        public VocabularyKey IsCustomerInformationTransferBeingPrompted { get; private set; }
        public VocabularyKey WillSalesOrderDeletionVoidOrder { get; private set; }
        public VocabularyKey IsSalesOrderPromissingUsingWorkingDays { get; private set; }
        public VocabularyKey IsSalesProductListBeingPrompted { get; private set; }
        public VocabularyKey LineLevelDiscountCalculationRule { get; private set; }
        public VocabularyKey OnHoldSalesOrderDisplayedRGBColor { get; private set; }
        public VocabularyKey QuestionablePriceMarginPercentage { get; private set; }
        public VocabularyKey SalesOrderHoldCommentDocumentAttachmentTypeCode { get; private set; }
        public VocabularyKey SalesOrderLineDeliveryDateUpdateRule { get; private set; }
        public VocabularyKey TradeAgreementSearchDateType { get; private set; }
        public VocabularyKey IsSalesAgreementCustomerAccountNumberUniquenessRequired { get; private set; }
        public VocabularyKey IsSalesAgreementClassificationUniquenessRequired { get; private set; }
        public VocabularyKey IsSalesAgreementCurrencyUniquenessRequired { get; private set; }
        public VocabularyKey IsSalesAgreementDocumentTitleUniquenessRequired { get; private set; }
        public VocabularyKey IsSalesAgreementExternalDocumentReferenceUniquenessRequired { get; private set; }
        public VocabularyKey IsSalesAgreementYearUniquenessRequired { get; private set; }
        public VocabularyKey ExcisePosting { get; private set; }
        public VocabularyKey DomesticSalesTaxGroupCode { get; private set; }


    }
}