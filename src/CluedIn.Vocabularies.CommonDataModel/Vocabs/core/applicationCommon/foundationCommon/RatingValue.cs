using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FoundationCommon
{
    public class RatingValueVocabulary : SimpleVocabulary
    {
        public RatingValueVocabulary()
        {
            VocabularyName = "Rating Value";
            KeyPrefix = "commonDataModel.ratingvalue.foundationcommon";
            KeySeparator = ".";
            Grouping = "/RatingValue";

            AddGroup("RatingValue Details for FoundationCommon", group =>
            {
			    RatingValueId = group.Add(new VocabularyKey(nameof(RatingValueId), "Rating Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Value", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "ExchangeRate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RatingValueId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}