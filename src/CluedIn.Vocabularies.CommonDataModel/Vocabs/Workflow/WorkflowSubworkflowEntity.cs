using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowSubworkflowEntityVocabulary : SimpleVocabulary
    {
        public WorkflowSubworkflowEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkflowSubworkflowEntity";
            KeyPrefix = "commonDataModel.workflowsubworkflowentity";
            KeySeparator = ".";
            Grouping = "/WorkflowSubworkflowEntity";

            AddGroup("Common Data Model WorkflowSubworkflowEntity Details", group =>
            {
                DocumentKeyField = group.Add(new VocabularyKey(nameof(DocumentKeyField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentKeyTable = group.Add(new VocabularyKey(nameof(DocumentKeyTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElementId = group.Add(new VocabularyKey(nameof(ElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElementName = group.Add(new VocabularyKey(nameof(ElementName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElementType = group.Add(new VocabularyKey(nameof(ElementType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineItemType = group.Add(new VocabularyKey(nameof(LineItemType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParallelBranchElementId = group.Add(new VocabularyKey(nameof(ParallelBranchElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParallelBranchName = group.Add(new VocabularyKey(nameof(ParallelBranchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WaitForComplete = group.Add(new VocabularyKey(nameof(WaitForComplete), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowNumber = group.Add(new VocabularyKey(nameof(WorkflowNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DocumentKeyField { get; private set; }
public VocabularyKey DocumentKeyTable { get; private set; }
public VocabularyKey ElementId { get; private set; }
public VocabularyKey ElementName { get; private set; }
public VocabularyKey ElementType { get; private set; }
public VocabularyKey LineItemType { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ParallelBranchElementId { get; private set; }
public VocabularyKey ParallelBranchName { get; private set; }
public VocabularyKey WaitForComplete { get; private set; }
public VocabularyKey WorkflowNumber { get; private set; }
public VocabularyKey WorkflowId { get; private set; }


    }
}