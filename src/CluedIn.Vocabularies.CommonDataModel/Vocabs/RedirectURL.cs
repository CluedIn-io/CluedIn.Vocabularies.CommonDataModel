using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RedirectURLVocabulary : SimpleVocabulary
    {
        public RedirectURLVocabulary()
        {
            VocabularyName = "Redirect URL";
            KeyPrefix = "commonDataModel.redirecturl";
            KeySeparator = ".";
            Grouping = "/RedirectURL";

            AddGroup("RedirectURL Details", group =>
            {
                InsightsResults = group.Add(new VocabularyKey(nameof(InsightsResults), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsightsTimeline = group.Add(new VocabularyKey(nameof(InsightsTimeline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginalURL = group.Add(new VocabularyKey(nameof(OriginalURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RedirectingURL = group.Add(new VocabularyKey(nameof(RedirectingURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RedirectURLId = group.Add(new VocabularyKey(nameof(RedirectURLId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey InsightsResults { get; private set; }
        public VocabularyKey InsightsTimeline { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OriginalURL { get; private set; }
        public VocabularyKey RedirectingURL { get; private set; }
        public VocabularyKey RedirectURLId { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}