using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWarehouseWaveTemplateV3EntityVocabulary : SimpleVocabulary
    {
        public WHSWarehouseWaveTemplateV3EntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWarehouseWaveTemplateV3Entity";
            KeyPrefix = "commonDataModel.whswarehousewavetemplatev3entity";
            KeySeparator = ".";
            Grouping = "/WHSWarehouseWaveTemplateV3Entity";

            AddGroup("Common Data Model WHSWarehouseWaveTemplateV3Entity Details", group =>
            {
                WillReleaseToWarehouseAddShipmentToOpenWave = group.Add(new VocabularyKey(nameof(WillReleaseToWarehouseAddShipmentToOpenWave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillReleaseToWarehouseAutomaticallyCreateWaves = group.Add(new VocabularyKey(nameof(WillReleaseToWarehouseAutomaticallyCreateWaves), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillReleaseToWarehouseAutomaticallyProcessWaves = group.Add(new VocabularyKey(nameof(WillReleaseToWarehouseAutomaticallyProcessWaves), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillReachingThresholdAutomaticallyProcessWave = group.Add(new VocabularyKey(nameof(WillReachingThresholdAutomaticallyProcessWave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillWaveProcessingAutomaticallyReleaseCreatedReplenishmentWork = group.Add(new VocabularyKey(nameof(WillWaveProcessingAutomaticallyReleaseCreatedReplenishmentWork), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WillWaveCreationAutomaticallyReleaseWaves = group.Add(new VocabularyKey(nameof(WillWaveCreationAutomaticallyReleaseWaves), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InventorySiteId = group.Add(new VocabularyKey(nameof(InventorySiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsTemplateValid = group.Add(new VocabularyKey(nameof(IsTemplateValid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumNumberOfShipmentLinesPerWave = group.Add(new VocabularyKey(nameof(MaximumNumberOfShipmentLinesPerWave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumWeightPerWave = group.Add(new VocabularyKey(nameof(MaximumWeightPerWave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumNumberOfShipmentsPerWave = group.Add(new VocabularyKey(nameof(MaximumNumberOfShipmentsPerWave), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateDescription = group.Add(new VocabularyKey(nameof(TemplateDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateName = group.Add(new VocabularyKey(nameof(TemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateQuery = group.Add(new VocabularyKey(nameof(TemplateQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateSequenceNumber = group.Add(new VocabularyKey(nameof(TemplateSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateType = group.Add(new VocabularyKey(nameof(TemplateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FirstDefaultWaveAttributeValue = group.Add(new VocabularyKey(nameof(FirstDefaultWaveAttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SecondDefaultWaveAttributeValue = group.Add(new VocabularyKey(nameof(SecondDefaultWaveAttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ThirdDefaultWaveAttributeValue = group.Add(new VocabularyKey(nameof(ThirdDefaultWaveAttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FourthDefaultWaveAttributeValue = group.Add(new VocabularyKey(nameof(FourthDefaultWaveAttributeValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WillReleaseToWarehouseAddShipmentToOpenWave { get; private set; }
public VocabularyKey WillReleaseToWarehouseAutomaticallyCreateWaves { get; private set; }
public VocabularyKey WillReleaseToWarehouseAutomaticallyProcessWaves { get; private set; }
public VocabularyKey WillReachingThresholdAutomaticallyProcessWave { get; private set; }
public VocabularyKey WillWaveProcessingAutomaticallyReleaseCreatedReplenishmentWork { get; private set; }
public VocabularyKey WillWaveCreationAutomaticallyReleaseWaves { get; private set; }
public VocabularyKey WarehouseId { get; private set; }
public VocabularyKey InventorySiteId { get; private set; }
public VocabularyKey IsTemplateValid { get; private set; }
public VocabularyKey MaximumNumberOfShipmentLinesPerWave { get; private set; }
public VocabularyKey MaximumWeightPerWave { get; private set; }
public VocabularyKey MaximumNumberOfShipmentsPerWave { get; private set; }
public VocabularyKey TemplateDescription { get; private set; }
public VocabularyKey TemplateName { get; private set; }
public VocabularyKey TemplateQuery { get; private set; }
public VocabularyKey TemplateSequenceNumber { get; private set; }
public VocabularyKey TemplateType { get; private set; }
public VocabularyKey FirstDefaultWaveAttributeValue { get; private set; }
public VocabularyKey SecondDefaultWaveAttributeValue { get; private set; }
public VocabularyKey ThirdDefaultWaveAttributeValue { get; private set; }
public VocabularyKey FourthDefaultWaveAttributeValue { get; private set; }


    }
}