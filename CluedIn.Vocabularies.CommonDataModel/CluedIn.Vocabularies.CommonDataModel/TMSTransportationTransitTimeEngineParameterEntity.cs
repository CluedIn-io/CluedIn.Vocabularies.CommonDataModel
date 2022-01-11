using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationTransitTimeEngineParameterEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationTransitTimeEngineParameterEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationTransitTimeEngineParameterEntity";
            KeyPrefix = "commonDataModel.tmstransportationtransittimeengineparameterentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationTransitTimeEngineParameterEntity";

            AddGroup("Common Data Model TMSTransportationTransitTimeEngineParameterEntity Details", group =>
            {
                ParameterName = group.Add(new VocabularyKey(nameof(ParameterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParameterValue = group.Add(new VocabularyKey(nameof(ParameterValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationTransitTimeEngineId = group.Add(new VocabularyKey(nameof(TransportationTransitTimeEngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ParameterName { get; private set; }
public VocabularyKey ParameterValue { get; private set; }
public VocabularyKey TransportationTransitTimeEngineId { get; private set; }


    }
}