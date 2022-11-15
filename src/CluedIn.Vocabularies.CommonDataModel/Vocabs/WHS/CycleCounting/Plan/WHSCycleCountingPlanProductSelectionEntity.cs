using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSCycleCountingPlanProductSelectionEntityVocabulary : SimpleVocabulary
    {
        public WHSCycleCountingPlanProductSelectionEntityVocabulary()
        {
            VocabularyName = "WHS Cycle Counting Plan Product Selection Entity";
            KeyPrefix = "commonDataModel.whscyclecountingplanproductselectionentity";
            KeySeparator = ".";
            Grouping = "/WHSCycleCountingPlanProductSelectionEntity";

            AddGroup("WHSCycleCountingPlanProductSelectionEntity Details", group =>
            {
                CycleCountingPlanId = group.Add(new VocabularyKey(nameof(CycleCountingPlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSelectionSequence = group.Add(new VocabularyKey(nameof(ProductSelectionSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSelectionQueryDescription = group.Add(new VocabularyKey(nameof(ProductSelectionQueryDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductSelectionQueryMode = group.Add(new VocabularyKey(nameof(ProductSelectionQueryMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductQuery = group.Add(new VocabularyKey(nameof(ProductQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductVariantQuery = group.Add(new VocabularyKey(nameof(ProductVariantQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CycleCountingPlanId { get; private set; }
        public VocabularyKey ProductSelectionSequence { get; private set; }
        public VocabularyKey ProductSelectionQueryDescription { get; private set; }
        public VocabularyKey ProductSelectionQueryMode { get; private set; }
        public VocabularyKey ProductQuery { get; private set; }
        public VocabularyKey ProductVariantQuery { get; private set; }
    }
}