using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressCityEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressCityEntityVocabulary()
        {
            VocabularyName = "LogisticsAddressCityEntity";
            KeyPrefix = "commonDataModel.logisticsaddresscityentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressCityEntity";

            AddGroup("LogisticsAddressCityEntity Details", group =>
            {
                CityKey = group.Add(new VocabularyKey(nameof(CityKey), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountyId = group.Add(new VocabularyKey(nameof(CountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilCityCode = group.Add(new VocabularyKey(nameof(BrazilCityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CityInKana = group.Add(new VocabularyKey(nameof(CityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CityKey { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey StateId { get; private set; }
        public VocabularyKey CountyId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey BrazilCityCode { get; private set; }
        public VocabularyKey CityInKana { get; private set; }


    }
}