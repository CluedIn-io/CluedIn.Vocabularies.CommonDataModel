using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeadToOpportunityVocabulary : SimpleVocabulary
    {
        public LeadToOpportunityVocabulary()
        {
            VocabularyName = "LeadToOpportunity";
            KeyPrefix = "commonDataModel.leadtoopportunity";
            KeySeparator = ".";
            Grouping = "/LeadToOpportunity";

            AddGroup("LeadToOpportunity Details", group =>
            {
                activeStageId = group.Add(new VocabularyKey(nameof(activeStageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                activeStageStartedOn = group.Add(new VocabularyKey(nameof(activeStageStartedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                businessProcessFlowInstanceId = group.Add(new VocabularyKey(nameof(businessProcessFlowInstanceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                completedOn = group.Add(new VocabularyKey(nameof(completedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                duration = group.Add(new VocabularyKey(nameof(duration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                traversedPath = group.Add(new VocabularyKey(nameof(traversedPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey activeStageId { get; private set; }
        public VocabularyKey activeStageStartedOn { get; private set; }
        public VocabularyKey businessProcessFlowInstanceId { get; private set; }
        public VocabularyKey completedOn { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey createdOnBehalfBy { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey modifiedOnBehalfBy { get; private set; }
        public VocabularyKey duration { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey traversedPath { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }


    }
}