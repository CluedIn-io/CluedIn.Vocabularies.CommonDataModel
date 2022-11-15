using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailChannelCustomerAddressBookEntityVocabulary : SimpleVocabulary
    {
        public RetailChannelCustomerAddressBookEntityVocabulary()
        {
            VocabularyName = "Retail Channel Customer Address Book Entity";
            KeyPrefix = "commonDataModel.retailchannelcustomeraddressbookentity";
            KeySeparator = ".";
            Grouping = "/RetailChannelCustomerAddressBookEntity";

            AddGroup("RetailChannelCustomerAddressBookEntity Details", group =>
            {
                AddressBook = group.Add(new VocabularyKey(nameof(AddressBook), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressBookName = group.Add(new VocabularyKey(nameof(AddressBookName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelId = group.Add(new VocabularyKey(nameof(RetailChannelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AddressBook { get; private set; }
        public VocabularyKey AddressBookName { get; private set; }
        public VocabularyKey RetailChannelId { get; private set; }
    }
}