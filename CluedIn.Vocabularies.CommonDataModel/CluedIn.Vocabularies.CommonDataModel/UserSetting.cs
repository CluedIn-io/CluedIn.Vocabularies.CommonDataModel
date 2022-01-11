using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class UserSettingVocabulary : SimpleVocabulary
    {
        public UserSettingVocabulary()
        {
            VocabularyName = "Common Data Model UserSetting";
            KeyPrefix = "commonDataModel.usersetting";
            KeySeparator = ".";
            Grouping = "/UserSetting";

            AddGroup("Common Data Model UserSetting Details", group =>
            {
                key = group.Add(new VocabularyKey(nameof(key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
userSettingId = group.Add(new VocabularyKey(nameof(userSettingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
value = group.Add(new VocabularyKey(nameof(value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
comment = group.Add(new VocabularyKey(nameof(comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey key { get; private set; }
public VocabularyKey userSettingId { get; private set; }
public VocabularyKey value { get; private set; }
public VocabularyKey comment { get; private set; }
public VocabularyKey stateCode { get; private set; }
public VocabularyKey statusCode { get; private set; }


    }
}