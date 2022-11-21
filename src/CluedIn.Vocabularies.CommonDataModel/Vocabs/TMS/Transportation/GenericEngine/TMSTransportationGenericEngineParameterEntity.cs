using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationGenericEngineParameterEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationGenericEngineParameterEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Generic Engine Parameter Entity";
            KeyPrefix = "commonDataModel.tmstransportationgenericengineparameterentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationGenericEngineParameterEntity";

            AddGroup("TMSTransportationGenericEngineParameterEntity Details", group =>
            {
                ParameterName = group.Add(new VocabularyKey(nameof(ParameterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParameterValue = group.Add(new VocabularyKey(nameof(ParameterValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationGenericEngineId = group.Add(new VocabularyKey(nameof(TransportationGenericEngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ParameterName { get; private set; }
        public VocabularyKey ParameterValue { get; private set; }
        public VocabularyKey TransportationGenericEngineId { get; private set; }
    }
}