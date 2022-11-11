using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationGenericEngineEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationGenericEngineEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationGenericEngineEntity";
            KeyPrefix = "commonDataModel.tmstransportationgenericengineentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationGenericEngineEntity";

            AddGroup("Common Data Model TMSTransportationGenericEngineEntity Details", group =>
            {
                IsDefaultEngine = group.Add(new VocabularyKey(nameof(IsDefaultEngine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngineType = group.Add(new VocabularyKey(nameof(EngineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngineAssemblyName = group.Add(new VocabularyKey(nameof(EngineAssemblyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngineClassName = group.Add(new VocabularyKey(nameof(EngineClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngineId = group.Add(new VocabularyKey(nameof(EngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngineName = group.Add(new VocabularyKey(nameof(EngineName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngineAssemblyType = group.Add(new VocabularyKey(nameof(EngineAssemblyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsDefaultEngine { get; private set; }
        public VocabularyKey EngineType { get; private set; }
        public VocabularyKey EngineAssemblyName { get; private set; }
        public VocabularyKey EngineClassName { get; private set; }
        public VocabularyKey EngineId { get; private set; }
        public VocabularyKey EngineName { get; private set; }
        public VocabularyKey EngineAssemblyType { get; private set; }


    }
}