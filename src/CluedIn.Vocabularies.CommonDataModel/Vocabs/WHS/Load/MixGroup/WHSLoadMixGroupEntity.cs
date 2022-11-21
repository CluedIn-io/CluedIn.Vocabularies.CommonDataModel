using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLoadMixGroupEntityVocabulary : SimpleVocabulary
    {
        public WHSLoadMixGroupEntityVocabulary()
        {
            VocabularyName = "WHS Load Mix Group Entity";
            KeyPrefix = "commonDataModel.whsloadmixgroupentity";
            KeySeparator = ".";
            Grouping = "/WHSLoadMixGroupEntity";

            AddGroup("WHSLoadMixGroupEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey GroupDescription { get; private set; }
    }
}