using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProductionOrderSequencingGroupEntityVocabulary : SimpleVocabulary
    {
        public ProductionOrderSequencingGroupEntityVocabulary()
        {
            VocabularyName = "Production Order Sequencing Group Entity";
            KeyPrefix = "commonDataModel.productionordersequencinggroupentity";
            KeySeparator = ".";
            Grouping = "/ProductionOrderSequencingGroupEntity";

            AddGroup("ProductionOrderSequencingGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
    }
}