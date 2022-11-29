using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class RoleUtilizationVocabulary : SimpleVocabulary
    {
        public RoleUtilizationVocabulary()
        {
            VocabularyName = "Role Utilization";
            KeyPrefix = "commonDataModel.roleutilization.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/RoleUtilization";

            AddGroup("RoleUtilization Details for ProjectServiceAutomation", group =>
            {
			    RoleUtilizationId = group.Add(new VocabularyKey(nameof(RoleUtilizationId), "Role Utilization", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TargetUtilizationPercent = group.Add(new VocabularyKey(nameof(TargetUtilizationPercent), "Target Utilization Percent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UtilizationPercent = group.Add(new VocabularyKey(nameof(UtilizationPercent), "Utilization Percent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UtilizationPercentDifference = group.Add(new VocabularyKey(nameof(UtilizationPercentDifference), "Utilization Percent Difference", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RoleUtilizationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey TargetUtilizationPercent { get; private set; }
        public VocabularyKey UtilizationPercent { get; private set; }
        public VocabularyKey UtilizationPercentDifference { get; private set; }
    }
}