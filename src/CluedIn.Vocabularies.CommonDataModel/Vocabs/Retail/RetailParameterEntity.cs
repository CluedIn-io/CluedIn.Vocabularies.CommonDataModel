using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailParameterEntityVocabulary : SimpleVocabulary
    {
        public RetailParameterEntityVocabulary()
        {
            VocabularyName = "Retail Parameter Entity";
            KeyPrefix = "commonDataModel.retailparameterentity";
            KeySeparator = ".";
            Grouping = "/RetailParameterEntity";

            AddGroup("RetailParameterEntity Details", group =>
            {
                PrePaymentLedgerJournalName = group.Add(new VocabularyKey(nameof(PrePaymentLedgerJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixAndMatchActivityType = group.Add(new VocabularyKey(nameof(MixAndMatchActivityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountExportProfile = group.Add(new VocabularyKey(nameof(AccountExportProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AggregateBeforePosting = group.Add(new VocabularyKey(nameof(AggregateBeforePosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AutoSettle = group.Add(new VocabularyKey(nameof(AutoSettle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BuyersPushRespectAssortments = group.Add(new VocabularyKey(nameof(BuyersPushRespectAssortments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CancellationCharge = group.Add(new VocabularyKey(nameof(CancellationCharge), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CancellationChargeCode = group.Add(new VocabularyKey(nameof(CancellationChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CrossDockingRespectAssortments = group.Add(new VocabularyKey(nameof(CrossDockingRespectAssortments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCustomerPosting = group.Add(new VocabularyKey(nameof(DefaultCustomerPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultInventoryJournalName = group.Add(new VocabularyKey(nameof(DefaultInventoryJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultJournalName4CategoryPrice = group.Add(new VocabularyKey(nameof(DefaultJournalName4CategoryPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultOrdertype = group.Add(new VocabularyKey(nameof(DefaultOrdertype), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultRCashJournalName = group.Add(new VocabularyKey(nameof(DefaultRCashJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DetailSummary = group.Add(new VocabularyKey(nameof(DetailSummary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountAccountLedgerDimension = group.Add(new VocabularyKey(nameof(DiscountAccountLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountOfferActivityType = group.Add(new VocabularyKey(nameof(DiscountOfferActivityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EANLicenseNo = group.Add(new VocabularyKey(nameof(EANLicenseNo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicDeliveryModeCode = group.Add(new VocabularyKey(nameof(ElectronicDeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventNotificationProfileId = group.Add(new VocabularyKey(nameof(EventNotificationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardCompany = group.Add(new VocabularyKey(nameof(GiftCardCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftcardItem = group.Add(new VocabularyKey(nameof(GiftcardItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardLedgerJournalName = group.Add(new VocabularyKey(nameof(GiftCardLedgerJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLocationIdForInventory = group.Add(new VocabularyKey(nameof(InventoryLocationIdForInventory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLocationIdForPurchaseOrder = group.Add(new VocabularyKey(nameof(InventoryLocationIdForPurchaseOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLocationIdForSalesOrder = group.Add(new VocabularyKey(nameof(InventoryLocationIdForSalesOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemLabelLastAction = group.Add(new VocabularyKey(nameof(ItemLabelLastAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemLabelsForNegativeStock = group.Add(new VocabularyKey(nameof(ItemLabelsForNegativeStock), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemSalesStatisticsOn = group.Add(new VocabularyKey(nameof(ItemSalesStatisticsOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                JournalNameForKitPricing = group.Add(new VocabularyKey(nameof(JournalNameForKitPricing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerAccountType = group.Add(new VocabularyKey(nameof(LedgerAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxSalesOrdersPerTask = group.Add(new VocabularyKey(nameof(MaxSalesOrdersPerTask), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CallCenterGiftCardVoidJournalName = group.Add(new VocabularyKey(nameof(CallCenterGiftCardVoidJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumDepositForSalesOrder = group.Add(new VocabularyKey(nameof(MinimumDepositForSalesOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumPasswordLength = group.Add(new VocabularyKey(nameof(MinimumPasswordLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixMatchLedgerDimension = group.Add(new VocabularyKey(nameof(MixMatchLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultibuyActivityType = group.Add(new VocabularyKey(nameof(MultibuyActivityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultiBuyLedgerDimension = group.Add(new VocabularyKey(nameof(MultiBuyLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferLedgerDimension = group.Add(new VocabularyKey(nameof(OfferLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverrideSystemLookup = group.Add(new VocabularyKey(nameof(OverrideSystemLookup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParallelSalesOrderPosting = group.Add(new VocabularyKey(nameof(ParallelSalesOrderPosting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Payment = group.Add(new VocabularyKey(nameof(Payment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentStatistics = group.Add(new VocabularyKey(nameof(PaymentStatistics), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentMode = group.Add(new VocabularyKey(nameof(PaymentMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PickUpDeliveryModeCode = group.Add(new VocabularyKey(nameof(PickUpDeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostBankedSum = group.Add(new VocabularyKey(nameof(PostBankedSum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostCustomerDiscount = group.Add(new VocabularyKey(nameof(PostCustomerDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostInfocodeDiscount = group.Add(new VocabularyKey(nameof(PostInfocodeDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostLineDiscount = group.Add(new VocabularyKey(nameof(PostLineDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostPeriodicDiscount = group.Add(new VocabularyKey(nameof(PostPeriodicDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostSafeSum = group.Add(new VocabularyKey(nameof(PostSafeSum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostSalesOrderWhenPaid = group.Add(new VocabularyKey(nameof(PostSalesOrderWhenPaid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostTotalDiscount = group.Add(new VocabularyKey(nameof(PostTotalDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrepaymentLedgerDimension = group.Add(new VocabularyKey(nameof(PrepaymentLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptEmailFilename = group.Add(new VocabularyKey(nameof(ReceiptEmailFilename), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptEmailSubject = group.Add(new VocabularyKey(nameof(ReceiptEmailSubject), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptEmailText = group.Add(new VocabularyKey(nameof(ReceiptEmailText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptOption = group.Add(new VocabularyKey(nameof(ReceiptOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentAssortmentsCoverageDays = group.Add(new VocabularyKey(nameof(ReplenishmentAssortmentsCoverageDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireNumericCharacter = group.Add(new VocabularyKey(nameof(RequireNumericCharacter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireSpecialCharacter = group.Add(new VocabularyKey(nameof(RequireSpecialCharacter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequireUppercase = group.Add(new VocabularyKey(nameof(RequireUppercase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnDispositionCodeId = group.Add(new VocabularyKey(nameof(ReturnDispositionCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShelfLabelLastAction = group.Add(new VocabularyKey(nameof(ShelfLabelLastAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingChargeCode = group.Add(new VocabularyKey(nameof(ShippingChargeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StaffStatistics = group.Add(new VocabularyKey(nameof(StaffStatistics), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemInUse = group.Add(new VocabularyKey(nameof(SystemInUse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TerminalStatistics = group.Add(new VocabularyKey(nameof(TerminalStatistics), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThresholdLedgerDimension = group.Add(new VocabularyKey(nameof(ThresholdLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountLedgerDimension = group.Add(new VocabularyKey(nameof(TotalDiscountLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseDefaultLedgerAccount = group.Add(new VocabularyKey(nameof(UseDefaultLedgerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseDefaultTradeDates = group.Add(new VocabularyKey(nameof(UseDefaultTradeDates), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseRetailReturnTaxGroup = group.Add(new VocabularyKey(nameof(UseRetailReturnTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WishListInvitationEmailId = group.Add(new VocabularyKey(nameof(WishListInvitationEmailId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardClosingLedgerDimension = group.Add(new VocabularyKey(nameof(GiftCardClosingLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemLabelSetupMissingAction = group.Add(new VocabularyKey(nameof(ItemLabelSetupMissingAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseGiftCardPolicies = group.Add(new VocabularyKey(nameof(UseGiftCardPolicies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SmallBusinessAccountExportProfileName = group.Add(new VocabularyKey(nameof(SmallBusinessAccountExportProfileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DiscountAccountLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DiscountAccountLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MixMatchLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(MixMatchLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MultiBuyLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(MultiBuyLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfferLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(OfferLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrepaymentLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(PrepaymentLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThresholdLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(ThresholdLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(TotalDiscountLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardClosingLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(GiftCardClosingLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PasswordExpiryInterval = group.Add(new VocabularyKey(nameof(PasswordExpiryInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PasswordExpiryNotificationThreshold = group.Add(new VocabularyKey(nameof(PasswordExpiryNotificationThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LockoutDuration = group.Add(new VocabularyKey(nameof(LockoutDuration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LockoutThreshold = group.Add(new VocabularyKey(nameof(LockoutThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoginCounterResetDuration = group.Add(new VocabularyKey(nameof(LoginCounterResetDuration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAttributeGroup = group.Add(new VocabularyKey(nameof(CustomerAttributeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAttributeGroupName = group.Add(new VocabularyKey(nameof(CustomerAttributeGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplyDiscountsToPriceKeyedIn = group.Add(new VocabularyKey(nameof(ApplyDiscountsToPriceKeyedIn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApplyDiscountsToPriceOverrides = group.Add(new VocabularyKey(nameof(ApplyDiscountsToPriceOverrides), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CouponBarcodeSetupId = group.Add(new VocabularyKey(nameof(CouponBarcodeSetupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowExchangeOnReturnOrders = group.Add(new VocabularyKey(nameof(AllowExchangeOnReturnOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowConcludeGiftCardTransactionsWhenOffline = group.Add(new VocabularyKey(nameof(AllowConcludeGiftCardTransactionsWhenOffline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCustomerPaymentJournalName = group.Add(new VocabularyKey(nameof(DefaultCustomerPaymentJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLedgerJournalName = group.Add(new VocabularyKey(nameof(DefaultLedgerJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AggregateCustomerPayments = group.Add(new VocabularyKey(nameof(AggregateCustomerPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AggregateIncomeExpenseTransactions = group.Add(new VocabularyKey(nameof(AggregateIncomeExpenseTransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AggregateSalesAndReturns = group.Add(new VocabularyKey(nameof(AggregateSalesAndReturns), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AggregateTenderRemoveAndFloat = group.Add(new VocabularyKey(nameof(AggregateTenderRemoveAndFloat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxOnGiftCards = group.Add(new VocabularyKey(nameof(TaxOnGiftCards), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseAdvanceInvoice = group.Add(new VocabularyKey(nameof(UseAdvanceInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCalculationBehavior = group.Add(new VocabularyKey(nameof(TaxCalculationBehavior), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxNumberOfStatementsPostInParallel = group.Add(new VocabularyKey(nameof(MaxNumberOfStatementsPostInParallel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxNumberOfThreadsCustomerOrder = group.Add(new VocabularyKey(nameof(MaxNumberOfThreadsCustomerOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AggregatedTransactionsBundleSize = group.Add(new VocabularyKey(nameof(AggregatedTransactionsBundleSize), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseAdvancedAutoCharges = group.Add(new VocabularyKey(nameof(UseAdvancedAutoCharges), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiftCardInquiryPrintHistoryCount = group.Add(new VocabularyKey(nameof(GiftCardInquiryPrintHistoryCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableReturnsForMultipleOrderInvoices = group.Add(new VocabularyKey(nameof(EnableReturnsForMultipleOrderInvoices), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecalculateDimensionsOnPostingError = group.Add(new VocabularyKey(nameof(RecalculateDimensionsOnPostingError), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargeOverrideReasonCode = group.Add(new VocabularyKey(nameof(ChargeOverrideReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostPeriodicDiscountForOrders = group.Add(new VocabularyKey(nameof(PostPeriodicDiscountForOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoNotAggregateReturns = group.Add(new VocabularyKey(nameof(DoNotAggregateReturns), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseRTSForOnlineOrderCreation = group.Add(new VocabularyKey(nameof(UseRTSForOnlineOrderCreation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseFinancialDimensionFromReturnStore = group.Add(new VocabularyKey(nameof(UseFinancialDimensionFromReturnStore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseSessionDateForCalculatingPricesAndDiscounts = group.Add(new VocabularyKey(nameof(UseSessionDateForCalculatingPricesAndDiscounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBatchIdOnSaleForCashAndCarrySales = group.Add(new VocabularyKey(nameof(DefaultBatchIdOnSaleForCashAndCarrySales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultBatchIdOnSaleForCustomerOrder = group.Add(new VocabularyKey(nameof(DefaultBatchIdOnSaleForCustomerOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseDefaultBatchIdOnSaleForCashAndCarrySales = group.Add(new VocabularyKey(nameof(UseDefaultBatchIdOnSaleForCashAndCarrySales), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseDefaultBatchIdOnSaleForCustomerOrder = group.Add(new VocabularyKey(nameof(UseDefaultBatchIdOnSaleForCustomerOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IgnoreReturnLink = group.Add(new VocabularyKey(nameof(IgnoreReturnLink), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClientBookAttributeGroup = group.Add(new VocabularyKey(nameof(ClientBookAttributeGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisablePostRoundingDifference = group.Add(new VocabularyKey(nameof(DisablePostRoundingDifference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowOnlyCarrierOptionsForShipOrders = group.Add(new VocabularyKey(nameof(ShowOnlyCarrierOptionsForShipOrders), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AsyncOrdersEditHoldCode = group.Add(new VocabularyKey(nameof(AsyncOrdersEditHoldCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableChannelReturnPolicies = group.Add(new VocabularyKey(nameof(EnableChannelReturnPolicies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StmtAutoSettleCustomerDeposit = group.Add(new VocabularyKey(nameof(StmtAutoSettleCustomerDeposit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerOrderTaxCalculationBehavior = group.Add(new VocabularyKey(nameof(CustomerOrderTaxCalculationBehavior), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowConcludeCreditMemoTransactionsWhenOffline = group.Add(new VocabularyKey(nameof(AllowConcludeCreditMemoTransactionsWhenOffline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryAvailabilityQuantityReturnType = group.Add(new VocabularyKey(nameof(InventoryAvailabilityQuantityReturnType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryEnableAutomaticValidation = group.Add(new VocabularyKey(nameof(InventoryEnableAutomaticValidation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PrePaymentLedgerJournalName { get; private set; }
        public VocabularyKey MixAndMatchActivityType { get; private set; }
        public VocabularyKey AccountExportProfile { get; private set; }
        public VocabularyKey AggregateBeforePosting { get; private set; }
        public VocabularyKey AutoSettle { get; private set; }
        public VocabularyKey BuyersPushRespectAssortments { get; private set; }
        public VocabularyKey CancellationCharge { get; private set; }
        public VocabularyKey CancellationChargeCode { get; private set; }
        public VocabularyKey CrossDockingRespectAssortments { get; private set; }
        public VocabularyKey DefaultCustomerPosting { get; private set; }
        public VocabularyKey DefaultInventoryJournalName { get; private set; }
        public VocabularyKey DefaultJournalName4CategoryPrice { get; private set; }
        public VocabularyKey DefaultOrdertype { get; private set; }
        public VocabularyKey DefaultRCashJournalName { get; private set; }
        public VocabularyKey DetailSummary { get; private set; }
        public VocabularyKey DiscountAccountLedgerDimension { get; private set; }
        public VocabularyKey DiscountOfferActivityType { get; private set; }
        public VocabularyKey EANLicenseNo { get; private set; }
        public VocabularyKey ElectronicDeliveryModeCode { get; private set; }
        public VocabularyKey EventNotificationProfileId { get; private set; }
        public VocabularyKey ExpirationDate { get; private set; }
        public VocabularyKey GiftCardCompany { get; private set; }
        public VocabularyKey GiftcardItem { get; private set; }
        public VocabularyKey GiftCardLedgerJournalName { get; private set; }
        public VocabularyKey InventoryLocationIdForInventory { get; private set; }
        public VocabularyKey InventoryLocationIdForPurchaseOrder { get; private set; }
        public VocabularyKey InventoryLocationIdForSalesOrder { get; private set; }
        public VocabularyKey ItemLabelLastAction { get; private set; }
        public VocabularyKey ItemLabelsForNegativeStock { get; private set; }
        public VocabularyKey ItemSalesStatisticsOn { get; private set; }
        public VocabularyKey JournalNameForKitPricing { get; private set; }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey LedgerAccountType { get; private set; }
        public VocabularyKey MaxSalesOrdersPerTask { get; private set; }
        public VocabularyKey CallCenterGiftCardVoidJournalName { get; private set; }
        public VocabularyKey MinimumDepositForSalesOrder { get; private set; }
        public VocabularyKey MinimumPasswordLength { get; private set; }
        public VocabularyKey MixMatchLedgerDimension { get; private set; }
        public VocabularyKey MultibuyActivityType { get; private set; }
        public VocabularyKey MultiBuyLedgerDimension { get; private set; }
        public VocabularyKey OfferLedgerDimension { get; private set; }
        public VocabularyKey OverrideSystemLookup { get; private set; }
        public VocabularyKey ParallelSalesOrderPosting { get; private set; }
        public VocabularyKey Payment { get; private set; }
        public VocabularyKey PaymentStatistics { get; private set; }
        public VocabularyKey PaymentMode { get; private set; }
        public VocabularyKey PickUpDeliveryModeCode { get; private set; }
        public VocabularyKey PostBankedSum { get; private set; }
        public VocabularyKey PostCustomerDiscount { get; private set; }
        public VocabularyKey PostInfocodeDiscount { get; private set; }
        public VocabularyKey PostLineDiscount { get; private set; }
        public VocabularyKey PostPeriodicDiscount { get; private set; }
        public VocabularyKey PostSafeSum { get; private set; }
        public VocabularyKey PostSalesOrderWhenPaid { get; private set; }
        public VocabularyKey PostTotalDiscount { get; private set; }
        public VocabularyKey PrepaymentLedgerDimension { get; private set; }
        public VocabularyKey ReceiptEmailFilename { get; private set; }
        public VocabularyKey ReceiptEmailSubject { get; private set; }
        public VocabularyKey ReceiptEmailText { get; private set; }
        public VocabularyKey ReceiptOption { get; private set; }
        public VocabularyKey ReplenishmentAssortmentsCoverageDays { get; private set; }
        public VocabularyKey RequireNumericCharacter { get; private set; }
        public VocabularyKey RequireSpecialCharacter { get; private set; }
        public VocabularyKey RequireUppercase { get; private set; }
        public VocabularyKey ReturnDispositionCodeId { get; private set; }
        public VocabularyKey ShelfLabelLastAction { get; private set; }
        public VocabularyKey ShippingChargeCode { get; private set; }
        public VocabularyKey StaffStatistics { get; private set; }
        public VocabularyKey SystemInUse { get; private set; }
        public VocabularyKey TerminalStatistics { get; private set; }
        public VocabularyKey ThresholdLedgerDimension { get; private set; }
        public VocabularyKey TotalDiscountLedgerDimension { get; private set; }
        public VocabularyKey UseDefaultLedgerAccount { get; private set; }
        public VocabularyKey UseDefaultTradeDates { get; private set; }
        public VocabularyKey UseRetailReturnTaxGroup { get; private set; }
        public VocabularyKey WishListInvitationEmailId { get; private set; }
        public VocabularyKey GiftCardClosingLedgerDimension { get; private set; }
        public VocabularyKey ItemLabelSetupMissingAction { get; private set; }
        public VocabularyKey UseGiftCardPolicies { get; private set; }
        public VocabularyKey SmallBusinessAccountExportProfileName { get; private set; }
        public VocabularyKey DiscountAccountLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey MixMatchLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey MultiBuyLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey OfferLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey PrepaymentLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey ThresholdLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey TotalDiscountLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey GiftCardClosingLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey PasswordExpiryInterval { get; private set; }
        public VocabularyKey PasswordExpiryNotificationThreshold { get; private set; }
        public VocabularyKey LockoutDuration { get; private set; }
        public VocabularyKey LockoutThreshold { get; private set; }
        public VocabularyKey LoginCounterResetDuration { get; private set; }
        public VocabularyKey CustomerAttributeGroup { get; private set; }
        public VocabularyKey CustomerAttributeGroupName { get; private set; }
        public VocabularyKey ApplyDiscountsToPriceKeyedIn { get; private set; }
        public VocabularyKey ApplyDiscountsToPriceOverrides { get; private set; }
        public VocabularyKey CouponBarcodeSetupId { get; private set; }
        public VocabularyKey AllowExchangeOnReturnOrders { get; private set; }
        public VocabularyKey AllowConcludeGiftCardTransactionsWhenOffline { get; private set; }
        public VocabularyKey DefaultCustomerPaymentJournalName { get; private set; }
        public VocabularyKey DefaultLedgerJournalName { get; private set; }
        public VocabularyKey AggregateCustomerPayments { get; private set; }
        public VocabularyKey AggregateIncomeExpenseTransactions { get; private set; }
        public VocabularyKey AggregateSalesAndReturns { get; private set; }
        public VocabularyKey AggregateTenderRemoveAndFloat { get; private set; }
        public VocabularyKey TaxOnGiftCards { get; private set; }
        public VocabularyKey UseAdvanceInvoice { get; private set; }
        public VocabularyKey TaxCalculationBehavior { get; private set; }
        public VocabularyKey MaxNumberOfStatementsPostInParallel { get; private set; }
        public VocabularyKey MaxNumberOfThreadsCustomerOrder { get; private set; }
        public VocabularyKey AggregatedTransactionsBundleSize { get; private set; }
        public VocabularyKey UseAdvancedAutoCharges { get; private set; }
        public VocabularyKey GiftCardInquiryPrintHistoryCount { get; private set; }
        public VocabularyKey EnableReturnsForMultipleOrderInvoices { get; private set; }
        public VocabularyKey RecalculateDimensionsOnPostingError { get; private set; }
        public VocabularyKey ChargeOverrideReasonCode { get; private set; }
        public VocabularyKey PostPeriodicDiscountForOrders { get; private set; }
        public VocabularyKey DoNotAggregateReturns { get; private set; }
        public VocabularyKey UseRTSForOnlineOrderCreation { get; private set; }
        public VocabularyKey UseFinancialDimensionFromReturnStore { get; private set; }
        public VocabularyKey UseSessionDateForCalculatingPricesAndDiscounts { get; private set; }
        public VocabularyKey DefaultBatchIdOnSaleForCashAndCarrySales { get; private set; }
        public VocabularyKey DefaultBatchIdOnSaleForCustomerOrder { get; private set; }
        public VocabularyKey UseDefaultBatchIdOnSaleForCashAndCarrySales { get; private set; }
        public VocabularyKey UseDefaultBatchIdOnSaleForCustomerOrder { get; private set; }
        public VocabularyKey IgnoreReturnLink { get; private set; }
        public VocabularyKey ClientBookAttributeGroup { get; private set; }
        public VocabularyKey DisablePostRoundingDifference { get; private set; }
        public VocabularyKey ShowOnlyCarrierOptionsForShipOrders { get; private set; }
        public VocabularyKey AsyncOrdersEditHoldCode { get; private set; }
        public VocabularyKey EnableChannelReturnPolicies { get; private set; }
        public VocabularyKey StmtAutoSettleCustomerDeposit { get; private set; }
        public VocabularyKey CustomerOrderTaxCalculationBehavior { get; private set; }
        public VocabularyKey AllowConcludeCreditMemoTransactionsWhenOffline { get; private set; }
        public VocabularyKey InventoryAvailabilityQuantityReturnType { get; private set; }
        public VocabularyKey InventoryEnableAutomaticValidation { get; private set; }
    }
}