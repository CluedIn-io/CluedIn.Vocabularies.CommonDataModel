using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressCountryRegionEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressCountryRegionEntityVocabulary()
        {
            VocabularyName = "Common Data Model LogisticsAddressCountryRegionEntity";
            KeyPrefix = "commonDataModel.logisticsaddresscountryregionentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressCountryRegionEntity";

            AddGroup("Common Data Model LogisticsAddressCountryRegionEntity Details", group =>
            {
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressFormat = group.Add(new VocabularyKey(nameof(AddressFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZone = group.Add(new VocabularyKey(nameof(TimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseZipPlus4 = group.Add(new VocabularyKey(nameof(UseZipPlus4), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ISOcode = group.Add(new VocabularyKey(nameof(ISOcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentCountryRegion = group.Add(new VocabularyKey(nameof(ParentCountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BrazilCentralBankCountryCode = group.Add(new VocabularyKey(nameof(BrazilCentralBankCountryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OKSMCode_RU = group.Add(new VocabularyKey(nameof(OKSMCode_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey AddressFormat { get; private set; }
        public VocabularyKey TimeZone { get; private set; }
        public VocabularyKey UseZipPlus4 { get; private set; }
        public VocabularyKey ISOcode { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey ParentCountryRegion { get; private set; }
        public VocabularyKey BrazilCentralBankCountryCode { get; private set; }
        public VocabularyKey OKSMCode_RU { get; private set; }


    }
}