using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWaveLoadBuildingTemplateV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWaveLoadBuildingTemplateV2EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWaveLoadBuildingTemplateV2Entity";
            KeyPrefix = "commonDataModel.whswarehousewaveloadbuildingtemplatev2entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWaveLoadBuildingTemplateV2Entity";

            AddGroup("Common Data Model WHSWarehouseWaveLoadBuildingTemplateV2Entity Details", group =>
            {
                TemplateSequenceNumber = group.Add(new VocabularyKey(nameof(TemplateSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateName = group.Add(new VocabularyKey(nameof(TemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WaveStepCode = group.Add(new VocabularyKey(nameof(WaveStepCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadTemplateId = group.Add(new VocabularyKey(nameof(LoadTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseEquipmentCode = group.Add(new VocabularyKey(nameof(WarehouseEquipmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadMixGroupId = group.Add(new VocabularyKey(nameof(LoadMixGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillWarehouseWaveLoadBuildingValidateVolumetrics = group.Add(new VocabularyKey(nameof(WillWarehouseWaveLoadBuildingValidateVolumetrics), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CanWarehouseWaveLoadBuildingUseOpenLoads = group.Add(new VocabularyKey(nameof(CanWarehouseWaveLoadBuildingUseOpenLoads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CanWarehouseWaveLoadBuildingCreateLoads = group.Add(new VocabularyKey(nameof(CanWarehouseWaveLoadBuildingCreateLoads), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLoadLineSplittingAllowed = group.Add(new VocabularyKey(nameof(IsLoadLineSplittingAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateQuery = group.Add(new VocabularyKey(nameof(TemplateQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TemplateSequenceNumber { get; private set; }
public VocabularyKey TemplateName { get; private set; }
public VocabularyKey WaveStepCode { get; private set; }
public VocabularyKey LoadTemplateId { get; private set; }
public VocabularyKey WarehouseEquipmentCode { get; private set; }
public VocabularyKey LoadMixGroupId { get; private set; }
public VocabularyKey WillWarehouseWaveLoadBuildingValidateVolumetrics { get; private set; }
public VocabularyKey CanWarehouseWaveLoadBuildingUseOpenLoads { get; private set; }
public VocabularyKey CanWarehouseWaveLoadBuildingCreateLoads { get; private set; }
public VocabularyKey IsLoadLineSplittingAllowed { get; private set; }
public VocabularyKey TemplateQuery { get; private set; }


    }
}