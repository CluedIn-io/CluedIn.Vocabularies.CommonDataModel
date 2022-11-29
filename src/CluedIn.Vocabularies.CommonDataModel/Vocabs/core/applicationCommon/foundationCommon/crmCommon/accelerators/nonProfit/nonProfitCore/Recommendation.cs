using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class RecommendationVocabulary : SimpleVocabulary
    {
        public RecommendationVocabulary()
        {
            VocabularyName = "Recommendation";
            KeyPrefix = "commonDataModel.recommendation.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Recommendation";

            AddGroup("Recommendation Details for NonProfitCore", group =>
            {
			    CommunicationChannel = group.Add(new VocabularyKey(nameof(CommunicationChannel), "Communication Channel", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Date = group.Add(new VocabularyKey(nameof(Date), "Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DateSubmitted = group.Add(new VocabularyKey(nameof(DateSubmitted), "Date Submitted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RecommendationId = group.Add(new VocabularyKey(nameof(RecommendationId), "Recommendation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CommunicationChannel { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey DateSubmitted { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RecommendationId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}