using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class DeviceMeasurementVocabulary : SimpleVocabulary
    {
        public DeviceMeasurementVocabulary()
        {
            VocabularyName = "Device Measurement";
            KeyPrefix = "commonDataModel.devicemeasurement.automotive";
            KeySeparator = ".";
            Grouping = "/DeviceMeasurement";

            AddGroup("DeviceMeasurement Details for Automotive", group =>
            {
			    DeviceMeasurementId = group.Add(new VocabularyKey(nameof(DeviceMeasurementId), "Device Measurement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MeasuredOn = group.Add(new VocabularyKey(nameof(MeasuredOn), "Measured On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MeasuredValue = group.Add(new VocabularyKey(nameof(MeasuredValue), "Measured Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DeviceMeasurementId { get; private set; }
        public VocabularyKey MeasuredOn { get; private set; }
        public VocabularyKey MeasuredValue { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}