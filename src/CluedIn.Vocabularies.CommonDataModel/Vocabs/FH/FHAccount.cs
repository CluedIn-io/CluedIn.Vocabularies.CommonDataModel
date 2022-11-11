using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FHAccountVocabulary : SimpleVocabulary
    {
        public FHAccountVocabulary()
        {
            VocabularyName = "Common Data Model FHAccount";
            KeyPrefix = "commonDataModel.fhaccount";
            KeySeparator = ".";
            Grouping = "/FHAccount";

            AddGroup("Common Data Model FHAccount Details", group =>
            {
                FH_AccountId = group.Add(new VocabularyKey(nameof(FH_AccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                availableBalance = group.Add(new VocabularyKey(nameof(availableBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                availablebalance_Base = group.Add(new VocabularyKey(nameof(availablebalance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                availableBalance_default = group.Add(new VocabularyKey(nameof(availableBalance_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                averageBalance = group.Add(new VocabularyKey(nameof(averageBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                averagebalance_Base = group.Add(new VocabularyKey(nameof(averagebalance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                averageBalance_default = group.Add(new VocabularyKey(nameof(averageBalance_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balance = group.Add(new VocabularyKey(nameof(balance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balance_Base = group.Add(new VocabularyKey(nameof(balance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balanceDefault = group.Add(new VocabularyKey(nameof(balanceDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balanceExchangerate = group.Add(new VocabularyKey(nameof(balanceExchangerate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                blockedAmount = group.Add(new VocabularyKey(nameof(blockedAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                blockedamount_Base = group.Add(new VocabularyKey(nameof(blockedamount_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                blockedAmount_default = group.Add(new VocabularyKey(nameof(blockedAmount_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                dateoflasttransaction = group.Add(new VocabularyKey(nameof(dateoflasttransaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                delinquencyStatus = group.Add(new VocabularyKey(nameof(delinquencyStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                financialHoldingCategory = group.Add(new VocabularyKey(nameof(financialHoldingCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                financialHoldingType = group.Add(new VocabularyKey(nameof(financialHoldingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                integrationKey = group.Add(new VocabularyKey(nameof(integrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                interestrate = group.Add(new VocabularyKey(nameof(interestrate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                interestType = group.Add(new VocabularyKey(nameof(interestType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                numberoftransactions = group.Add(new VocabularyKey(nameof(numberoftransactions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                unclearedBalance = group.Add(new VocabularyKey(nameof(unclearedBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                unclearedbalance_Base = group.Add(new VocabularyKey(nameof(unclearedbalance_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                unclearedBalance_default = group.Add(new VocabularyKey(nameof(unclearedBalance_default), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balanceDefaultDisplayValue = group.Add(new VocabularyKey(nameof(balanceDefaultDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balanceDisplayValue = group.Add(new VocabularyKey(nameof(balanceDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                balancedisplayvalue_Base = group.Add(new VocabularyKey(nameof(balancedisplayvalue_Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FH_AccountId { get; private set; }
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
        public VocabularyKey availableBalance { get; private set; }
        public VocabularyKey availablebalance_Base { get; private set; }
        public VocabularyKey availableBalance_default { get; private set; }
        public VocabularyKey averageBalance { get; private set; }
        public VocabularyKey averagebalance_Base { get; private set; }
        public VocabularyKey averageBalance_default { get; private set; }
        public VocabularyKey balance { get; private set; }
        public VocabularyKey balance_Base { get; private set; }
        public VocabularyKey balanceDefault { get; private set; }
        public VocabularyKey balanceExchangerate { get; private set; }
        public VocabularyKey blockedAmount { get; private set; }
        public VocabularyKey blockedamount_Base { get; private set; }
        public VocabularyKey blockedAmount_default { get; private set; }
        public VocabularyKey dateoflasttransaction { get; private set; }
        public VocabularyKey delinquencyStatus { get; private set; }
        public VocabularyKey financialHoldingCategory { get; private set; }
        public VocabularyKey financialHoldingType { get; private set; }
        public VocabularyKey integrationKey { get; private set; }
        public VocabularyKey interestrate { get; private set; }
        public VocabularyKey interestType { get; private set; }
        public VocabularyKey numberoftransactions { get; private set; }
        public VocabularyKey unclearedBalance { get; private set; }
        public VocabularyKey unclearedbalance_Base { get; private set; }
        public VocabularyKey unclearedBalance_default { get; private set; }
        public VocabularyKey balanceDefaultDisplayValue { get; private set; }
        public VocabularyKey balanceDisplayValue { get; private set; }
        public VocabularyKey balancedisplayvalue_Base { get; private set; }


    }
}