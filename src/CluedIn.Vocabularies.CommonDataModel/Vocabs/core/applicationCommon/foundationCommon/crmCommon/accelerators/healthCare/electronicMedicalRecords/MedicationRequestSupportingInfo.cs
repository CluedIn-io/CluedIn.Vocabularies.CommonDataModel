using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicationRequestSupportingInfoVocabulary : SimpleVocabulary
    {
        public MedicationRequestSupportingInfoVocabulary()
        {
            VocabularyName = "Medication Request Supporting Info";
            KeyPrefix = "commonDataModel.medicationrequestsupportinginfo.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicationRequestSupportingInfo";

            AddGroup("MedicationRequestSupportingInfo Details for ElectronicMedicalRecords", group =>
            {
			    MedicationRequestSupportingInfoId = group.Add(new VocabularyKey(nameof(MedicationRequestSupportingInfoId), "Medication Request Supporting Info", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SupportingInformation = group.Add(new VocabularyKey(nameof(SupportingInformation), "Supporting Information", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MedicationRequestSupportingInfoId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SupportingInformation { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}