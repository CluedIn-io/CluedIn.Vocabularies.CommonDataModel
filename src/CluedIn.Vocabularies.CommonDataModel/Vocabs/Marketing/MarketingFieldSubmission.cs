using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingFieldSubmissionVocabulary : SimpleVocabulary
    {
        public MarketingFieldSubmissionVocabulary()
        {
            VocabularyName = "Marketing Field Submission";
            KeyPrefix = "commonDataModel.marketingfieldsubmission";
            KeySeparator = ".";
            Grouping = "/MarketingFieldSubmission";

            AddGroup("MarketingFieldSubmission Details", group =>
            {
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FieldValue = group.Add(new VocabularyKey(nameof(FieldValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingFieldSubmissionId = group.Add(new VocabularyKey(nameof(MarketingFieldSubmissionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingformfieldidValue = group.Add(new VocabularyKey(nameof(MarketingformfieldidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey FieldName { get; private set; }
        public VocabularyKey FieldValue { get; private set; }
        public VocabularyKey MarketingFieldSubmissionId { get; private set; }
        public VocabularyKey MarketingformfieldidValue { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}