using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class RatingModelVocabulary : SimpleVocabulary
    {
        public RatingModelVocabulary()
        {
            VocabularyName = "Rating Model";
            KeyPrefix = "commonDataModel.ratingmodel.foundationcommon";
            KeySeparator = ".";
            Grouping = "/RatingModel";

            AddGroup("RatingModel Details for FoundationCommon", group =>
            {
			    RatingModelId = group.Add(new VocabularyKey(nameof(RatingModelId), "Rating Model", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MaxRatingValue = group.Add(new VocabularyKey(nameof(MaxRatingValue), "Max Rating Value", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    MinRatingValue = group.Add(new VocabularyKey(nameof(MinRatingValue), "Min Rating Value", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RatingModelId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey MaxRatingValue { get; private set; }
        public VocabularyKey MinRatingValue { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}