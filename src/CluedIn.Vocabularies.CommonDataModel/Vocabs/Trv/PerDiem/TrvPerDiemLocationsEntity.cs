using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvPerDiemLocationsEntityVocabulary : SimpleVocabulary
    {
        public TrvPerDiemLocationsEntityVocabulary()
        {
            VocabularyName = "Trv Per Diem Locations Entity";
            KeyPrefix = "commonDataModel.trvperdiemlocationsentity";
            KeySeparator = ".";
            Grouping = "/TrvPerDiemLocationsEntity";

            AddGroup("TrvPerDiemLocationsEntity Details", group =>
            {
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey StateId { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
    }
}