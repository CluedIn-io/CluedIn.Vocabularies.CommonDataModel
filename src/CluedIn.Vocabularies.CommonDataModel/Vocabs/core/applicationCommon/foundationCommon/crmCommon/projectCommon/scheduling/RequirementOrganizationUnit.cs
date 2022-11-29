using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class RequirementOrganizationUnitVocabulary : SimpleVocabulary
    {
        public RequirementOrganizationUnitVocabulary()
        {
            VocabularyName = "Requirement Organization Unit";
            KeyPrefix = "commonDataModel.requirementorganizationunit.scheduling";
            KeySeparator = ".";
            Grouping = "/RequirementOrganizationUnit";

            AddGroup("RequirementOrganizationUnit Details for Scheduling", group =>
            {
			    RequirementOrganizationUnitId = group.Add(new VocabularyKey(nameof(RequirementOrganizationUnitId), "Requirement Organization Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RequirementOrganizationUnitId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}