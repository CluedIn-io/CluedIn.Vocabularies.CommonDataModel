using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetCycleTimeSpanEntityVocabulary : SimpleVocabulary
    {
        public BudgetCycleTimeSpanEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetCycleTimeSpanEntity";
            KeyPrefix = "commonDataModel.budgetcycletimespanentity";
            KeySeparator = ".";
            Grouping = "/BudgetCycleTimeSpanEntity";

            AddGroup("Common Data Model BudgetCycleTimeSpanEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCalendarId = group.Add(new VocabularyKey(nameof(FiscalCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCalendar = group.Add(new VocabularyKey(nameof(FiscalCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCycleLengthOption = group.Add(new VocabularyKey(nameof(BudgetCycleLengthOption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultNumberOfAccountingPeriods = group.Add(new VocabularyKey(nameof(DefaultNumberOfAccountingPeriods), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey FiscalCalendarId { get; private set; }
public VocabularyKey FiscalCalendar { get; private set; }
public VocabularyKey BudgetCycleLengthOption { get; private set; }
public VocabularyKey DefaultNumberOfAccountingPeriods { get; private set; }


    }
}