using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchProcurementDocumentProcessingPolicyEntityVocabulary : SimpleVocabulary
    {
        public PurchProcurementDocumentProcessingPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchProcurementDocumentProcessingPolicyEntity";
            KeyPrefix = "commonDataModel.purchprocurementdocumentprocessingpolicyentity";
            KeySeparator = ".";
            Grouping = "/PurchProcurementDocumentProcessingPolicyEntity";

            AddGroup("Common Data Model PurchProcurementDocumentProcessingPolicyEntity Details", group =>
            {
                AreThreeWayMatchedPurchaseOrderLinesDecentrallyReceivedOnly = group.Add(new VocabularyKey(nameof(AreThreeWayMatchedPurchaseOrderLinesDecentrallyReceivedOnly), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultSummaryUpdateMethod = group.Add(new VocabularyKey(nameof(DefaultSummaryUpdateMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DuplicateProductReceiptNumberValidationRule = group.Add(new VocabularyKey(nameof(DuplicateProductReceiptNumberValidationRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillDocumentProcessingAutomaticallyCalculateTotalDiscount = group.Add(new VocabularyKey(nameof(WillDocumentProcessingAutomaticallyCalculateTotalDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsInvoiceDeliveryAddressSpecific = group.Add(new VocabularyKey(nameof(IsInvoiceDeliveryAddressSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillProcumentProcessesAcceptOverdelivery = group.Add(new VocabularyKey(nameof(WillProcumentProcessesAcceptOverdelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillProductReceiptProcessAccountCharges = group.Add(new VocabularyKey(nameof(WillProductReceiptProcessAccountCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsProductReceiptDeliveryAddressSpecific = group.Add(new VocabularyKey(nameof(IsProductReceiptDeliveryAddressSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsQuantitySelectionBeingPrompted = group.Add(new VocabularyKey(nameof(IsQuantitySelectionBeingPrompted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillSalesOrderPrepaymentAutomaticallyCreateDropShipment = group.Add(new VocabularyKey(nameof(WillSalesOrderPrepaymentAutomaticallyCreateDropShipment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillProcumentProcessesAcceptUnderdelivery = group.Add(new VocabularyKey(nameof(WillProcumentProcessesAcceptUnderdelivery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumParallelDocumentProcessingBatchTaskSize = group.Add(new VocabularyKey(nameof(MaximumParallelDocumentProcessingBatchTaskSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OrderSummaryUpdateTypeDiscrepancyRule = group.Add(new VocabularyKey(nameof(OrderSummaryUpdateTypeDiscrepancyRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQAmendmentNotificationEmailTemplateId = group.Add(new VocabularyKey(nameof(RFQAmendmentNotificationEmailTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReceivedQuotationTradeAgreementJournalName = group.Add(new VocabularyKey(nameof(ReceivedQuotationTradeAgreementJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQCancellationNotificationEmailTemplateId = group.Add(new VocabularyKey(nameof(RFQCancellationNotificationEmailTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExchangeRateDateRule = group.Add(new VocabularyKey(nameof(ExchangeRateDateRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IndependentDeliveryNoteNumbering = group.Add(new VocabularyKey(nameof(IndependentDeliveryNoteNumbering), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AreThreeWayMatchedPurchaseOrderLinesDecentrallyReceivedOnly { get; private set; }
public VocabularyKey DefaultSummaryUpdateMethod { get; private set; }
public VocabularyKey DuplicateProductReceiptNumberValidationRule { get; private set; }
public VocabularyKey WillDocumentProcessingAutomaticallyCalculateTotalDiscount { get; private set; }
public VocabularyKey IsInvoiceDeliveryAddressSpecific { get; private set; }
public VocabularyKey WillProcumentProcessesAcceptOverdelivery { get; private set; }
public VocabularyKey WillProductReceiptProcessAccountCharges { get; private set; }
public VocabularyKey IsProductReceiptDeliveryAddressSpecific { get; private set; }
public VocabularyKey IsQuantitySelectionBeingPrompted { get; private set; }
public VocabularyKey WillSalesOrderPrepaymentAutomaticallyCreateDropShipment { get; private set; }
public VocabularyKey WillProcumentProcessesAcceptUnderdelivery { get; private set; }
public VocabularyKey MaximumParallelDocumentProcessingBatchTaskSize { get; private set; }
public VocabularyKey OrderSummaryUpdateTypeDiscrepancyRule { get; private set; }
public VocabularyKey RFQAmendmentNotificationEmailTemplateId { get; private set; }
public VocabularyKey ReceivedQuotationTradeAgreementJournalName { get; private set; }
public VocabularyKey RFQCancellationNotificationEmailTemplateId { get; private set; }
public VocabularyKey ExchangeRateDateRule { get; private set; }
public VocabularyKey IndependentDeliveryNoteNumbering { get; private set; }


    }
}