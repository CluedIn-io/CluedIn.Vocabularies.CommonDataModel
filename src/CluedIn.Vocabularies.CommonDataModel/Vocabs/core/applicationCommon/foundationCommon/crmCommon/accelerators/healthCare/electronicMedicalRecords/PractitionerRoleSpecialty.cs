using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class PractitionerRoleSpecialtyVocabulary : SimpleVocabulary
    {
        public PractitionerRoleSpecialtyVocabulary()
        {
            VocabularyName = "Practitioner Role Specialty";
            KeyPrefix = "commonDataModel.practitionerrolespecialty.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/PractitionerRoleSpecialty";

            AddGroup("PractitionerRoleSpecialty Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PractitionerRoleSpecialtyId = group.Add(new VocabularyKey(nameof(PractitionerRoleSpecialtyId), "Practitioner Role Specialty", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey PractitionerRoleSpecialtyId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}