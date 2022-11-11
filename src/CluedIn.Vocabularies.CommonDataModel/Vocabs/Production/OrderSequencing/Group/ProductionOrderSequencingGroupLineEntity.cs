using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProductionOrderSequencingGroupLineEntityVocabulary : SimpleVocabulary
    {
        public ProductionOrderSequencingGroupLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProductionOrderSequencingGroupLineEntity";
            KeyPrefix = "commonDataModel.productionordersequencinggrouplineentity";
            KeySeparator = ".";
            Grouping = "/ProductionOrderSequencingGroupLineEntity";

            AddGroup("Common Data Model ProductionOrderSequencingGroupLineEntity Details", group =>
            {
                ProductionOrderSequencingGroupId = group.Add(new VocabularyKey(nameof(ProductionOrderSequencingGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionOrderSequencingSequenceId = group.Add(new VocabularyKey(nameof(ProductionOrderSequencingSequenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rank = group.Add(new VocabularyKey(nameof(Rank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProductionOrderSequencingGroupId { get; private set; }
        public VocabularyKey ProductionOrderSequencingSequenceId { get; private set; }
        public VocabularyKey Rank { get; private set; }


    }
}