using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetTransReportingCurrencyAmountsEntityVocabulary : SimpleVocabulary
    {
        public AssetTransReportingCurrencyAmountsEntityVocabulary()
        {
            VocabularyName = "Asset Trans Reporting Currency Amounts Entity";
            KeyPrefix = "commonDataModel.assettransreportingcurrencyamountsentity";
            KeySeparator = ".";
            Grouping = "/AssetTransReportingCurrencyAmountsEntity";

            AddGroup("AssetTransReportingCurrencyAmountsEntity Details", group =>
            {
                BookId = group.Add(new VocabularyKey(nameof(BookId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetId = group.Add(new VocabularyKey(nameof(AssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransType = group.Add(new VocabularyKey(nameof(TransType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountCur = group.Add(new VocabularyKey(nameof(AmountCur), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountMST = group.Add(new VocabularyKey(nameof(AmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingCurrencyExchRate = group.Add(new VocabularyKey(nameof(ReportingCurrencyExchRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountReportingCurrency = group.Add(new VocabularyKey(nameof(AmountReportingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetTrans = group.Add(new VocabularyKey(nameof(AssetTrans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BookId { get; private set; }
        public VocabularyKey AssetId { get; private set; }
        public VocabularyKey TransType { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey AmountCur { get; private set; }
        public VocabularyKey AmountMST { get; private set; }
        public VocabularyKey ReportingCurrencyExchRate { get; private set; }
        public VocabularyKey AmountReportingCurrency { get; private set; }
        public VocabularyKey AssetTrans { get; private set; }
    }
}