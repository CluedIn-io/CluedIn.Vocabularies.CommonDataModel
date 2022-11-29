using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class VisionPrescriptionVocabulary : SimpleVocabulary
    {
        public VisionPrescriptionVocabulary()
        {
            VocabularyName = "Vision Prescription";
            KeyPrefix = "commonDataModel.visionprescription.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/VisionPrescription";

            AddGroup("VisionPrescription Details for ElectronicMedicalRecords", group =>
            {
			    DateWritten = group.Add(new VocabularyKey(nameof(DateWritten), "Date Written", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReasonType = group.Add(new VocabularyKey(nameof(ReasonType), "Reason Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VisionPrescriptionId = group.Add(new VocabularyKey(nameof(VisionPrescriptionId), "Vision Prescription", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VisionPrescriptionNumber = group.Add(new VocabularyKey(nameof(VisionPrescriptionNumber), "Vision Prescription Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DateWritten { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReasonType { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey VisionPrescriptionId { get; private set; }
        public VocabularyKey VisionPrescriptionNumber { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}