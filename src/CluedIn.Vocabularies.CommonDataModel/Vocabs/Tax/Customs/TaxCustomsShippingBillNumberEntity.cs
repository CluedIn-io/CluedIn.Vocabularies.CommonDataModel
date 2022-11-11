using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxCustomsShippingBillNumberEntityVocabulary : SimpleVocabulary
    {
        public TaxCustomsShippingBillNumberEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxCustomsShippingBillNumberEntity";
            KeyPrefix = "commonDataModel.taxcustomsshippingbillnumberentity";
            KeySeparator = ".";
            Grouping = "/TaxCustomsShippingBillNumberEntity";

            AddGroup("Common Data Model TaxCustomsShippingBillNumberEntity Details", group =>
            {
                Closed = group.Add(new VocabularyKey(nameof(Closed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShippingBill = group.Add(new VocabularyKey(nameof(ShippingBill), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Closed { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey ShippingBill { get; private set; }


    }
}