using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankAccountTrapEntityVocabulary : SimpleVocabulary
    {
        public BankAccountTrapEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankAccountTrapEntity";
            KeyPrefix = "commonDataModel.bankaccounttrapentity";
            KeySeparator = ".";
            Grouping = "/BankAccountTrapEntity";

            AddGroup("Common Data Model BankAccountTrapEntity Details", group =>
            {
                BankAccountNumber = group.Add(new VocabularyKey(nameof(BankAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BankAccountNumber { get; private set; }
        public VocabularyKey Name { get; private set; }


    }
}