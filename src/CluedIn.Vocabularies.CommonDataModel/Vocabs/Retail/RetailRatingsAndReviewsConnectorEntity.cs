using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailRatingsAndReviewsConnectorEntityVocabulary : SimpleVocabulary
    {
        public RetailRatingsAndReviewsConnectorEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailRatingsAndReviewsConnectorEntity";
            KeyPrefix = "commonDataModel.retailratingsandreviewsconnectorentity";
            KeySeparator = ".";
            Grouping = "/RetailRatingsAndReviewsConnectorEntity";

            AddGroup("Common Data Model RetailRatingsAndReviewsConnectorEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Url = group.Add(new VocabularyKey(nameof(Url), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContinuationToken = group.Add(new VocabularyKey(nameof(ContinuationToken), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Manifest = group.Add(new VocabularyKey(nameof(Manifest), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Url { get; private set; }
        public VocabularyKey ContinuationToken { get; private set; }
        public VocabularyKey Manifest { get; private set; }


    }
}