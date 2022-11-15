using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeadToOpportunityVocabulary : SimpleVocabulary
    {
        public LeadToOpportunityVocabulary()
        {
            VocabularyName = "Lead To Opportunity";
            KeyPrefix = "commonDataModel.leadtoopportunity";
            KeySeparator = ".";
            Grouping = "/LeadToOpportunity";

            AddGroup("LeadToOpportunity Details", group =>
            {
                ActiveStageId = group.Add(new VocabularyKey(nameof(ActiveStageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveStageStartedOn = group.Add(new VocabularyKey(nameof(ActiveStageStartedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BusinessProcessFlowInstanceId = group.Add(new VocabularyKey(nameof(BusinessProcessFlowInstanceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompletedOn = group.Add(new VocabularyKey(nameof(CompletedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Duration = group.Add(new VocabularyKey(nameof(Duration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ActiveStageId { get; private set; }
        public VocabularyKey ActiveStageStartedOn { get; private set; }
        public VocabularyKey BusinessProcessFlowInstanceId { get; private set; }
        public VocabularyKey CompletedOn { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}