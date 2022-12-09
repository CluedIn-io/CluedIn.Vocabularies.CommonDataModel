using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ProjectTaskStatusUserVocabulary : SimpleVocabulary
    {
        public ProjectTaskStatusUserVocabulary()
        {
            VocabularyName = "Project Task Status User";
            KeyPrefix = "commonDataModel.projecttaskstatususer";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ProjectTaskStatusUser;

            AddGroup("ProjectTaskStatusUser Details for ProjectServiceAutomation", group =>
            {
			    ProjectTaskStatusUserId = group.Add(new VocabularyKey(nameof(ProjectTaskStatusUserId), "Project Task Status User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedCompletionDate = group.Add(new VocabularyKey(nameof(ExpectedCompletionDate), "Expected Completion Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedHoursToComplete = group.Add(new VocabularyKey(nameof(ExpectedHoursToComplete), "Expected Hours To Complete", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    IsCompleted = group.Add(new VocabularyKey(nameof(IsCompleted), "Is Completed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    PercentComplete = group.Add(new VocabularyKey(nameof(PercentComplete), "Percent Complete", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ProjectTaskStatusIndicator = group.Add(new VocabularyKey(nameof(ProjectTaskStatusIndicator), "Project Task Status Indicator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ProjectTaskId"/> to Vocab 'ProjectTask.cdm.json/ProjectTask' with Property 'ProjectTaskId'
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

        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExpectedCompletionDate { get; private set; }
        public VocabularyKey ExpectedHoursToComplete { get; private set; }
        public VocabularyKey IsCompleted { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PercentComplete { get; private set; }
        public VocabularyKey ProjectTaskStatusIndicator { get; private set; }
        public VocabularyKey ProjectTaskStatusUserId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}