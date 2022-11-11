using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressCountyEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressCountyEntityVocabulary()
        {
            VocabularyName = "LogisticsAddressCountyEntity";
            KeyPrefix = "commonDataModel.logisticsaddresscountyentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressCountyEntity";

            AddGroup("LogisticsAddressCountyEntity Details", group =>
            {
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountyId = group.Add(new VocabularyKey(nameof(CountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ESCountryCode = group.Add(new VocabularyKey(nameof(ESCountryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ITCountyCode = group.Add(new VocabularyKey(nameof(ITCountyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey StateId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey CountyId { get; private set; }
        public VocabularyKey ESCountryCode { get; private set; }
        public VocabularyKey ITCountyCode { get; private set; }


    }
}