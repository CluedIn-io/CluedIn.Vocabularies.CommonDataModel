using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesDocumentEventTrackingSetupEntityVocabulary : SimpleVocabulary
    {
        public SalesDocumentEventTrackingSetupEntityVocabulary()
        {
            VocabularyName = "SalesDocumentEventTrackingSetupEntity";
            KeyPrefix = "commonDataModel.salesdocumenteventtrackingsetupentity";
            KeySeparator = ".";
            Grouping = "/SalesDocumentEventTrackingSetupEntity";

            AddGroup("SalesDocumentEventTrackingSetupEntity Details", group =>
            {
                AreFraudHoldAdditionsLogged = group.Add(new VocabularyKey(nameof(AreFraudHoldAdditionsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderHoldAdditionsLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderHoldAdditionsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsAlternateItemUsageLogged = group.Add(new VocabularyKey(nameof(IsAlternateItemUsageLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreDropShipmentOrderCancellationsLogged = group.Add(new VocabularyKey(nameof(AreDropShipmentOrderCancellationsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderHeaderCancellationsLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderHeaderCancellationsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderLineCancellationsLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderLineCancellationsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCheckHoldOnCustomerThresholdAmountLogged = group.Add(new VocabularyKey(nameof(IsCheckHoldOnCustomerThresholdAmountLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreDropShipmentOrderCreationsLogged = group.Add(new VocabularyKey(nameof(AreDropShipmentOrderCreationsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderCreationsLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderCreationsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderDeletionsLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderDeletionsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDropShipmentOrderDeliveryLogged = group.Add(new VocabularyKey(nameof(IsDropShipmentOrderDeliveryLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderLineExpeditionsLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderLineExpeditionsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderHeaderExpeditionsLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderHeaderExpeditionsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesDocumentEventTrackingStartDate = group.Add(new VocabularyKey(nameof(SalesDocumentEventTrackingStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreExemptionsLogged = group.Add(new VocabularyKey(nameof(AreExemptionsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderHeaderChargeOverridesLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderHeaderChargeOverridesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderLineChargeOverridesLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderLineChargeOverridesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreReturnOrderModificationsLogged = group.Add(new VocabularyKey(nameof(AreReturnOrderModificationsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderModificationsLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderModificationsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesLineDeliveryAddressModificationsLogged = group.Add(new VocabularyKey(nameof(AreSalesLineDeliveryAddressModificationsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderHoldModificationsLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderHoldModificationsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderCreditTracksLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderCreditTracksLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesOrderExceededCreditLimitLogged = group.Add(new VocabularyKey(nameof(IsSalesOrderExceededCreditLimitLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesOrderOverpaidOrUnderpaidLogged = group.Add(new VocabularyKey(nameof(IsSalesOrderOverpaidOrUnderpaidLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesLinesPriceMatchLogged = group.Add(new VocabularyKey(nameof(AreSalesLinesPriceMatchLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesLinePriceOverridesLogged = group.Add(new VocabularyKey(nameof(AreSalesLinePriceOverridesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreDropShipmentOrderReleasesLogged = group.Add(new VocabularyKey(nameof(AreDropShipmentOrderReleasesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreFraudHoldRemovalsLogged = group.Add(new VocabularyKey(nameof(AreFraudHoldRemovalsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesOrderHoldRemovalsLogged = group.Add(new VocabularyKey(nameof(AreSalesOrderHoldRemovalsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreReturnOrderCreationsLogged = group.Add(new VocabularyKey(nameof(AreReturnOrderCreationsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesQuotationLinePriceOverridesLogged = group.Add(new VocabularyKey(nameof(AreSalesQuotationLinePriceOverridesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesQuotationHeaderPriceOverridesLogged = group.Add(new VocabularyKey(nameof(AreSalesQuotationHeaderPriceOverridesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreSalesHeaderPriceOverridesLogged = group.Add(new VocabularyKey(nameof(AreSalesHeaderPriceOverridesLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesDocumentEventTrackingEndDate = group.Add(new VocabularyKey(nameof(SalesDocumentEventTrackingEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserCode = group.Add(new VocabularyKey(nameof(UserCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserRelation = group.Add(new VocabularyKey(nameof(UserRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreRequestedReceiptOrShipDateModificationsLogged = group.Add(new VocabularyKey(nameof(AreRequestedReceiptOrShipDateModificationsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreConfirmedReceiptOrShipDateModificationsLogged = group.Add(new VocabularyKey(nameof(AreConfirmedReceiptOrShipDateModificationsLogged), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserId = group.Add(new VocabularyKey(nameof(UserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserGroupId = group.Add(new VocabularyKey(nameof(UserGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AreFraudHoldAdditionsLogged { get; private set; }
        public VocabularyKey AreSalesOrderHoldAdditionsLogged { get; private set; }
        public VocabularyKey IsAlternateItemUsageLogged { get; private set; }
        public VocabularyKey AreDropShipmentOrderCancellationsLogged { get; private set; }
        public VocabularyKey AreSalesOrderHeaderCancellationsLogged { get; private set; }
        public VocabularyKey AreSalesOrderLineCancellationsLogged { get; private set; }
        public VocabularyKey IsCheckHoldOnCustomerThresholdAmountLogged { get; private set; }
        public VocabularyKey AreDropShipmentOrderCreationsLogged { get; private set; }
        public VocabularyKey AreSalesOrderCreationsLogged { get; private set; }
        public VocabularyKey AreSalesOrderDeletionsLogged { get; private set; }
        public VocabularyKey IsDropShipmentOrderDeliveryLogged { get; private set; }
        public VocabularyKey AreSalesOrderLineExpeditionsLogged { get; private set; }
        public VocabularyKey AreSalesOrderHeaderExpeditionsLogged { get; private set; }
        public VocabularyKey SalesDocumentEventTrackingStartDate { get; private set; }
        public VocabularyKey AreExemptionsLogged { get; private set; }
        public VocabularyKey AreSalesOrderHeaderChargeOverridesLogged { get; private set; }
        public VocabularyKey AreSalesOrderLineChargeOverridesLogged { get; private set; }
        public VocabularyKey AreReturnOrderModificationsLogged { get; private set; }
        public VocabularyKey AreSalesOrderModificationsLogged { get; private set; }
        public VocabularyKey AreSalesLineDeliveryAddressModificationsLogged { get; private set; }
        public VocabularyKey AreSalesOrderHoldModificationsLogged { get; private set; }
        public VocabularyKey AreSalesOrderCreditTracksLogged { get; private set; }
        public VocabularyKey IsSalesOrderExceededCreditLimitLogged { get; private set; }
        public VocabularyKey IsSalesOrderOverpaidOrUnderpaidLogged { get; private set; }
        public VocabularyKey AreSalesLinesPriceMatchLogged { get; private set; }
        public VocabularyKey AreSalesLinePriceOverridesLogged { get; private set; }
        public VocabularyKey AreDropShipmentOrderReleasesLogged { get; private set; }
        public VocabularyKey AreFraudHoldRemovalsLogged { get; private set; }
        public VocabularyKey AreSalesOrderHoldRemovalsLogged { get; private set; }
        public VocabularyKey AreReturnOrderCreationsLogged { get; private set; }
        public VocabularyKey AreSalesQuotationLinePriceOverridesLogged { get; private set; }
        public VocabularyKey AreSalesQuotationHeaderPriceOverridesLogged { get; private set; }
        public VocabularyKey AreSalesHeaderPriceOverridesLogged { get; private set; }
        public VocabularyKey SalesDocumentEventTrackingEndDate { get; private set; }
        public VocabularyKey UserCode { get; private set; }
        public VocabularyKey UserRelation { get; private set; }
        public VocabularyKey AreRequestedReceiptOrShipDateModificationsLogged { get; private set; }
        public VocabularyKey AreConfirmedReceiptOrShipDateModificationsLogged { get; private set; }
        public VocabularyKey UserId { get; private set; }
        public VocabularyKey UserGroupId { get; private set; }


    }
}