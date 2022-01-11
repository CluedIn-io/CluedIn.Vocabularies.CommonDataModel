using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationZoneEngineParameterEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationZoneEngineParameterEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationZoneEngineParameterEntity";
            KeyPrefix = "commonDataModel.tmstransportationzoneengineparameterentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationZoneEngineParameterEntity";

            AddGroup("Common Data Model TMSTransportationZoneEngineParameterEntity Details", group =>
            {
                TransportationZoneEngineId = group.Add(new VocabularyKey(nameof(TransportationZoneEngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParameterName = group.Add(new VocabularyKey(nameof(ParameterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParameterValue = group.Add(new VocabularyKey(nameof(ParameterValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TransportationZoneEngineId { get; private set; }
public VocabularyKey ParameterName { get; private set; }
public VocabularyKey ParameterValue { get; private set; }


    }
}