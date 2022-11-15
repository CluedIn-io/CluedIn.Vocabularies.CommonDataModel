using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FHAccountVocabulary : SimpleVocabulary
    {
        public FHAccountVocabulary()
        {
            VocabularyName = "FH Account";
            KeyPrefix = "commonDataModel.fhaccount";
            KeySeparator = ".";
            Grouping = "/FHAccount";

            AddGroup("FHAccount Details", group =>
            {
                FH_AccountId = group.Add(new VocabularyKey(nameof(FH_AccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statecode = group.Add(new VocabularyKey(nameof(Statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Statuscode = group.Add(new VocabularyKey(nameof(Statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingClassification = group.Add(new VocabularyKey(nameof(AccountingClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AvailableBalance = group.Add(new VocabularyKey(nameof(AvailableBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Availablebalance_Base = group.Add(new VocabularyKey(nameof(Availablebalance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AvailableBalance_default = group.Add(new VocabularyKey(nameof(AvailableBalance_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AverageBalance = group.Add(new VocabularyKey(nameof(AverageBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Averagebalance_Base = group.Add(new VocabularyKey(nameof(Averagebalance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AverageBalance_default = group.Add(new VocabularyKey(nameof(AverageBalance_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balance = group.Add(new VocabularyKey(nameof(Balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balance_Base = group.Add(new VocabularyKey(nameof(Balance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDefault = group.Add(new VocabularyKey(nameof(BalanceDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceExchangerate = group.Add(new VocabularyKey(nameof(BalanceExchangerate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BlockedAmount = group.Add(new VocabularyKey(nameof(BlockedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Blockedamount_Base = group.Add(new VocabularyKey(nameof(Blockedamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BlockedAmount_default = group.Add(new VocabularyKey(nameof(BlockedAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dateoflasttransaction = group.Add(new VocabularyKey(nameof(Dateoflasttransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelinquencyStatus = group.Add(new VocabularyKey(nameof(DelinquencyStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialHoldingCategory = group.Add(new VocabularyKey(nameof(FinancialHoldingCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialHoldingType = group.Add(new VocabularyKey(nameof(FinancialHoldingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationKey = group.Add(new VocabularyKey(nameof(IntegrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interestrate = group.Add(new VocabularyKey(nameof(Interestrate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestType = group.Add(new VocabularyKey(nameof(InterestType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Numberoftransactions = group.Add(new VocabularyKey(nameof(Numberoftransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnclearedBalance = group.Add(new VocabularyKey(nameof(UnclearedBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Unclearedbalance_Base = group.Add(new VocabularyKey(nameof(Unclearedbalance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnclearedBalance_default = group.Add(new VocabularyKey(nameof(UnclearedBalance_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDefaultDisplayValue = group.Add(new VocabularyKey(nameof(BalanceDefaultDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDisplayValue = group.Add(new VocabularyKey(nameof(BalanceDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balancedisplayvalue_Base = group.Add(new VocabularyKey(nameof(Balancedisplayvalue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FH_AccountId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Statecode { get; private set; }
        public VocabularyKey Statuscode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AccountingClassification { get; private set; }
        public VocabularyKey AvailableBalance { get; private set; }
        public VocabularyKey Availablebalance_Base { get; private set; }
        public VocabularyKey AvailableBalance_default { get; private set; }
        public VocabularyKey AverageBalance { get; private set; }
        public VocabularyKey Averagebalance_Base { get; private set; }
        public VocabularyKey AverageBalance_default { get; private set; }
        public VocabularyKey Balance { get; private set; }
        public VocabularyKey Balance_Base { get; private set; }
        public VocabularyKey BalanceDefault { get; private set; }
        public VocabularyKey BalanceExchangerate { get; private set; }
        public VocabularyKey BlockedAmount { get; private set; }
        public VocabularyKey Blockedamount_Base { get; private set; }
        public VocabularyKey BlockedAmount_default { get; private set; }
        public VocabularyKey Dateoflasttransaction { get; private set; }
        public VocabularyKey DelinquencyStatus { get; private set; }
        public VocabularyKey FinancialHoldingCategory { get; private set; }
        public VocabularyKey FinancialHoldingType { get; private set; }
        public VocabularyKey IntegrationKey { get; private set; }
        public VocabularyKey Interestrate { get; private set; }
        public VocabularyKey InterestType { get; private set; }
        public VocabularyKey Numberoftransactions { get; private set; }
        public VocabularyKey UnclearedBalance { get; private set; }
        public VocabularyKey Unclearedbalance_Base { get; private set; }
        public VocabularyKey UnclearedBalance_default { get; private set; }
        public VocabularyKey BalanceDefaultDisplayValue { get; private set; }
        public VocabularyKey BalanceDisplayValue { get; private set; }
        public VocabularyKey Balancedisplayvalue_Base { get; private set; }
    }
}