using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmVendorContactPersonCDSEntityVocabulary : SimpleVocabulary
    {
        public smmVendorContactPersonCDSEntityVocabulary()
        {
            VocabularyName = "smmVendorContactPersonCDSEntity";
            KeyPrefix = "commonDataModel.smmvendorcontactpersoncdsentity";
            KeySeparator = ".";
            Grouping = "/smmVendorContactPersonCDSEntity";

            AddGroup("smmVendorContactPersonCDSEntity Details", group =>
            {
                ContactPersonPartyNumber = group.Add(new VocabularyKey(nameof(ContactPersonPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ContactPersonPartyNumber { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }


    }
}