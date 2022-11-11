using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MainAccountEntityVocabulary : SimpleVocabulary
    {
        public MainAccountEntityVocabulary()
        {
            VocabularyName = "Common Data Model MainAccountEntity";
            KeyPrefix = "commonDataModel.mainaccountentity";
            KeySeparator = ".";
            Grouping = "/MainAccountEntity";

            AddGroup("Common Data Model MainAccountEntity Details", group =>
            {
                MainAccountCategory = group.Add(new VocabularyKey(nameof(MainAccountCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCategoryReference = group.Add(new VocabularyKey(nameof(AccountCategoryReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Closing = group.Add(new VocabularyKey(nameof(Closing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultConsolidationAccount = group.Add(new VocabularyKey(nameof(DefaultConsolidationAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultCurrency = group.Add(new VocabularyKey(nameof(DefaultCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceControl = group.Add(new VocabularyKey(nameof(BalanceControl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitCreditRequirement = group.Add(new VocabularyKey(nameof(DebitCreditRequirement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DebitCreditDefault = group.Add(new VocabularyKey(nameof(DebitCreditDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForeignCurrencyRevaluation = group.Add(new VocabularyKey(nameof(ForeignCurrencyRevaluation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialReportingExchangeRateTypeRecId = group.Add(new VocabularyKey(nameof(FinancialReportingExchangeRateTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialReportingCurrencyTranslationType = group.Add(new VocabularyKey(nameof(FinancialReportingCurrencyTranslationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccountsRecId = group.Add(new VocabularyKey(nameof(ChartOfAccountsRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MandatoryPaymentReference = group.Add(new VocabularyKey(nameof(MandatoryPaymentReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Monetary = group.Add(new VocabularyKey(nameof(Monetary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccount = group.Add(new VocabularyKey(nameof(OffsetAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingType = group.Add(new VocabularyKey(nameof(PostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SRUCode = group.Add(new VocabularyKey(nameof(SRUCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountType = group.Add(new VocabularyKey(nameof(MainAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                User = group.Add(new VocabularyKey(nameof(User), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateCurrency = group.Add(new VocabularyKey(nameof(ValidateCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidatePostingType = group.Add(new VocabularyKey(nameof(ValidatePostingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateUser = group.Add(new VocabularyKey(nameof(ValidateUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetAccountDisplayValue = group.Add(new VocabularyKey(nameof(OffsetAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OpeningAccountId = group.Add(new VocabularyKey(nameof(OpeningAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccounts = group.Add(new VocabularyKey(nameof(ChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingAccountType = group.Add(new VocabularyKey(nameof(ReportingAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialReportingExchangeRateType = group.Add(new VocabularyKey(nameof(FinancialReportingExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DoNotAllowManualEntry = group.Add(new VocabularyKey(nameof(DoNotAllowManualEntry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSuspended = group.Add(new VocabularyKey(nameof(IsSuspended), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveFrom = group.Add(new VocabularyKey(nameof(ActiveFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveTo = group.Add(new VocabularyKey(nameof(ActiveTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountRecId = group.Add(new VocabularyKey(nameof(MainAccountRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCategoryDescription = group.Add(new VocabularyKey(nameof(AccountCategoryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustmentMethod = group.Add(new VocabularyKey(nameof(AdjustmentMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InflationAdjustment = group.Add(new VocabularyKey(nameof(InflationAdjustment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RepomoType = group.Add(new VocabularyKey(nameof(RepomoType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentMainAccountId = group.Add(new VocabularyKey(nameof(ParentMainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountCategoryRef = group.Add(new VocabularyKey(nameof(AccountCategoryRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeAdjustmentRateTypeRecId = group.Add(new VocabularyKey(nameof(ExchangeAdjustmentRateTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeAdjustmentRateType = group.Add(new VocabularyKey(nameof(ExchangeAdjustmentRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingExchangeAdjustmentRateTypeRecId = group.Add(new VocabularyKey(nameof(ReportingExchangeAdjustmentRateTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingExchangeAdjustmentRateType = group.Add(new VocabularyKey(nameof(ReportingExchangeAdjustmentRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MainAccountCategory { get; private set; }
        public VocabularyKey AccountCategoryReference { get; private set; }
        public VocabularyKey Closing { get; private set; }
        public VocabularyKey DefaultConsolidationAccount { get; private set; }
        public VocabularyKey DefaultCurrency { get; private set; }
        public VocabularyKey BalanceControl { get; private set; }
        public VocabularyKey DebitCreditRequirement { get; private set; }
        public VocabularyKey DebitCreditDefault { get; private set; }
        public VocabularyKey ForeignCurrencyRevaluation { get; private set; }
        public VocabularyKey FinancialReportingExchangeRateTypeRecId { get; private set; }
        public VocabularyKey FinancialReportingCurrencyTranslationType { get; private set; }
        public VocabularyKey ChartOfAccountsRecId { get; private set; }
        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey MandatoryPaymentReference { get; private set; }
        public VocabularyKey Monetary { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OffsetAccount { get; private set; }
        public VocabularyKey PostingType { get; private set; }
        public VocabularyKey SRUCode { get; private set; }
        public VocabularyKey MainAccountType { get; private set; }
        public VocabularyKey User { get; private set; }
        public VocabularyKey ValidateCurrency { get; private set; }
        public VocabularyKey ValidatePostingType { get; private set; }
        public VocabularyKey ValidateUser { get; private set; }
        public VocabularyKey OffsetAccountDisplayValue { get; private set; }
        public VocabularyKey OpeningAccountId { get; private set; }
        public VocabularyKey ChartOfAccounts { get; private set; }
        public VocabularyKey ReportingAccountType { get; private set; }
        public VocabularyKey FinancialReportingExchangeRateType { get; private set; }
        public VocabularyKey DoNotAllowManualEntry { get; private set; }
        public VocabularyKey IsSuspended { get; private set; }
        public VocabularyKey ActiveFrom { get; private set; }
        public VocabularyKey ActiveTo { get; private set; }
        public VocabularyKey MainAccountRecId { get; private set; }
        public VocabularyKey AccountCategoryDescription { get; private set; }
        public VocabularyKey AdjustmentMethod { get; private set; }
        public VocabularyKey InflationAdjustment { get; private set; }
        public VocabularyKey RepomoType { get; private set; }
        public VocabularyKey ParentMainAccountId { get; private set; }
        public VocabularyKey AccountCategoryRef { get; private set; }
        public VocabularyKey ExchangeAdjustmentRateTypeRecId { get; private set; }
        public VocabularyKey ExchangeAdjustmentRateType { get; private set; }
        public VocabularyKey ReportingExchangeAdjustmentRateTypeRecId { get; private set; }
        public VocabularyKey ReportingExchangeAdjustmentRateType { get; private set; }


    }
}