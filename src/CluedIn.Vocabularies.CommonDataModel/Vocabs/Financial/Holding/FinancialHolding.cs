using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FinancialHoldingVocabulary : SimpleVocabulary
    {
        public FinancialHoldingVocabulary()
        {
            VocabularyName = "Common Data Model FinancialHolding";
            KeyPrefix = "commonDataModel.financialholding";
            KeySeparator = ".";
            Grouping = "/FinancialHolding";

            AddGroup("Common Data Model FinancialHolding Details", group =>
            {
                financialholdingId = group.Add(new VocabularyKey(nameof(financialholdingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                financialHoldingCategory = group.Add(new VocabularyKey(nameof(financialHoldingCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                financialHoldingCode = group.Add(new VocabularyKey(nameof(financialHoldingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                integrationKey = group.Add(new VocabularyKey(nameof(integrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                validFrom = group.Add(new VocabularyKey(nameof(validFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey financialholdingId { get; private set; }
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
        public VocabularyKey financialHoldingCategory { get; private set; }
        public VocabularyKey financialHoldingCode { get; private set; }
        public VocabularyKey integrationKey { get; private set; }
        public VocabularyKey validFrom { get; private set; }


    }
}