using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceSensorVocabulary : SimpleVocabulary
    {
        public DeviceSensorVocabulary()
        {
            VocabularyName = "Device Sensor";
            KeyPrefix = "commonDataModel.devicesensor.automotive";
            KeySeparator = ".";
            Grouping = "/DeviceSensor";

            AddGroup("DeviceSensor Details for Automotive", group =>
            {
			    DeviceSensorId = group.Add(new VocabularyKey(nameof(DeviceSensorId), "Device Sensor", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IoTSensorReference = group.Add(new VocabularyKey(nameof(IoTSensorReference), "IoT Sensor Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SerialNumber = group.Add(new VocabularyKey(nameof(SerialNumber), "Serial Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeviceSensorId { get; private set; }
        public VocabularyKey IoTSensorReference { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SerialNumber { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}