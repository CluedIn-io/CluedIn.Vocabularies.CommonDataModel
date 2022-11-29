using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectCommon
{
    public class BookableResourceBookingVocabulary : SimpleVocabulary
    {
        public BookableResourceBookingVocabulary()
        {
            VocabularyName = "Bookable Resource Booking";
            KeyPrefix = "commonDataModel.bookableresourcebooking.projectcommon";
            KeySeparator = ".";
            Grouping = "/BookableResourceBooking";

            AddGroup("BookableResourceBooking Details for ProjectCommon", group =>
            {
			    ActualArrivalTime = group.Add(new VocabularyKey(nameof(ActualArrivalTime), "Actual Arrival Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualTravelDuration = group.Add(new VocabularyKey(nameof(ActualTravelDuration), "Actual Travel Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AllowOverlapping = group.Add(new VocabularyKey(nameof(AllowOverlapping), "Allow Overlapping", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    BookingMethod = group.Add(new VocabularyKey(nameof(BookingMethod), "Booking Method", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CascadeCrewChanges = group.Add(new VocabularyKey(nameof(CascadeCrewChanges), "Cascade Crew Changes", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AcceptCascadeCrewChanges = group.Add(new VocabularyKey(nameof(AcceptCascadeCrewChanges), "Accept Cascade Crew Changes", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Effort = group.Add(new VocabularyKey(nameof(Effort), "Capacity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    EstimatedArrivalTime = group.Add(new VocabularyKey(nameof(EstimatedArrivalTime), "Estimated Arrival Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EstimatedTravelDuration = group.Add(new VocabularyKey(nameof(EstimatedTravelDuration), "Estimated Travel Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Latitude = group.Add(new VocabularyKey(nameof(Latitude), "Latitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Longitude = group.Add(new VocabularyKey(nameof(Longitude), "Longitude", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MilesTraveled = group.Add(new VocabularyKey(nameof(MilesTraveled), "Miles Traveled", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    WorkLocation = group.Add(new VocabularyKey(nameof(WorkLocation), "Work Location", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActualArrivalTime { get; private set; }
        public VocabularyKey ActualTravelDuration { get; private set; }
        public VocabularyKey AllowOverlapping { get; private set; }
        public VocabularyKey BookingMethod { get; private set; }
        public VocabularyKey CascadeCrewChanges { get; private set; }
        public VocabularyKey AcceptCascadeCrewChanges { get; private set; }
        public VocabularyKey Effort { get; private set; }
        public VocabularyKey EstimatedArrivalTime { get; private set; }
        public VocabularyKey EstimatedTravelDuration { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey MilesTraveled { get; private set; }
        public VocabularyKey WorkLocation { get; private set; }
    }
}