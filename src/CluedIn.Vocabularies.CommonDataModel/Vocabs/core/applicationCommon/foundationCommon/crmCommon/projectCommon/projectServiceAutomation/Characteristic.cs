using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class CharacteristicVocabulary : SimpleVocabulary
    {
        public CharacteristicVocabulary()
        {
            VocabularyName = "Characteristic";
            KeyPrefix = "commonDataModel.characteristic.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/Characteristic";

            AddGroup("Characteristic Details for ProjectServiceAutomation", group =>
            {
			    RequireApproval = group.Add(new VocabularyKey(nameof(RequireApproval), "Require Approval", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RequireApproval { get; private set; }
    }
}