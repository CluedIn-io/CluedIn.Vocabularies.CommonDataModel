using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerOverdueJournalSettingsEntityVocabulary : SimpleVocabulary
    {
        public LedgerOverdueJournalSettingsEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerOverdueJournalSettingsEntity";
            KeyPrefix = "commonDataModel.ledgeroverduejournalsettingsentity";
            KeySeparator = ".";
            Grouping = "/LedgerOverdueJournalSettingsEntity";

            AddGroup("Common Data Model LedgerOverdueJournalSettingsEntity Details", group =>
            {
                CalculationType = group.Add(new VocabularyKey(nameof(CalculationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Condition = group.Add(new VocabularyKey(nameof(Condition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalType = group.Add(new VocabularyKey(nameof(JournalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumNumberOfDays = group.Add(new VocabularyKey(nameof(MaximumNumberOfDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumNumberOfDays = group.Add(new VocabularyKey(nameof(MinimumNumberOfDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymTermDays = group.Add(new VocabularyKey(nameof(PaymTermDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsValidateEnabled = group.Add(new VocabularyKey(nameof(IsValidateEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CalculationType { get; private set; }
public VocabularyKey Condition { get; private set; }
public VocabularyKey JournalType { get; private set; }
public VocabularyKey MaximumNumberOfDays { get; private set; }
public VocabularyKey MinimumNumberOfDays { get; private set; }
public VocabularyKey PaymTermDays { get; private set; }
public VocabularyKey IsValidateEnabled { get; private set; }
public VocabularyKey LineId { get; private set; }


    }
}