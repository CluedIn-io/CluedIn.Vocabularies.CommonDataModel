using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventBuyerGroupEntityVocabulary : SimpleVocabulary
    {
        public InventBuyerGroupEntityVocabulary()
        {
            VocabularyName = "Invent Buyer Group Entity";
            KeyPrefix = "commonDataModel.inventbuyergroupentity";
            KeySeparator = ".";
            Grouping = "/InventBuyerGroupEntity";

            AddGroup("InventBuyerGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey GroupId { get; private set; }
    }
}