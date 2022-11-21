using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FHSavingVocabulary : SimpleVocabulary
    {
        public FHSavingVocabulary()
        {
            VocabularyName = "FH Saving";
            KeyPrefix = "commonDataModel.fhsaving";
            KeySeparator = ".";
            Grouping = "/FHSaving";

            AddGroup("FHSaving Details", group =>
            {
                FH_SavingId = group.Add(new VocabularyKey(nameof(FH_SavingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                AccruedInterest = group.Add(new VocabularyKey(nameof(AccruedInterest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Accruedinterest_Base = group.Add(new VocabularyKey(nameof(Accruedinterest_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccruedInterest_default = group.Add(new VocabularyKey(nameof(AccruedInterest_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balance = group.Add(new VocabularyKey(nameof(Balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balance_Base = group.Add(new VocabularyKey(nameof(Balance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceatMaturity = group.Add(new VocabularyKey(nameof(BalanceatMaturity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balanceatmaturity_Base = group.Add(new VocabularyKey(nameof(Balanceatmaturity_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceatMaturity_default = group.Add(new VocabularyKey(nameof(BalanceatMaturity_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDefault = group.Add(new VocabularyKey(nameof(BalanceDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceExchangerate = group.Add(new VocabularyKey(nameof(BalanceExchangerate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BlockedAmount = group.Add(new VocabularyKey(nameof(BlockedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Blockedamount_Base = group.Add(new VocabularyKey(nameof(Blockedamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BlockedAmount_default = group.Add(new VocabularyKey(nameof(BlockedAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialHoldingCategory = group.Add(new VocabularyKey(nameof(FinancialHoldingCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialHoldingType = group.Add(new VocabularyKey(nameof(FinancialHoldingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InitialSource = group.Add(new VocabularyKey(nameof(InitialSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationKey = group.Add(new VocabularyKey(nameof(IntegrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interestrate = group.Add(new VocabularyKey(nameof(Interestrate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Maturitydate = group.Add(new VocabularyKey(nameof(Maturitydate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaturityInstructionsDetails = group.Add(new VocabularyKey(nameof(MaturityInstructionsDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectedInterestAmount = group.Add(new VocabularyKey(nameof(ProjectedInterestAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Projectedinterestamount_Base = group.Add(new VocabularyKey(nameof(Projectedinterestamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectedInterestAmount_default = group.Add(new VocabularyKey(nameof(ProjectedInterestAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Term = group.Add(new VocabularyKey(nameof(Term), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDefaultDisplayValue = group.Add(new VocabularyKey(nameof(BalanceDefaultDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDisplayValue = group.Add(new VocabularyKey(nameof(BalanceDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balancedisplayvalue_Base = group.Add(new VocabularyKey(nameof(Balancedisplayvalue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FH_SavingId { get; private set; }
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
        public VocabularyKey AccruedInterest { get; private set; }
        public VocabularyKey Accruedinterest_Base { get; private set; }
        public VocabularyKey AccruedInterest_default { get; private set; }
        public VocabularyKey Balance { get; private set; }
        public VocabularyKey Balance_Base { get; private set; }
        public VocabularyKey BalanceatMaturity { get; private set; }
        public VocabularyKey Balanceatmaturity_Base { get; private set; }
        public VocabularyKey BalanceatMaturity_default { get; private set; }
        public VocabularyKey BalanceDefault { get; private set; }
        public VocabularyKey BalanceExchangerate { get; private set; }
        public VocabularyKey BlockedAmount { get; private set; }
        public VocabularyKey Blockedamount_Base { get; private set; }
        public VocabularyKey BlockedAmount_default { get; private set; }
        public VocabularyKey FinancialHoldingCategory { get; private set; }
        public VocabularyKey FinancialHoldingType { get; private set; }
        public VocabularyKey InitialSource { get; private set; }
        public VocabularyKey IntegrationKey { get; private set; }
        public VocabularyKey Interestrate { get; private set; }
        public VocabularyKey Maturitydate { get; private set; }
        public VocabularyKey MaturityInstructionsDetails { get; private set; }
        public VocabularyKey ProjectedInterestAmount { get; private set; }
        public VocabularyKey Projectedinterestamount_Base { get; private set; }
        public VocabularyKey ProjectedInterestAmount_default { get; private set; }
        public VocabularyKey Term { get; private set; }
        public VocabularyKey BalanceDefaultDisplayValue { get; private set; }
        public VocabularyKey BalanceDisplayValue { get; private set; }
        public VocabularyKey Balancedisplayvalue_Base { get; private set; }
    }
}