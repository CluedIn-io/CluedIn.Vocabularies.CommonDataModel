using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemGlobalConfigurationEntityVocabulary : SimpleVocabulary
    {
        public SystemGlobalConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model SystemGlobalConfigurationEntity";
            KeyPrefix = "commonDataModel.systemglobalconfigurationentity";
            KeySeparator = ".";
            Grouping = "/SystemGlobalConfigurationEntity";

            AddGroup("Common Data Model SystemGlobalConfigurationEntity Details", group =>
            {
                AOSInstanceName = group.Add(new VocabularyKey(nameof(AOSInstanceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SettingLevel = group.Add(new VocabularyKey(nameof(SettingLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AOSInstanceName { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey SettingLevel { get; private set; }
public VocabularyKey Value { get; private set; }


    }
}