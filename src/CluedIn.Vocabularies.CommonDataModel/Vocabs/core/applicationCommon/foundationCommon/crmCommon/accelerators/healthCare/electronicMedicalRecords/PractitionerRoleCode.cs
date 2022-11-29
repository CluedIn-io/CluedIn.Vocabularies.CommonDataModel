using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class PractitionerRoleCodeVocabulary : SimpleVocabulary
    {
        public PractitionerRoleCodeVocabulary()
        {
            VocabularyName = "Practitioner Role Code";
            KeyPrefix = "commonDataModel.practitionerrolecode.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/PractitionerRoleCode";

            AddGroup("PractitionerRoleCode Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PractitionerRoleCodeId = group.Add(new VocabularyKey(nameof(PractitionerRoleCodeId), "Practitioner Role Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey PractitionerRoleCodeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}