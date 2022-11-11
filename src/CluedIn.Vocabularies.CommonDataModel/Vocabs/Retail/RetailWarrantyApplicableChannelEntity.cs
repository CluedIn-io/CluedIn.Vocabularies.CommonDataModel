using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailWarrantyApplicableChannelEntityVocabulary : SimpleVocabulary
    {
        public RetailWarrantyApplicableChannelEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailWarrantyApplicableChannelEntity";
            KeyPrefix = "commonDataModel.retailwarrantyapplicablechannelentity";
            KeySeparator = ".";
            Grouping = "/RetailWarrantyApplicableChannelEntity";

            AddGroup("Common Data Model RetailWarrantyApplicableChannelEntity Details", group =>
            {
                WarrantyGroupId = group.Add(new VocabularyKey(nameof(WarrantyGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMHierarchyTypeId = group.Add(new VocabularyKey(nameof(OMHierarchyTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMInternalOrganizationId = group.Add(new VocabularyKey(nameof(OMInternalOrganizationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarrantyGroupName = group.Add(new VocabularyKey(nameof(WarrantyGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMHierarchyType = group.Add(new VocabularyKey(nameof(OMHierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChannelName = group.Add(new VocabularyKey(nameof(ChannelName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineIdentifier = group.Add(new VocabularyKey(nameof(LineIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WarrantyGroupId { get; private set; }
        public VocabularyKey OMHierarchyTypeId { get; private set; }
        public VocabularyKey OMInternalOrganizationId { get; private set; }
        public VocabularyKey WarrantyGroupName { get; private set; }
        public VocabularyKey OMHierarchyType { get; private set; }
        public VocabularyKey ChannelName { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey LineIdentifier { get; private set; }


    }
}