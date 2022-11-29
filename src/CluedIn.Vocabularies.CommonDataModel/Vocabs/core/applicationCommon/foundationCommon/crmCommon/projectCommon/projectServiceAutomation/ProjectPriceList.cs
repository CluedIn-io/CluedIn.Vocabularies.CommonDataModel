using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ProjectPriceListVocabulary : SimpleVocabulary
    {
        public ProjectPriceListVocabulary()
        {
            VocabularyName = "Project Price List";
            KeyPrefix = "commonDataModel.projectpricelist.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ProjectPriceList";

            AddGroup("ProjectPriceList Details for ProjectServiceAutomation", group =>
            {
			    ProjectPriceListId = group.Add(new VocabularyKey(nameof(ProjectPriceListId), "Project Price List", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ProjectPriceListId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}