using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSFuelIndexRegionEntityVocabulary : SimpleVocabulary
    {
        public TMSFuelIndexRegionEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSFuelIndexRegionEntity";
            KeyPrefix = "commonDataModel.tmsfuelindexregionentity";
            KeySeparator = ".";
            Grouping = "/TMSFuelIndexRegionEntity";

            AddGroup("Common Data Model TMSFuelIndexRegionEntity Details", group =>
            {
                RegionId = group.Add(new VocabularyKey(nameof(RegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RegionName = group.Add(new VocabularyKey(nameof(RegionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey RegionId { get; private set; }
public VocabularyKey RegionName { get; private set; }


    }
}