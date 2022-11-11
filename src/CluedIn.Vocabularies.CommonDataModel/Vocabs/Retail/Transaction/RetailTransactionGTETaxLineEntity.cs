using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionGTETaxLineEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionGTETaxLineEntityVocabulary()
        {
            VocabularyName = "RetailTransactionGTETaxLineEntity";
            KeyPrefix = "commonDataModel.retailtransactiongtetaxlineentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionGTETaxLineEntity";

            AddGroup("RetailTransactionGTETaxLineEntity Details", group =>
            {
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTaxIncludedInPrice = group.Add(new VocabularyKey(nameof(IsTaxIncludedInPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SaleLineNum = group.Add(new VocabularyKey(nameof(SaleLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAmount = group.Add(new VocabularyKey(nameof(TaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxBasis = group.Add(new VocabularyKey(nameof(TaxBasis), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxComponent = group.Add(new VocabularyKey(nameof(TaxComponent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxPercentage = group.Add(new VocabularyKey(nameof(TaxPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailChannelTableOMOperatingUnitID = group.Add(new VocabularyKey(nameof(RetailChannelTableOMOperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Channel { get; private set; }
        public VocabularyKey IsTaxIncludedInPrice { get; private set; }
        public VocabularyKey SaleLineNum { get; private set; }
        public VocabularyKey TaxAmount { get; private set; }
        public VocabularyKey TaxBasis { get; private set; }
        public VocabularyKey TaxComponent { get; private set; }
        public VocabularyKey TaxPercentage { get; private set; }
        public VocabularyKey Terminal { get; private set; }
        public VocabularyKey TransactionNumber { get; private set; }
        public VocabularyKey RetailChannelTableOMOperatingUnitID { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }


    }
}