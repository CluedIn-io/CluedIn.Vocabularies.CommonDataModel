using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class ServiceOrderJobVocabulary : SimpleVocabulary
    {
        public ServiceOrderJobVocabulary()
        {
            VocabularyName = "Service Order Job";
            KeyPrefix = "commonDataModel.serviceorderjob.automotive";
            KeySeparator = ".";
            Grouping = "/ServiceOrderJob";

            AddGroup("ServiceOrderJob Details for Automotive", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Number = group.Add(new VocabularyKey(nameof(Number), "Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OperationCode = group.Add(new VocabularyKey(nameof(OperationCode), "Operation Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ServiceOrderJobId = group.Add(new VocabularyKey(nameof(ServiceOrderJobId), "Service Order Job", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Number { get; private set; }
        public VocabularyKey OperationCode { get; private set; }
        public VocabularyKey ServiceOrderJobId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}