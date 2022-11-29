using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class BookingChangeVocabulary : SimpleVocabulary
    {
        public BookingChangeVocabulary()
        {
            VocabularyName = "Booking Change";
            KeyPrefix = "commonDataModel.bookingchange.scheduling";
            KeySeparator = ".";
            Grouping = "/BookingChange";

            AddGroup("BookingChange Details for Scheduling", group =>
            {
			    BookingChangeId = group.Add(new VocabularyKey(nameof(BookingChangeId), "Booking Change", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ChangesJSON = group.Add(new VocabularyKey(nameof(ChangesJSON), "Changes JSON", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BookingChangeId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ChangesJSON { get; private set; }
    }
}