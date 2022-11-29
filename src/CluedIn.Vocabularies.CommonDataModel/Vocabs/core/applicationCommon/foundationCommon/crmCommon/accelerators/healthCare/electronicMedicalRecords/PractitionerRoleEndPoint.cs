using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class PractitionerRoleEndPointVocabulary : SimpleVocabulary
    {
        public PractitionerRoleEndPointVocabulary()
        {
            VocabularyName = "Practitioner Role End Point";
            KeyPrefix = "commonDataModel.practitionerroleendpoint.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/PractitionerRoleEndPoint";

            AddGroup("PractitionerRoleEndPoint Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PractitionerRoleEndPointId = group.Add(new VocabularyKey(nameof(PractitionerRoleEndPointId), "Practitioner Role End Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey PractitionerRoleEndPointId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}