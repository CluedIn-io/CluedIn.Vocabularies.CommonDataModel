using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class GroupFinancialHoldingVocabulary : SimpleVocabulary
    {
        public GroupFinancialHoldingVocabulary()
        {
            VocabularyName = "Common Data Model GroupFinancialHolding";
            KeyPrefix = "commonDataModel.groupfinancialholding";
            KeySeparator = ".";
            Grouping = "/GroupFinancialHolding";

            AddGroup("Common Data Model GroupFinancialHolding Details", group =>
            {
                groupFinancialHoldingId = group.Add(new VocabularyKey(nameof(groupFinancialHoldingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statecode = group.Add(new VocabularyKey(nameof(statecode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statuscode = group.Add(new VocabularyKey(nameof(statuscode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey groupFinancialHoldingId { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey statecode { get; private set; }
        public VocabularyKey statuscode { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey name { get; private set; }


    }
}