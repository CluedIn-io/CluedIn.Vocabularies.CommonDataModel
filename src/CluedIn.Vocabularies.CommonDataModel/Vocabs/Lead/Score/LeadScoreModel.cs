using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeadScoreModelVocabulary : SimpleVocabulary
    {
        public LeadScoreModelVocabulary()
        {
            VocabularyName = "Lead Score Model";
            KeyPrefix = "commonDataModel.leadscoremodel";
            KeySeparator = ".";
            Grouping = "/LeadScoreModel";

            AddGroup("LeadScoreModel Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeadscoremodelId = group.Add(new VocabularyKey(nameof(LeadscoremodelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModelDefinition = group.Add(new VocabularyKey(nameof(ModelDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdName = group.Add(new VocabularyKey(nameof(OwnerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwnerIdYomiName = group.Add(new VocabularyKey(nameof(OwnerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntityTarget = group.Add(new VocabularyKey(nameof(EntityTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey LeadscoremodelId { get; private set; }
        public VocabularyKey ModelDefinition { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OwnerIdName { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwnerIdYomiName { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey EntityTarget { get; private set; }
    }
}