using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FHLineOfCreditVocabulary : SimpleVocabulary
    {
        public FHLineOfCreditVocabulary()
        {
            VocabularyName = "FHLineOfCredit";
            KeyPrefix = "commonDataModel.fhlineofcredit";
            KeySeparator = ".";
            Grouping = "/FHLineOfCredit";

            AddGroup("FHLineOfCredit Details", group =>
            {
                FH_CreditlineId = group.Add(new VocabularyKey(nameof(FH_CreditlineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                creditLimit = group.Add(new VocabularyKey(nameof(creditLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                creditlimit_Base = group.Add(new VocabularyKey(nameof(creditlimit_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                creditLimit_default = group.Add(new VocabularyKey(nameof(creditLimit_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                delinquencyStatus = group.Add(new VocabularyKey(nameof(delinquencyStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                financialHoldingCategory = group.Add(new VocabularyKey(nameof(financialHoldingCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                financialHoldingType = group.Add(new VocabularyKey(nameof(financialHoldingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                integrationKey = group.Add(new VocabularyKey(nameof(integrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                interestrate = group.Add(new VocabularyKey(nameof(interestrate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastPaymentDueDate = group.Add(new VocabularyKey(nameof(lastPaymentDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastStatementBalance = group.Add(new VocabularyKey(nameof(lastStatementBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                laststatementbalance_Base = group.Add(new VocabularyKey(nameof(laststatementbalance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastStatementBalance_default = group.Add(new VocabularyKey(nameof(lastStatementBalance_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                lastStatementDate = group.Add(new VocabularyKey(nameof(lastStatementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                minimumPaymentDue = group.Add(new VocabularyKey(nameof(minimumPaymentDue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                minimumpaymentdue_Base = group.Add(new VocabularyKey(nameof(minimumpaymentdue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                minimumPaymentDue_default = group.Add(new VocabularyKey(nameof(minimumPaymentDue_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                monthlyPaymentPercentage = group.Add(new VocabularyKey(nameof(monthlyPaymentPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                nextPaymentDate = group.Add(new VocabularyKey(nameof(nextPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                nextStatementDate = group.Add(new VocabularyKey(nameof(nextStatementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balanceDefaultDisplayValue = group.Add(new VocabularyKey(nameof(balanceDefaultDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balanceDisplayValue = group.Add(new VocabularyKey(nameof(balanceDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balancedisplayvalue_Base = group.Add(new VocabularyKey(nameof(balancedisplayvalue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FH_CreditlineId { get; private set; }
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
        public VocabularyKey creditLimit { get; private set; }
        public VocabularyKey creditlimit_Base { get; private set; }
        public VocabularyKey creditLimit_default { get; private set; }
        public VocabularyKey delinquencyStatus { get; private set; }
        public VocabularyKey financialHoldingCategory { get; private set; }
        public VocabularyKey financialHoldingType { get; private set; }
        public VocabularyKey integrationKey { get; private set; }
        public VocabularyKey interestrate { get; private set; }
        public VocabularyKey lastPaymentDueDate { get; private set; }
        public VocabularyKey lastStatementBalance { get; private set; }
        public VocabularyKey laststatementbalance_Base { get; private set; }
        public VocabularyKey lastStatementBalance_default { get; private set; }
        public VocabularyKey lastStatementDate { get; private set; }
        public VocabularyKey minimumPaymentDue { get; private set; }
        public VocabularyKey minimumpaymentdue_Base { get; private set; }
        public VocabularyKey minimumPaymentDue_default { get; private set; }
        public VocabularyKey monthlyPaymentPercentage { get; private set; }
        public VocabularyKey nextPaymentDate { get; private set; }
        public VocabularyKey nextStatementDate { get; private set; }
        public VocabularyKey balanceDefaultDisplayValue { get; private set; }
        public VocabularyKey balanceDisplayValue { get; private set; }
        public VocabularyKey balancedisplayvalue_Base { get; private set; }


    }
}