using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailDiscountFiscalTextEntityVocabulary : SimpleVocabulary
    {
        public RetailDiscountFiscalTextEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailDiscountFiscalTextEntity";
            KeyPrefix = "commonDataModel.retaildiscountfiscaltextentity";
            KeySeparator = ".";
            Grouping = "/RetailDiscountFiscalTextEntity";

            AddGroup("Common Data Model RetailDiscountFiscalTextEntity Details", group =>
            {
                Discount = group.Add(new VocabularyKey(nameof(Discount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TextOnFiscalReceipt = group.Add(new VocabularyKey(nameof(TextOnFiscalReceipt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConnectorGroupNumber = group.Add(new VocabularyKey(nameof(ConnectorGroupNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Discount { get; private set; }
        public VocabularyKey TextOnFiscalReceipt { get; private set; }
        public VocabularyKey ConnectorGroupNumber { get; private set; }


    }
}