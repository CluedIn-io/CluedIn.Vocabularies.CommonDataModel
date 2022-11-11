using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceObjectGroupEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceObjectGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model SMAServiceObjectGroupEntity";
            KeyPrefix = "commonDataModel.smaserviceobjectgroupentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceObjectGroupEntity";

            AddGroup("Common Data Model SMAServiceObjectGroupEntity Details", group =>
            {
                GroupDescription = group.Add(new VocabularyKey(nameof(GroupDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupDescription { get; private set; }
        public VocabularyKey GroupId { get; private set; }


    }
}