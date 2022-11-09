using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeanProductionFlowModelEntityVocabulary : SimpleVocabulary
    {
        public LeanProductionFlowModelEntityVocabulary()
        {
            VocabularyName = "Common Data Model LeanProductionFlowModelEntity";
            KeyPrefix = "commonDataModel.leanproductionflowmodelentity";
            KeySeparator = ".";
            Grouping = "/LeanProductionFlowModelEntity";

            AddGroup("Common Data Model LeanProductionFlowModelEntity Details", group =>
            {
                ModelName = group.Add(new VocabularyKey(nameof(ModelName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ModelType = group.Add(new VocabularyKey(nameof(ModelType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EPECycleDays = group.Add(new VocabularyKey(nameof(EPECycleDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlanningPeriodType = group.Add(new VocabularyKey(nameof(PlanningPeriodType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PlanningTimeFence = group.Add(new VocabularyKey(nameof(PlanningTimeFence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CapacityShortageReaction = group.Add(new VocabularyKey(nameof(CapacityShortageReaction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ModelName { get; private set; }
public VocabularyKey ModelType { get; private set; }
public VocabularyKey EPECycleDays { get; private set; }
public VocabularyKey PlanningPeriodType { get; private set; }
public VocabularyKey PlanningTimeFence { get; private set; }
public VocabularyKey CapacityShortageReaction { get; private set; }


    }
}