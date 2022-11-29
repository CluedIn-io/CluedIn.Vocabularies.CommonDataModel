using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectCommon
{
    public class RelationshipInsightsUnifiedConfigVocabulary : SimpleVocabulary
    {
        public RelationshipInsightsUnifiedConfigVocabulary()
        {
            VocabularyName = "Relationship Insights Unified Config";
            KeyPrefix = "commonDataModel.relationshipinsightsunifiedconfig.projectcommon";
            KeySeparator = ".";
            Grouping = "/RelationshipInsightsUnifiedConfig";

            AddGroup("RelationshipInsightsUnifiedConfig Details for ProjectCommon", group =>
            {
			    RelationshipInsightsUnifiedConfigId = group.Add(new VocabularyKey(nameof(RelationshipInsightsUnifiedConfigId), "msdyn_relationshipinsightsunifiedconfig", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NewName = group.Add(new VocabularyKey(nameof(NewName), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UseNewConfigExperience = group.Add(new VocabularyKey(nameof(UseNewConfigExperience), "msdyn_usenewconfigexperience", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RelationshipInsightsUnifiedConfigId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey NewName { get; private set; }
        public VocabularyKey UseNewConfigExperience { get; private set; }
    }
}