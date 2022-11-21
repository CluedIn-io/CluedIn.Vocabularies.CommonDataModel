using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmCustomerContactPersonCDSEntityVocabulary : SimpleVocabulary
    {
        public SmmCustomerContactPersonCDSEntityVocabulary()
        {
            VocabularyName = "Smm Customer Contact Person CDS Entity";
            KeyPrefix = "commonDataModel.smmcustomercontactpersoncdsentity";
            KeySeparator = ".";
            Grouping = "/SmmCustomerContactPersonCDSEntity";

            AddGroup("SmmCustomerContactPersonCDSEntity Details", group =>
            {
                ContactPersonPartyNumber = group.Add(new VocabularyKey(nameof(ContactPersonPartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ContactPersonPartyNumber { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
    }
}