using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionTaxMeasureEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionTaxMeasureEntityVocabulary()
        {
            VocabularyName = "RetailTransactionTaxMeasureEntity";
            KeyPrefix = "commonDataModel.retailtransactiontaxmeasureentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionTaxMeasureEntity";

            AddGroup("RetailTransactionTaxMeasureEntity Details", group =>
            {
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Path = group.Add(new VocabularyKey(nameof(Path), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SaleLineNum = group.Add(new VocabularyKey(nameof(SaleLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelTableOMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Channel { get; private set; }
        public VocabularyKey Path { get; private set; }
        public VocabularyKey SaleLineNum { get; private set; }
        public VocabularyKey Terminal { get; private set; }
        public VocabularyKey TransactionNumber { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey RetailChannelTableOMOperatingUnitID { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }


    }
}