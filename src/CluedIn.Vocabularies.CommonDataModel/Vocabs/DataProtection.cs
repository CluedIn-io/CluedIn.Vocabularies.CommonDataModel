using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DataProtectionVocabulary : SimpleVocabulary
    {
        public DataProtectionVocabulary()
        {
            VocabularyName = "DataProtection";
            KeyPrefix = "commonDataModel.dataprotection";
            KeySeparator = ".";
            Grouping = "/DataProtection";

            AddGroup("DataProtection Details", group =>
            {
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                gdprconfigurationId = group.Add(new VocabularyKey(nameof(gdprconfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isDefault = group.Add(new VocabularyKey(nameof(isDefault), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isenforced = group.Add(new VocabularyKey(nameof(isenforced), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                isconsentchangeloggingenabled = group.Add(new VocabularyKey(nameof(isconsentchangeloggingenabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey createdOnBehalfBy { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey modifiedOnBehalfBy { get; private set; }
        public VocabularyKey gdprconfigurationId { get; private set; }
        public VocabularyKey isDefault { get; private set; }
        public VocabularyKey isenforced { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey isconsentchangeloggingenabled { get; private set; }


    }
}