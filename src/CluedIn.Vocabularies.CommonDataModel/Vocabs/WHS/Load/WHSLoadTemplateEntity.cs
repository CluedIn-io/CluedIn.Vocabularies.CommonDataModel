using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSLoadTemplateEntityVocabulary : SimpleVocabulary
    {
        public WHSLoadTemplateEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSLoadTemplateEntity";
            KeyPrefix = "commonDataModel.whsloadtemplateentity";
            KeySeparator = ".";
            Grouping = "/WHSLoadTemplateEntity";

            AddGroup("Common Data Model WHSLoadTemplateEntity Details", group =>
            {
                WarehouseEquipmentCode = group.Add(new VocabularyKey(nameof(WarehouseEquipmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadDepth = group.Add(new VocabularyKey(nameof(LoadDepth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLoadFloorStacked = group.Add(new VocabularyKey(nameof(IsLoadFloorStacked), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadHeight = group.Add(new VocabularyKey(nameof(LoadHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumLoadVolume = group.Add(new VocabularyKey(nameof(MaximumLoadVolume), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumLoadWeight = group.Add(new VocabularyKey(nameof(MaximumLoadWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LoadWidth = group.Add(new VocabularyKey(nameof(LoadWidth), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumFreightPieces = group.Add(new VocabularyKey(nameof(MaximumFreightPieces), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumGrossWeight = group.Add(new VocabularyKey(nameof(MaximumGrossWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsLoadSplitShipConfirmAllowed = group.Add(new VocabularyKey(nameof(IsLoadSplitShipConfirmAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumQuantity = group.Add(new VocabularyKey(nameof(MaximumQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MaximumQuantityUnitSymbol = group.Add(new VocabularyKey(nameof(MaximumQuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey WarehouseEquipmentCode { get; private set; }
public VocabularyKey LoadDepth { get; private set; }
public VocabularyKey IsLoadFloorStacked { get; private set; }
public VocabularyKey LoadHeight { get; private set; }
public VocabularyKey MaximumLoadVolume { get; private set; }
public VocabularyKey MaximumLoadWeight { get; private set; }
public VocabularyKey TemplateId { get; private set; }
public VocabularyKey LoadWidth { get; private set; }
public VocabularyKey MaximumFreightPieces { get; private set; }
public VocabularyKey MaximumGrossWeight { get; private set; }
public VocabularyKey IsLoadSplitShipConfirmAllowed { get; private set; }
public VocabularyKey MaximumQuantity { get; private set; }
public VocabularyKey MaximumQuantityUnitSymbol { get; private set; }


    }
}