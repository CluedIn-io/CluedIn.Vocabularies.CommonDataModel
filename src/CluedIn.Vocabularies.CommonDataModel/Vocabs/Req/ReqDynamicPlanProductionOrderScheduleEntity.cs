using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqDynamicPlanProductionOrderScheduleEntityVocabulary : SimpleVocabulary
    {
        public ReqDynamicPlanProductionOrderScheduleEntityVocabulary()
        {
            VocabularyName = "Common Data Model ReqDynamicPlanProductionOrderScheduleEntity";
            KeyPrefix = "commonDataModel.reqdynamicplanproductionorderscheduleentity";
            KeySeparator = ".";
            Grouping = "/ReqDynamicPlanProductionOrderScheduleEntity";

            AddGroup("Common Data Model ReqDynamicPlanProductionOrderScheduleEntity Details", group =>
            {
                DynamicMasterPlanId = group.Add(new VocabularyKey(nameof(DynamicMasterPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceOrderId = group.Add(new VocabularyKey(nameof(ReferenceOrderId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequirementDate = group.Add(new VocabularyKey(nameof(RequirementDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScheduledEndDate = group.Add(new VocabularyKey(nameof(ScheduledEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DynamicMasterPlanId { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ReferenceOrderId { get; private set; }
        public VocabularyKey RequirementDate { get; private set; }
        public VocabularyKey ScheduledEndDate { get; private set; }


    }
}