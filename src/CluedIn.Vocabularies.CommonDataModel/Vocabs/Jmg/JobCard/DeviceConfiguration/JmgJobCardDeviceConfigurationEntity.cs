using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgJobCardDeviceConfigurationEntityVocabulary : SimpleVocabulary
    {
        public JmgJobCardDeviceConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model JmgJobCardDeviceConfigurationEntity";
            KeyPrefix = "commonDataModel.jmgjobcarddeviceconfigurationentity";
            KeySeparator = ".";
            Grouping = "/JmgJobCardDeviceConfigurationEntity";

            AddGroup("Common Data Model JmgJobCardDeviceConfigurationEntity Details", group =>
            {
                IsWorkerIdFieldDisabled = group.Add(new VocabularyKey(nameof(IsWorkerIdFieldDisabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConfigurationId = group.Add(new VocabularyKey(nameof(ConfigurationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillClockOutPromptWorkerForQuantity = group.Add(new VocabularyKey(nameof(WillClockOutPromptWorkerForQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsBarcodeScannerPrimaryInputDevice = group.Add(new VocabularyKey(nameof(IsBarcodeScannerPrimaryInputDevice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsActualRegistrationTimeUsed = group.Add(new VocabularyKey(nameof(IsActualRegistrationTimeUsed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultProductionUnitIdFilter = group.Add(new VocabularyKey(nameof(DefaultProductionUnitIdFilter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultOperationsResourceIdFilter = group.Add(new VocabularyKey(nameof(DefaultOperationsResourceIdFilter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultOperationsResourceGroupIdFilter = group.Add(new VocabularyKey(nameof(DefaultOperationsResourceGroupIdFilter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ArePersonalFiltersAllowed = group.Add(new VocabularyKey(nameof(ArePersonalFiltersAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsSingleWorkerModeEnforced = group.Add(new VocabularyKey(nameof(IsSingleWorkerModeEnforced), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsWorkerIdFieldDisabled { get; private set; }
public VocabularyKey ConfigurationId { get; private set; }
public VocabularyKey WillClockOutPromptWorkerForQuantity { get; private set; }
public VocabularyKey IsBarcodeScannerPrimaryInputDevice { get; private set; }
public VocabularyKey IsActualRegistrationTimeUsed { get; private set; }
public VocabularyKey DefaultProductionUnitIdFilter { get; private set; }
public VocabularyKey DefaultOperationsResourceIdFilter { get; private set; }
public VocabularyKey DefaultOperationsResourceGroupIdFilter { get; private set; }
public VocabularyKey ArePersonalFiltersAllowed { get; private set; }
public VocabularyKey IsSingleWorkerModeEnforced { get; private set; }


    }
}