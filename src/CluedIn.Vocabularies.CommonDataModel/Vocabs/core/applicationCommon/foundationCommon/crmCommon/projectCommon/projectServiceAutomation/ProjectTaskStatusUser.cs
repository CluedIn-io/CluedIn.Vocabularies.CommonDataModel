using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ProjectTaskStatusUserVocabulary : SimpleVocabulary
    {
        public ProjectTaskStatusUserVocabulary()
        {
            VocabularyName = "Project Task Status User";
            KeyPrefix = "commonDataModel.projecttaskstatususer.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ProjectTaskStatusUser";

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
        }

        public VocabularyKey ProjectTaskStatusUserId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExpectedCompletionDate { get; private set; }
        public VocabularyKey ExpectedHoursToComplete { get; private set; }
        public VocabularyKey IsCompleted { get; private set; }
        public VocabularyKey PercentComplete { get; private set; }
        public VocabularyKey ProjectTaskStatusIndicator { get; private set; }
    }
}