using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class EncounterVocabulary : SimpleVocabulary
    {
        public EncounterVocabulary()
        {
            VocabularyName = "Encounter";
            KeyPrefix = "commonDataModel.encounter.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Encounter";

            AddGroup("Encounter Details for ElectronicMedicalRecords", group =>
            {
			    Class = group.Add(new VocabularyKey(nameof(Class), "Class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Duration = group.Add(new VocabularyKey(nameof(Duration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    EncounterClass = group.Add(new VocabularyKey(nameof(EncounterClass), "Class", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterEndDate = group.Add(new VocabularyKey(nameof(EncounterEndDate), "End Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterId = group.Add(new VocabularyKey(nameof(EncounterId), "Encounter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterIdentifier = group.Add(new VocabularyKey(nameof(EncounterIdentifier), "Encounter Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterLength = group.Add(new VocabularyKey(nameof(EncounterLength), "Duration", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EncounterStartDate = group.Add(new VocabularyKey(nameof(EncounterStartDate), "Start Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EncounterStatus = group.Add(new VocabularyKey(nameof(EncounterStatus), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    HospitalizationPreAdmissionNumber = group.Add(new VocabularyKey(nameof(HospitalizationPreAdmissionNumber), "Pre Admission Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodEnd = group.Add(new VocabularyKey(nameof(PeriodEnd), "Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodStart = group.Add(new VocabularyKey(nameof(PeriodStart), "Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Priority = group.Add(new VocabularyKey(nameof(Priority), "Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Class { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey EncounterClass { get; private set; }
        public VocabularyKey EncounterEndDate { get; private set; }
        public VocabularyKey EncounterId { get; private set; }
        public VocabularyKey EncounterIdentifier { get; private set; }
        public VocabularyKey EncounterLength { get; private set; }
        public VocabularyKey EncounterStartDate { get; private set; }
        public VocabularyKey EncounterStatus { get; private set; }
        public VocabularyKey HospitalizationPreAdmissionNumber { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PeriodEnd { get; private set; }
        public VocabularyKey PeriodStart { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}