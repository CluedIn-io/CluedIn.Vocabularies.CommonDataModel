using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class BookableResourceCategoryAssnVocabulary : SimpleVocabulary
    {
        public BookableResourceCategoryAssnVocabulary()
        {
            VocabularyName = "Bookable Resource Category Assn";
            KeyPrefix = "commonDataModel.bookableresourcecategoryassn.foundationcommon";
            KeySeparator = ".";
            Grouping = "/BookableResourceCategoryAssn";

            AddGroup("BookableResourceCategoryAssn Details for FoundationCommon", group =>
            {
			    BookableResourceCategoryAssnId = group.Add(new VocabularyKey(nameof(BookableResourceCategoryAssnId), "Resource Category Assn", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BookableResourceCategoryAssnId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}