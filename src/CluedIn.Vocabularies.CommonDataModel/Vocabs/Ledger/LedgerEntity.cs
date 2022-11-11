using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerEntityVocabulary : SimpleVocabulary
    {
        public LedgerEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerEntity";
            KeyPrefix = "commonDataModel.ledgerentity";
            KeySeparator = ".";
            Grouping = "/LedgerEntity";

            AddGroup("Common Data Model LedgerEntity Details", group =>
            {
                AccountingCurrency = group.Add(new VocabularyKey(nameof(AccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrency = group.Add(new VocabularyKey(nameof(ReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendar = group.Add(new VocabularyKey(nameof(FiscalCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalCalendarRecId = group.Add(new VocabularyKey(nameof(FiscalCalendarRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateType = group.Add(new VocabularyKey(nameof(ExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRateTypeRecId = group.Add(new VocabularyKey(nameof(ExchangeRateTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetExchangeRateType = group.Add(new VocabularyKey(nameof(BudgetExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetExchangeRateTypeRecId = group.Add(new VocabularyKey(nameof(BudgetExchangeRateTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBudgetControlEnabled = group.Add(new VocabularyKey(nameof(IsBudgetControlEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccounts = group.Add(new VocabularyKey(nameof(ChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChartOfAccountsRecId = group.Add(new VocabularyKey(nameof(ChartOfAccountsRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryForLegalEntityRecId = group.Add(new VocabularyKey(nameof(PrimaryForLegalEntityRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalancingFinancialDimensionRecId = group.Add(new VocabularyKey(nameof(BalancingFinancialDimensionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalancingFinancialDimension = group.Add(new VocabularyKey(nameof(BalancingFinancialDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName1 = group.Add(new VocabularyKey(nameof(AccountStructureName1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName2 = group.Add(new VocabularyKey(nameof(AccountStructureName2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName3 = group.Add(new VocabularyKey(nameof(AccountStructureName3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName4 = group.Add(new VocabularyKey(nameof(AccountStructureName4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName5 = group.Add(new VocabularyKey(nameof(AccountStructureName5), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName6 = group.Add(new VocabularyKey(nameof(AccountStructureName6), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName7 = group.Add(new VocabularyKey(nameof(AccountStructureName7), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName8 = group.Add(new VocabularyKey(nameof(AccountStructureName8), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName9 = group.Add(new VocabularyKey(nameof(AccountStructureName9), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName10 = group.Add(new VocabularyKey(nameof(AccountStructureName10), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName11 = group.Add(new VocabularyKey(nameof(AccountStructureName11), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName12 = group.Add(new VocabularyKey(nameof(AccountStructureName12), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName13 = group.Add(new VocabularyKey(nameof(AccountStructureName13), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName14 = group.Add(new VocabularyKey(nameof(AccountStructureName14), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName15 = group.Add(new VocabularyKey(nameof(AccountStructureName15), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName16 = group.Add(new VocabularyKey(nameof(AccountStructureName16), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName17 = group.Add(new VocabularyKey(nameof(AccountStructureName17), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName18 = group.Add(new VocabularyKey(nameof(AccountStructureName18), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName19 = group.Add(new VocabularyKey(nameof(AccountStructureName19), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountStructureName20 = group.Add(new VocabularyKey(nameof(AccountStructureName20), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerRecId = group.Add(new VocabularyKey(nameof(LedgerRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdRealizedGain = group.Add(new VocabularyKey(nameof(MainAccountIdRealizedGain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdRealizedLoss = group.Add(new VocabularyKey(nameof(MainAccountIdRealizedLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdUnrealizedGain = group.Add(new VocabularyKey(nameof(MainAccountIdUnrealizedGain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdUnrealizedLoss = group.Add(new VocabularyKey(nameof(MainAccountIdUnrealizedLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdFinancialGain = group.Add(new VocabularyKey(nameof(MainAccountIdFinancialGain), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountIdFinancialLoss = group.Add(new VocabularyKey(nameof(MainAccountIdFinancialLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchangeRateType = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchangeRateTypeRecId = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchangeRateTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountingCurrency { get; private set; }
        public VocabularyKey ReportingCurrency { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey FiscalCalendar { get; private set; }
        public VocabularyKey FiscalCalendarRecId { get; private set; }
        public VocabularyKey ExchangeRateType { get; private set; }
        public VocabularyKey ExchangeRateTypeRecId { get; private set; }
        public VocabularyKey BudgetExchangeRateType { get; private set; }
        public VocabularyKey BudgetExchangeRateTypeRecId { get; private set; }
        public VocabularyKey IsBudgetControlEnabled { get; private set; }
        public VocabularyKey ChartOfAccounts { get; private set; }
        public VocabularyKey ChartOfAccountsRecId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PrimaryForLegalEntityRecId { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey BalancingFinancialDimensionRecId { get; private set; }
        public VocabularyKey BalancingFinancialDimension { get; private set; }
        public VocabularyKey AccountStructureName1 { get; private set; }
        public VocabularyKey AccountStructureName2 { get; private set; }
        public VocabularyKey AccountStructureName3 { get; private set; }
        public VocabularyKey AccountStructureName4 { get; private set; }
        public VocabularyKey AccountStructureName5 { get; private set; }
        public VocabularyKey AccountStructureName6 { get; private set; }
        public VocabularyKey AccountStructureName7 { get; private set; }
        public VocabularyKey AccountStructureName8 { get; private set; }
        public VocabularyKey AccountStructureName9 { get; private set; }
        public VocabularyKey AccountStructureName10 { get; private set; }
        public VocabularyKey AccountStructureName11 { get; private set; }
        public VocabularyKey AccountStructureName12 { get; private set; }
        public VocabularyKey AccountStructureName13 { get; private set; }
        public VocabularyKey AccountStructureName14 { get; private set; }
        public VocabularyKey AccountStructureName15 { get; private set; }
        public VocabularyKey AccountStructureName16 { get; private set; }
        public VocabularyKey AccountStructureName17 { get; private set; }
        public VocabularyKey AccountStructureName18 { get; private set; }
        public VocabularyKey AccountStructureName19 { get; private set; }
        public VocabularyKey AccountStructureName20 { get; private set; }
        public VocabularyKey LedgerRecId { get; private set; }
        public VocabularyKey MainAccountIdRealizedGain { get; private set; }
        public VocabularyKey MainAccountIdRealizedLoss { get; private set; }
        public VocabularyKey MainAccountIdUnrealizedGain { get; private set; }
        public VocabularyKey MainAccountIdUnrealizedLoss { get; private set; }
        public VocabularyKey MainAccountIdFinancialGain { get; private set; }
        public VocabularyKey MainAccountIdFinancialLoss { get; private set; }
        public VocabularyKey ReportingCurrencyExchangeRateType { get; private set; }
        public VocabularyKey ReportingCurrencyExchangeRateTypeRecId { get; private set; }


    }
}