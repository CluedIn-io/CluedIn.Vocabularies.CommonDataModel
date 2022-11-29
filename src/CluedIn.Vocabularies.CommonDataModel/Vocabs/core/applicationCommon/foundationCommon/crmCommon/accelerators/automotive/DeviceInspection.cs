using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceInspectionVocabulary : SimpleVocabulary
    {
        public DeviceInspectionVocabulary()
        {
            VocabularyName = "Device Inspection";
            KeyPrefix = "commonDataModel.deviceinspection.automotive";
            KeySeparator = ".";
            Grouping = "/DeviceInspection";

            AddGroup("DeviceInspection Details for Automotive", group =>
            {
			    DeviceInspectionId = group.Add(new VocabularyKey(nameof(DeviceInspectionId), "Device Inspection", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Result = group.Add(new VocabularyKey(nameof(Result), "Result", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeviceInspectionId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Result { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}