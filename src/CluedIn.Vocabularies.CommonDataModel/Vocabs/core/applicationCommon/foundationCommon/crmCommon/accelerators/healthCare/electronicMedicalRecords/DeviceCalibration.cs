using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class DeviceCalibrationVocabulary : SimpleVocabulary
    {
        public DeviceCalibrationVocabulary()
        {
            VocabularyName = "Device Calibration";
            KeyPrefix = "commonDataModel.devicecalibration.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/DeviceCalibration";

            AddGroup("DeviceCalibration Details for ElectronicMedicalRecords", group =>
            {
			    CalibrationState = group.Add(new VocabularyKey(nameof(CalibrationState), "State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CalibrationTime = group.Add(new VocabularyKey(nameof(CalibrationTime), "Calibration Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeviceCalibrationId = group.Add(new VocabularyKey(nameof(DeviceCalibrationId), "Device Calibration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CalibrationState { get; private set; }
        public VocabularyKey CalibrationTime { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DeviceCalibrationId { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}