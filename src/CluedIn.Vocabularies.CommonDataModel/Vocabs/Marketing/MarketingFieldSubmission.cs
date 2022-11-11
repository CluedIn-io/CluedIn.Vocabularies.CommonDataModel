using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingFieldSubmissionVocabulary : SimpleVocabulary
    {
        public MarketingFieldSubmissionVocabulary()
        {
            VocabularyName = "MarketingFieldSubmission";
            KeyPrefix = "commonDataModel.marketingfieldsubmission";
            KeySeparator = ".";
            Grouping = "/MarketingFieldSubmission";

            AddGroup("MarketingFieldSubmission Details", group =>
            {
                fieldName = group.Add(new VocabularyKey(nameof(fieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                fieldValue = group.Add(new VocabularyKey(nameof(fieldValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingFieldSubmissionId = group.Add(new VocabularyKey(nameof(marketingFieldSubmissionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                marketingformfieldidValue = group.Add(new VocabularyKey(nameof(marketingformfieldidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey fieldName { get; private set; }
        public VocabularyKey fieldValue { get; private set; }
        public VocabularyKey marketingFieldSubmissionId { get; private set; }
        public VocabularyKey marketingformfieldidValue { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}