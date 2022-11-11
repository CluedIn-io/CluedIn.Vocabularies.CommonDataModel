using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FinancialHoldingInstrumentVocabulary : SimpleVocabulary
    {
        public FinancialHoldingInstrumentVocabulary()
        {
            VocabularyName = "FinancialHoldingInstrument";
            KeyPrefix = "commonDataModel.financialholdinginstrument";
            KeySeparator = ".";
            Grouping = "/FinancialHoldingInstrument";

            AddGroup("FinancialHoldingInstrument Details", group =>
            {
                financialholdinginstrumentId = group.Add(new VocabularyKey(nameof(financialholdinginstrumentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                financialHoldingInstrumentType = group.Add(new VocabularyKey(nameof(financialHoldingInstrumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                financialInstrumentCode = group.Add(new VocabularyKey(nameof(financialInstrumentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                integrationKey = group.Add(new VocabularyKey(nameof(integrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey financialholdinginstrumentId { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey statecode { get; private set; }
        public VocabularyKey statuscode { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey financialHoldingInstrumentType { get; private set; }
        public VocabularyKey financialInstrumentCode { get; private set; }
        public VocabularyKey integrationKey { get; private set; }


    }
}