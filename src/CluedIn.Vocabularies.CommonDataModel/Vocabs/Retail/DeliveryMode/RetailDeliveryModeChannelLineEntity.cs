using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDeliveryModeChannelLineEntityVocabulary : SimpleVocabulary
    {
        public RetailDeliveryModeChannelLineEntityVocabulary()
        {
            VocabularyName = "Retail Delivery Mode Channel Line Entity";
            KeyPrefix = "commonDataModel.retaildeliverymodechannellineentity";
            KeySeparator = ".";
            Grouping = "/RetailDeliveryModeChannelLineEntity";

            AddGroup("RetailDeliveryModeChannelLineEntity Details", group =>
            {
                ModeOfDeliveryCode = group.Add(new VocabularyKey(nameof(ModeOfDeliveryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationName = group.Add(new VocabularyKey(nameof(OrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationHierarchyType = group.Add(new VocabularyKey(nameof(OrganizationHierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ModeOfDeliveryCode { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey OrganizationName { get; private set; }
        public VocabularyKey OrganizationHierarchyType { get; private set; }
    }
}