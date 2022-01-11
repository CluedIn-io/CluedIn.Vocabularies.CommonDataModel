using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerJournalHeaderCDSEntityVocabulary : SimpleVocabulary
    {
        public LedgerJournalHeaderCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerJournalHeaderCDSEntity";
            KeyPrefix = "commonDataModel.ledgerjournalheadercdsentity";
            KeySeparator = ".";
            Grouping = "/LedgerJournalHeaderCDSEntity";

            AddGroup("Common Data Model LedgerJournalHeaderCDSEntity Details", group =>
            {
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalName = group.Add(new VocabularyKey(nameof(JournalName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalTotalDebit = group.Add(new VocabularyKey(nameof(JournalTotalDebit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalTotalCredit = group.Add(new VocabularyKey(nameof(JournalTotalCredit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntegrationKey = group.Add(new VocabularyKey(nameof(IntegrationKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IntegrationComputedKey = group.Add(new VocabularyKey(nameof(IntegrationComputedKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PostingLayer { get; private set; }
public VocabularyKey JournalName { get; private set; }
public VocabularyKey JournalBatchNumber { get; private set; }
public VocabularyKey IsPosted { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey JournalTotalDebit { get; private set; }
public VocabularyKey JournalTotalCredit { get; private set; }
public VocabularyKey IntegrationKey { get; private set; }
public VocabularyKey IntegrationComputedKey { get; private set; }


    }
}