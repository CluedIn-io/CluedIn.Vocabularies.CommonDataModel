using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class RequirementRelationshipVocabulary : SimpleVocabulary
    {
        public RequirementRelationshipVocabulary()
        {
            VocabularyName = "Requirement Relationship";
            KeyPrefix = "commonDataModel.requirementrelationship.scheduling";
            KeySeparator = ".";
            Grouping = "/RequirementRelationship";

            AddGroup("RequirementRelationship Details for Scheduling", group =>
            {
			    RequirementrelationshipId = group.Add(new VocabularyKey(nameof(RequirementrelationshipId), "Requirement Relationship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MinConditionCount = group.Add(new VocabularyKey(nameof(MinConditionCount), "Min Condition Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Operator = group.Add(new VocabularyKey(nameof(Operator), "Operator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResourceGroupings = group.Add(new VocabularyKey(nameof(ResourceGroupings), "Part of Same", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequirementGroupControlViewId = group.Add(new VocabularyKey(nameof(RequirementGroupControlViewId), "Requirement Group Control View Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RequirementrelationshipId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey MinConditionCount { get; private set; }
        public VocabularyKey Operator { get; private set; }
        public VocabularyKey ResourceGroupings { get; private set; }
        public VocabularyKey RequirementGroupControlViewId { get; private set; }
    }
}