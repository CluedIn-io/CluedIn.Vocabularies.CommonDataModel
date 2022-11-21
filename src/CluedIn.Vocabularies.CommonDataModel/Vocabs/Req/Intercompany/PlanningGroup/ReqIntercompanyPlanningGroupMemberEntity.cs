using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReqIntercompanyPlanningGroupMemberEntityVocabulary : SimpleVocabulary
    {
        public ReqIntercompanyPlanningGroupMemberEntityVocabulary()
        {
            VocabularyName = "Req Intercompany Planning Group Member Entity";
            KeyPrefix = "commonDataModel.reqintercompanyplanninggroupmemberentity";
            KeySeparator = ".";
            Grouping = "/ReqIntercompanyPlanningGroupMemberEntity";

            AddGroup("ReqIntercompanyPlanningGroupMemberEntity Details", group =>
            {
                WillIntercompanyPlanAutomaticallyBeCopiedToDynamicPlan = group.Add(new VocabularyKey(nameof(WillIntercompanyPlanAutomaticallyBeCopiedToDynamicPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WillIntercompanyPlanAutomaticallyBeCopiedToStaticPlan = group.Add(new VocabularyKey(nameof(WillIntercompanyPlanAutomaticallyBeCopiedToStaticPlan), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MasterPlanId = group.Add(new VocabularyKey(nameof(MasterPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntercompanyPlanningSequence = group.Add(new VocabularyKey(nameof(IntercompanyPlanningSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntercompanyPlanningGroupName = group.Add(new VocabularyKey(nameof(IntercompanyPlanningGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntercompanyPlanDataAreaId = group.Add(new VocabularyKey(nameof(IntercompanyPlanDataAreaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey WillIntercompanyPlanAutomaticallyBeCopiedToDynamicPlan { get; private set; }
        public VocabularyKey WillIntercompanyPlanAutomaticallyBeCopiedToStaticPlan { get; private set; }
        public VocabularyKey MasterPlanId { get; private set; }
        public VocabularyKey IntercompanyPlanningSequence { get; private set; }
        public VocabularyKey IntercompanyPlanningGroupName { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey IntercompanyPlanDataAreaId { get; private set; }
    }
}