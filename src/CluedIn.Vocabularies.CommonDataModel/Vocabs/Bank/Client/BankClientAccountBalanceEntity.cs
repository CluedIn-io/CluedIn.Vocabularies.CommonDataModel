using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankClientAccountBalanceEntityVocabulary : SimpleVocabulary
    {
        public BankClientAccountBalanceEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankClientAccountBalanceEntity";
            KeyPrefix = "commonDataModel.bankclientaccountbalanceentity";
            KeySeparator = ".";
            Grouping = "/BankClientAccountBalanceEntity";

            AddGroup("Common Data Model BankClientAccountBalanceEntity Details", group =>
            {
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RecordType = group.Add(new VocabularyKey(nameof(RecordType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BankAccount { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey RecordType { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ToDate { get; private set; }


    }
}