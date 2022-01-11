using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjWBSTemplateTasksEntityVocabulary : SimpleVocabulary
    {
        public ProjWBSTemplateTasksEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjWBSTemplateTasksEntity";
            KeyPrefix = "commonDataModel.projwbstemplatetasksentity";
            KeySeparator = ".";
            Grouping = "/ProjWBSTemplateTasksEntity";

            AddGroup("Common Data Model ProjWBSTemplateTasksEntity Details", group =>
            {
                HierarchyId = group.Add(new VocabularyKey(nameof(HierarchyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaskId = group.Add(new VocabularyKey(nameof(TaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WBSId = group.Add(new VocabularyKey(nameof(WBSId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Task = group.Add(new VocabularyKey(nameof(Task), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Predecessors = group.Add(new VocabularyKey(nameof(Predecessors), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Category = group.Add(new VocabularyKey(nameof(Category), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Effort = group.Add(new VocabularyKey(nameof(Effort), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NumberOfResources = group.Add(new VocabularyKey(nameof(NumberOfResources), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Role = group.Add(new VocabularyKey(nameof(Role), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ActivityStatus = group.Add(new VocabularyKey(nameof(ActivityStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParentTaskId = group.Add(new VocabularyKey(nameof(ParentTaskId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaskSiblingNumber = group.Add(new VocabularyKey(nameof(TaskSiblingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ResourceCategory = group.Add(new VocabularyKey(nameof(ResourceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaskPriority = group.Add(new VocabularyKey(nameof(TaskPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsCategoryMandatory = group.Add(new VocabularyKey(nameof(IsCategoryMandatory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsTemplate = group.Add(new VocabularyKey(nameof(IsTemplate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey HierarchyId { get; private set; }
public VocabularyKey TaskId { get; private set; }
public VocabularyKey WBSId { get; private set; }
public VocabularyKey Notes { get; private set; }
public VocabularyKey Task { get; private set; }
public VocabularyKey Predecessors { get; private set; }
public VocabularyKey Category { get; private set; }
public VocabularyKey Effort { get; private set; }
public VocabularyKey NumberOfResources { get; private set; }
public VocabularyKey Role { get; private set; }
public VocabularyKey ActivityStatus { get; private set; }
public VocabularyKey ParentTaskId { get; private set; }
public VocabularyKey TaskSiblingNumber { get; private set; }
public VocabularyKey ResourceCategory { get; private set; }
public VocabularyKey TaskPriority { get; private set; }
public VocabularyKey IsCategoryMandatory { get; private set; }
public VocabularyKey IsTemplate { get; private set; }


    }
}