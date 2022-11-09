using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailChannelCustomerAddressBookEntityVocabulary : SimpleVocabulary
    {
        public RetailChannelCustomerAddressBookEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailChannelCustomerAddressBookEntity";
            KeyPrefix = "commonDataModel.retailchannelcustomeraddressbookentity";
            KeySeparator = ".";
            Grouping = "/RetailChannelCustomerAddressBookEntity";

            AddGroup("Common Data Model RetailChannelCustomerAddressBookEntity Details", group =>
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