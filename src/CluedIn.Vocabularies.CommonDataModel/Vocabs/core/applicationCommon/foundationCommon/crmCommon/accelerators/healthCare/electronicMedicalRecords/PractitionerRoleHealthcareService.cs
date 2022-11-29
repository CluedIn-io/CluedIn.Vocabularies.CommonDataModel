using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class PractitionerRoleHealthcareServiceVocabulary : SimpleVocabulary
    {
        public PractitionerRoleHealthcareServiceVocabulary()
        {
            VocabularyName = "Practitioner Role Healthcare Service";
            KeyPrefix = "commonDataModel.practitionerrolehealthcareservice.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/PractitionerRoleHealthcareService";

            AddGroup("PractitionerRoleHealthcareService Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PractitionerRoleHealthcareServiceId = group.Add(new VocabularyKey(nameof(PractitionerRoleHealthcareServiceId), "Practitioner Role Healthcare Service", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey PractitionerRoleHealthcareServiceId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}