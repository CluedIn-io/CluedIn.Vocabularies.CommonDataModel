using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DeviceRequestPriorRequestVocabulary : SimpleVocabulary
    {
        public DeviceRequestPriorRequestVocabulary()
        {
            VocabularyName = "Device Request Prior Request";
            KeyPrefix = "commonDataModel.devicerequestpriorrequest.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/DeviceRequestPriorRequest";

            AddGroup("DeviceRequestPriorRequest Details for ElectronicMedicalRecords", group =>
            {
			    DeviceRequestPriorRequestId = group.Add(new VocabularyKey(nameof(DeviceRequestPriorRequestId), "Device Request Prior Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PriorRequest = group.Add(new VocabularyKey(nameof(PriorRequest), "Prior Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeviceRequestPriorRequestId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PriorRequest { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}