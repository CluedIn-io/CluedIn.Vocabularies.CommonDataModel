using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FHInvestmentVocabulary : SimpleVocabulary
    {
        public FHInvestmentVocabulary()
        {
            VocabularyName = "FH Investment";
            KeyPrefix = "commonDataModel.fhinvestment";
            KeySeparator = ".";
            Grouping = "/FHInvestment";

            AddGroup("FHInvestment Details", group =>
            {
                FH_InvestmentId = group.Add(new VocabularyKey(nameof(FH_InvestmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                Cashbalance = group.Add(new VocabularyKey(nameof(Cashbalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Cashbalance_Base = group.Add(new VocabularyKey(nameof(Cashbalance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Cashbalance_default = group.Add(new VocabularyKey(nameof(Cashbalance_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialHoldingCategory = group.Add(new VocabularyKey(nameof(FinancialHoldingCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialHoldingType = group.Add(new VocabularyKey(nameof(FinancialHoldingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GainLoss = group.Add(new VocabularyKey(nameof(GainLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Gainloss_Base = group.Add(new VocabularyKey(nameof(Gainloss_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GainLoss_default = group.Add(new VocabularyKey(nameof(GainLoss_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntegrationKey = group.Add(new VocabularyKey(nameof(IntegrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvestmentObjectives = group.Add(new VocabularyKey(nameof(InvestmentObjectives), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Investmentrisk = group.Add(new VocabularyKey(nameof(Investmentrisk), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvestmentTimeFrame = group.Add(new VocabularyKey(nameof(InvestmentTimeFrame), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Openeddate = group.Add(new VocabularyKey(nameof(Openeddate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Performance1Y = group.Add(new VocabularyKey(nameof(Performance1Y), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Performance3Y = group.Add(new VocabularyKey(nameof(Performance3Y), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PerformanceYTD = group.Add(new VocabularyKey(nameof(PerformanceYTD), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PortfolioName = group.Add(new VocabularyKey(nameof(PortfolioName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDefaultDisplayValue = group.Add(new VocabularyKey(nameof(BalanceDefaultDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalanceDisplayValue = group.Add(new VocabularyKey(nameof(BalanceDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Balancedisplayvalue_Base = group.Add(new VocabularyKey(nameof(Balancedisplayvalue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FH_InvestmentId { get; private set; }
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
        public VocabularyKey Cashbalance { get; private set; }
        public VocabularyKey Cashbalance_Base { get; private set; }
        public VocabularyKey Cashbalance_default { get; private set; }
        public VocabularyKey FinancialHoldingCategory { get; private set; }
        public VocabularyKey FinancialHoldingType { get; private set; }
        public VocabularyKey GainLoss { get; private set; }
        public VocabularyKey Gainloss_Base { get; private set; }
        public VocabularyKey GainLoss_default { get; private set; }
        public VocabularyKey IntegrationKey { get; private set; }
        public VocabularyKey InvestmentObjectives { get; private set; }
        public VocabularyKey Investmentrisk { get; private set; }
        public VocabularyKey InvestmentTimeFrame { get; private set; }
        public VocabularyKey Openeddate { get; private set; }
        public VocabularyKey Performance1Y { get; private set; }
        public VocabularyKey Performance3Y { get; private set; }
        public VocabularyKey PerformanceYTD { get; private set; }
        public VocabularyKey PortfolioName { get; private set; }
        public VocabularyKey BalanceDefaultDisplayValue { get; private set; }
        public VocabularyKey BalanceDisplayValue { get; private set; }
        public VocabularyKey Balancedisplayvalue_Base { get; private set; }
    }
}