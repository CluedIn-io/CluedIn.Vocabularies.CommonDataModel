using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationLoadBuildingStrategyEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationLoadBuildingStrategyEntityVocabulary()
        {
            VocabularyName = "TMSTransportationLoadBuildingStrategyEntity";
            KeyPrefix = "commonDataModel.tmstransportationloadbuildingstrategyentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationLoadBuildingStrategyEntity";

            AddGroup("TMSTransportationLoadBuildingStrategyEntity Details", group =>
            {
                TransportationLoadBuildStrategyClass = group.Add(new VocabularyKey(nameof(TransportationLoadBuildStrategyClass), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StrategyName = group.Add(new VocabularyKey(nameof(StrategyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StrategyClassName = group.Add(new VocabularyKey(nameof(StrategyClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TransportationLoadBuildStrategyClass { get; private set; }
        public VocabularyKey StrategyName { get; private set; }
        public VocabularyKey StrategyClassName { get; private set; }


    }
}