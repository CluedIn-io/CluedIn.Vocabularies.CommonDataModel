using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FHInvestmentVocabulary : SimpleVocabulary
    {
        public FHInvestmentVocabulary()
        {
            VocabularyName = "FHInvestment";
            KeyPrefix = "commonDataModel.fhinvestment";
            KeySeparator = ".";
            Grouping = "/FHInvestment";

            AddGroup("FHInvestment Details", group =>
            {
                FH_InvestmentId = group.Add(new VocabularyKey(nameof(FH_InvestmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                accountingClassification = group.Add(new VocabularyKey(nameof(accountingClassification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balance = group.Add(new VocabularyKey(nameof(balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balance_Base = group.Add(new VocabularyKey(nameof(balance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balanceDefault = group.Add(new VocabularyKey(nameof(balanceDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balanceExchangerate = group.Add(new VocabularyKey(nameof(balanceExchangerate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                cashbalance = group.Add(new VocabularyKey(nameof(cashbalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                cashbalance_Base = group.Add(new VocabularyKey(nameof(cashbalance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                cashbalance_default = group.Add(new VocabularyKey(nameof(cashbalance_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                financialHoldingCategory = group.Add(new VocabularyKey(nameof(financialHoldingCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                financialHoldingType = group.Add(new VocabularyKey(nameof(financialHoldingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                gainLoss = group.Add(new VocabularyKey(nameof(gainLoss), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                gainloss_Base = group.Add(new VocabularyKey(nameof(gainloss_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                gainLoss_default = group.Add(new VocabularyKey(nameof(gainLoss_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                integrationKey = group.Add(new VocabularyKey(nameof(integrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                investmentObjectives = group.Add(new VocabularyKey(nameof(investmentObjectives), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                investmentrisk = group.Add(new VocabularyKey(nameof(investmentrisk), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                investmentTimeFrame = group.Add(new VocabularyKey(nameof(investmentTimeFrame), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                openeddate = group.Add(new VocabularyKey(nameof(openeddate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                performance1Y = group.Add(new VocabularyKey(nameof(performance1Y), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                performance3Y = group.Add(new VocabularyKey(nameof(performance3Y), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                performanceYTD = group.Add(new VocabularyKey(nameof(performanceYTD), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                portfolioName = group.Add(new VocabularyKey(nameof(portfolioName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balanceDefaultDisplayValue = group.Add(new VocabularyKey(nameof(balanceDefaultDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balanceDisplayValue = group.Add(new VocabularyKey(nameof(balanceDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balancedisplayvalue_Base = group.Add(new VocabularyKey(nameof(balancedisplayvalue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FH_InvestmentId { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey statecode { get; private set; }
        public VocabularyKey statuscode { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey accountingClassification { get; private set; }
        public VocabularyKey balance { get; private set; }
        public VocabularyKey balance_Base { get; private set; }
        public VocabularyKey balanceDefault { get; private set; }
        public VocabularyKey balanceExchangerate { get; private set; }
        public VocabularyKey cashbalance { get; private set; }
        public VocabularyKey cashbalance_Base { get; private set; }
        public VocabularyKey cashbalance_default { get; private set; }
        public VocabularyKey financialHoldingCategory { get; private set; }
        public VocabularyKey financialHoldingType { get; private set; }
        public VocabularyKey gainLoss { get; private set; }
        public VocabularyKey gainloss_Base { get; private set; }
        public VocabularyKey gainLoss_default { get; private set; }
        public VocabularyKey integrationKey { get; private set; }
        public VocabularyKey investmentObjectives { get; private set; }
        public VocabularyKey investmentrisk { get; private set; }
        public VocabularyKey investmentTimeFrame { get; private set; }
        public VocabularyKey openeddate { get; private set; }
        public VocabularyKey performance1Y { get; private set; }
        public VocabularyKey performance3Y { get; private set; }
        public VocabularyKey performanceYTD { get; private set; }
        public VocabularyKey portfolioName { get; private set; }
        public VocabularyKey balanceDefaultDisplayValue { get; private set; }
        public VocabularyKey balanceDisplayValue { get; private set; }
        public VocabularyKey balancedisplayvalue_Base { get; private set; }


    }
}