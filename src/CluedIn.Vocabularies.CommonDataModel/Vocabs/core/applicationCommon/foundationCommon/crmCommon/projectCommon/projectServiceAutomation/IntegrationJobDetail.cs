using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class IntegrationJobDetailVocabulary : SimpleVocabulary
    {
        public IntegrationJobDetailVocabulary()
        {
            VocabularyName = "Integration Job Detail";
            KeyPrefix = "commonDataModel.integrationjobdetail.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/IntegrationJobDetail";

            AddGroup("IntegrationJobDetail Details for ProjectServiceAutomation", group =>
            {
			    IntegrationJobDetailId = group.Add(new VocabularyKey(nameof(IntegrationJobDetailId), "Integration Job Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ChangesJSON = group.Add(new VocabularyKey(nameof(ChangesJSON), "Changes JSON", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FullJSON = group.Add(new VocabularyKey(nameof(FullJSON), "Full JSON", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), "Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey IntegrationJobDetailId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ChangesJSON { get; private set; }
        public VocabularyKey FullJSON { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
    }
}