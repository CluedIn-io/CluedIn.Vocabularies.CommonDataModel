using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Portals
{
    public class ArticleVocabulary : SimpleVocabulary
    {
        public ArticleVocabulary()
        {
            VocabularyName = "Article";
            KeyPrefix = "commonDataModel.article.portals";
            KeySeparator = ".";
            Grouping = "/Article";

            AddGroup("Article Details for Portals", group =>
            {
			    PublishToWeb = group.Add(new VocabularyKey(nameof(PublishToWeb), "Publish to Web", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AverageRating = group.Add(new VocabularyKey(nameof(AverageRating), "Average Rating", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AverageRatingWholeNumber = group.Add(new VocabularyKey(nameof(AverageRatingWholeNumber), "Average Rating (Whole Number)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Downvotes = group.Add(new VocabularyKey(nameof(Downvotes), "Downvotes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RatingCount = group.Add(new VocabularyKey(nameof(RatingCount), "Rating Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    RatingSum = group.Add(new VocabularyKey(nameof(RatingSum), "Rating Sum", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Upvotes = group.Add(new VocabularyKey(nameof(Upvotes), "Upvotes", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey PublishToWeb { get; private set; }
        public VocabularyKey AverageRating { get; private set; }
        public VocabularyKey AverageRatingWholeNumber { get; private set; }
        public VocabularyKey Downvotes { get; private set; }
        public VocabularyKey RatingCount { get; private set; }
        public VocabularyKey RatingSum { get; private set; }
        public VocabularyKey Upvotes { get; private set; }
    }
}