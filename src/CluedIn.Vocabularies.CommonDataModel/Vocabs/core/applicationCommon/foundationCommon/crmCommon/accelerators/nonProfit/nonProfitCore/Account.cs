using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class AccountVocabulary : SimpleVocabulary
    {
        public AccountVocabulary()
        {
            VocabularyName = "Account";
            KeyPrefix = "commonDataModel.account.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/Account";

            AddGroup("Account Details for NonProfitCore", group =>
            {
			    AccountType = group.Add(new VocabularyKey(nameof(AccountType), "Account Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AcquisitionDate = group.Add(new VocabularyKey(nameof(AcquisitionDate), "Acquisition Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AcquisitionSource = group.Add(new VocabularyKey(nameof(AcquisitionSource), "Acquisition Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryConstituentType = group.Add(new VocabularyKey(nameof(PrimaryConstituentType), "Primary Constituent Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AccountType { get; private set; }
        public VocabularyKey AcquisitionDate { get; private set; }
        public VocabularyKey AcquisitionSource { get; private set; }
        public VocabularyKey PrimaryConstituentType { get; private set; }
    }
}