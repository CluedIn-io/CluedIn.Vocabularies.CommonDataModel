using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailAssortmentChannelLineEntityVocabulary : SimpleVocabulary
    {
        public RetailAssortmentChannelLineEntityVocabulary()
        {
            VocabularyName = "RetailAssortmentChannelLineEntity";
            KeyPrefix = "commonDataModel.retailassortmentchannellineentity";
            KeySeparator = ".";
            Grouping = "/RetailAssortmentChannelLineEntity";

            AddGroup("RetailAssortmentChannelLineEntity Details", group =>
            {
                AssortmentId = group.Add(new VocabularyKey(nameof(AssortmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationName = group.Add(new VocabularyKey(nameof(OrganizationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationHierarchyType = group.Add(new VocabularyKey(nameof(OrganizationHierarchyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AssortmentId { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey OrganizationName { get; private set; }
        public VocabularyKey OrganizationHierarchyType { get; private set; }
        public VocabularyKey Status { get; private set; }


    }
}