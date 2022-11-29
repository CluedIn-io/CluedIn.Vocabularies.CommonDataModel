using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class FeedbackVocabulary : SimpleVocabulary
    {
        public FeedbackVocabulary()
        {
            VocabularyName = "Feedback";
            KeyPrefix = "commonDataModel.feedback.applicationcommon";
            KeySeparator = ".";
            Grouping = "/Feedback";

            AddGroup("Feedback Details for ApplicationCommon", group =>
            {
			    FeedbackId = group.Add(new VocabularyKey(nameof(FeedbackId), "Feedback", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Rating = group.Add(new VocabularyKey(nameof(Rating), "Rating", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    MinRating = group.Add(new VocabularyKey(nameof(MinRating), "Minimum Rating", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    MaxRating = group.Add(new VocabularyKey(nameof(MaxRating), "Maximum Rating", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    NormalizedRating = group.Add(new VocabularyKey(nameof(NormalizedRating), "Normalized Rating", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Comments = group.Add(new VocabularyKey(nameof(Comments), "Comments", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Source = group.Add(new VocabularyKey(nameof(Source), "Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), "Owning User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningTeam = group.Add(new VocabularyKey(nameof(OwningTeam), "Owning Team", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ClosedOn = group.Add(new VocabularyKey(nameof(ClosedOn), "Closed On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey FeedbackId { get; private set; }
        public VocabularyKey Rating { get; private set; }
        public VocabularyKey MinRating { get; private set; }
        public VocabularyKey MaxRating { get; private set; }
        public VocabularyKey NormalizedRating { get; private set; }
        public VocabularyKey Comments { get; private set; }
        public VocabularyKey Source { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey OwningTeam { get; private set; }
        public VocabularyKey ClosedOn { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Title { get; private set; }
    }
}