using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ProjectTaskDependencyVocabulary : SimpleVocabulary
    {
        public ProjectTaskDependencyVocabulary()
        {
            VocabularyName = "Project Task Dependency";
            KeyPrefix = "commonDataModel.projecttaskdependency.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ProjectTaskDependency";

            AddGroup("ProjectTaskDependency Details for ProjectServiceAutomation", group =>
            {
			    ProjectTaskDependencyId = group.Add(new VocabularyKey(nameof(ProjectTaskDependencyId), "Project Task Dependency", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkType = group.Add(new VocabularyKey(nameof(LinkType), "Link Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ProjectTaskDependencyId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LinkType { get; private set; }
    }
}