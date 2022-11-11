using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProductionOrderSequencingSequenceEntityVocabulary : SimpleVocabulary
    {
        public ProductionOrderSequencingSequenceEntityVocabulary()
        {
            VocabularyName = "ProductionOrderSequencingSequenceEntity";
            KeyPrefix = "commonDataModel.productionordersequencingsequenceentity";
            KeySeparator = ".";
            Grouping = "/ProductionOrderSequencingSequenceEntity";

            AddGroup("ProductionOrderSequencingSequenceEntity Details", group =>
            {
                SequenceId = group.Add(new VocabularyKey(nameof(SequenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceDescription = group.Add(new VocabularyKey(nameof(SequenceDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SequenceId { get; private set; }
        public VocabularyKey SequenceDescription { get; private set; }


    }
}