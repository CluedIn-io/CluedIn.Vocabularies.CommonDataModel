using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmCompensationPerformanceRatingEntityVocabulary : SimpleVocabulary
    {
        public HcmCompensationPerformanceRatingEntityVocabulary()
        {
            VocabularyName = "HcmCompensationPerformanceRatingEntity";
            KeyPrefix = "commonDataModel.hcmcompensationperformanceratingentity";
            KeySeparator = ".";
            Grouping = "/HcmCompensationPerformanceRatingEntity";

            AddGroup("HcmCompensationPerformanceRatingEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rating = group.Add(new VocabularyKey(nameof(Rating), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Effective = group.Add(new VocabularyKey(nameof(Effective), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Expiration = group.Add(new VocabularyKey(nameof(Expiration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Rating { get; private set; }
        public VocabularyKey Effective { get; private set; }
        public VocabularyKey Expiration { get; private set; }


    }
}