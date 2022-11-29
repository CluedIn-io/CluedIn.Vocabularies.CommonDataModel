using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/Account";

            AddGroup("Account Details for NonProfitIati", group =>
            {
			    IatiOrganizationIdentifier = group.Add(new VocabularyKey(nameof(IatiOrganizationIdentifier), "IATI Organization Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SecondaryReporter = group.Add(new VocabularyKey(nameof(SecondaryReporter), "Secondary Reporter", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    AccountType = group.Add(new VocabularyKey(nameof(AccountType), "Account Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AcquisitionDate = group.Add(new VocabularyKey(nameof(AcquisitionDate), "Acquisition Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AcquisitionSource = group.Add(new VocabularyKey(nameof(AcquisitionSource), "Acquisition Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryConstituentType = group.Add(new VocabularyKey(nameof(PrimaryConstituentType), "Primary Constituent Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey IatiOrganizationIdentifier { get; private set; }
        public VocabularyKey SecondaryReporter { get; private set; }
        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey AcquisitionDate { get; private set; }
        public VocabularyKey AcquisitionSource { get; private set; }
        public VocabularyKey PrimaryConstituentType { get; private set; }
    }
}