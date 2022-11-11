using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankCodaAccountTableEntityVocabulary : SimpleVocabulary
    {
        public BankCodaAccountTableEntityVocabulary()
        {
            VocabularyName = "BankCodaAccountTableEntity";
            KeyPrefix = "commonDataModel.bankcodaaccounttableentity";
            KeySeparator = ".";
            Grouping = "/BankCodaAccountTableEntity";

            AddGroup("BankCodaAccountTableEntity Details", group =>
            {
                AccountID = group.Add(new VocabularyKey(nameof(AccountID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CodaJournalName = group.Add(new VocabularyKey(nameof(CodaJournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CodaProtocol = group.Add(new VocabularyKey(nameof(CodaProtocol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CodaVersion = group.Add(new VocabularyKey(nameof(CodaVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccountID { get; private set; }
        public VocabularyKey CodaJournalName { get; private set; }
        public VocabularyKey CodaProtocol { get; private set; }
        public VocabularyKey CodaVersion { get; private set; }


    }
}