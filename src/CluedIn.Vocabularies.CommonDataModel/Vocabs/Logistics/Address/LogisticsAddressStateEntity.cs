using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressStateEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressStateEntityVocabulary()
        {
            VocabularyName = "LogisticsAddressStateEntity";
            KeyPrefix = "commonDataModel.logisticsaddressstateentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressStateEntity";

            AddGroup("LogisticsAddressStateEntity Details", group =>
            {
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZone = group.Add(new VocabularyKey(nameof(TimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatCode = group.Add(new VocabularyKey(nameof(IntrastatCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilStateCode = group.Add(new VocabularyKey(nameof(BrazilStateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey TimeZone { get; private set; }
        public VocabularyKey IntrastatCode { get; private set; }
        public VocabularyKey BrazilStateCode { get; private set; }


    }
}