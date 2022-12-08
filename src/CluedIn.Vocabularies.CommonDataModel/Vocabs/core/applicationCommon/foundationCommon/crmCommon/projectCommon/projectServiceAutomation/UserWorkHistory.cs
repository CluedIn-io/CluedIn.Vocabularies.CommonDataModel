using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ProjectServiceAutomation
{
    public class UserWorkHistoryVocabulary : SimpleVocabulary
    {
        public UserWorkHistoryVocabulary()
        {
            VocabularyName = "User Work History";
            KeyPrefix = "commonDataModel.userworkhistory.projectserviceautomation";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.UserWorkHistory;

            AddGroup("UserWorkHistory Details for ProjectServiceAutomation", group =>
            {
			    UserWorkHistoryId = group.Add(new VocabularyKey(nameof(UserWorkHistoryId), "User Work History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BudgetPerformance = group.Add(new VocabularyKey(nameof(BudgetPerformance), "Budget Performance", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    OnTimePerformance = group.Add(new VocabularyKey(nameof(OnTimePerformance), "On Time Performance", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    OnTimeProjectCount = group.Add(new VocabularyKey(nameof(OnTimeProjectCount), "On Time Project Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ProjectCount = group.Add(new VocabularyKey(nameof(ProjectCount), "Project Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RecordType = group.Add(new VocabularyKey(nameof(RecordType), "Record Type", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    SkillExperience = group.Add(new VocabularyKey(nameof(SkillExperience), "Skill Experience", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="BookableResource"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/BookableResource.cdm.json/BookableResource' with Property 'BookableResourceId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey UserWorkHistoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey BudgetPerformance { get; private set; }
        public VocabularyKey OnTimePerformance { get; private set; }
        public VocabularyKey OnTimeProjectCount { get; private set; }
        public VocabularyKey ProjectCount { get; private set; }
        public VocabularyKey RecordType { get; private set; }
        public VocabularyKey SkillExperience { get; private set; }
    }
}