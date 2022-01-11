using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgJobCardTerminalConfigurationEntityVocabulary : SimpleVocabulary
    {
        public JmgJobCardTerminalConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgJobCardTerminalConfigurationEntity";
            KeyPrefix = "commonDataModel.jmgjobcardterminalconfigurationentity";
            KeySeparator = ".";
            Grouping = "/JmgJobCardTerminalConfigurationEntity";

            AddGroup("Common Data Model JmgJobCardTerminalConfigurationEntity Details", group =>
            {
                JobCardTerminalActionPaneConfigurationRecId = group.Add(new VocabularyKey(nameof(JobCardTerminalActionPaneConfigurationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobCardTerminalIndirectActivitiesGridConfigurationRecId = group.Add(new VocabularyKey(nameof(JobCardTerminalIndirectActivitiesGridConfigurationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsWorkerIdFieldDisabled = group.Add(new VocabularyKey(nameof(IsWorkerIdFieldDisabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobCardTerminalProductionGridConfigurationRecId = group.Add(new VocabularyKey(nameof(JobCardTerminalProductionGridConfigurationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobCardTerminalProjectGridConfigurationRecId = group.Add(new VocabularyKey(nameof(JobCardTerminalProjectGridConfigurationRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfigurationId = group.Add(new VocabularyKey(nameof(ConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrentActivitiesFactBoxDisplayMode = group.Add(new VocabularyKey(nameof(CurrentActivitiesFactBoxDisplayMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MustWorkerSpecifyProductionAreaBeforeRegistration = group.Add(new VocabularyKey(nameof(MustWorkerSpecifyProductionAreaBeforeRegistration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MessagesFactBoxDisplayMode = group.Add(new VocabularyKey(nameof(MessagesFactBoxDisplayMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PreviewPaneDisplayMode = group.Add(new VocabularyKey(nameof(PreviewPaneDisplayMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobStatusFactBoxDisplayMode = group.Add(new VocabularyKey(nameof(JobStatusFactBoxDisplayMode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SignInStartPage = group.Add(new VocabularyKey(nameof(SignInStartPage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillClockOutPromptWorkerForQuantity = group.Add(new VocabularyKey(nameof(WillClockOutPromptWorkerForQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillRegistrationFormValidateScheduledJobList = group.Add(new VocabularyKey(nameof(WillRegistrationFormValidateScheduledJobList), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsBarcodeScannerPrimaryInputDevice = group.Add(new VocabularyKey(nameof(IsBarcodeScannerPrimaryInputDevice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActualRegistrationTimeUsed = group.Add(new VocabularyKey(nameof(IsActualRegistrationTimeUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobCardTerminalActionPaneConfigurationId = group.Add(new VocabularyKey(nameof(JobCardTerminalActionPaneConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobCardTerminalIndirectActivitesGridConfigurationId = group.Add(new VocabularyKey(nameof(JobCardTerminalIndirectActivitesGridConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobCardTerminalProductionGridConfigurationId = group.Add(new VocabularyKey(nameof(JobCardTerminalProductionGridConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JobCardTerminalProjectGridConfigurationId = group.Add(new VocabularyKey(nameof(JobCardTerminalProjectGridConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey JobCardTerminalActionPaneConfigurationRecId { get; private set; }
public VocabularyKey JobCardTerminalIndirectActivitiesGridConfigurationRecId { get; private set; }
public VocabularyKey IsWorkerIdFieldDisabled { get; private set; }
public VocabularyKey JobCardTerminalProductionGridConfigurationRecId { get; private set; }
public VocabularyKey JobCardTerminalProjectGridConfigurationRecId { get; private set; }
public VocabularyKey ConfigurationId { get; private set; }
public VocabularyKey CurrentActivitiesFactBoxDisplayMode { get; private set; }
public VocabularyKey MustWorkerSpecifyProductionAreaBeforeRegistration { get; private set; }
public VocabularyKey MessagesFactBoxDisplayMode { get; private set; }
public VocabularyKey PreviewPaneDisplayMode { get; private set; }
public VocabularyKey JobStatusFactBoxDisplayMode { get; private set; }
public VocabularyKey SignInStartPage { get; private set; }
public VocabularyKey WillClockOutPromptWorkerForQuantity { get; private set; }
public VocabularyKey WillRegistrationFormValidateScheduledJobList { get; private set; }
public VocabularyKey IsBarcodeScannerPrimaryInputDevice { get; private set; }
public VocabularyKey IsActualRegistrationTimeUsed { get; private set; }
public VocabularyKey JobCardTerminalActionPaneConfigurationId { get; private set; }
public VocabularyKey JobCardTerminalIndirectActivitesGridConfigurationId { get; private set; }
public VocabularyKey JobCardTerminalProductionGridConfigurationId { get; private set; }
public VocabularyKey JobCardTerminalProjectGridConfigurationId { get; private set; }


    }
}