using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailLoyaltySchemeChannelEntityVocabulary : SimpleVocabulary
    {
        public RetailLoyaltySchemeChannelEntityVocabulary()
        {
            VocabularyName = "RetailLoyaltySchemeChannelEntity";
            KeyPrefix = "commonDataModel.retailloyaltyschemechannelentity";
            KeySeparator = ".";
            Grouping = "/RetailLoyaltySchemeChannelEntity";

            AddGroup("RetailLoyaltySchemeChannelEntity Details", group =>
            {
                LoyaltyScheme = group.Add(new VocabularyKey(nameof(LoyaltyScheme), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMHierarchyType = group.Add(new VocabularyKey(nameof(OMHierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMInternalOrganization = group.Add(new VocabularyKey(nameof(OMInternalOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMHierarchyTypeName = group.Add(new VocabularyKey(nameof(OMHierarchyTypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationPartyNumber = group.Add(new VocabularyKey(nameof(OrganizationPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LoyaltySchemeId = group.Add(new VocabularyKey(nameof(LoyaltySchemeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LoyaltyScheme { get; private set; }
        public VocabularyKey OMHierarchyType { get; private set; }
        public VocabularyKey OMInternalOrganization { get; private set; }
        public VocabularyKey OMHierarchyTypeName { get; private set; }
        public VocabularyKey OrganizationPartyNumber { get; private set; }
        public VocabularyKey LoyaltySchemeId { get; private set; }


    }
}