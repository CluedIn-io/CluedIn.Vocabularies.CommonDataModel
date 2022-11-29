using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class RequirementGroupVocabulary : SimpleVocabulary
    {
        public RequirementGroupVocabulary()
        {
            VocabularyName = "Requirement Group";
            KeyPrefix = "commonDataModel.requirementgroup.scheduling";
            KeySeparator = ".";
            Grouping = "/RequirementGroup";

            AddGroup("RequirementGroup Details for Scheduling", group =>
            {
			    RequirementgroupId = group.Add(new VocabularyKey(nameof(RequirementgroupId), "Requirement Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsTemplate = group.Add(new VocabularyKey(nameof(IsTemplate), "Is Template", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AutoGroupType = group.Add(new VocabularyKey(nameof(AutoGroupType), "Auto Group Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RequirementgroupId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey IsTemplate { get; private set; }
        public VocabularyKey AutoGroupType { get; private set; }
    }
}