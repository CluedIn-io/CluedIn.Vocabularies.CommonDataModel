using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarketingFormSubmissionVocabulary : SimpleVocabulary
    {
        public MarketingFormSubmissionVocabulary()
        {
            VocabularyName = "Marketing Form Submission";
            KeyPrefix = "commonDataModel.marketingformsubmission";
            KeySeparator = ".";
            Grouping = "/MarketingFormSubmission";

            AddGroup("MarketingFormSubmission Details", group =>
            {
                CustomerjourneyidValue = group.Add(new VocabularyKey(nameof(CustomerjourneyidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Failuredescription = group.Add(new VocabularyKey(nameof(Failuredescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Failuretechnicaldetails = group.Add(new VocabularyKey(nameof(Failuretechnicaldetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormName = group.Add(new VocabularyKey(nameof(FormName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactMatchingResult = group.Add(new VocabularyKey(nameof(ContactMatchingResult), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WebsiteidValue = group.Add(new VocabularyKey(nameof(WebsiteidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingemailidValue = group.Add(new VocabularyKey(nameof(MarketingemailidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingformidValue = group.Add(new VocabularyKey(nameof(MarketingformidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingFormSubmissionId = group.Add(new VocabularyKey(nameof(MarketingFormSubmissionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MarketingpageidValue = group.Add(new VocabularyKey(nameof(MarketingpageidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalContactidValue = group.Add(new VocabularyKey(nameof(OriginalContactidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimestampSubmission = group.Add(new VocabularyKey(nameof(TimestampSubmission), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SessionidValue = group.Add(new VocabularyKey(nameof(SessionidValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VisitoridValue = group.Add(new VocabularyKey(nameof(VisitoridValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Pageurl = group.Add(new VocabularyKey(nameof(Pageurl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubmittedValues = group.Add(new VocabularyKey(nameof(SubmittedValues), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProcessingStep = group.Add(new VocabularyKey(nameof(ProcessingStep), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CustomerjourneyidValue { get; private set; }
        public VocabularyKey Failuredescription { get; private set; }
        public VocabularyKey Failuretechnicaldetails { get; private set; }
        public VocabularyKey FormName { get; private set; }
        public VocabularyKey ContactMatchingResult { get; private set; }
        public VocabularyKey WebsiteidValue { get; private set; }
        public VocabularyKey MarketingemailidValue { get; private set; }
        public VocabularyKey MarketingformidValue { get; private set; }
        public VocabularyKey MarketingFormSubmissionId { get; private set; }
        public VocabularyKey MarketingpageidValue { get; private set; }
        public VocabularyKey OriginalContactidValue { get; private set; }
        public VocabularyKey TimestampSubmission { get; private set; }
        public VocabularyKey SessionidValue { get; private set; }
        public VocabularyKey VisitoridValue { get; private set; }
        public VocabularyKey Pageurl { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubmittedValues { get; private set; }
        public VocabularyKey ProcessingStep { get; private set; }
    }
}