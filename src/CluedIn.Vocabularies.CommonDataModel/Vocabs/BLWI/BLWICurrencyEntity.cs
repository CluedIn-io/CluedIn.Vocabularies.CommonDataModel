using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BLWICurrencyEntityVocabulary : SimpleVocabulary
    {
        public BLWICurrencyEntityVocabulary()
        {
            VocabularyName = "BLWI Currency Entity";
            KeyPrefix = "commonDataModel.blwicurrencyentity";
            KeySeparator = ".";
            Grouping = "/BLWICurrencyEntity";

            AddGroup("BLWICurrencyEntity Details", group =>
            {
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportInThisCurrency = group.Add(new VocabularyKey(nameof(ReportInThisCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnNumber = group.Add(new VocabularyKey(nameof(ColumnNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey ReportInThisCurrency { get; private set; }
        public VocabularyKey ColumnNumber { get; private set; }
    }
}