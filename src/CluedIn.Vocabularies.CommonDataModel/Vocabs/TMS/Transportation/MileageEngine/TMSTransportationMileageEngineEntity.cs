using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationMileageEngineEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationMileageEngineEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationMileageEngineEntity";
            KeyPrefix = "commonDataModel.tmstransportationmileageengineentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationMileageEngineEntity";

            AddGroup("Common Data Model TMSTransportationMileageEngineEntity Details", group =>
            {
                IsDefaultEngine = group.Add(new VocabularyKey(nameof(IsDefaultEngine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngineAssemblyName = group.Add(new VocabularyKey(nameof(EngineAssemblyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngineAssemblyClassName = group.Add(new VocabularyKey(nameof(EngineAssemblyClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngineId = group.Add(new VocabularyKey(nameof(EngineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EngineDescription = group.Add(new VocabularyKey(nameof(EngineDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsDefaultEngine { get; private set; }
        public VocabularyKey EngineAssemblyName { get; private set; }
        public VocabularyKey EngineAssemblyClassName { get; private set; }
        public VocabularyKey EngineId { get; private set; }
        public VocabularyKey EngineDescription { get; private set; }


    }
}