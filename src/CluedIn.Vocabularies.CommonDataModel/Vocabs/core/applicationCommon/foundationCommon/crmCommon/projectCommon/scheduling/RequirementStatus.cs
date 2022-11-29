using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class RequirementStatusVocabulary : SimpleVocabulary
    {
        public RequirementStatusVocabulary()
        {
            VocabularyName = "Requirement Status";
            KeyPrefix = "commonDataModel.requirementstatus.scheduling";
            KeySeparator = ".";
            Grouping = "/RequirementStatus";

            AddGroup("RequirementStatus Details for Scheduling", group =>
            {
			    RequirementStatusId = group.Add(new VocabularyKey(nameof(RequirementStatusId), "Requirement Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RequirementStatusId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Status { get; private set; }
    }
}