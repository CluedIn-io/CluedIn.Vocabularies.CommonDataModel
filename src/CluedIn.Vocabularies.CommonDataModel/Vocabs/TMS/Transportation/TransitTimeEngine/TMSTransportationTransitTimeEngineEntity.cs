using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationTransitTimeEngineEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationTransitTimeEngineEntityVocabulary()
        {
            VocabularyName = "TMSTransportationTransitTimeEngineEntity";
            KeyPrefix = "commonDataModel.tmstransportationtransittimeengineentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationTransitTimeEngineEntity";

            AddGroup("TMSTransportationTransitTimeEngineEntity Details", group =>
            {
                EngineId = group.Add(new VocabularyKey(nameof(EngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngineDescription = group.Add(new VocabularyKey(nameof(EngineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransitTimeEngineAssemblyName = group.Add(new VocabularyKey(nameof(TransitTimeEngineAssemblyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransitTimeEngineClassName = group.Add(new VocabularyKey(nameof(TransitTimeEngineClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey EngineId { get; private set; }
        public VocabularyKey EngineDescription { get; private set; }
        public VocabularyKey TransitTimeEngineAssemblyName { get; private set; }
        public VocabularyKey TransitTimeEngineClassName { get; private set; }


    }
}