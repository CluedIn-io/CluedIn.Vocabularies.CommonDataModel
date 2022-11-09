using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFMJournalNamePaymAccountListEntityVocabulary : SimpleVocabulary
    {
        public CFMJournalNamePaymAccountListEntityVocabulary()
        {
            VocabularyName = "Common Data Model CFMJournalNamePaymAccountListEntity";
            KeyPrefix = "commonDataModel.cfmjournalnamepaymaccountlistentity";
            KeySeparator = ".";
            Grouping = "/CFMJournalNamePaymAccountListEntity";

            AddGroup("Common Data Model CFMJournalNamePaymAccountListEntity Details", group =>
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