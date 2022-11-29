using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class RoleCompetencyRequirementVocabulary : SimpleVocabulary
    {
        public RoleCompetencyRequirementVocabulary()
        {
            VocabularyName = "Role Competency Requirement";
            KeyPrefix = "commonDataModel.rolecompetencyrequirement.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/RoleCompetencyRequirement";

            AddGroup("RoleCompetencyRequirement Details for ProjectServiceAutomation", group =>
            {
			    RoleCompetencyRequirementId = group.Add(new VocabularyKey(nameof(RoleCompetencyRequirementId), "Role competency requirement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BookableCharacteristicType = group.Add(new VocabularyKey(nameof(BookableCharacteristicType), "Bookable Characteristic Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RoleCompetencyRequirementId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey BookableCharacteristicType { get; private set; }
    }
}