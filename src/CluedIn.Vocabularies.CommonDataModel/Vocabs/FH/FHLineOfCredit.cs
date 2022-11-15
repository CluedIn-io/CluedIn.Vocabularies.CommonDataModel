using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FHLineOfCreditVocabulary : SimpleVocabulary
    {
        public FHLineOfCreditVocabulary()
        {
            VocabularyName = "FH Line Of Credit";
            KeyPrefix = "commonDataModel.fhlineofcredit";
            KeySeparator = ".";
            Grouping = "/FHLineOfCredit";

            AddGroup("FHLineOfCredit Details", group =>
            {
                FH_CreditlineId = group.Add(new VocabularyKey(nameof(FH_CreditlineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                Balance = group.Add(new VocabularyKey(nameof(Balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balance_Base = group.Add(new VocabularyKey(nameof(Balance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDefault = group.Add(new VocabularyKey(nameof(BalanceDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceExchangerate = group.Add(new VocabularyKey(nameof(BalanceExchangerate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLimit = group.Add(new VocabularyKey(nameof(CreditLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Creditlimit_Base = group.Add(new VocabularyKey(nameof(Creditlimit_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditLimit_default = group.Add(new VocabularyKey(nameof(CreditLimit_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelinquencyStatus = group.Add(new VocabularyKey(nameof(DelinquencyStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialHoldingCategory = group.Add(new VocabularyKey(nameof(FinancialHoldingCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialHoldingType = group.Add(new VocabularyKey(nameof(FinancialHoldingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationKey = group.Add(new VocabularyKey(nameof(IntegrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Interestrate = group.Add(new VocabularyKey(nameof(Interestrate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastPaymentDueDate = group.Add(new VocabularyKey(nameof(LastPaymentDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastStatementBalance = group.Add(new VocabularyKey(nameof(LastStatementBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Laststatementbalance_Base = group.Add(new VocabularyKey(nameof(Laststatementbalance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastStatementBalance_default = group.Add(new VocabularyKey(nameof(LastStatementBalance_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LastStatementDate = group.Add(new VocabularyKey(nameof(LastStatementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumPaymentDue = group.Add(new VocabularyKey(nameof(MinimumPaymentDue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Minimumpaymentdue_Base = group.Add(new VocabularyKey(nameof(Minimumpaymentdue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumPaymentDue_default = group.Add(new VocabularyKey(nameof(MinimumPaymentDue_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MonthlyPaymentPercentage = group.Add(new VocabularyKey(nameof(MonthlyPaymentPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextPaymentDate = group.Add(new VocabularyKey(nameof(NextPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextStatementDate = group.Add(new VocabularyKey(nameof(NextStatementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDefaultDisplayValue = group.Add(new VocabularyKey(nameof(BalanceDefaultDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDisplayValue = group.Add(new VocabularyKey(nameof(BalanceDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balancedisplayvalue_Base = group.Add(new VocabularyKey(nameof(Balancedisplayvalue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FH_CreditlineId { get; private set; }
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
        public VocabularyKey Balance { get; private set; }
        public VocabularyKey Balance_Base { get; private set; }
        public VocabularyKey BalanceDefault { get; private set; }
        public VocabularyKey BalanceExchangerate { get; private set; }
        public VocabularyKey CreditLimit { get; private set; }
        public VocabularyKey Creditlimit_Base { get; private set; }
        public VocabularyKey CreditLimit_default { get; private set; }
        public VocabularyKey DelinquencyStatus { get; private set; }
        public VocabularyKey FinancialHoldingCategory { get; private set; }
        public VocabularyKey FinancialHoldingType { get; private set; }
        public VocabularyKey IntegrationKey { get; private set; }
        public VocabularyKey Interestrate { get; private set; }
        public VocabularyKey LastPaymentDueDate { get; private set; }
        public VocabularyKey LastStatementBalance { get; private set; }
        public VocabularyKey Laststatementbalance_Base { get; private set; }
        public VocabularyKey LastStatementBalance_default { get; private set; }
        public VocabularyKey LastStatementDate { get; private set; }
        public VocabularyKey MinimumPaymentDue { get; private set; }
        public VocabularyKey Minimumpaymentdue_Base { get; private set; }
        public VocabularyKey MinimumPaymentDue_default { get; private set; }
        public VocabularyKey MonthlyPaymentPercentage { get; private set; }
        public VocabularyKey NextPaymentDate { get; private set; }
        public VocabularyKey NextStatementDate { get; private set; }
        public VocabularyKey BalanceDefaultDisplayValue { get; private set; }
        public VocabularyKey BalanceDisplayValue { get; private set; }
        public VocabularyKey Balancedisplayvalue_Base { get; private set; }
    }
}