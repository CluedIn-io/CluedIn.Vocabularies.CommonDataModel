using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.CustomerInsights
{
    public class CustomerActivityVocabulary : SimpleVocabulary
    {
        public CustomerActivityVocabulary()
        {
            VocabularyName = "Customer Activity";
            KeyPrefix = "commonDataModel.customeractivity.customerinsights";
            KeySeparator = ".";
            Grouping = "/CustomerActivity";

            AddGroup("CustomerActivity Details for CustomerInsights", group =>
            {
			    ActivityName = group.Add(new VocabularyKey(nameof(ActivityName), "Activity Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityType = group.Add(new VocabularyKey(nameof(ActivityType), "Activity Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualEndDate = group.Add(new VocabularyKey(nameof(ActualEndDate), "Actual End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualStartDate = group.Add(new VocabularyKey(nameof(ActualStartDate), "Actual Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AttachmentReferences = group.Add(new VocabularyKey(nameof(AttachmentReferences), "AttachmentReferences", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Community = group.Add(new VocabularyKey(nameof(Community), "Community", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CustomerActivityId = group.Add(new VocabularyKey(nameof(CustomerActivityId), "CustomerActivity", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Mentions = group.Add(new VocabularyKey(nameof(Mentions), "Mentions", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Message = group.Add(new VocabularyKey(nameof(Message), "Message", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NumberOfResponses = group.Add(new VocabularyKey(nameof(NumberOfResponses), "Number of Responses", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Sentiment = group.Add(new VocabularyKey(nameof(Sentiment), "Sentiment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Subject = group.Add(new VocabularyKey(nameof(Subject), "Subject", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Url = group.Add(new VocabularyKey(nameof(Url), "Url", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    Version = group.Add(new VocabularyKey(nameof(Version), "Version", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ViralityScore = group.Add(new VocabularyKey(nameof(ViralityScore), "Virality Score", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActivityName { get; private set; }
        public VocabularyKey ActivityType { get; private set; }
        public VocabularyKey ActualEndDate { get; private set; }
        public VocabularyKey ActualStartDate { get; private set; }
        public VocabularyKey AttachmentReferences { get; private set; }
        public VocabularyKey Community { get; private set; }
        public VocabularyKey CustomerActivityId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Mentions { get; private set; }
        public VocabularyKey Message { get; private set; }
        public VocabularyKey NumberOfResponses { get; private set; }
        public VocabularyKey Sentiment { get; private set; }
        public VocabularyKey Subject { get; private set; }
        public VocabularyKey Url { get; private set; }
        public VocabularyKey Version { get; private set; }
        public VocabularyKey ViralityScore { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}