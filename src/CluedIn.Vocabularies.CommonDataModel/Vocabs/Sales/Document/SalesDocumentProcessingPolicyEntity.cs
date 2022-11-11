using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesDocumentProcessingPolicyEntityVocabulary : SimpleVocabulary
    {
        public SalesDocumentProcessingPolicyEntityVocabulary()
        {
            VocabularyName = "SalesDocumentProcessingPolicyEntity";
            KeyPrefix = "commonDataModel.salesdocumentprocessingpolicyentity";
            KeySeparator = ".";
            Grouping = "/SalesDocumentProcessingPolicyEntity";

            AddGroup("SalesDocumentProcessingPolicyEntity Details", group =>
            {
                BillOfLadingGenerationRule = group.Add(new VocabularyKey(nameof(BillOfLadingGenerationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditNoteDateControlRule = group.Add(new VocabularyKey(nameof(CreditNoteDateControlRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditNoteDocumentDateControlRule = group.Add(new VocabularyKey(nameof(CreditNoteDocumentDateControlRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultSummaryUpdateMethod = group.Add(new VocabularyKey(nameof(DefaultSummaryUpdateMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDateControlRule = group.Add(new VocabularyKey(nameof(InvoiceDateControlRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDocumentDateControlRule = group.Add(new VocabularyKey(nameof(InvoiceDocumentDateControlRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsConfirmationDeliveryAddressSpecific = group.Add(new VocabularyKey(nameof(IsConfirmationDeliveryAddressSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInvoiceDeliveryAddressSpecific = group.Add(new VocabularyKey(nameof(IsInvoiceDeliveryAddressSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInvoiceProcessDeleteInvoicedSalesOrder = group.Add(new VocabularyKey(nameof(WillInvoiceProcessDeleteInvoicedSalesOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInvoiceProcessDeleteInvoicedSalesOrderLine = group.Add(new VocabularyKey(nameof(WillInvoiceProcessDeleteInvoicedSalesOrderLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillInvoiceProcessingAutomaticallyReduceQuantity = group.Add(new VocabularyKey(nameof(WillInvoiceProcessingAutomaticallyReduceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsInvoiceSiteSpecific = group.Add(new VocabularyKey(nameof(IsInvoiceSiteSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesProcessesAcceptOverdelivery = group.Add(new VocabularyKey(nameof(WillSalesProcessesAcceptOverdelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPackingSlipBeingAccounted = group.Add(new VocabularyKey(nameof(IsPackingSlipBeingAccounted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPackingSlipDeliveryAddressSpecific = group.Add(new VocabularyKey(nameof(IsPackingSlipDeliveryAddressSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPackingSlipProcessingAutomaticallyReduceQuantity = group.Add(new VocabularyKey(nameof(WillPackingSlipProcessingAutomaticallyReduceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingListDeliveryAddressSpecific = group.Add(new VocabularyKey(nameof(IsPickingListDeliveryAddressSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillPickingListProcessingAutomaticallyReduceQuantity = group.Add(new VocabularyKey(nameof(WillPickingListProcessingAutomaticallyReduceQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsQuantitySelectionBeingPrompted = group.Add(new VocabularyKey(nameof(IsQuantitySelectionBeingPrompted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSalesDocumentProcessingUsingSettledCustomerTransactionExchangeRate = group.Add(new VocabularyKey(nameof(IsSalesDocumentProcessingUsingSettledCustomerTransactionExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillSalesProcessesAcceptUnderdelivery = group.Add(new VocabularyKey(nameof(WillSalesProcessesAcceptUnderdelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumParallelDocumentProcessingBatchTaskSize = group.Add(new VocabularyKey(nameof(MaximumParallelDocumentProcessingBatchTaskSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderSummaryUpdateTypeDiscrepancyRule = group.Add(new VocabularyKey(nameof(OrderSummaryUpdateTypeDiscrepancyRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickingListProcessingPickingRouteStatusUpdateRule = group.Add(new VocabularyKey(nameof(PickingListProcessingPickingRouteStatusUpdateRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingSpecificationEntryRule = group.Add(new VocabularyKey(nameof(ShippingSpecificationEntryRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateDateRule = group.Add(new VocabularyKey(nameof(ExchangeRateDateRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndependentDeliveryNoteNumbering = group.Add(new VocabularyKey(nameof(IndependentDeliveryNoteNumbering), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPickingListWarehouseSpecific = group.Add(new VocabularyKey(nameof(IsPickingListWarehouseSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BillOfLadingGenerationRule { get; private set; }
        public VocabularyKey CreditNoteDateControlRule { get; private set; }
        public VocabularyKey CreditNoteDocumentDateControlRule { get; private set; }
        public VocabularyKey DefaultSummaryUpdateMethod { get; private set; }
        public VocabularyKey InvoiceDateControlRule { get; private set; }
        public VocabularyKey InvoiceDocumentDateControlRule { get; private set; }
        public VocabularyKey IsConfirmationDeliveryAddressSpecific { get; private set; }
        public VocabularyKey IsInvoiceDeliveryAddressSpecific { get; private set; }
        public VocabularyKey WillInvoiceProcessDeleteInvoicedSalesOrder { get; private set; }
        public VocabularyKey WillInvoiceProcessDeleteInvoicedSalesOrderLine { get; private set; }
        public VocabularyKey WillInvoiceProcessingAutomaticallyReduceQuantity { get; private set; }
        public VocabularyKey IsInvoiceSiteSpecific { get; private set; }
        public VocabularyKey WillSalesProcessesAcceptOverdelivery { get; private set; }
        public VocabularyKey IsPackingSlipBeingAccounted { get; private set; }
        public VocabularyKey IsPackingSlipDeliveryAddressSpecific { get; private set; }
        public VocabularyKey WillPackingSlipProcessingAutomaticallyReduceQuantity { get; private set; }
        public VocabularyKey IsPickingListDeliveryAddressSpecific { get; private set; }
        public VocabularyKey WillPickingListProcessingAutomaticallyReduceQuantity { get; private set; }
        public VocabularyKey IsQuantitySelectionBeingPrompted { get; private set; }
        public VocabularyKey IsSalesDocumentProcessingUsingSettledCustomerTransactionExchangeRate { get; private set; }
        public VocabularyKey WillSalesProcessesAcceptUnderdelivery { get; private set; }
        public VocabularyKey MaximumParallelDocumentProcessingBatchTaskSize { get; private set; }
        public VocabularyKey OrderSummaryUpdateTypeDiscrepancyRule { get; private set; }
        public VocabularyKey PickingListProcessingPickingRouteStatusUpdateRule { get; private set; }
        public VocabularyKey ShippingSpecificationEntryRule { get; private set; }
        public VocabularyKey ExchangeRateDateRule { get; private set; }
        public VocabularyKey IndependentDeliveryNoteNumbering { get; private set; }
        public VocabularyKey IsPickingListWarehouseSpecific { get; private set; }


    }
}