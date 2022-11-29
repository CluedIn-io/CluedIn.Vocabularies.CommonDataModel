using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectCommon
{
    public class BookableResourceBookingHeaderVocabulary : SimpleVocabulary
    {
        public BookableResourceBookingHeaderVocabulary()
        {
            VocabularyName = "Bookable Resource Booking Header";
            KeyPrefix = "commonDataModel.bookableresourcebookingheader.projectcommon";
            KeySeparator = ".";
            Grouping = "/BookableResourceBookingHeader";

            AddGroup("BookableResourceBookingHeader Details for ProjectCommon", group =>
            {
			    BookingType = group.Add(new VocabularyKey(nameof(BookingType), "Booking Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BookingType { get; private set; }
    }
}