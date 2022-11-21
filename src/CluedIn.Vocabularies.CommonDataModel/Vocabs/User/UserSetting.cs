using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class UserSettingVocabulary : SimpleVocabulary
    {
        public UserSettingVocabulary()
        {
            VocabularyName = "User Setting";
            KeyPrefix = "commonDataModel.usersetting";
            KeySeparator = ".";
            Grouping = "/UserSetting";

            AddGroup("UserSetting Details", group =>
            {
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UserSettingId = group.Add(new VocabularyKey(nameof(UserSettingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Key { get; private set; }
        public VocabularyKey UserSettingId { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}