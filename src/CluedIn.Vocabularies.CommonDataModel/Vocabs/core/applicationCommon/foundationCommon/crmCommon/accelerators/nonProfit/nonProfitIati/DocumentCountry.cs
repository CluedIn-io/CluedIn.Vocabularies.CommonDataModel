using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class DocumentCountryVocabulary : SimpleVocabulary
    {
        public DocumentCountryVocabulary()
        {
            VocabularyName = "Document Country";
            KeyPrefix = "commonDataModel.documentcountry.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/DocumentCountry";

            AddGroup("DocumentCountry Details for NonProfitIati", group =>
            {
			    DocumentCountryId = group.Add(new VocabularyKey(nameof(DocumentCountryId), "Document Country", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DocumentCountryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}