using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgJobCardTerminalGridConfigurationEntityVocabulary : SimpleVocabulary
    {
        public JmgJobCardTerminalGridConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgJobCardTerminalGridConfigurationEntity";
            KeyPrefix = "commonDataModel.jmgjobcardterminalgridconfigurationentity";
            KeySeparator = ".";
            Grouping = "/JmgJobCardTerminalGridConfigurationEntity";

            AddGroup("Common Data Model JmgJobCardTerminalGridConfigurationEntity Details", group =>
            {
                GridConfigurationDescription = group.Add(new VocabularyKey(nameof(GridConfigurationDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GridConfigurationId = group.Add(new VocabularyKey(nameof(GridConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey GridConfigurationDescription { get; private set; }
public VocabularyKey GridConfigurationId { get; private set; }


    }
}