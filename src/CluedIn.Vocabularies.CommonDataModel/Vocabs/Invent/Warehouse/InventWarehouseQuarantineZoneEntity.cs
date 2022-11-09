using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InventWarehouseQuarantineZoneEntityVocabulary : SimpleVocabulary
    {
        public InventWarehouseQuarantineZoneEntityVocabulary()
        {
            VocabularyName = "Common Data Model InventWarehouseQuarantineZoneEntity";
            KeyPrefix = "commonDataModel.inventwarehousequarantinezoneentity";
            KeySeparator = ".";
            Grouping = "/InventWarehouseQuarantineZoneEntity";

            AddGroup("Common Data Model InventWarehouseQuarantineZoneEntity Details", group =>
            {
                ZoneDescription = group.Add(new VocabularyKey(nameof(ZoneDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZoneId = group.Add(new VocabularyKey(nameof(ZoneId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ZoneDescription { get; private set; }
public VocabularyKey ZoneId { get; private set; }


    }
}