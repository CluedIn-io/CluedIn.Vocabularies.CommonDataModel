using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgJobCardTerminalGridControlConfigurationEntityVocabulary : SimpleVocabulary
    {
        public JmgJobCardTerminalGridControlConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgJobCardTerminalGridControlConfigurationEntity";
            KeyPrefix = "commonDataModel.jmgjobcardterminalgridcontrolconfigurationentity";
            KeySeparator = ".";
            Grouping = "/JmgJobCardTerminalGridControlConfigurationEntity";

            AddGroup("Common Data Model JmgJobCardTerminalGridControlConfigurationEntity Details", group =>
            {
                FieldName = group.Add(new VocabularyKey(nameof(FieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ControlLocation = group.Add(new VocabularyKey(nameof(ControlLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobCardTerminalGridConfigurationRecId = group.Add(new VocabularyKey(nameof(JobCardTerminalGridConfigurationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobCardTerminalGridConfigurationId = group.Add(new VocabularyKey(nameof(JobCardTerminalGridConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ControlLabel = group.Add(new VocabularyKey(nameof(ControlLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ControlSequenceNumber = group.Add(new VocabularyKey(nameof(ControlSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FieldName { get; private set; }
public VocabularyKey ControlLocation { get; private set; }
public VocabularyKey JobCardTerminalGridConfigurationRecId { get; private set; }
public VocabularyKey JobCardTerminalGridConfigurationId { get; private set; }
public VocabularyKey ControlLabel { get; private set; }
public VocabularyKey ControlSequenceNumber { get; private set; }


    }
}