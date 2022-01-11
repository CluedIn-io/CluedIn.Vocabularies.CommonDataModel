using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WorkflowParallelBranchEntityVocabulary : SimpleVocabulary
    {
        public WorkflowParallelBranchEntityVocabulary()
        {
            VocabularyName = "Common Data Model WorkflowParallelBranchEntity";
            KeyPrefix = "commonDataModel.workflowparallelbranchentity";
            KeySeparator = ".";
            Grouping = "/WorkflowParallelBranchEntity";

            AddGroup("Common Data Model WorkflowParallelBranchEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ElementId = group.Add(new VocabularyKey(nameof(ElementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey ElementId { get; private set; }


    }
}