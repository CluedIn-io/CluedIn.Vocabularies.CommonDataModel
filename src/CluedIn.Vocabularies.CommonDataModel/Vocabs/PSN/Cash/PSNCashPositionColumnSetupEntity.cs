using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSNCashPositionColumnSetupEntityVocabulary : SimpleVocabulary
    {
        public PSNCashPositionColumnSetupEntityVocabulary()
        {
            VocabularyName = "PSN Cash Position Column Setup Entity";
            KeyPrefix = "commonDataModel.psncashpositioncolumnsetupentity";
            KeySeparator = ".";
            Grouping = "/PSNCashPositionColumnSetupEntity";

            AddGroup("PSNCashPositionColumnSetupEntity Details", group =>
            {
                ColumnOneLabel = group.Add(new VocabularyKey(nameof(ColumnOneLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnOneRange = group.Add(new VocabularyKey(nameof(ColumnOneRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnTwoLabel = group.Add(new VocabularyKey(nameof(ColumnTwoLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnTwoRange = group.Add(new VocabularyKey(nameof(ColumnTwoRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnTwoCreditRange = group.Add(new VocabularyKey(nameof(ColumnTwoCreditRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnTwoDebitRange = group.Add(new VocabularyKey(nameof(ColumnTwoDebitRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnThreeLabel = group.Add(new VocabularyKey(nameof(ColumnThreeLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnThreeRange = group.Add(new VocabularyKey(nameof(ColumnThreeRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnThreeCreditRange = group.Add(new VocabularyKey(nameof(ColumnThreeCreditRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnThreeDebitRange = group.Add(new VocabularyKey(nameof(ColumnThreeDebitRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnFourLabel = group.Add(new VocabularyKey(nameof(ColumnFourLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnFourRange = group.Add(new VocabularyKey(nameof(ColumnFourRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnFourCreditRange = group.Add(new VocabularyKey(nameof(ColumnFourCreditRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnFourDebitRange = group.Add(new VocabularyKey(nameof(ColumnFourDebitRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnFiveLabel = group.Add(new VocabularyKey(nameof(ColumnFiveLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnSixLabel = group.Add(new VocabularyKey(nameof(ColumnSixLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnSixRange = group.Add(new VocabularyKey(nameof(ColumnSixRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnSixCreditRange = group.Add(new VocabularyKey(nameof(ColumnSixCreditRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnSixDebitRange = group.Add(new VocabularyKey(nameof(ColumnSixDebitRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnSevenLabel = group.Add(new VocabularyKey(nameof(ColumnSevenLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnSevenRange = group.Add(new VocabularyKey(nameof(ColumnSevenRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnSevenCreditRange = group.Add(new VocabularyKey(nameof(ColumnSevenCreditRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnSevenDebitRange = group.Add(new VocabularyKey(nameof(ColumnSevenDebitRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ColumnEightLabel = group.Add(new VocabularyKey(nameof(ColumnEightLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ColumnOneLabel { get; private set; }
        public VocabularyKey ColumnOneRange { get; private set; }
        public VocabularyKey ColumnTwoLabel { get; private set; }
        public VocabularyKey ColumnTwoRange { get; private set; }
        public VocabularyKey ColumnTwoCreditRange { get; private set; }
        public VocabularyKey ColumnTwoDebitRange { get; private set; }
        public VocabularyKey ColumnThreeLabel { get; private set; }
        public VocabularyKey ColumnThreeRange { get; private set; }
        public VocabularyKey ColumnThreeCreditRange { get; private set; }
        public VocabularyKey ColumnThreeDebitRange { get; private set; }
        public VocabularyKey ColumnFourLabel { get; private set; }
        public VocabularyKey ColumnFourRange { get; private set; }
        public VocabularyKey ColumnFourCreditRange { get; private set; }
        public VocabularyKey ColumnFourDebitRange { get; private set; }
        public VocabularyKey ColumnFiveLabel { get; private set; }
        public VocabularyKey ColumnSixLabel { get; private set; }
        public VocabularyKey ColumnSixRange { get; private set; }
        public VocabularyKey ColumnSixCreditRange { get; private set; }
        public VocabularyKey ColumnSixDebitRange { get; private set; }
        public VocabularyKey ColumnSevenLabel { get; private set; }
        public VocabularyKey ColumnSevenRange { get; private set; }
        public VocabularyKey ColumnSevenCreditRange { get; private set; }
        public VocabularyKey ColumnSevenDebitRange { get; private set; }
        public VocabularyKey ColumnEightLabel { get; private set; }
        public VocabularyKey Key { get; private set; }
    }
}