using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSUnitOfMeasureConversionSequenceGroupSequenceEntityVocabulary : SimpleVocabulary
    {
        public WHSUnitOfMeasureConversionSequenceGroupSequenceEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSUnitOfMeasureConversionSequenceGroupSequenceEntity";
            KeyPrefix = "commonDataModel.whsunitofmeasureconversionsequencegroupsequenceentity";
            KeySeparator = ".";
            Grouping = "/WHSUnitOfMeasureConversionSequenceGroupSequenceEntity";

            AddGroup("Common Data Model WHSUnitOfMeasureConversionSequenceGroupSequenceEntity Details", group =>
            {
                IsCycleCountingUnit = group.Add(new VocabularyKey(nameof(IsCycleCountingUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDefaultProductionReceivingUnit = group.Add(new VocabularyKey(nameof(IsDefaultProductionReceivingUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDefaultInboundReceivingUnit = group.Add(new VocabularyKey(nameof(IsDefaultInboundReceivingUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LicensePlatePackingType = group.Add(new VocabularyKey(nameof(LicensePlatePackingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ToUnitSymbol = group.Add(new VocabularyKey(nameof(ToUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsUnitLicensePlateGrouped = group.Add(new VocabularyKey(nameof(IsUnitLicensePlateGrouped), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UnitConversionSequenceGroupId = group.Add(new VocabularyKey(nameof(UnitConversionSequenceGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultContainerTypeId = group.Add(new VocabularyKey(nameof(DefaultContainerTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsDefaultMaterialConsumptionUnit = group.Add(new VocabularyKey(nameof(IsDefaultMaterialConsumptionUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
WaveLabelTypeId = group.Add(new VocabularyKey(nameof(WaveLabelTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IsCycleCountingUnit { get; private set; }
public VocabularyKey IsDefaultProductionReceivingUnit { get; private set; }
public VocabularyKey IsDefaultInboundReceivingUnit { get; private set; }
public VocabularyKey LicensePlatePackingType { get; private set; }
public VocabularyKey SequenceNumber { get; private set; }
public VocabularyKey ToUnitSymbol { get; private set; }
public VocabularyKey IsUnitLicensePlateGrouped { get; private set; }
public VocabularyKey UnitConversionSequenceGroupId { get; private set; }
public VocabularyKey DefaultContainerTypeId { get; private set; }
public VocabularyKey IsDefaultMaterialConsumptionUnit { get; private set; }
public VocabularyKey WaveLabelTypeId { get; private set; }


    }
}