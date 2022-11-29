using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class SocialActivityVocabulary : SimpleVocabulary
    {
        public SocialActivityVocabulary()
        {
            VocabularyName = "Social Activity";
            KeyPrefix = "commonDataModel.socialactivity.applicationcommon";
            KeySeparator = ".";
            Grouping = "/SocialActivity";

            AddGroup("SocialActivity Details for ApplicationCommon", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Post Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    SentimentValue = group.Add(new VocabularyKey(nameof(SentimentValue), "Sentiment Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    PostedOn = group.Add(new VocabularyKey(nameof(PostedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostURL = group.Add(new VocabularyKey(nameof(PostURL), "Post URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    InResponseTo = group.Add(new VocabularyKey(nameof(InResponseTo), "In Response To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostMessageType = group.Add(new VocabularyKey(nameof(PostMessageType), "Received As", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostId = group.Add(new VocabularyKey(nameof(PostId), "Post ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ThreadId = group.Add(new VocabularyKey(nameof(ThreadId), "Thread ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostToProfileId = group.Add(new VocabularyKey(nameof(PostToProfileId), "Posted To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SocialAdditionalParams = group.Add(new VocabularyKey(nameof(SocialAdditionalParams), "Social Additional Parameters", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey SentimentValue { get; private set; }
        public VocabularyKey PostedOn { get; private set; }
        public VocabularyKey PostURL { get; private set; }
        public VocabularyKey InResponseTo { get; private set; }
        public VocabularyKey PostMessageType { get; private set; }
        public VocabularyKey PostId { get; private set; }
        public VocabularyKey ThreadId { get; private set; }
        public VocabularyKey PostToProfileId { get; private set; }
        public VocabularyKey SocialAdditionalParams { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
    }
}