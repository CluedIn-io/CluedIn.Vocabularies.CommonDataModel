using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDirAddressBookPartyEntityVocabulary : SimpleVocabulary
    {
        public RetailDirAddressBookPartyEntityVocabulary()
        {
            VocabularyName = "RetailDirAddressBookPartyEntity";
            KeyPrefix = "commonDataModel.retaildiraddressbookpartyentity";
            KeySeparator = ".";
            Grouping = "/RetailDirAddressBookPartyEntity";

            AddGroup("RetailDirAddressBookPartyEntity Details", group =>
            {
                AddressBookRecordId = group.Add(new VocabularyKey(nameof(AddressBookRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyRecordId = group.Add(new VocabularyKey(nameof(PartyRecordId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBookName = group.Add(new VocabularyKey(nameof(AddressBookName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AddressBookRecordId { get; private set; }
        public VocabularyKey PartyRecordId { get; private set; }
        public VocabularyKey AddressBookName { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }


    }
}