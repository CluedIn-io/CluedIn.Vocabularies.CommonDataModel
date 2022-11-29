using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class CareTeamManagingOrganizationVocabulary : SimpleVocabulary
    {
        public CareTeamManagingOrganizationVocabulary()
        {
            VocabularyName = "Care Team Managing Organization";
            KeyPrefix = "commonDataModel.careteammanagingorganization.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/CareTeamManagingOrganization";

            AddGroup("CareTeamManagingOrganization Details for ElectronicMedicalRecords", group =>
            {
			    CareTeamManagingOrganizationId = group.Add(new VocabularyKey(nameof(CareTeamManagingOrganizationId), "Care Team Managing Organization", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CareTeamManagingOrganizationId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}