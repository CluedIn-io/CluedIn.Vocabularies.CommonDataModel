using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class ServiceContractTypeVocabulary : SimpleVocabulary
    {
        public ServiceContractTypeVocabulary()
        {
            VocabularyName = "Service Contract Type";
            KeyPrefix = "commonDataModel.servicecontracttype.automotive";
            KeySeparator = ".";
            Grouping = "/ServiceContractType";

            AddGroup("ServiceContractType Details for Automotive", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Duration = group.Add(new VocabularyKey(nameof(Duration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DurationUnit = group.Add(new VocabularyKey(nameof(DurationUnit), "Duration Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ServiceContractTypeId = group.Add(new VocabularyKey(nameof(ServiceContractTypeId), "Service Contract Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey DurationUnit { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ServiceContractTypeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}