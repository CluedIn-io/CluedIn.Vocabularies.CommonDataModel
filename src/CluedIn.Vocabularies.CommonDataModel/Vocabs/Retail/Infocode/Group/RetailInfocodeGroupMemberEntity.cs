using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInfocodeGroupMemberEntityVocabulary : SimpleVocabulary
    {
        public RetailInfocodeGroupMemberEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailInfocodeGroupMemberEntity";
            KeyPrefix = "commonDataModel.retailinfocodegroupmemberentity";
            KeySeparator = ".";
            Grouping = "/RetailInfocodeGroupMemberEntity";

            AddGroup("Common Data Model RetailInfocodeGroupMemberEntity Details", group =>
            {
                GroupId = group.Add(new VocabularyKey(nameof(GroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InfocodeId = group.Add(new VocabularyKey(nameof(InfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey GroupId { get; private set; }
        public VocabularyKey InfocodeId { get; private set; }
        public VocabularyKey Priority { get; private set; }


    }
}