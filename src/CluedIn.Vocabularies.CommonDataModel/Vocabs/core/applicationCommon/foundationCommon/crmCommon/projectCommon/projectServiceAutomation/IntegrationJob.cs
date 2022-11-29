using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class IntegrationJobVocabulary : SimpleVocabulary
    {
        public IntegrationJobVocabulary()
        {
            VocabularyName = "Integration Job";
            KeyPrefix = "commonDataModel.integrationjob.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/IntegrationJob";

            AddGroup("IntegrationJob Details for ProjectServiceAutomation", group =>
            {
			    IntegrationJobId = group.Add(new VocabularyKey(nameof(IntegrationJobId), "Integration Job", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfPackets = group.Add(new VocabularyKey(nameof(NumberOfPackets), "Number of packets", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RegardingEntity = group.Add(new VocabularyKey(nameof(RegardingEntity), "Regarding Entity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RegardingEntityId = group.Add(new VocabularyKey(nameof(RegardingEntityId), "Regarding Entity Id", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ResponseJSON = group.Add(new VocabularyKey(nameof(ResponseJSON), "ResponseJSON", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey IntegrationJobId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NumberOfPackets { get; private set; }
        public VocabularyKey RegardingEntity { get; private set; }
        public VocabularyKey RegardingEntityId { get; private set; }
        public VocabularyKey ResponseJSON { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}