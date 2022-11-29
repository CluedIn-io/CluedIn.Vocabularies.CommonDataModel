using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class BookableResourceGroupVocabulary : SimpleVocabulary
    {
        public BookableResourceGroupVocabulary()
        {
            VocabularyName = "Bookable Resource Group";
            KeyPrefix = "commonDataModel.bookableresourcegroup.foundationcommon";
            KeySeparator = ".";
            Grouping = "/BookableResourceGroup";

            AddGroup("BookableResourceGroup Details for FoundationCommon", group =>
            {
			    BookableResourceGroupId = group.Add(new VocabularyKey(nameof(BookableResourceGroupId), "Bookable Resource Group", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FromDate = group.Add(new VocabularyKey(nameof(FromDate), "From Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ToDate = group.Add(new VocabularyKey(nameof(ToDate), "To Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BookableResourceGroupId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}