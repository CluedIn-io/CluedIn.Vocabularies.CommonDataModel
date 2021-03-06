using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSFuelIndexEntityVocabulary : SimpleVocabulary
    {
        public TMSFuelIndexEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSFuelIndexEntity";
            KeyPrefix = "commonDataModel.tmsfuelindexentity";
            KeySeparator = ".";
            Grouping = "/TMSFuelIndexEntity";

            AddGroup("Common Data Model TMSFuelIndexEntity Details", group =>
            {
                EffectiveDateTime = group.Add(new VocabularyKey(nameof(EffectiveDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FuelIndexRegionId = group.Add(new VocabularyKey(nameof(FuelIndexRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GallonPrice = group.Add(new VocabularyKey(nameof(GallonPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey EffectiveDateTime { get; private set; }
public VocabularyKey FuelIndexRegionId { get; private set; }
public VocabularyKey GallonPrice { get; private set; }


    }
}