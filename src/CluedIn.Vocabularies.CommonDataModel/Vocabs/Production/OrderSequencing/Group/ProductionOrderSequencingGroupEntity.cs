using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProductionOrderSequencingGroupEntityVocabulary : SimpleVocabulary
    {
        public ProductionOrderSequencingGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProductionOrderSequencingGroupEntity";
            KeyPrefix = "commonDataModel.productionordersequencinggroupentity";
            KeySeparator = ".";
            Grouping = "/ProductionOrderSequencingGroupEntity";

            AddGroup("Common Data Model ProductionOrderSequencingGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }


    }
}