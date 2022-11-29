using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/Account";

            AddGroup("Account Details for ProjectServiceAutomation", group =>
            {
			    DefaultPriceLevelId = group.Add(new VocabularyKey(nameof(DefaultPriceLevelId), "Product Price List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExternalID = group.Add(new VocabularyKey(nameof(ExternalID), "External ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DefaultPriceLevelId { get; private set; }
        public VocabularyKey ExternalID { get; private set; }
    }
}