using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeadScoreModelVocabulary : SimpleVocabulary
    {
        public LeadScoreModelVocabulary()
        {
            VocabularyName = "LeadScoreModel";
            KeyPrefix = "commonDataModel.leadscoremodel";
            KeySeparator = ".";
            Grouping = "/LeadScoreModel";

            AddGroup("LeadScoreModel Details", group =>
            {
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                insightsPlaceholder = group.Add(new VocabularyKey(nameof(insightsPlaceholder), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                leadscoremodelId = group.Add(new VocabularyKey(nameof(leadscoremodelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                modelDefinition = group.Add(new VocabularyKey(nameof(modelDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdName = group.Add(new VocabularyKey(nameof(ownerIdName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ownerIdYomiName = group.Add(new VocabularyKey(nameof(ownerIdYomiName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                entityTarget = group.Add(new VocabularyKey(nameof(entityTarget), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey description { get; private set; }
        public VocabularyKey insightsPlaceholder { get; private set; }
        public VocabularyKey leadscoremodelId { get; private set; }
        public VocabularyKey modelDefinition { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey ownerIdName { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey ownerIdYomiName { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey entityTarget { get; private set; }


    }
}