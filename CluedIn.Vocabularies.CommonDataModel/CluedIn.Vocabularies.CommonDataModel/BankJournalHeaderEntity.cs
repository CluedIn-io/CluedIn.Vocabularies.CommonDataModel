using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankJournalHeaderEntityVocabulary : SimpleVocabulary
    {
        public BankJournalHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model BankJournalHeaderEntity";
            KeyPrefix = "commonDataModel.bankjournalheaderentity";
            KeySeparator = ".";
            Grouping = "/BankJournalHeaderEntity";

            AddGroup("Common Data Model BankJournalHeaderEntity Details", group =>
            {
                JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey JournalName { get; private set; }
public VocabularyKey JournalBatchNumber { get; private set; }
public VocabularyKey IsPosted { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}