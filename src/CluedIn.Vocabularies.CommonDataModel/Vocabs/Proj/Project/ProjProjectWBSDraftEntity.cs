using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectWBSDraftEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectWBSDraftEntityVocabulary()
        {
            VocabularyName = "Proj Project WBS Draft Entity";
            KeyPrefix = "commonDataModel.projprojectwbsdraftentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectWBSDraftEntity";

            AddGroup("ProjProjectWBSDraftEntity Details", group =>
            {
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyId = group.Add(new VocabularyKey(nameof(HierarchyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskId = group.Add(new VocabularyKey(nameof(TaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WBSId = group.Add(new VocabularyKey(nameof(WBSId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Note = group.Add(new VocabularyKey(nameof(Note), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Task = group.Add(new VocabularyKey(nameof(Task), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Predecessors = group.Add(new VocabularyKey(nameof(Predecessors), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Effort = group.Add(new VocabularyKey(nameof(Effort), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Duration = group.Add(new VocabularyKey(nameof(Duration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfResources = group.Add(new VocabularyKey(nameof(NumberOfResources), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Role = group.Add(new VocabularyKey(nameof(Role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTaskClosed = group.Add(new VocabularyKey(nameof(IsTaskClosed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTaskMandatory = group.Add(new VocabularyKey(nameof(IsTaskMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyTreeTableRefRecId = group.Add(new VocabularyKey(nameof(HierarchyTreeTableRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskSiblingNumber = group.Add(new VocabularyKey(nameof(TaskSiblingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentTaskId = group.Add(new VocabularyKey(nameof(ParentTaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ResourceCategory = group.Add(new VocabularyKey(nameof(ResourceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskPriority = group.Add(new VocabularyKey(nameof(TaskPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActivityTaskTimeType = group.Add(new VocabularyKey(nameof(ActivityTaskTimeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsCategoryMandatory = group.Add(new VocabularyKey(nameof(IsCategoryMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarId = group.Add(new VocabularyKey(nameof(CalendarId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MSPID = group.Add(new VocabularyKey(nameof(MSPID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndNode = group.Add(new VocabularyKey(nameof(EndNode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HierarchyLevel = group.Add(new VocabularyKey(nameof(HierarchyLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CalendarStandardWorkDayHours = group.Add(new VocabularyKey(nameof(CalendarStandardWorkDayHours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskEffortAtComplete = group.Add(new VocabularyKey(nameof(TaskEffortAtComplete), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaskCostAtComplete = group.Add(new VocabularyKey(nameof(TaskCostAtComplete), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey HierarchyId { get; private set; }
        public VocabularyKey TaskId { get; private set; }
        public VocabularyKey WBSId { get; private set; }
        public VocabularyKey Note { get; private set; }
        public VocabularyKey Task { get; private set; }
        public VocabularyKey Predecessors { get; private set; }
        public VocabularyKey Category { get; private set; }
        public VocabularyKey Effort { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey NumberOfResources { get; private set; }
        public VocabularyKey Role { get; private set; }
        public VocabularyKey IsTaskClosed { get; private set; }
        public VocabularyKey IsTaskMandatory { get; private set; }
        public VocabularyKey HierarchyTreeTableRefRecId { get; private set; }
        public VocabularyKey TaskSiblingNumber { get; private set; }
        public VocabularyKey ParentTaskId { get; private set; }
        public VocabularyKey ResourceCategory { get; private set; }
        public VocabularyKey TaskPriority { get; private set; }
        public VocabularyKey ActivityTaskTimeType { get; private set; }
        public VocabularyKey IsCategoryMandatory { get; private set; }
        public VocabularyKey CalendarId { get; private set; }
        public VocabularyKey MSPID { get; private set; }
        public VocabularyKey EndNode { get; private set; }
        public VocabularyKey HierarchyLevel { get; private set; }
        public VocabularyKey CalendarStandardWorkDayHours { get; private set; }
        public VocabularyKey TaskEffortAtComplete { get; private set; }
        public VocabularyKey TaskCostAtComplete { get; private set; }
    }
}