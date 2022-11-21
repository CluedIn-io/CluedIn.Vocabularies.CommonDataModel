using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailMarkupAutoChannelLineEntityVocabulary : SimpleVocabulary
    {
        public RetailMarkupAutoChannelLineEntityVocabulary()
        {
            VocabularyName = "Retail Markup Auto Channel Line Entity";
            KeyPrefix = "commonDataModel.retailmarkupautochannellineentity";
            KeySeparator = ".";
            Grouping = "/RetailMarkupAutoChannelLineEntity";

            AddGroup("RetailMarkupAutoChannelLineEntity Details", group =>
            {
                OMInternalOrganizationId = group.Add(new VocabularyKey(nameof(OMInternalOrganizationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMHierarchyTypeId = group.Add(new VocabularyKey(nameof(OMHierarchyTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelRelation = group.Add(new VocabularyKey(nameof(RetailChannelRelation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMHierarchyType_Name = group.Add(new VocabularyKey(nameof(OMHierarchyType_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMInternalOrganization_PartyNumber = group.Add(new VocabularyKey(nameof(OMInternalOrganization_PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OMOperatingUnit1_PartyNumber = group.Add(new VocabularyKey(nameof(OMOperatingUnit1_PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey OMInternalOrganizationId { get; private set; }
        public VocabularyKey OMHierarchyTypeId { get; private set; }
        public VocabularyKey RetailChannelRelation { get; private set; }
        public VocabularyKey OMHierarchyType_Name { get; private set; }
        public VocabularyKey OMInternalOrganization_PartyNumber { get; private set; }
        public VocabularyKey OMOperatingUnit1_PartyNumber { get; private set; }
    }
}