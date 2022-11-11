using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventOrderEntryDeadlineActivationEntityVocabulary : SimpleVocabulary
    {
        public InventOrderEntryDeadlineActivationEntityVocabulary()
        {
            VocabularyName = "InventOrderEntryDeadlineActivationEntity";
            KeyPrefix = "commonDataModel.inventorderentrydeadlineactivationentity";
            KeySeparator = ".";
            Grouping = "/InventOrderEntryDeadlineActivationEntity";

            AddGroup("InventOrderEntryDeadlineActivationEntity Details", group =>
            {
                IsSpecificSiteSpecificOrderGroupCombinationActivated = group.Add(new VocabularyKey(nameof(IsSpecificSiteSpecificOrderGroupCombinationActivated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsSpecificSiteCrossOrderGroupCombinationActivated = group.Add(new VocabularyKey(nameof(IsSpecificSiteCrossOrderGroupCombinationActivated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCrossSiteSpecificOrderGroupCombinationActivated = group.Add(new VocabularyKey(nameof(IsCrossSiteSpecificOrderGroupCombinationActivated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsSpecificSiteSpecificOrderGroupCombinationActivated { get; private set; }
        public VocabularyKey IsSpecificSiteCrossOrderGroupCombinationActivated { get; private set; }
        public VocabularyKey IsCrossSiteSpecificOrderGroupCombinationActivated { get; private set; }


    }
}