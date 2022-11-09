using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRateEngineEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRateEngineEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationRateEngineEntity";
            KeyPrefix = "commonDataModel.tmstransportationrateengineentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRateEngineEntity";

            AddGroup("Common Data Model TMSTransportationRateEngineEntity Details", group =>
            {
                RateEngineAssemblyName = group.Add(new VocabularyKey(nameof(RateEngineAssemblyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RateEngineClassName = group.Add(new VocabularyKey(nameof(RateEngineClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EngineDescription = group.Add(new VocabularyKey(nameof(EngineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationRatingMetadataId = group.Add(new VocabularyKey(nameof(TransportationRatingMetadataId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EngineId = group.Add(new VocabularyKey(nameof(EngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey RateEngineAssemblyName { get; private set; }
public VocabularyKey RateEngineClassName { get; private set; }
public VocabularyKey EngineDescription { get; private set; }
public VocabularyKey TransportationRatingMetadataId { get; private set; }
public VocabularyKey EngineId { get; private set; }


    }
}