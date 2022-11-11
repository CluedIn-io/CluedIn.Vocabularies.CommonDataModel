using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailReplenishmentRuleLineV2EntityVocabulary : SimpleVocabulary
    {
        public RetailReplenishmentRuleLineV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailReplenishmentRuleLineV2Entity";
            KeyPrefix = "commonDataModel.retailreplenishmentrulelinev2entity";
            KeySeparator = ".";
            Grouping = "/RetailReplenishmentRuleLineV2Entity";

            AddGroup("Common Data Model RetailReplenishmentRuleLineV2Entity Details", group =>
            {
                ReplenishmentRule = group.Add(new VocabularyKey(nameof(ReplenishmentRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelationId = group.Add(new VocabularyKey(nameof(RelationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentHierarchyTypeName = group.Add(new VocabularyKey(nameof(ReplenishmentHierarchyTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentOrganizationPartyNumber = group.Add(new VocabularyKey(nameof(ReplenishmentOrganizationPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentHierarchyValidFrom = group.Add(new VocabularyKey(nameof(ReplenishmentHierarchyValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReplenishmentHierarchyValidTo = group.Add(new VocabularyKey(nameof(ReplenishmentHierarchyValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelId = group.Add(new VocabularyKey(nameof(RetailChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Weight = group.Add(new VocabularyKey(nameof(Weight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percent = group.Add(new VocabularyKey(nameof(Percent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultWeight = group.Add(new VocabularyKey(nameof(DefaultWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultPercent = group.Add(new VocabularyKey(nameof(DefaultPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ReplenishmentRule { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey RelationId { get; private set; }
        public VocabularyKey ReplenishmentHierarchyTypeName { get; private set; }
        public VocabularyKey ReplenishmentOrganizationPartyNumber { get; private set; }
        public VocabularyKey ReplenishmentHierarchyValidFrom { get; private set; }
        public VocabularyKey ReplenishmentHierarchyValidTo { get; private set; }
        public VocabularyKey RetailChannelId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Weight { get; private set; }
        public VocabularyKey Percent { get; private set; }
        public VocabularyKey DefaultWeight { get; private set; }
        public VocabularyKey DefaultPercent { get; private set; }


    }
}