using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationZoneMasterEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationZoneMasterEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationZoneMasterEntity";
            KeyPrefix = "commonDataModel.tmstransportationzonemasterentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationZoneMasterEntity";

            AddGroup("Common Data Model TMSTransportationZoneMasterEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZoneEngineCode = group.Add(new VocabularyKey(nameof(ZoneEngineCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZoneMasterCode = group.Add(new VocabularyKey(nameof(ZoneMasterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ZoneType = group.Add(new VocabularyKey(nameof(ZoneType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Name { get; private set; }
public VocabularyKey ZoneEngineCode { get; private set; }
public VocabularyKey ZoneMasterCode { get; private set; }
public VocabularyKey ZoneType { get; private set; }


    }
}