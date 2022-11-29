using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RequestGroupVocabulary : SimpleVocabulary
    {
        public RequestGroupVocabulary()
        {
            VocabularyName = "Request Group";
            KeyPrefix = "commonDataModel.requestgroup.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RequestGroup";

            AddGroup("RequestGroup Details for ElectronicMedicalRecords", group =>
            {
			    AuthoredOn = group.Add(new VocabularyKey(nameof(AuthoredOn), "Authored On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AuthorType = group.Add(new VocabularyKey(nameof(AuthorType), "Author Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GroupNumber = group.Add(new VocabularyKey(nameof(GroupNumber), "Group Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Intent = group.Add(new VocabularyKey(nameof(Intent), "Intent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Priority = group.Add(new VocabularyKey(nameof(Priority), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReasonReference = group.Add(new VocabularyKey(nameof(ReasonReference), "Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReasonType = group.Add(new VocabularyKey(nameof(ReasonType), "Reason Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupId = group.Add(new VocabularyKey(nameof(RequestGroupId), "Request Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupNumber = group.Add(new VocabularyKey(nameof(RequestGroupNumber), "Request Group Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AuthoredOn { get; private set; }
        public VocabularyKey AuthorType { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey GroupNumber { get; private set; }
        public VocabularyKey Intent { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey ReasonReference { get; private set; }
        public VocabularyKey ReasonType { get; private set; }
        public VocabularyKey RequestGroupId { get; private set; }
        public VocabularyKey RequestGroupNumber { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}