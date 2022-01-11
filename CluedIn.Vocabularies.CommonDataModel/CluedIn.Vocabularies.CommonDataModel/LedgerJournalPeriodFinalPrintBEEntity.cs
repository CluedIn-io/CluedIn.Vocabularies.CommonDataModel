using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerJournalPeriodFinalPrintBEEntityVocabulary : SimpleVocabulary
    {
        public LedgerJournalPeriodFinalPrintBEEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerJournalPeriodFinalPrintBEEntity";
            KeyPrefix = "commonDataModel.ledgerjournalperiodfinalprintbeentity";
            KeySeparator = ".";
            Grouping = "/LedgerJournalPeriodFinalPrintBEEntity";

            AddGroup("Common Data Model LedgerJournalPeriodFinalPrintBEEntity Details", group =>
            {
                Compressed = group.Add(new VocabularyKey(nameof(Compressed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Journal = group.Add(new VocabularyKey(nameof(Journal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberLastPage = group.Add(new VocabularyKey(nameof(NumberLastPage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
End = group.Add(new VocabularyKey(nameof(End), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Start = group.Add(new VocabularyKey(nameof(Start), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Compressed { get; private set; }
public VocabularyKey Journal { get; private set; }
public VocabularyKey NumberLastPage { get; private set; }
public VocabularyKey End { get; private set; }
public VocabularyKey Start { get; private set; }


    }
}