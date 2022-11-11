using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventInventoryProfileRelationEntityVocabulary : SimpleVocabulary
    {
        public InventInventoryProfileRelationEntityVocabulary()
        {
            VocabularyName = "InventInventoryProfileRelationEntity";
            KeyPrefix = "commonDataModel.inventinventoryprofilerelationentity";
            KeySeparator = ".";
            Grouping = "/InventInventoryProfileRelationEntity";

            AddGroup("InventInventoryProfileRelationEntity Details", group =>
            {
                InventoryProfileId = group.Add(new VocabularyKey(nameof(InventoryProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompatibleInventoryProfileId = group.Add(new VocabularyKey(nameof(CompatibleInventoryProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MatchingPriority = group.Add(new VocabularyKey(nameof(MatchingPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InventoryProfileId { get; private set; }
        public VocabularyKey CompatibleInventoryProfileId { get; private set; }
        public VocabularyKey MatchingPriority { get; private set; }


    }
}