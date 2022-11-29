using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class ListFormVocabulary : SimpleVocabulary
    {
        public ListFormVocabulary()
        {
            VocabularyName = "List Form";
            KeyPrefix = "commonDataModel.listform.marketing";
            KeySeparator = ".";
            Grouping = "/ListForm";

            AddGroup("ListForm Details for Marketing", group =>
            {
			    ListformId = group.Add(new VocabularyKey(nameof(ListformId), "List form", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ListformId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}