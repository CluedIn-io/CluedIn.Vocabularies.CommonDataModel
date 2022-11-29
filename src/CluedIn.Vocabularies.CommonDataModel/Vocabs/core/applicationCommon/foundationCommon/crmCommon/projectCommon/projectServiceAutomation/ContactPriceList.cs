using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ContactPriceListVocabulary : SimpleVocabulary
    {
        public ContactPriceListVocabulary()
        {
            VocabularyName = "Contact Price List";
            KeyPrefix = "commonDataModel.contactpricelist.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ContactPriceList";

            AddGroup("ContactPriceList Details for ProjectServiceAutomation", group =>
            {
			    ContactPriceListId = group.Add(new VocabularyKey(nameof(ContactPriceListId), "Contact Price List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ContactPriceListId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}