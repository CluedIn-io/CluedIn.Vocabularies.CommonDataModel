using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationZoneEngineEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationZoneEngineEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationZoneEngineEntity";
            KeyPrefix = "commonDataModel.tmstransportationzoneengineentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationZoneEngineEntity";

            AddGroup("Common Data Model TMSTransportationZoneEngineEntity Details", group =>
            {
                ZoneEngineAssemblyName = group.Add(new VocabularyKey(nameof(ZoneEngineAssemblyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZoneEngineClassName = group.Add(new VocabularyKey(nameof(ZoneEngineClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EngineDescription = group.Add(new VocabularyKey(nameof(EngineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EngineId = group.Add(new VocabularyKey(nameof(EngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ZoneEngineAssemblyName { get; private set; }
public VocabularyKey ZoneEngineClassName { get; private set; }
public VocabularyKey EngineDescription { get; private set; }
public VocabularyKey EngineId { get; private set; }


    }
}