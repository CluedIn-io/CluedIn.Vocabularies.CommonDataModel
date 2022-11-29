using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CarePlanCareTeamVocabulary : SimpleVocabulary
    {
        public CarePlanCareTeamVocabulary()
        {
            VocabularyName = "Care Plan Care Team";
            KeyPrefix = "commonDataModel.careplancareteam.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CarePlanCareTeam";

            AddGroup("CarePlanCareTeam Details for ElectronicMedicalRecords", group =>
            {
			    CarePlanCareTeamId = group.Add(new VocabularyKey(nameof(CarePlanCareTeamId), "Care Plan Care Team", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CarePlanCareTeamId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}