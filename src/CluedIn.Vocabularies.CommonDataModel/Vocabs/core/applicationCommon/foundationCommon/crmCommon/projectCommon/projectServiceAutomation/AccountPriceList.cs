using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class AccountPriceListVocabulary : SimpleVocabulary
    {
        public AccountPriceListVocabulary()
        {
            VocabularyName = "Account Price List";
            KeyPrefix = "commonDataModel.accountpricelist.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/AccountPriceList";

            AddGroup("AccountPriceList Details for ProjectServiceAutomation", group =>
            {
			    AccountPriceListId = group.Add(new VocabularyKey(nameof(AccountPriceListId), "Account Price List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AccountPriceListId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}