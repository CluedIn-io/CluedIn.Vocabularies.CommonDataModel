using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWorkCreationRuleV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWorkCreationRuleV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWorkCreationRuleV2Entity";
            KeyPrefix = "commonDataModel.whswarehouseworkcreationrulev2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWorkCreationRuleV2Entity";

            AddGroup("Common Data Model WHSWarehouseWorkCreationRuleV2Entity Details", group =>
            {
                WHSPolicyRecId = group.Add(new VocabularyKey(nameof(WHSPolicyRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkOrderType = group.Add(new VocabularyKey(nameof(WorkOrderType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkCreationMethod = group.Add(new VocabularyKey(nameof(WorkCreationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkPolicyName = group.Add(new VocabularyKey(nameof(WorkPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CrossDockingOpportunityPolicyName = group.Add(new VocabularyKey(nameof(CrossDockingOpportunityPolicyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WorkProcess = group.Add(new VocabularyKey(nameof(WorkProcess), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WHSPolicyRecId { get; private set; }
public VocabularyKey WorkOrderType { get; private set; }
public VocabularyKey WorkCreationMethod { get; private set; }
public VocabularyKey WorkPolicyName { get; private set; }
public VocabularyKey CrossDockingOpportunityPolicyName { get; private set; }
public VocabularyKey WorkProcess { get; private set; }


    }
}