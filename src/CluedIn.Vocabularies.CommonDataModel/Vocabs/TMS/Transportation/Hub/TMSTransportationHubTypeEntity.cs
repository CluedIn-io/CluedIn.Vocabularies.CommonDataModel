using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationHubTypeEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationHubTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationHubTypeEntity";
            KeyPrefix = "commonDataModel.tmstransportationhubtypeentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationHubTypeEntity";

            AddGroup("Common Data Model TMSTransportationHubTypeEntity Details", group =>
            {
                TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeName = group.Add(new VocabularyKey(nameof(TypeName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TypeId { get; private set; }
        public VocabularyKey TypeName { get; private set; }


    }
}