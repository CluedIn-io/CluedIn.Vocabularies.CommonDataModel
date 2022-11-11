using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailTransactionEntity";
            KeyPrefix = "commonDataModel.retailtransactionentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionEntity";

            AddGroup("Common Data Model RetailTransactionEntity Details", group =>
            {
                BatchID = group.Add(new VocabularyKey(nameof(BatchID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountPostedToAccount = group.Add(new VocabularyKey(nameof(AmountPostedToAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChannelReferenceId = group.Add(new VocabularyKey(nameof(ChannelReferenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostAmount = group.Add(new VocabularyKey(nameof(CostAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOffline = group.Add(new VocabularyKey(nameof(CreatedOffline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerDiscountAmount = group.Add(new VocabularyKey(nameof(CustomerDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountAmount = group.Add(new VocabularyKey(nameof(DiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountAmountWithoutTax = group.Add(new VocabularyKey(nameof(DiscountAmountWithoutTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryMode = group.Add(new VocabularyKey(nameof(DeliveryMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionStatus = group.Add(new VocabularyKey(nameof(TransactionStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossAmount = group.Add(new VocabularyKey(nameof(GrossAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncomeExpenseAmount = group.Add(new VocabularyKey(nameof(IncomeExpenseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InfocodeDiscountGroup = group.Add(new VocabularyKey(nameof(InfocodeDiscountGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Warehouse = group.Add(new VocabularyKey(nameof(Warehouse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SiteId = group.Add(new VocabularyKey(nameof(SiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceId = group.Add(new VocabularyKey(nameof(InvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemsPosted = group.Add(new VocabularyKey(nameof(ItemsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltyCardId = group.Add(new VocabularyKey(nameof(LoyaltyCardId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetAmount = group.Add(new VocabularyKey(nameof(NetAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetPrice = group.Add(new VocabularyKey(nameof(NetPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentAmount = group.Add(new VocabularyKey(nameof(PaymentAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostAsShipment = group.Add(new VocabularyKey(nameof(PostAsShipment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RreceiptId = group.Add(new VocabularyKey(nameof(RreceiptId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefundReceiptId = group.Add(new VocabularyKey(nameof(RefundReceiptId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SaleIsReturnSale = group.Add(new VocabularyKey(nameof(SaleIsReturnSale), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesInvoiceAmount = group.Add(new VocabularyKey(nameof(SalesInvoiceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderAmount = group.Add(new VocabularyKey(nameof(SalesOrderAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderId = group.Add(new VocabularyKey(nameof(SalesOrderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPaymentDifference = group.Add(new VocabularyKey(nameof(SalesPaymentDifference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Shift = group.Add(new VocabularyKey(nameof(Shift), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingDateRequested = group.Add(new VocabularyKey(nameof(ShippingDateRequested), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Staff = group.Add(new VocabularyKey(nameof(Staff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToAccount = group.Add(new VocabularyKey(nameof(ToAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalManualDiscountAmount = group.Add(new VocabularyKey(nameof(TotalManualDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalManualDiscountPercentage = group.Add(new VocabularyKey(nameof(TotalManualDiscountPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionTime = group.Add(new VocabularyKey(nameof(TransactionTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsPostalAddressLocation = group.Add(new VocabularyKey(nameof(LogisticsPostalAddressLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsLocationId = group.Add(new VocabularyKey(nameof(LogisticsLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsPostalAddress = group.Add(new VocabularyKey(nameof(LogisticsPostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsPostalCity = group.Add(new VocabularyKey(nameof(LogisticsPostalCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsPostalCounty = group.Add(new VocabularyKey(nameof(LogisticsPostalCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsPostalState = group.Add(new VocabularyKey(nameof(LogisticsPostalState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsPostalStreet = group.Add(new VocabularyKey(nameof(LogisticsPostalStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsPostalZipCode = group.Add(new VocabularyKey(nameof(LogisticsPostalZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsPostalAddressValidFrom = group.Add(new VocabularyKey(nameof(LogisticsPostalAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticPostalAddressValidTo = group.Add(new VocabularyKey(nameof(LogisticPostalAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelTableOMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCalculationType = group.Add(new VocabularyKey(nameof(TaxCalculationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuspendedTransactionId = group.Add(new VocabularyKey(nameof(SuspendedTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardActiveFrom = group.Add(new VocabularyKey(nameof(GiftCardActiveFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardBalance = group.Add(new VocabularyKey(nameof(GiftCardBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardExpireDate = group.Add(new VocabularyKey(nameof(GiftCardExpireDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardHistoryDetails = group.Add(new VocabularyKey(nameof(GiftCardHistoryDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardIssueAmount = group.Add(new VocabularyKey(nameof(GiftCardIssueAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardIdMasked = group.Add(new VocabularyKey(nameof(GiftCardIdMasked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                businessDate = group.Add(new VocabularyKey(nameof(businessDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTaxIncludedInPrice = group.Add(new VocabularyKey(nameof(IsTaxIncludedInPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailTransactionAggregationFieldList = group.Add(new VocabularyKey(nameof(RetailTransactionAggregationFieldList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionOrderType = group.Add(new VocabularyKey(nameof(TransactionOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BeginDateTime = group.Add(new VocabularyKey(nameof(BeginDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfItemLines = group.Add(new VocabularyKey(nameof(NumberOfItemLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfItems = group.Add(new VocabularyKey(nameof(NumberOfItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfPaymentLines = group.Add(new VocabularyKey(nameof(NumberOfPaymentLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTaxExemptedForPriceInclusive = group.Add(new VocabularyKey(nameof(IsTaxExemptedForPriceInclusive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchTerminalId = group.Add(new VocabularyKey(nameof(BatchTerminalId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOnPosTerminal = group.Add(new VocabularyKey(nameof(CreatedOnPosTerminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BatchID { get; private set; }
        public VocabularyKey Terminal { get; private set; }
        public VocabularyKey AmountPostedToAccount { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey ChannelReferenceId { get; private set; }
        public VocabularyKey CostAmount { get; private set; }
        public VocabularyKey CreatedOffline { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey CustomerDiscountAmount { get; private set; }
        public VocabularyKey DiscountAmount { get; private set; }
        public VocabularyKey DiscountAmountWithoutTax { get; private set; }
        public VocabularyKey DeliveryMode { get; private set; }
        public VocabularyKey TransactionStatus { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey GrossAmount { get; private set; }
        public VocabularyKey IncomeExpenseAmount { get; private set; }
        public VocabularyKey InfocodeDiscountGroup { get; private set; }
        public VocabularyKey Warehouse { get; private set; }
        public VocabularyKey SiteId { get; private set; }
        public VocabularyKey InvoiceId { get; private set; }
        public VocabularyKey ItemsPosted { get; private set; }
        public VocabularyKey LoyaltyCardId { get; private set; }
        public VocabularyKey NetAmount { get; private set; }
        public VocabularyKey NetPrice { get; private set; }
        public VocabularyKey PaymentAmount { get; private set; }
        public VocabularyKey PostAsShipment { get; private set; }
        public VocabularyKey RreceiptId { get; private set; }
        public VocabularyKey RefundReceiptId { get; private set; }
        public VocabularyKey SaleIsReturnSale { get; private set; }
        public VocabularyKey SalesInvoiceAmount { get; private set; }
        public VocabularyKey SalesOrderAmount { get; private set; }
        public VocabularyKey SalesOrderId { get; private set; }
        public VocabularyKey SalesPaymentDifference { get; private set; }
        public VocabularyKey Shift { get; private set; }
        public VocabularyKey ShippingDateRequested { get; private set; }
        public VocabularyKey Staff { get; private set; }
        public VocabularyKey ToAccount { get; private set; }
        public VocabularyKey TotalDiscountAmount { get; private set; }
        public VocabularyKey TotalManualDiscountAmount { get; private set; }
        public VocabularyKey TotalManualDiscountPercentage { get; private set; }
        public VocabularyKey TransactionNumber { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey TransactionTime { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey LogisticsPostalAddressLocation { get; private set; }
        public VocabularyKey LogisticsLocationId { get; private set; }
        public VocabularyKey LogisticsPostalAddress { get; private set; }
        public VocabularyKey LogisticsPostalCity { get; private set; }
        public VocabularyKey LogisticsPostalCounty { get; private set; }
        public VocabularyKey LogisticsPostalState { get; private set; }
        public VocabularyKey LogisticsPostalStreet { get; private set; }
        public VocabularyKey LogisticsPostalZipCode { get; private set; }
        public VocabularyKey LogisticsPostalAddressValidFrom { get; private set; }
        public VocabularyKey LogisticPostalAddressValidTo { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }
        public VocabularyKey RetailChannelTableOMOperatingUnitID { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey TaxCalculationType { get; private set; }
        public VocabularyKey SuspendedTransactionId { get; private set; }
        public VocabularyKey GiftCardActiveFrom { get; private set; }
        public VocabularyKey GiftCardBalance { get; private set; }
        public VocabularyKey GiftCardExpireDate { get; private set; }
        public VocabularyKey GiftCardHistoryDetails { get; private set; }
        public VocabularyKey GiftCardIssueAmount { get; private set; }
        public VocabularyKey GiftCardIdMasked { get; private set; }
        public VocabularyKey businessDate { get; private set; }
        public VocabularyKey IsTaxIncludedInPrice { get; private set; }
        public VocabularyKey RetailTransactionAggregationFieldList { get; private set; }
        public VocabularyKey TransactionOrderType { get; private set; }
        public VocabularyKey BeginDateTime { get; private set; }
        public VocabularyKey NumberOfItemLines { get; private set; }
        public VocabularyKey NumberOfItems { get; private set; }
        public VocabularyKey NumberOfPaymentLines { get; private set; }
        public VocabularyKey IsTaxExemptedForPriceInclusive { get; private set; }
        public VocabularyKey BatchTerminalId { get; private set; }
        public VocabularyKey CreatedOnPosTerminal { get; private set; }


    }
}