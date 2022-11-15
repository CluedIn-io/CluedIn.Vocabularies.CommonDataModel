using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailChannelEntityVocabulary : SimpleVocabulary
    {
        public RetailChannelEntityVocabulary()
        {
            VocabularyName = "Retail Channel Entity";
            KeyPrefix = "commonDataModel.retailchannelentity";
            KeySeparator = ".";
            Grouping = "/RetailChannelEntity";

            AddGroup("RetailChannelEntity Details", group =>
            {
                RetailChannelId = group.Add(new VocabularyKey(nameof(RetailChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChannelTimeZone = group.Add(new VocabularyKey(nameof(ChannelTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChannelTimeZoneInfoId = group.Add(new VocabularyKey(nameof(ChannelTimeZoneInfoId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCustomerAccount = group.Add(new VocabularyKey(nameof(DefaultCustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCustomerLegalEntity = group.Add(new VocabularyKey(nameof(DefaultCustomerLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroupCode = group.Add(new VocabularyKey(nameof(TaxGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxGroupLegalEntity = group.Add(new VocabularyKey(nameof(TaxGroupLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChannelType = group.Add(new VocabularyKey(nameof(ChannelType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EventNotificationProfileId = group.Add(new VocabularyKey(nameof(EventNotificationProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventLocation = group.Add(new VocabularyKey(nameof(InventLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventLocationDataAreaId = group.Add(new VocabularyKey(nameof(InventLocationDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnitID = group.Add(new VocabularyKey(nameof(OMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Payment = group.Add(new VocabularyKey(nameof(Payment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymMode = group.Add(new VocabularyKey(nameof(PaymMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriceIncludesSalesTax = group.Add(new VocabularyKey(nameof(PriceIncludesSalesTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StoreArea = group.Add(new VocabularyKey(nameof(StoreArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionServiceProfile = group.Add(new VocabularyKey(nameof(TransactionServiceProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayTaxPerTaxComponent = group.Add(new VocabularyKey(nameof(DisplayTaxPerTaxComponent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchyName = group.Add(new VocabularyKey(nameof(CategoryHierarchyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MCRCustomerCreditRetailInfocodeId = group.Add(new VocabularyKey(nameof(MCRCustomerCreditRetailInfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MCREnableDirectedSelling = group.Add(new VocabularyKey(nameof(MCREnableDirectedSelling), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MCREnableOrderCompletion = group.Add(new VocabularyKey(nameof(MCREnableOrderCompletion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MCREnableOrderPriceControl = group.Add(new VocabularyKey(nameof(MCREnableOrderPriceControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MCRPriceOverrideRetailInfocodeId = group.Add(new VocabularyKey(nameof(MCRPriceOverrideRetailInfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MCRReasonCodeRetailInfocodeId = group.Add(new VocabularyKey(nameof(MCRReasonCodeRetailInfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OnlineCatalogName = group.Add(new VocabularyKey(nameof(OnlineCatalogName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClosingMethod = group.Add(new VocabularyKey(nameof(ClosingMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateLabelsForZeroPrice = group.Add(new VocabularyKey(nameof(CreateLabelsForZeroPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CultureName = group.Add(new VocabularyKey(nameof(CultureName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DatabaseName = group.Add(new VocabularyKey(nameof(DatabaseName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EFTStoreNumber = group.Add(new VocabularyKey(nameof(EFTStoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FunctionalityProfile = group.Add(new VocabularyKey(nameof(FunctionalityProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneratesItemLabels = group.Add(new VocabularyKey(nameof(GeneratesItemLabels), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneratesShelfLabels = group.Add(new VocabularyKey(nameof(GeneratesShelfLabels), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HideTrainingMode = group.Add(new VocabularyKey(nameof(HideTrainingMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventLocationIdForCustomerOrder = group.Add(new VocabularyKey(nameof(InventLocationIdForCustomerOrder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InventoryLookup = group.Add(new VocabularyKey(nameof(InventoryLookup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemIdOnReceipt = group.Add(new VocabularyKey(nameof(ItemIdOnReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumPostingDifference = group.Add(new VocabularyKey(nameof(MaximumPostingDifference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumTextLengthOnReceipt = group.Add(new VocabularyKey(nameof(MaximumTextLengthOnReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxRoundingAmount = group.Add(new VocabularyKey(nameof(MaxRoundingAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxRoundingTaxAmount = group.Add(new VocabularyKey(nameof(MaxRoundingTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxShiftDifferenceAmount = group.Add(new VocabularyKey(nameof(MaxShiftDifferenceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxTransactionDifferenceAmount = group.Add(new VocabularyKey(nameof(MaxTransactionDifferenceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfTopOrBottomLines = group.Add(new VocabularyKey(nameof(NumberOfTopOrBottomLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfflineProfile = group.Add(new VocabularyKey(nameof(OfflineProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OneStatementPerDay = group.Add(new VocabularyKey(nameof(OneStatementPerDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpenFrom = group.Add(new VocabularyKey(nameof(OpenFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpenTo = group.Add(new VocabularyKey(nameof(OpenTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Phone = group.Add(new VocabularyKey(nameof(Phone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PoItemFilter = group.Add(new VocabularyKey(nameof(PoItemFilter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemoveAddTender = group.Add(new VocabularyKey(nameof(RemoveAddTender), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailReqPlanIdSched = group.Add(new VocabularyKey(nameof(RetailReqPlanIdSched), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnTaxGroup_W = group.Add(new VocabularyKey(nameof(ReturnTaxGroup_W), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingAccountLedgerDimension = group.Add(new VocabularyKey(nameof(RoundingAccountLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingTaxAccount = group.Add(new VocabularyKey(nameof(RoundingTaxAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SeparateStmtPerStaffTerminal = group.Add(new VocabularyKey(nameof(SeparateStmtPerStaffTerminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceChargePct = group.Add(new VocabularyKey(nameof(ServiceChargePct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceChargePrompt = group.Add(new VocabularyKey(nameof(ServiceChargePrompt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SQLServerName = group.Add(new VocabularyKey(nameof(SQLServerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementMethod = group.Add(new VocabularyKey(nameof(StatementMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StmtCalcBatchEndTime = group.Add(new VocabularyKey(nameof(StmtCalcBatchEndTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StmtPostAsBusinessDay = group.Add(new VocabularyKey(nameof(StmtPostAsBusinessDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StoreNumber = group.Add(new VocabularyKey(nameof(StoreNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxIdentificationNumber = group.Add(new VocabularyKey(nameof(TaxIdentificationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxOverrideGroup = group.Add(new VocabularyKey(nameof(TaxOverrideGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TenderDeclarationCalculation = group.Add(new VocabularyKey(nameof(TenderDeclarationCalculation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseCustomerBasedTax = group.Add(new VocabularyKey(nameof(UseCustomerBasedTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseDefaultCustAccount = group.Add(new VocabularyKey(nameof(UseDefaultCustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseDestinationBasedTax = group.Add(new VocabularyKey(nameof(UseDestinationBasedTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserName = group.Add(new VocabularyKey(nameof(UserName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OfflineProfileName = group.Add(new VocabularyKey(nameof(OfflineProfileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingAccountLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(RoundingAccountLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchy = group.Add(new VocabularyKey(nameof(CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChannelProfileName = group.Add(new VocabularyKey(nameof(ChannelProfileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LiveDatabaseConnectionProfileName = group.Add(new VocabularyKey(nameof(LiveDatabaseConnectionProfileName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitPartyNumber = group.Add(new VocabularyKey(nameof(OperatingUnitPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxOverrideGroupCode = group.Add(new VocabularyKey(nameof(TaxOverrideGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManualAccept = group.Add(new VocabularyKey(nameof(ManualAccept), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseCustomerBasedTaxExemption = group.Add(new VocabularyKey(nameof(UseCustomerBasedTaxExemption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailReturnPolicyChannel = group.Add(new VocabularyKey(nameof(RetailReturnPolicyChannel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalcExemptTaxesForPriceInclusive = group.Add(new VocabularyKey(nameof(CalcExemptTaxesForPriceInclusive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RetailChannelId { get; private set; }
        public VocabularyKey ChannelTimeZone { get; private set; }
        public VocabularyKey ChannelTimeZoneInfoId { get; private set; }
        public VocabularyKey DefaultCustomerAccount { get; private set; }
        public VocabularyKey DefaultCustomerLegalEntity { get; private set; }
        public VocabularyKey TaxGroupCode { get; private set; }
        public VocabularyKey TaxGroupLegalEntity { get; private set; }
        public VocabularyKey ChannelType { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey EventNotificationProfileId { get; private set; }
        public VocabularyKey InventLocation { get; private set; }
        public VocabularyKey InventLocationDataAreaId { get; private set; }
        public VocabularyKey OMOperatingUnitID { get; private set; }
        public VocabularyKey Payment { get; private set; }
        public VocabularyKey PaymMode { get; private set; }
        public VocabularyKey PriceIncludesSalesTax { get; private set; }
        public VocabularyKey StoreArea { get; private set; }
        public VocabularyKey TransactionServiceProfile { get; private set; }
        public VocabularyKey DisplayTaxPerTaxComponent { get; private set; }
        public VocabularyKey CategoryHierarchyName { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey MCRCustomerCreditRetailInfocodeId { get; private set; }
        public VocabularyKey MCREnableDirectedSelling { get; private set; }
        public VocabularyKey MCREnableOrderCompletion { get; private set; }
        public VocabularyKey MCREnableOrderPriceControl { get; private set; }
        public VocabularyKey MCRPriceOverrideRetailInfocodeId { get; private set; }
        public VocabularyKey MCRReasonCodeRetailInfocodeId { get; private set; }
        public VocabularyKey OnlineCatalogName { get; private set; }
        public VocabularyKey ClosingMethod { get; private set; }
        public VocabularyKey CreateLabelsForZeroPrice { get; private set; }
        public VocabularyKey CultureName { get; private set; }
        public VocabularyKey DatabaseName { get; private set; }
        public VocabularyKey EFTStoreNumber { get; private set; }
        public VocabularyKey FunctionalityProfile { get; private set; }
        public VocabularyKey GeneratesItemLabels { get; private set; }
        public VocabularyKey GeneratesShelfLabels { get; private set; }
        public VocabularyKey HideTrainingMode { get; private set; }
        public VocabularyKey InventLocationIdForCustomerOrder { get; private set; }
        public VocabularyKey InventoryLookup { get; private set; }
        public VocabularyKey ItemIdOnReceipt { get; private set; }
        public VocabularyKey MaximumPostingDifference { get; private set; }
        public VocabularyKey MaximumTextLengthOnReceipt { get; private set; }
        public VocabularyKey MaxRoundingAmount { get; private set; }
        public VocabularyKey MaxRoundingTaxAmount { get; private set; }
        public VocabularyKey MaxShiftDifferenceAmount { get; private set; }
        public VocabularyKey MaxTransactionDifferenceAmount { get; private set; }
        public VocabularyKey NumberOfTopOrBottomLines { get; private set; }
        public VocabularyKey OfflineProfile { get; private set; }
        public VocabularyKey OneStatementPerDay { get; private set; }
        public VocabularyKey OpenFrom { get; private set; }
        public VocabularyKey OpenTo { get; private set; }
        public VocabularyKey Phone { get; private set; }
        public VocabularyKey PoItemFilter { get; private set; }
        public VocabularyKey RemoveAddTender { get; private set; }
        public VocabularyKey RetailReqPlanIdSched { get; private set; }
        public VocabularyKey ReturnTaxGroup_W { get; private set; }
        public VocabularyKey RoundingAccountLedgerDimension { get; private set; }
        public VocabularyKey RoundingTaxAccount { get; private set; }
        public VocabularyKey SeparateStmtPerStaffTerminal { get; private set; }
        public VocabularyKey ServiceChargePct { get; private set; }
        public VocabularyKey ServiceChargePrompt { get; private set; }
        public VocabularyKey SQLServerName { get; private set; }
        public VocabularyKey StatementMethod { get; private set; }
        public VocabularyKey StmtCalcBatchEndTime { get; private set; }
        public VocabularyKey StmtPostAsBusinessDay { get; private set; }
        public VocabularyKey StoreNumber { get; private set; }
        public VocabularyKey TaxIdentificationNumber { get; private set; }
        public VocabularyKey TaxOverrideGroup { get; private set; }
        public VocabularyKey TenderDeclarationCalculation { get; private set; }
        public VocabularyKey UseCustomerBasedTax { get; private set; }
        public VocabularyKey UseDefaultCustAccount { get; private set; }
        public VocabularyKey UseDestinationBasedTax { get; private set; }
        public VocabularyKey UserName { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }
        public VocabularyKey OfflineProfileName { get; private set; }
        public VocabularyKey RoundingAccountLedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey CategoryHierarchy { get; private set; }
        public VocabularyKey ChannelProfileName { get; private set; }
        public VocabularyKey LiveDatabaseConnectionProfileName { get; private set; }
        public VocabularyKey OperatingUnitPartyNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey TaxOverrideGroupCode { get; private set; }
        public VocabularyKey ManualAccept { get; private set; }
        public VocabularyKey UseCustomerBasedTaxExemption { get; private set; }
        public VocabularyKey RetailReturnPolicyChannel { get; private set; }
        public VocabularyKey CalcExemptTaxesForPriceInclusive { get; private set; }
    }
}