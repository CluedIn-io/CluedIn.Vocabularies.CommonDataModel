using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationMileageEngineParameterEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationMileageEngineParameterEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationMileageEngineParameterEntity";
            KeyPrefix = "commonDataModel.tmstransportationmileageengineparameterentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationMileageEngineParameterEntity";

            AddGroup("Common Data Model TMSTransportationMileageEngineParameterEntity Details", group =>
            {
                ParameterName = group.Add(new VocabularyKey(nameof(ParameterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ParameterValue = group.Add(new VocabularyKey(nameof(ParameterValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransportationMileageEngineId = group.Add(new VocabularyKey(nameof(TransportationMileageEngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ParameterName { get; private set; }
public VocabularyKey ParameterValue { get; private set; }
public VocabularyKey TransportationMileageEngineId { get; private set; }


    }
}