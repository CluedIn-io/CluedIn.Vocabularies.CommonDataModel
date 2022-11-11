using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LogisticsAddressParametersEntityVocabulary : SimpleVocabulary
    {
        public LogisticsAddressParametersEntityVocabulary()
        {
            VocabularyName = "LogisticsAddressParametersEntity";
            KeyPrefix = "commonDataModel.logisticsaddressparametersentity";
            KeySeparator = ".";
            Grouping = "/LogisticsAddressParametersEntity";

            AddGroup("LogisticsAddressParametersEntity Details", group =>
            {
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateCity = group.Add(new VocabularyKey(nameof(ValidateCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateDistrict = group.Add(new VocabularyKey(nameof(ValidateDistrict), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidateZipCode = group.Add(new VocabularyKey(nameof(ValidateZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Key { get; private set; }
        public VocabularyKey ValidateCity { get; private set; }
        public VocabularyKey ValidateDistrict { get; private set; }
        public VocabularyKey ValidateZipCode { get; private set; }


    }
}