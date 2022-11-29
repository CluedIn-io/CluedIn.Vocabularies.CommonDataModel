using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class BookableResourceCategoryVocabulary : SimpleVocabulary
    {
        public BookableResourceCategoryVocabulary()
        {
            VocabularyName = "Bookable Resource Category";
            KeyPrefix = "commonDataModel.bookableresourcecategory.foundationcommon";
            KeySeparator = ".";
            Grouping = "/BookableResourceCategory";

            AddGroup("BookableResourceCategory Details for FoundationCommon", group =>
            {
			    BookableResourceCategoryId = group.Add(new VocabularyKey(nameof(BookableResourceCategoryId), "Resource Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BookableResourceCategoryId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}