using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectCommon
{
    public class RelationshipInsightsUnifiedConfigVocabulary : SimpleVocabulary
    {
        public RelationshipInsightsUnifiedConfigVocabulary()
        {
            VocabularyName = "Relationship Insights Unified Config";
            KeyPrefix = "commonDataModel.relationshipinsightsunifiedconfig.projectcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.RelationshipInsightsUnifiedConfig;

            AddGroup("RelationshipInsightsUnifiedConfig Details for ProjectCommon", group =>
            {
			    RelationshipInsightsUnifiedConfigId = group.Add(new VocabularyKey(nameof(RelationshipInsightsUnifiedConfigId), "msdyn_relationshipinsightsunifiedconfig", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NewName = group.Add(new VocabularyKey(nameof(NewName), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    UseNewConfigExperience = group.Add(new VocabularyKey(nameof(UseNewConfigExperience), "msdyn_usenewconfigexperience", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey RelationshipInsightsUnifiedConfigId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey NewName { get; private set; }
        public VocabularyKey UseNewConfigExperience { get; private set; }
    }
}