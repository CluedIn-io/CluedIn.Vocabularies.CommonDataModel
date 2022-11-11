using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PdsItemBatchAttributeGroupEntityVocabulary : SimpleVocabulary
    {
        public PdsItemBatchAttributeGroupEntityVocabulary()
        {
            VocabularyName = "PdsItemBatchAttributeGroupEntity";
            KeyPrefix = "commonDataModel.pdsitembatchattributegroupentity";
            KeySeparator = ".";
            Grouping = "/PdsItemBatchAttributeGroupEntity";

            AddGroup("PdsItemBatchAttributeGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }


    }
}