using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjPeriodEntityVocabulary : SimpleVocabulary
    {
        public ProjPeriodEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjPeriodEntity";
            KeyPrefix = "commonDataModel.projperiodentity";
            KeySeparator = ".";
            Grouping = "/ProjPeriodEntity";

            AddGroup("Common Data Model ProjPeriodEntity Details", group =>
            {
                PeriodId = group.Add(new VocabularyKey(nameof(PeriodId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WeekDayPeriodStart = group.Add(new VocabularyKey(nameof(WeekDayPeriodStart), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Frequency = group.Add(new VocabularyKey(nameof(Frequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodFrequency = group.Add(new VocabularyKey(nameof(PeriodFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TimesheetFrequency = group.Add(new VocabularyKey(nameof(TimesheetFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWeekAutoSplit = group.Add(new VocabularyKey(nameof(IsWeekAutoSplit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PeriodId { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey WeekDayPeriodStart { get; private set; }
public VocabularyKey Frequency { get; private set; }
public VocabularyKey PeriodFrequency { get; private set; }
public VocabularyKey TimesheetFrequency { get; private set; }
public VocabularyKey IsWeekAutoSplit { get; private set; }


    }
}