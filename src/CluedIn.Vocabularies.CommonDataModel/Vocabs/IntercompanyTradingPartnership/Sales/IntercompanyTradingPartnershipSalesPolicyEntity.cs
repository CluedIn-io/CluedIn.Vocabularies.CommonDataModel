using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class IntercompanyTradingPartnershipSalesPolicyEntityVocabulary : SimpleVocabulary
    {
        public IntercompanyTradingPartnershipSalesPolicyEntityVocabulary()
        {
            VocabularyName = "IntercompanyTradingPartnershipSalesPolicyEntity";
            KeyPrefix = "commonDataModel.intercompanytradingpartnershipsalespolicyentity";
            KeySeparator = ".";
            Grouping = "/IntercompanyTradingPartnershipSalesPolicyEntity";

            AddGroup("IntercompanyTradingPartnershipSalesPolicyEntity Details", group =>
            {
                CustomerLegalEntityId = group.Add(new VocabularyKey(nameof(CustomerLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntercompanySalesOrderNumberingMethod = group.Add(new VocabularyKey(nameof(IntercompanySalesOrderNumberingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntercompanySalesOrderNumberSequenceCode = group.Add(new VocabularyKey(nameof(IntercompanySalesOrderNumberSequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanySalesOrderOriginalCustomerSummaryUpdateAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanySalesOrderOriginalCustomerSummaryUpdateAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanySalesOrderPickinglistAutomaticallyPrinted = group.Add(new VocabularyKey(nameof(IsIntercompanySalesOrderPickinglistAutomaticallyPrinted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntercompanyVendorPaymentJournalNameId = group.Add(new VocabularyKey(nameof(IntercompanyVendorPaymentJournalNameId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanyVendorPaymentJournalAutomaticallyPosted = group.Add(new VocabularyKey(nameof(IsIntercompanyVendorPaymentJournalAutomaticallyPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanySalesOrderLineUnitPriceEqualCostPriceWhenInvoicePosting = group.Add(new VocabularyKey(nameof(IsIntercompanySalesOrderLineUnitPriceEqualCostPriceWhenInvoicePosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOriginalSalesOrderInvoicePostingAllowedWithUnpostedIntercompanySalesOrder = group.Add(new VocabularyKey(nameof(IsOriginalSalesOrderInvoicePostingAllowedWithUnpostedIntercompanySalesOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompaySalesOrderCreationUsingPriceDiscountSearch = group.Add(new VocabularyKey(nameof(IsIntercompaySalesOrderCreationUsingPriceDiscountSearch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanySalesOrderLinePriceChangeAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanySalesOrderLinePriceChangeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanySalesOrderLineDiscountChangeAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanySalesOrderLineDiscountChangeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanyPurchaseOrderIntercompanySalesOrderCustomerReferenceSynchronized = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseOrderIntercompanySalesOrderCustomerReferenceSynchronized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanyPurchaseOrderIntercompanySalesOrderRMANumberSynchronized = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseOrderIntercompanySalesOrderRMANumberSynchronized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanyPurchaseOrderIntercompanySalesOrderLineBatchNumberSynchronized = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseOrderIntercompanySalesOrderLineBatchNumberSynchronized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanyPurchaseOrderIntercompanySalesOrderLineSerialNumberSynchronized = group.Add(new VocabularyKey(nameof(IsIntercompanyPurchaseOrderIntercompanySalesOrderLineSerialNumberSynchronized), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanySalesAgreementEffectiveOnHoldChangeAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanySalesAgreementEffectiveOnHoldChangeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanySalesAgreementValidityPeriodChangeAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanySalesAgreementValidityPeriodChangeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanySalesAgreementPriceChangeAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanySalesAgreementPriceChangeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsIntercompanySalesAgreementDiscountChangeAllowed = group.Add(new VocabularyKey(nameof(IsIntercompanySalesAgreementDiscountChangeAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustomerLegalEntityId { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey IntercompanySalesOrderNumberingMethod { get; private set; }
        public VocabularyKey IntercompanySalesOrderNumberSequenceCode { get; private set; }
        public VocabularyKey IsIntercompanySalesOrderOriginalCustomerSummaryUpdateAllowed { get; private set; }
        public VocabularyKey IsIntercompanySalesOrderPickinglistAutomaticallyPrinted { get; private set; }
        public VocabularyKey IntercompanyVendorPaymentJournalNameId { get; private set; }
        public VocabularyKey IsIntercompanyVendorPaymentJournalAutomaticallyPosted { get; private set; }
        public VocabularyKey IsIntercompanySalesOrderLineUnitPriceEqualCostPriceWhenInvoicePosting { get; private set; }
        public VocabularyKey IsOriginalSalesOrderInvoicePostingAllowedWithUnpostedIntercompanySalesOrder { get; private set; }
        public VocabularyKey IsIntercompaySalesOrderCreationUsingPriceDiscountSearch { get; private set; }
        public VocabularyKey IsIntercompanySalesOrderLinePriceChangeAllowed { get; private set; }
        public VocabularyKey IsIntercompanySalesOrderLineDiscountChangeAllowed { get; private set; }
        public VocabularyKey IsIntercompanyPurchaseOrderIntercompanySalesOrderCustomerReferenceSynchronized { get; private set; }
        public VocabularyKey IsIntercompanyPurchaseOrderIntercompanySalesOrderRMANumberSynchronized { get; private set; }
        public VocabularyKey IsIntercompanyPurchaseOrderIntercompanySalesOrderLineBatchNumberSynchronized { get; private set; }
        public VocabularyKey IsIntercompanyPurchaseOrderIntercompanySalesOrderLineSerialNumberSynchronized { get; private set; }
        public VocabularyKey IsIntercompanySalesAgreementEffectiveOnHoldChangeAllowed { get; private set; }
        public VocabularyKey IsIntercompanySalesAgreementValidityPeriodChangeAllowed { get; private set; }
        public VocabularyKey IsIntercompanySalesAgreementPriceChangeAllowed { get; private set; }
        public VocabularyKey IsIntercompanySalesAgreementDiscountChangeAllowed { get; private set; }


    }
}