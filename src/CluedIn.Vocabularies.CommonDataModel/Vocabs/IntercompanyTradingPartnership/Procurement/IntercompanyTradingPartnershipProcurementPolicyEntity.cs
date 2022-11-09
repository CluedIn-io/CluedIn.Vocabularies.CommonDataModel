using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntercompanyTradingPartnershipProcurementPolicyEntityVocabulary : SimpleVocabulary
    {
        public IntercompanyTradingPartnershipProcurementPolicyEntityVocabulary()
        {
            VocabularyName = "Common Data Model IntercompanyTradingPartnershipProcurementPolicyEntity";
            KeyPrefix = "commonDataModel.intercompanytradingpartnershipprocurementpolicyentity";
            KeySeparator = ".";
            Grouping = "/IntercompanyTradingPartnershipProcurementPolicyEntity";

            AddGroup("Common Data Model IntercompanyTradingPartnershipProcurementPolicyEntity Details", group =>
            {
                VendorLegalEntityId = group.Add(new VocabularyKey(nameof(VendorLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDirectDeliveryOriginalSalesOrderPackingSlipAutomaticallyPrinted = group.Add(new VocabularyKey(nameof(IsDirectDeliveryOriginalSalesOrderPackingSlipAutomaticallyPrinted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDirectDeliveryOriginalSalesOrderInvoiceAutomaticallyPosted = group.Add(new VocabularyKey(nameof(IsDirectDeliveryOriginalSalesOrderInvoiceAutomaticallyPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDirectDeliveryOriginalSalesOrderInvoiceAutomaticallyPrinted = group.Add(new VocabularyKey(nameof(IsDirectDeliveryOriginalSalesOrderInvoiceAutomaticallyPrinted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDirectDeliveryIntercompanyPurchaseOrderProductReceiptAutomaticallyPrinted = group.Add(new VocabularyKey(nameof(IsDirectDeliveryIntercompanyPurchaseOrderProductReceiptAutomaticallyPrinted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDirectDeliveryIntercompanyPurchaseOrderInvoiceAutomaticallyPosted = group.Add(new VocabularyKey(nameof(IsDirectDeliveryIntercompanyPurchaseOrderInvoiceAutomaticallyPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDirectDeliveryIntercompanyPurchaseOrderInvoiceAutomaticallyPrinted = group.Add(new VocabularyKey(nameof(IsDirectDeliveryIntercompanyPurchaseOrderInvoiceAutomaticallyPrinted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FixedChargeAllocationMethod = group.Add(new VocabularyKey(nameof(FixedChargeAllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOnlyStockedProductAllocatedFixedCharge = group.Add(new VocabularyKey(nameof(IsOnlyStockedProductAllocatedFixedCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompayPurchaseOrderCreationUsingPriceDiscountSearch = group.Add(new VocabularyKey(nameof(IsIntercompayPurchaseOrderCreationUsingPriceDiscountSearch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompanyPurchaseOrderLinePriceChangeAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseOrderLinePriceChangeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompanyPurchaseOrderLineDiscountChangeAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseOrderLineDiscountChangeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOriginalSalesOrderIntercompanyPurchaseOrderCustomerReferenceSynchronized = group.Add(new VocabularyKey(nameof(IsOriginalSalesOrderIntercompanyPurchaseOrderCustomerReferenceSynchronized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOriginalSalesOrderIntercompanyPurchaseOrderRMANumberSynchronized = group.Add(new VocabularyKey(nameof(IsOriginalSalesOrderIntercompanyPurchaseOrderRMANumberSynchronized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsOriginalSalesOrderIntercompanyPurchaseOrderLinePriceDiscountSynchronized = group.Add(new VocabularyKey(nameof(IsOriginalSalesOrderIntercompanyPurchaseOrderLinePriceDiscountSynchronized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompanyPurchaseOrderIntercompanySalesOrderCustomerReferenceSynchronized = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseOrderIntercompanySalesOrderCustomerReferenceSynchronized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompanyPurchaseOrderIntercompanySalesOrderRMANumberSynchronized = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseOrderIntercompanySalesOrderRMANumberSynchronized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompanyPurchaseOrderIntercompanySalesOrderLineBatchNumberSynchronized = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseOrderIntercompanySalesOrderLineBatchNumberSynchronized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompanyPurchaseOrderIntercompanySalesOrderLineSerialNumberSynchronized = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseOrderIntercompanySalesOrderLineSerialNumberSynchronized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompanyPurchaseAgreementEffectiveOnHoldChangeAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseAgreementEffectiveOnHoldChangeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompanyPurchaseAgreementValidityPeriodChangeAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseAgreementValidityPeriodChangeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompanyPurchaseAgreementPriceChangeAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseAgreementPriceChangeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsIntercompanyPurchaseAgreementDiscountChangeAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseAgreementDiscountChangeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey VendorLegalEntityId { get; private set; }
public VocabularyKey VendorAccountNumber { get; private set; }
public VocabularyKey IsDirectDeliveryOriginalSalesOrderPackingSlipAutomaticallyPrinted { get; private set; }
public VocabularyKey IsDirectDeliveryOriginalSalesOrderInvoiceAutomaticallyPosted { get; private set; }
public VocabularyKey IsDirectDeliveryOriginalSalesOrderInvoiceAutomaticallyPrinted { get; private set; }
public VocabularyKey IsDirectDeliveryIntercompanyPurchaseOrderProductReceiptAutomaticallyPrinted { get; private set; }
public VocabularyKey IsDirectDeliveryIntercompanyPurchaseOrderInvoiceAutomaticallyPosted { get; private set; }
public VocabularyKey IsDirectDeliveryIntercompanyPurchaseOrderInvoiceAutomaticallyPrinted { get; private set; }
public VocabularyKey FixedChargeAllocationMethod { get; private set; }
public VocabularyKey IsOnlyStockedProductAllocatedFixedCharge { get; private set; }
public VocabularyKey IsIntercompayPurchaseOrderCreationUsingPriceDiscountSearch { get; private set; }
public VocabularyKey IsIntercompanyPurchaseOrderLinePriceChangeAllowed { get; private set; }
public VocabularyKey IsIntercompanyPurchaseOrderLineDiscountChangeAllowed { get; private set; }
public VocabularyKey IsOriginalSalesOrderIntercompanyPurchaseOrderCustomerReferenceSynchronized { get; private set; }
public VocabularyKey IsOriginalSalesOrderIntercompanyPurchaseOrderRMANumberSynchronized { get; private set; }
public VocabularyKey IsOriginalSalesOrderIntercompanyPurchaseOrderLinePriceDiscountSynchronized { get; private set; }
public VocabularyKey IsIntercompanyPurchaseOrderIntercompanySalesOrderCustomerReferenceSynchronized { get; private set; }
public VocabularyKey IsIntercompanyPurchaseOrderIntercompanySalesOrderRMANumberSynchronized { get; private set; }
public VocabularyKey IsIntercompanyPurchaseOrderIntercompanySalesOrderLineBatchNumberSynchronized { get; private set; }
public VocabularyKey IsIntercompanyPurchaseOrderIntercompanySalesOrderLineSerialNumberSynchronized { get; private set; }
public VocabularyKey IsIntercompanyPurchaseAgreementEffectiveOnHoldChangeAllowed { get; private set; }
public VocabularyKey IsIntercompanyPurchaseAgreementValidityPeriodChangeAllowed { get; private set; }
public VocabularyKey IsIntercompanyPurchaseAgreementPriceChangeAllowed { get; private set; }
public VocabularyKey IsIntercompanyPurchaseAgreementDiscountChangeAllowed { get; private set; }


    }
}