using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class BookingAlertStatusVocabulary : SimpleVocabulary
    {
        public BookingAlertStatusVocabulary()
        {
            VocabularyName = "Booking Alert Status";
            KeyPrefix = "commonDataModel.bookingalertstatus.scheduling";
            KeySeparator = ".";
            Grouping = "/BookingAlertStatus";

            AddGroup("BookingAlertStatus Details for Scheduling", group =>
            {
			    BookingAlertStatusId = group.Add(new VocabularyKey(nameof(BookingAlertStatusId), "Booking Alert Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InternalFlags = group.Add(new VocabularyKey(nameof(InternalFlags), "Internal Flags", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NextTimeToShow = group.Add(new VocabularyKey(nameof(NextTimeToShow), "Next Time To Show", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Alert Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BookingAlertStatusId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey InternalFlags { get; private set; }
        public VocabularyKey NextTimeToShow { get; private set; }
        public VocabularyKey Status { get; private set; }
    }
}