using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmLeadRatingEntityVocabulary : SimpleVocabulary
    {
        public SmmLeadRatingEntityVocabulary()
        {
            VocabularyName = "Smm Lead Rating Entity";
            KeyPrefix = "commonDataModel.smmleadratingentity";
            KeySeparator = ".";
            Grouping = "/SmmLeadRatingEntity";

            AddGroup("SmmLeadRatingEntity Details", group =>
            {
                RatingDescription = group.Add(new VocabularyKey(nameof(RatingDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RatingId = group.Add(new VocabularyKey(nameof(RatingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RatingDescription { get; private set; }
        public VocabularyKey RatingId { get; private set; }
    }
}