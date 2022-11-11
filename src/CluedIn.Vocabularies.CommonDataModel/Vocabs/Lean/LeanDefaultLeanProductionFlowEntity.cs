using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LeanDefaultLeanProductionFlowEntityVocabulary : SimpleVocabulary
    {
        public LeanDefaultLeanProductionFlowEntityVocabulary()
        {
            VocabularyName = "Common Data Model LeanDefaultLeanProductionFlowEntity";
            KeyPrefix = "commonDataModel.leandefaultleanproductionflowentity";
            KeySeparator = ".";
            Grouping = "/LeanDefaultLeanProductionFlowEntity";

            AddGroup("Common Data Model LeanDefaultLeanProductionFlowEntity Details", group =>
            {
                LeanProductionFlowReference_PlanReference = group.Add(new VocabularyKey(nameof(LeanProductionFlowReference_PlanReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeanProductionFlowReference = group.Add(new VocabularyKey(nameof(LeanProductionFlowReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalSiteId = group.Add(new VocabularyKey(nameof(OperationalSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LeanProductionFlowName = group.Add(new VocabularyKey(nameof(LeanProductionFlowName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LeanProductionFlowReference_PlanReference { get; private set; }
        public VocabularyKey LeanProductionFlowReference { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey OperationalSiteId { get; private set; }
        public VocabularyKey LeanProductionFlowName { get; private set; }


    }
}