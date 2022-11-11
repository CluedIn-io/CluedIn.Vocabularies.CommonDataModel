using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SystemParametersEntityVocabulary : SimpleVocabulary
    {
        public SystemParametersEntityVocabulary()
        {
            VocabularyName = "SystemParametersEntity";
            KeyPrefix = "commonDataModel.systemparametersentity";
            KeySeparator = ".";
            Grouping = "/SystemParametersEntity";

            AddGroup("SystemParametersEntity Details", group =>
            {
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumRowsOfSSRSReports = group.Add(new VocabularyKey(nameof(MaximumRowsOfSSRSReports), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemLanguage = group.Add(new VocabularyKey(nameof(SystemLanguage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Increment = group.Add(new VocabularyKey(nameof(Increment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ThaiSoftwareSequenceNumber = group.Add(new VocabularyKey(nameof(ThaiSoftwareSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemCurrencyCode = group.Add(new VocabularyKey(nameof(SystemCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemExchangeRateType = group.Add(new VocabularyKey(nameof(SystemExchangeRateType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemExchangeRateTypeId = group.Add(new VocabularyKey(nameof(SystemExchangeRateTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ID { get; private set; }
        public VocabularyKey MaximumRowsOfSSRSReports { get; private set; }
        public VocabularyKey SystemLanguage { get; private set; }
        public VocabularyKey Increment { get; private set; }
        public VocabularyKey ThaiSoftwareSequenceNumber { get; private set; }
        public VocabularyKey SystemCurrencyCode { get; private set; }
        public VocabularyKey SystemExchangeRateType { get; private set; }
        public VocabularyKey SystemExchangeRateTypeId { get; private set; }


    }
}