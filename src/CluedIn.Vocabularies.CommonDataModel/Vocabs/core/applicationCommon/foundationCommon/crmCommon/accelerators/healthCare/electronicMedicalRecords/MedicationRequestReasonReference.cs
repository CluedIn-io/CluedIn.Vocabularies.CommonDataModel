using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationRequestReasonReferenceVocabulary : SimpleVocabulary
    {
        public MedicationRequestReasonReferenceVocabulary()
        {
            VocabularyName = "Medication Request Reason Reference";
            KeyPrefix = "commonDataModel.medicationrequestreasonreference.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationRequestReasonReference";

            AddGroup("MedicationRequestReasonReference Details for ElectronicMedicalRecords", group =>
            {
			    MedicationRequestReasonReferenceId = group.Add(new VocabularyKey(nameof(MedicationRequestReasonReferenceId), "Medication Request Reason Reference", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReasonReferenceType = group.Add(new VocabularyKey(nameof(ReasonReferenceType), "Reason Reference Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationRequestReasonReferenceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReasonReferenceType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}