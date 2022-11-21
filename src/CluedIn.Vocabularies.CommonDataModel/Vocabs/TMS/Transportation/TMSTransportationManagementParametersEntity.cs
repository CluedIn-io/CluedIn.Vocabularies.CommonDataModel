using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationManagementParametersEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationManagementParametersEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Management Parameters Entity";
            KeyPrefix = "commonDataModel.tmstransportationmanagementparametersentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationManagementParametersEntity";

            AddGroup("TMSTransportationManagementParametersEntity Details", group =>
            {
                WillPurchaseOrderEntryAutomaticallyCreateLoad = group.Add(new VocabularyKey(nameof(WillPurchaseOrderEntryAutomaticallyCreateLoad), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesOrderEntryAutomaticallyCreateLoad = group.Add(new VocabularyKey(nameof(WillSalesOrderEntryAutomaticallyCreateLoad), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillTransferOrderEntryAutomaticallyCreateLoad = group.Add(new VocabularyKey(nameof(WillTransferOrderEntryAutomaticallyCreateLoad), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BOLCarrierRoleRecId = group.Add(new VocabularyKey(nameof(BOLCarrierRoleRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCarrierAppointmentDurationMinutes = group.Add(new VocabularyKey(nameof(DefaultCarrierAppointmentDurationMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultVendorInvoiceReconciliationAttachmentName = group.Add(new VocabularyKey(nameof(DefaultVendorInvoiceReconciliationAttachmentName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultVendorInvoiceReconciliationAttachmentTypeCode = group.Add(new VocabularyKey(nameof(DefaultVendorInvoiceReconciliationAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillLoadRatingApplyDirectDeliverySalesCharge = group.Add(new VocabularyKey(nameof(WillLoadRatingApplyDirectDeliverySalesCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DriverCheckoutIntervalMinutes = group.Add(new VocabularyKey(nameof(DriverCheckoutIntervalMinutes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsVendorInvoiceWorkflowEnabled = group.Add(new VocabularyKey(nameof(IsVendorInvoiceWorkflowEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightBillTransactionText = group.Add(new VocabularyKey(nameof(FreightBillTransactionText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsDynamicRoutePlanningEnabled = group.Add(new VocabularyKey(nameof(IsDynamicRoutePlanningEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoadAttachmentTypeCode = group.Add(new VocabularyKey(nameof(LoadAttachmentTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillVendorInvoiceReceiptAutomaticallyReconcileFreightBill = group.Add(new VocabularyKey(nameof(WillVendorInvoiceReceiptAutomaticallyReconcileFreightBill), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightBillReconciliationIntervalSeconds = group.Add(new VocabularyKey(nameof(FreightBillReconciliationIntervalSeconds), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillLoadPlanningShipmentConfirmationPromptForShipmentDate = group.Add(new VocabularyKey(nameof(WillLoadPlanningShipmentConfirmationPromptForShipmentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParametersKey = group.Add(new VocabularyKey(nameof(ParametersKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillShipmentsCreateLoads = group.Add(new VocabularyKey(nameof(WillShipmentsCreateLoads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PortTransportationHubTypeId = group.Add(new VocabularyKey(nameof(PortTransportationHubTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillVendorInvoiceApprovalAutomaticallyPostVendorInvoiceJournal = group.Add(new VocabularyKey(nameof(WillVendorInvoiceApprovalAutomaticallyPostVendorInvoiceJournal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceJournalName = group.Add(new VocabularyKey(nameof(VendorInvoiceJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorInvoiceWorkflowUserId = group.Add(new VocabularyKey(nameof(VendorInvoiceWorkflowUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFreightBillReconciliationEnabled = group.Add(new VocabularyKey(nameof(IsFreightBillReconciliationEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AreFreightBillsCreated = group.Add(new VocabularyKey(nameof(AreFreightBillsCreated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsMasterBillOfLadingCreatedForMultipleShipmentLoads = group.Add(new VocabularyKey(nameof(IsMasterBillOfLadingCreatedForMultipleShipmentLoads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillLoadPlanningSeparatelyPostTransferOrderShipmentConfirmations = group.Add(new VocabularyKey(nameof(WillLoadPlanningSeparatelyPostTransferOrderShipmentConfirmations), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillOfLadingThirdPartyShippingCarrierLogisticsLocationRolePurpose = group.Add(new VocabularyKey(nameof(BillOfLadingThirdPartyShippingCarrierLogisticsLocationRolePurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WillPurchaseOrderEntryAutomaticallyCreateLoad { get; private set; }
        public VocabularyKey WillSalesOrderEntryAutomaticallyCreateLoad { get; private set; }
        public VocabularyKey WillTransferOrderEntryAutomaticallyCreateLoad { get; private set; }
        public VocabularyKey BOLCarrierRoleRecId { get; private set; }
        public VocabularyKey DefaultCarrierAppointmentDurationMinutes { get; private set; }
        public VocabularyKey DefaultVendorInvoiceReconciliationAttachmentName { get; private set; }
        public VocabularyKey DefaultVendorInvoiceReconciliationAttachmentTypeCode { get; private set; }
        public VocabularyKey WillLoadRatingApplyDirectDeliverySalesCharge { get; private set; }
        public VocabularyKey DriverCheckoutIntervalMinutes { get; private set; }
        public VocabularyKey IsVendorInvoiceWorkflowEnabled { get; private set; }
        public VocabularyKey FreightBillTransactionText { get; private set; }
        public VocabularyKey IsDynamicRoutePlanningEnabled { get; private set; }
        public VocabularyKey LoadAttachmentTypeCode { get; private set; }
        public VocabularyKey WillVendorInvoiceReceiptAutomaticallyReconcileFreightBill { get; private set; }
        public VocabularyKey FreightBillReconciliationIntervalSeconds { get; private set; }
        public VocabularyKey WillLoadPlanningShipmentConfirmationPromptForShipmentDate { get; private set; }
        public VocabularyKey ParametersKey { get; private set; }
        public VocabularyKey WillShipmentsCreateLoads { get; private set; }
        public VocabularyKey PortTransportationHubTypeId { get; private set; }
        public VocabularyKey WillVendorInvoiceApprovalAutomaticallyPostVendorInvoiceJournal { get; private set; }
        public VocabularyKey VendorInvoiceJournalName { get; private set; }
        public VocabularyKey VendorInvoiceWorkflowUserId { get; private set; }
        public VocabularyKey IsFreightBillReconciliationEnabled { get; private set; }
        public VocabularyKey AreFreightBillsCreated { get; private set; }
        public VocabularyKey IsMasterBillOfLadingCreatedForMultipleShipmentLoads { get; private set; }
        public VocabularyKey WillLoadPlanningSeparatelyPostTransferOrderShipmentConfirmations { get; private set; }
        public VocabularyKey BillOfLadingThirdPartyShippingCarrierLogisticsLocationRolePurpose { get; private set; }
    }
}