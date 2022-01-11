using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowElementEntityVocabulary : SimpleVocabulary
    {
        public WorkflowElementEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkflowElementEntity";
            KeyPrefix = "commonDataModel.workflowelemententity";
            KeySeparator = ".";
            Grouping = "/WorkflowElementEntity";

            AddGroup("Common Data Model WorkflowElementEntity Details", group =>
            {
                ConditionId = group.Add(new VocabularyKey(nameof(ConditionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AutoCompleteAction = group.Add(new VocabularyKey(nameof(AutoCompleteAction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AutoCompleteConditionId = group.Add(new VocabularyKey(nameof(AutoCompleteConditionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElementId = group.Add(new VocabularyKey(nameof(ElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElementName = group.Add(new VocabularyKey(nameof(ElementName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElementType = group.Add(new VocabularyKey(nameof(ElementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnableActionsInWorkList = group.Add(new VocabularyKey(nameof(EnableActionsInWorkList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RunSubworkflow = group.Add(new VocabularyKey(nameof(RunSubworkflow), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RunSubworkflowConditionId = group.Add(new VocabularyKey(nameof(RunSubworkflowConditionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FinalApproverUser = group.Add(new VocabularyKey(nameof(FinalApproverUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Required = group.Add(new VocabularyKey(nameof(Required), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RunInParallel = group.Add(new VocabularyKey(nameof(RunInParallel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Sequence = group.Add(new VocabularyKey(nameof(Sequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnableAutoComplete = group.Add(new VocabularyKey(nameof(EnableAutoComplete), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnableFinalApprover = group.Add(new VocabularyKey(nameof(EnableFinalApprover), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnableMaximumRuntime = group.Add(new VocabularyKey(nameof(EnableMaximumRuntime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeOutcome = group.Add(new VocabularyKey(nameof(MaximumRuntimeOutcome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeTime = group.Add(new VocabularyKey(nameof(MaximumRuntimeTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeTimeZone = group.Add(new VocabularyKey(nameof(MaximumRuntimeTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParallelBranchName = group.Add(new VocabularyKey(nameof(ParallelBranchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParallelBranchElementId = group.Add(new VocabularyKey(nameof(ParallelBranchElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeDailyCalendar = group.Add(new VocabularyKey(nameof(MaximumRuntimeDailyCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeDailyCalendarProvider = group.Add(new VocabularyKey(nameof(MaximumRuntimeDailyCalendarProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeDailyIncludeFriday = group.Add(new VocabularyKey(nameof(MaximumRuntimeDailyIncludeFriday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeDailyIncludeMonday = group.Add(new VocabularyKey(nameof(MaximumRuntimeDailyIncludeMonday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeDailyIncludeSaturday = group.Add(new VocabularyKey(nameof(MaximumRuntimeDailyIncludeSaturday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeDailyIncludeSunday = group.Add(new VocabularyKey(nameof(MaximumRuntimeDailyIncludeSunday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeDailyIncludeThursday = group.Add(new VocabularyKey(nameof(MaximumRuntimeDailyIncludeThursday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeDailyIncludeTuesday = group.Add(new VocabularyKey(nameof(MaximumRuntimeDailyIncludeTuesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeDailyIncludeWednesday = group.Add(new VocabularyKey(nameof(MaximumRuntimeDailyIncludeWednesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeDailyUseNonCalendar = group.Add(new VocabularyKey(nameof(MaximumRuntimeDailyUseNonCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeDailyValue = group.Add(new VocabularyKey(nameof(MaximumRuntimeDailyValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeDateType = group.Add(new VocabularyKey(nameof(MaximumRuntimeDateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHourCalendar = group.Add(new VocabularyKey(nameof(MaximumRuntimeHourCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHourCalendarProvider = group.Add(new VocabularyKey(nameof(MaximumRuntimeHourCalendarProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHourIncludeFriday = group.Add(new VocabularyKey(nameof(MaximumRuntimeHourIncludeFriday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHourIncludeMonday = group.Add(new VocabularyKey(nameof(MaximumRuntimeHourIncludeMonday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHourIncludeSaturday = group.Add(new VocabularyKey(nameof(MaximumRuntimeHourIncludeSaturday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHourIncludeSunday = group.Add(new VocabularyKey(nameof(MaximumRuntimeHourIncludeSunday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHourIncludeThursday = group.Add(new VocabularyKey(nameof(MaximumRuntimeHourIncludeThursday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHourIncludeTuesday = group.Add(new VocabularyKey(nameof(MaximumRuntimeHourIncludeTuesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHourIncludeWednesday = group.Add(new VocabularyKey(nameof(MaximumRuntimeHourIncludeWednesday), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHoursAvailable = group.Add(new VocabularyKey(nameof(MaximumRuntimeHoursAvailable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHourStartTime = group.Add(new VocabularyKey(nameof(MaximumRuntimeHourStartTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHourUseNonCalendar = group.Add(new VocabularyKey(nameof(MaximumRuntimeHourUseNonCalendar), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeHourValue = group.Add(new VocabularyKey(nameof(MaximumRuntimeHourValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeMonthlyDayOfWeek = group.Add(new VocabularyKey(nameof(MaximumRuntimeMonthlyDayOfWeek), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeMonthlyWeekInMonth = group.Add(new VocabularyKey(nameof(MaximumRuntimeMonthlyWeekInMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeTimeSpanRelationType = group.Add(new VocabularyKey(nameof(MaximumRuntimeTimeSpanRelationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeWeeklyDayOfWeek = group.Add(new VocabularyKey(nameof(MaximumRuntimeWeeklyDayOfWeek), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeWeeklyValue = group.Add(new VocabularyKey(nameof(MaximumRuntimeWeeklyValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeYearlyDayOfWeek = group.Add(new VocabularyKey(nameof(MaximumRuntimeYearlyDayOfWeek), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeYearlyMonthInYear = group.Add(new VocabularyKey(nameof(MaximumRuntimeYearlyMonthInYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumRuntimeYearlyWeekInMonth = group.Add(new VocabularyKey(nameof(MaximumRuntimeYearlyWeekInMonth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ConditionId { get; private set; }
public VocabularyKey AutoCompleteAction { get; private set; }
public VocabularyKey AutoCompleteConditionId { get; private set; }
public VocabularyKey WorkflowId { get; private set; }
public VocabularyKey ElementId { get; private set; }
public VocabularyKey ElementName { get; private set; }
public VocabularyKey ElementType { get; private set; }
public VocabularyKey EnableActionsInWorkList { get; private set; }
public VocabularyKey RunSubworkflow { get; private set; }
public VocabularyKey RunSubworkflowConditionId { get; private set; }
public VocabularyKey FinalApproverUser { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey Required { get; private set; }
public VocabularyKey RunInParallel { get; private set; }
public VocabularyKey Sequence { get; private set; }
public VocabularyKey EnableAutoComplete { get; private set; }
public VocabularyKey EnableFinalApprover { get; private set; }
public VocabularyKey EnableMaximumRuntime { get; private set; }
public VocabularyKey MaximumRuntimeOutcome { get; private set; }
public VocabularyKey MaximumRuntimeTime { get; private set; }
public VocabularyKey MaximumRuntimeTimeZone { get; private set; }
public VocabularyKey ParallelBranchName { get; private set; }
public VocabularyKey ParallelBranchElementId { get; private set; }
public VocabularyKey MaximumRuntimeDailyCalendar { get; private set; }
public VocabularyKey MaximumRuntimeDailyCalendarProvider { get; private set; }
public VocabularyKey MaximumRuntimeDailyIncludeFriday { get; private set; }
public VocabularyKey MaximumRuntimeDailyIncludeMonday { get; private set; }
public VocabularyKey MaximumRuntimeDailyIncludeSaturday { get; private set; }
public VocabularyKey MaximumRuntimeDailyIncludeSunday { get; private set; }
public VocabularyKey MaximumRuntimeDailyIncludeThursday { get; private set; }
public VocabularyKey MaximumRuntimeDailyIncludeTuesday { get; private set; }
public VocabularyKey MaximumRuntimeDailyIncludeWednesday { get; private set; }
public VocabularyKey MaximumRuntimeDailyUseNonCalendar { get; private set; }
public VocabularyKey MaximumRuntimeDailyValue { get; private set; }
public VocabularyKey MaximumRuntimeDateType { get; private set; }
public VocabularyKey MaximumRuntimeHourCalendar { get; private set; }
public VocabularyKey MaximumRuntimeHourCalendarProvider { get; private set; }
public VocabularyKey MaximumRuntimeHourIncludeFriday { get; private set; }
public VocabularyKey MaximumRuntimeHourIncludeMonday { get; private set; }
public VocabularyKey MaximumRuntimeHourIncludeSaturday { get; private set; }
public VocabularyKey MaximumRuntimeHourIncludeSunday { get; private set; }
public VocabularyKey MaximumRuntimeHourIncludeThursday { get; private set; }
public VocabularyKey MaximumRuntimeHourIncludeTuesday { get; private set; }
public VocabularyKey MaximumRuntimeHourIncludeWednesday { get; private set; }
public VocabularyKey MaximumRuntimeHoursAvailable { get; private set; }
public VocabularyKey MaximumRuntimeHourStartTime { get; private set; }
public VocabularyKey MaximumRuntimeHourUseNonCalendar { get; private set; }
public VocabularyKey MaximumRuntimeHourValue { get; private set; }
public VocabularyKey MaximumRuntimeMonthlyDayOfWeek { get; private set; }
public VocabularyKey MaximumRuntimeMonthlyWeekInMonth { get; private set; }
public VocabularyKey MaximumRuntimeTimeSpanRelationType { get; private set; }
public VocabularyKey MaximumRuntimeWeeklyDayOfWeek { get; private set; }
public VocabularyKey MaximumRuntimeWeeklyValue { get; private set; }
public VocabularyKey MaximumRuntimeYearlyDayOfWeek { get; private set; }
public VocabularyKey MaximumRuntimeYearlyMonthInYear { get; private set; }
public VocabularyKey MaximumRuntimeYearlyWeekInMonth { get; private set; }


    }
}