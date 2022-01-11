using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowElementLinkEntityVocabulary : SimpleVocabulary
    {
        public WorkflowElementLinkEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkflowElementLinkEntity";
            KeyPrefix = "commonDataModel.workflowelementlinkentity";
            KeySeparator = ".";
            Grouping = "/WorkflowElementLinkEntity";

            AddGroup("Common Data Model WorkflowElementLinkEntity Details", group =>
            {
                Level = group.Add(new VocabularyKey(nameof(Level), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Sequence = group.Add(new VocabularyKey(nameof(Sequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceType = group.Add(new VocabularyKey(nameof(SourceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TargetType = group.Add(new VocabularyKey(nameof(TargetType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceElementId = group.Add(new VocabularyKey(nameof(SourceElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TargetElementId = group.Add(new VocabularyKey(nameof(TargetElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Outcome = group.Add(new VocabularyKey(nameof(Outcome), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OutcomeName = group.Add(new VocabularyKey(nameof(OutcomeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParallelBranchName = group.Add(new VocabularyKey(nameof(ParallelBranchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParallelBranchElementId = group.Add(new VocabularyKey(nameof(ParallelBranchElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OutcomeRecId = group.Add(new VocabularyKey(nameof(OutcomeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SourceSubworkflowElementId = group.Add(new VocabularyKey(nameof(SourceSubworkflowElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TargetSubworkflowElementId = group.Add(new VocabularyKey(nameof(TargetSubworkflowElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Level { get; private set; }
public VocabularyKey Sequence { get; private set; }
public VocabularyKey SourceType { get; private set; }
public VocabularyKey TargetType { get; private set; }
public VocabularyKey SourceElementId { get; private set; }
public VocabularyKey TargetElementId { get; private set; }
public VocabularyKey WorkflowId { get; private set; }
public VocabularyKey Outcome { get; private set; }
public VocabularyKey OutcomeName { get; private set; }
public VocabularyKey ParallelBranchName { get; private set; }
public VocabularyKey ParallelBranchElementId { get; private set; }
public VocabularyKey OutcomeRecId { get; private set; }
public VocabularyKey SourceSubworkflowElementId { get; private set; }
public VocabularyKey TargetSubworkflowElementId { get; private set; }


    }
}