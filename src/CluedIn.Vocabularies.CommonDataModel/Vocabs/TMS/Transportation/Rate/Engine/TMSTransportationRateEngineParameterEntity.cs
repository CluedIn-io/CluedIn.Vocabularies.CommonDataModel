using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRateEngineParameterEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRateEngineParameterEntityVocabulary()
        {
            VocabularyName = "TMS Transportation Rate Engine Parameter Entity";
            KeyPrefix = "commonDataModel.tmstransportationrateengineparameterentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRateEngineParameterEntity";

            AddGroup("TMSTransportationRateEngineParameterEntity Details", group =>
            {
                ParameterName = group.Add(new VocabularyKey(nameof(ParameterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParameterValue = group.Add(new VocabularyKey(nameof(ParameterValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransportationRateEngineId = group.Add(new VocabularyKey(nameof(TransportationRateEngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ParameterName { get; private set; }
        public VocabularyKey ParameterValue { get; private set; }
        public VocabularyKey TransportationRateEngineId { get; private set; }
    }
}