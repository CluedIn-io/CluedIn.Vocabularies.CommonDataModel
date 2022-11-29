using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class PractitionerRoleVocabulary : SimpleVocabulary
    {
        public PractitionerRoleVocabulary()
        {
            VocabularyName = "Practitioner Role";
            KeyPrefix = "commonDataModel.practitionerrole.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/PractitionerRole";

            AddGroup("PractitionerRole Details for ElectronicMedicalRecords", group =>
            {
			    AvailabilityExceptions = group.Add(new VocabularyKey(nameof(AvailabilityExceptions), "Availability Exceptions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NotAvailableDescription = group.Add(new VocabularyKey(nameof(NotAvailableDescription), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NotAvailableEndDatetime = group.Add(new VocabularyKey(nameof(NotAvailableEndDatetime), "Not available (End datetime)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NotAvailableStartDatetime = group.Add(new VocabularyKey(nameof(NotAvailableStartDatetime), "Not available (Start datetime)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodEndDatetime = group.Add(new VocabularyKey(nameof(PeriodEndDatetime), "Period (End datetime)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodStartDatetime = group.Add(new VocabularyKey(nameof(PeriodStartDatetime), "Period (Start datetime)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PractitionerRoleId = group.Add(new VocabularyKey(nameof(PractitionerRoleId), "Practitioner Role", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PractitionerRoleNumber = group.Add(new VocabularyKey(nameof(PractitionerRoleNumber), "Practitioner Role Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AvailabilityExceptions { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NotAvailableDescription { get; private set; }
        public VocabularyKey NotAvailableEndDatetime { get; private set; }
        public VocabularyKey NotAvailableStartDatetime { get; private set; }
        public VocabularyKey PeriodEndDatetime { get; private set; }
        public VocabularyKey PeriodStartDatetime { get; private set; }
        public VocabularyKey PractitionerRoleId { get; private set; }
        public VocabularyKey PractitionerRoleNumber { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}