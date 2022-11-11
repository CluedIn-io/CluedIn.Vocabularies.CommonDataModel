using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FormMatchingVocabulary : SimpleVocabulary
    {
        public FormMatchingVocabulary()
        {
            VocabularyName = "Common Data Model FormMatching";
            KeyPrefix = "commonDataModel.formmatching";
            KeySeparator = ".";
            Grouping = "/FormMatching";

            AddGroup("Common Data Model FormMatching Details", group =>
            {
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                matchingstrategyfields = group.Add(new VocabularyKey(nameof(matchingstrategyfields), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                matchingstrategyId = group.Add(new VocabularyKey(nameof(matchingstrategyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                targetentity = group.Add(new VocabularyKey(nameof(targetentity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                matchingstrategyfieldsstatus = group.Add(new VocabularyKey(nameof(matchingstrategyfieldsstatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey createdOnBehalfBy { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey modifiedOnBehalfBy { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey matchingstrategyfields { get; private set; }
        public VocabularyKey matchingstrategyId { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey targetentity { get; private set; }
        public VocabularyKey matchingstrategyfieldsstatus { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }


    }
}