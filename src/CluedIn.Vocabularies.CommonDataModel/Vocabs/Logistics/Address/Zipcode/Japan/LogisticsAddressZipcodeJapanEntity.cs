using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressZipcodeJapanEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressZipcodeJapanEntityVocabulary()
        {
            VocabularyName = "Logistics Address Zipcode Japan Entity";
            KeyPrefix = "commonDataModel.logisticsaddresszipcodejapanentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressZipcodeJapanEntity";

            AddGroup("LogisticsAddressZipcodeJapanEntity Details", group =>
            {
                CityId = group.Add(new VocabularyKey(nameof(CityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StreetName = group.Add(new VocabularyKey(nameof(StreetName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ZipCode = group.Add(new VocabularyKey(nameof(ZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey(nameof(Country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpdateFlag = group.Add(new VocabularyKey(nameof(UpdateFlag), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KanaStreetName = group.Add(new VocabularyKey(nameof(KanaStreetName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KanaCity = group.Add(new VocabularyKey(nameof(KanaCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CityId { get; private set; }
        public VocabularyKey StreetName { get; private set; }
        public VocabularyKey ZipCode { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey UpdateFlag { get; private set; }
        public VocabularyKey KanaStreetName { get; private set; }
        public VocabularyKey KanaCity { get; private set; }
    }
}