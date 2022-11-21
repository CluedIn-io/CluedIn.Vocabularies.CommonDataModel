using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailPosBatch2EntityVocabulary : SimpleVocabulary
    {
        public RetailPosBatch2EntityVocabulary()
        {
            VocabularyName = "Retail Pos Batch 2 Entity";
            KeyPrefix = "commonDataModel.retailposbatch2entity";
            KeySeparator = ".";
            Grouping = "/RetailPosBatch2Entity";

            AddGroup("RetailPosBatch2Entity Details", group =>
            {
                Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BatchShiftId = group.Add(new VocabularyKey(nameof(BatchShiftId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CloseDate = group.Add(new VocabularyKey(nameof(CloseDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CloseDateTimeUtc = group.Add(new VocabularyKey(nameof(CloseDateTimeUtc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClosedAtRegisterNumber = group.Add(new VocabularyKey(nameof(ClosedAtRegisterNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CloseTime = group.Add(new VocabularyKey(nameof(CloseTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerSalesCount = group.Add(new VocabularyKey(nameof(CustomerSalesCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountTotalAmount = group.Add(new VocabularyKey(nameof(DiscountTotalAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogonsCount = group.Add(new VocabularyKey(nameof(LogonsCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NoSaleCount = group.Add(new VocabularyKey(nameof(NoSaleCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationNumber = group.Add(new VocabularyKey(nameof(LocationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaidToAccountTotal = group.Add(new VocabularyKey(nameof(PaidToAccountTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Posted = group.Add(new VocabularyKey(nameof(Posted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplicationCounter = group.Add(new VocabularyKey(nameof(ReplicationCounter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnsTotal = group.Add(new VocabularyKey(nameof(ReturnsTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundedAmountTotal = group.Add(new VocabularyKey(nameof(RoundedAmountTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesCount = group.Add(new VocabularyKey(nameof(SalesCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTotal = group.Add(new VocabularyKey(nameof(SalesTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatorId = group.Add(new VocabularyKey(nameof(OperatorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDateTimeUtc = group.Add(new VocabularyKey(nameof(StartDateTimeUtc), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartTime = group.Add(new VocabularyKey(nameof(StartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementId = group.Add(new VocabularyKey(nameof(StatementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationUnitNumber = group.Add(new VocabularyKey(nameof(OperationUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxTotal = group.Add(new VocabularyKey(nameof(TaxTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionsCount = group.Add(new VocabularyKey(nameof(TransactionsCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoidsCount = group.Add(new VocabularyKey(nameof(VoidsCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemsSold = group.Add(new VocabularyKey(nameof(ItemsSold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceOverrideTotal = group.Add(new VocabularyKey(nameof(PriceOverrideTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptCopiesCount = group.Add(new VocabularyKey(nameof(ReceiptCopiesCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptCopiesTotal = group.Add(new VocabularyKey(nameof(ReceiptCopiesTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnsCount = group.Add(new VocabularyKey(nameof(ReturnsCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnsGrandTotal = group.Add(new VocabularyKey(nameof(ReturnsGrandTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesGrandTotal = group.Add(new VocabularyKey(nameof(SalesGrandTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServicesSoldQuantity = group.Add(new VocabularyKey(nameof(ServicesSoldQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuspendedCount = group.Add(new VocabularyKey(nameof(SuspendedCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuspendedTotal = group.Add(new VocabularyKey(nameof(SuspendedTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrainingCount = group.Add(new VocabularyKey(nameof(TrainingCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TrainingTotal = group.Add(new VocabularyKey(nameof(TrainingTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelTable_OMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTable_OMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationPartyNumber = group.Add(new VocabularyKey(nameof(OrganizationPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardsTotal = group.Add(new VocabularyKey(nameof(GiftCardsTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VoidedSalesTotal = group.Add(new VocabularyKey(nameof(VoidedSalesTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShiftReturnsTotal = group.Add(new VocabularyKey(nameof(ShiftReturnsTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShiftSalesTotal = group.Add(new VocabularyKey(nameof(ShiftSalesTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardCashOutTotal = group.Add(new VocabularyKey(nameof(GiftCardCashOutTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeTotal = group.Add(new VocabularyKey(nameof(ChargeTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZeroSalesCount = group.Add(new VocabularyKey(nameof(ZeroSalesCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Terminal { get; private set; }
        public VocabularyKey BatchShiftId { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey CloseDate { get; private set; }
        public VocabularyKey CloseDateTimeUtc { get; private set; }
        public VocabularyKey ClosedAtRegisterNumber { get; private set; }
        public VocabularyKey CloseTime { get; private set; }
        public VocabularyKey CustomerSalesCount { get; private set; }
        public VocabularyKey DiscountTotalAmount { get; private set; }
        public VocabularyKey LogonsCount { get; private set; }
        public VocabularyKey NoSaleCount { get; private set; }
        public VocabularyKey LocationNumber { get; private set; }
        public VocabularyKey PaidToAccountTotal { get; private set; }
        public VocabularyKey Posted { get; private set; }
        public VocabularyKey ReplicationCounter { get; private set; }
        public VocabularyKey ReturnsTotal { get; private set; }
        public VocabularyKey RoundedAmountTotal { get; private set; }
        public VocabularyKey SalesCount { get; private set; }
        public VocabularyKey SalesTotal { get; private set; }
        public VocabularyKey OperatorId { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StartDateTimeUtc { get; private set; }
        public VocabularyKey StartTime { get; private set; }
        public VocabularyKey StatementId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey OperationUnitNumber { get; private set; }
        public VocabularyKey TaxTotal { get; private set; }
        public VocabularyKey TransactionsCount { get; private set; }
        public VocabularyKey VoidsCount { get; private set; }
        public VocabularyKey ItemsSold { get; private set; }
        public VocabularyKey PriceOverrideTotal { get; private set; }
        public VocabularyKey ReceiptCopiesCount { get; private set; }
        public VocabularyKey ReceiptCopiesTotal { get; private set; }
        public VocabularyKey ReturnsCount { get; private set; }
        public VocabularyKey ReturnsGrandTotal { get; private set; }
        public VocabularyKey SalesGrandTotal { get; private set; }
        public VocabularyKey ServicesSoldQuantity { get; private set; }
        public VocabularyKey SuspendedCount { get; private set; }
        public VocabularyKey SuspendedTotal { get; private set; }
        public VocabularyKey TrainingCount { get; private set; }
        public VocabularyKey TrainingTotal { get; private set; }
        public VocabularyKey RetailChannelTable_OMOperatingUnitID { get; private set; }
        public VocabularyKey OrganizationPartyNumber { get; private set; }
        public VocabularyKey StoreNumber { get; private set; }
        public VocabularyKey GiftCardsTotal { get; private set; }
        public VocabularyKey VoidedSalesTotal { get; private set; }
        public VocabularyKey ShiftReturnsTotal { get; private set; }
        public VocabularyKey ShiftSalesTotal { get; private set; }
        public VocabularyKey GiftCardCashOutTotal { get; private set; }
        public VocabularyKey ChargeTotal { get; private set; }
        public VocabularyKey ZeroSalesCount { get; private set; }
    }
}