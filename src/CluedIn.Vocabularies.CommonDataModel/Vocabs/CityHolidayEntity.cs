using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CityHolidayEntityVocabulary : SimpleVocabulary
    {
        public CityHolidayEntityVocabulary()
        {
            VocabularyName = "CityHolidayEntity";
            KeyPrefix = "commonDataModel.cityholidayentity";
            KeySeparator = ".";
            Grouping = "/CityHolidayEntity";

            AddGroup("CityHolidayEntity Details", group =>
            {
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CityName = group.Add(new VocabularyKey(nameof(CityName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HolidayDate = group.Add(new VocabularyKey(nameof(HolidayDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey City { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey StateId { get; private set; }
        public VocabularyKey CityName { get; private set; }
        public VocabularyKey HolidayDate { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}