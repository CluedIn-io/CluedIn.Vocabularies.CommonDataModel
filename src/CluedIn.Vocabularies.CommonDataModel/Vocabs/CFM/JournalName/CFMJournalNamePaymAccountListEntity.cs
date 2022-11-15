using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFMJournalNamePaymAccountListEntityVocabulary : SimpleVocabulary
    {
        public CFMJournalNamePaymAccountListEntityVocabulary()
        {
            VocabularyName = "CFM Journal Name Paym Account List Entity";
            KeyPrefix = "commonDataModel.cfmjournalnamepaymaccountlistentity";
            KeySeparator = ".";
            Grouping = "/CFMJournalNamePaymAccountListEntity";

            AddGroup("CFMJournalNamePaymAccountListEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountNumber = group.Add(new VocabularyKey(nameof(AccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentAccountType = group.Add(new VocabularyKey(nameof(PaymentAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AccountNumber { get; private set; }
        public VocabularyKey PaymentAccountType { get; private set; }
    }
}