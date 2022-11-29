using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class DocumentLanguageVocabulary : SimpleVocabulary
    {
        public DocumentLanguageVocabulary()
        {
            VocabularyName = "Document Language";
            KeyPrefix = "commonDataModel.documentlanguage.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/DocumentLanguage";

            AddGroup("DocumentLanguage Details for NonProfitIati", group =>
            {
			    DocumentLanguageId = group.Add(new VocabularyKey(nameof(DocumentLanguageId), "Document Language", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DocumentLanguageId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}