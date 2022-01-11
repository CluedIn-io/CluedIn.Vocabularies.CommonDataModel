using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetCycleEntityVocabulary : SimpleVocabulary
    {
        public BudgetCycleEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetCycleEntity";
            KeyPrefix = "commonDataModel.budgetcycleentity";
            KeySeparator = ".";
            Grouping = "/BudgetCycleEntity";

            AddGroup("Common Data Model BudgetCycleEntity Details", group =>
            {
                BudgetCycleName = group.Add(new VocabularyKey(nameof(BudgetCycleName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCycleTimeSpanName = group.Add(new VocabularyKey(nameof(BudgetCycleTimeSpanName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndPeriodStartDate = group.Add(new VocabularyKey(nameof(EndPeriodStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndPeriodName = group.Add(new VocabularyKey(nameof(EndPeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndPeriodYear = group.Add(new VocabularyKey(nameof(EndPeriodYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCalendarId = group.Add(new VocabularyKey(nameof(FiscalCalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalCalendar = group.Add(new VocabularyKey(nameof(FiscalCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LengthOfBudgetCycle = group.Add(new VocabularyKey(nameof(LengthOfBudgetCycle), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberOfFiscalPeriods = group.Add(new VocabularyKey(nameof(NumberOfFiscalPeriods), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartPeriodName = group.Add(new VocabularyKey(nameof(StartPeriodName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartPeriodYear = group.Add(new VocabularyKey(nameof(StartPeriodYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BudgetCycleName { get; private set; }
public VocabularyKey BudgetCycleTimeSpanName { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey EndPeriodStartDate { get; private set; }
public VocabularyKey EndPeriodName { get; private set; }
public VocabularyKey EndPeriodYear { get; private set; }
public VocabularyKey FiscalCalendarId { get; private set; }
public VocabularyKey FiscalCalendar { get; private set; }
public VocabularyKey LengthOfBudgetCycle { get; private set; }
public VocabularyKey NumberOfFiscalPeriods { get; private set; }
public VocabularyKey StartDate { get; private set; }
public VocabularyKey StartPeriodName { get; private set; }
public VocabularyKey StartPeriodYear { get; private set; }


    }
}