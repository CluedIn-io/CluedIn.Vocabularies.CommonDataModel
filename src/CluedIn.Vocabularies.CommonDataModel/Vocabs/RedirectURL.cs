using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RedirectURLVocabulary : SimpleVocabulary
    {
        public RedirectURLVocabulary()
        {
            VocabularyName = "Common Data Model RedirectURL";
            KeyPrefix = "commonDataModel.redirecturl";
            KeySeparator = ".";
            Grouping = "/RedirectURL";

            AddGroup("Common Data Model RedirectURL Details", group =>
            {
                insightsResults = group.Add(new VocabularyKey(nameof(insightsResults), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                insightsTimeline = group.Add(new VocabularyKey(nameof(insightsTimeline), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                originalURL = group.Add(new VocabularyKey(nameof(originalURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                redirectingURL = group.Add(new VocabularyKey(nameof(redirectingURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                redirectURLId = group.Add(new VocabularyKey(nameof(redirectURLId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey insightsResults { get; private set; }
        public VocabularyKey insightsTimeline { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey originalURL { get; private set; }
        public VocabularyKey redirectingURL { get; private set; }
        public VocabularyKey redirectURLId { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }


    }
}