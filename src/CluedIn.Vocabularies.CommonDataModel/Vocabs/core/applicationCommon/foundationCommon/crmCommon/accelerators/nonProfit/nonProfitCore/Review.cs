using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class ReviewVocabulary : SimpleVocabulary
    {
        public ReviewVocabulary()
        {
            VocabularyName = "Review";
            KeyPrefix = "commonDataModel.review.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Review";

            AddGroup("Review Details for NonProfitCore", group =>
            {
			    DateSubmitted = group.Add(new VocabularyKey(nameof(DateSubmitted), "Date Submitted", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DueDate = group.Add(new VocabularyKey(nameof(DueDate), "Due Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReviewDate = group.Add(new VocabularyKey(nameof(ReviewDate), "Review Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReviewerType = group.Add(new VocabularyKey(nameof(ReviewerType), "Reviewer Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReviewId = group.Add(new VocabularyKey(nameof(ReviewId), "Review", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey DateSubmitted { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DueDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReviewDate { get; private set; }
        public VocabularyKey ReviewerType { get; private set; }
        public VocabularyKey ReviewId { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}