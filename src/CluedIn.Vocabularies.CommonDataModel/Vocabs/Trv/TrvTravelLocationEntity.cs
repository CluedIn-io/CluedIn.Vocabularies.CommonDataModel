using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvTravelLocationEntityVocabulary : SimpleVocabulary
    {
        public TrvTravelLocationEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvTravelLocationEntity";
            KeyPrefix = "commonDataModel.trvtravellocationentity";
            KeySeparator = ".";
            Grouping = "/TrvTravelLocationEntity";

            AddGroup("Common Data Model TrvTravelLocationEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Destination = group.Add(new VocabularyKey(nameof(Destination), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey Destination { get; private set; }


    }
}