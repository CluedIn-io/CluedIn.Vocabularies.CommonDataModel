using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class DocumentCategoryVocabulary : SimpleVocabulary
    {
        public DocumentCategoryVocabulary()
        {
            VocabularyName = "Document Category";
            KeyPrefix = "commonDataModel.documentcategory.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/DocumentCategory";

            AddGroup("DocumentCategory Details for NonProfitIati", group =>
            {
			    Category = group.Add(new VocabularyKey(nameof(Category), "Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DocumentCategoryId = group.Add(new VocabularyKey(nameof(DocumentCategoryId), "Document Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Category { get; private set; }
        public VocabularyKey DocumentCategoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}