using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmVendorContactPersonCDSEntityVocabulary : SimpleVocabulary
    {
        public SmmVendorContactPersonCDSEntityVocabulary()
        {
            VocabularyName = "Smm Vendor Contact Person CDS Entity";
            KeyPrefix = "commonDataModel.smmvendorcontactpersoncdsentity";
            KeySeparator = ".";
            Grouping = "/SmmVendorContactPersonCDSEntity";

            AddGroup("SmmVendorContactPersonCDSEntity Details", group =>
            {
                ContactPersonPartyNumber = group.Add(new VocabularyKey(nameof(ContactPersonPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorAccountNumber = group.Add(new VocabularyKey(nameof(VendorAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ContactPersonPartyNumber { get; private set; }
        public VocabularyKey VendorAccountNumber { get; private set; }
    }
}