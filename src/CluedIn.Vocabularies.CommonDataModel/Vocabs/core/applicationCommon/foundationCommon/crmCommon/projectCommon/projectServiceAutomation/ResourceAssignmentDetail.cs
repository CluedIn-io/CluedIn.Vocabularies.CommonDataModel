using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ResourceAssignmentDetailVocabulary : SimpleVocabulary
    {
        public ResourceAssignmentDetailVocabulary()
        {
            VocabularyName = "Resource Assignment Detail";
            KeyPrefix = "commonDataModel.resourceassignmentdetail.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ResourceAssignmentDetail";

            AddGroup("ResourceAssignmentDetail Details for ProjectServiceAutomation", group =>
            {
			    ResourceAssignmentDetailId = group.Add(new VocabularyKey(nameof(ResourceAssignmentDetailId), "Resource Assignment Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Duration = group.Add(new VocabularyKey(nameof(Duration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    From = group.Add(new VocabularyKey(nameof(From), "From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ResourceAssignmentDetailId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey From { get; private set; }
    }
}