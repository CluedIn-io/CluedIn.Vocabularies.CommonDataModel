using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInternalOrgCatHierarchyCollapsedEntityVocabulary : SimpleVocabulary
    {
        public RetailInternalOrgCatHierarchyCollapsedEntityVocabulary()
        {
            VocabularyName = "RetailInternalOrgCatHierarchyCollapsedEntity";
            KeyPrefix = "commonDataModel.retailinternalorgcathierarchycollapsedentity";
            KeySeparator = ".";
            Grouping = "/RetailInternalOrgCatHierarchyCollapsedEntity";

            AddGroup("RetailInternalOrgCatHierarchyCollapsedEntity Details", group =>
            {
                AncestorInternalOrg = group.Add(new VocabularyKey(nameof(AncestorInternalOrg), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryHierarchy = group.Add(new VocabularyKey(nameof(CategoryHierarchy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Distance = group.Add(new VocabularyKey(nameof(Distance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Origin = group.Add(new VocabularyKey(nameof(Origin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginRecVersion = group.Add(new VocabularyKey(nameof(OriginRecVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AncestorInternalOrg { get; private set; }
        public VocabularyKey CategoryHierarchy { get; private set; }
        public VocabularyKey Distance { get; private set; }
        public VocabularyKey Origin { get; private set; }
        public VocabularyKey OriginRecVersion { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }


    }
}