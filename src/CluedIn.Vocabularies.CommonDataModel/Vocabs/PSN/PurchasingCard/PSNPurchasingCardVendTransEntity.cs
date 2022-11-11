using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PSNPurchasingCardVendTransEntityVocabulary : SimpleVocabulary
    {
        public PSNPurchasingCardVendTransEntityVocabulary()
        {
            VocabularyName = "PSNPurchasingCardVendTransEntity";
            KeyPrefix = "commonDataModel.psnpurchasingcardvendtransentity";
            KeySeparator = ".";
            Grouping = "/PSNPurchasingCardVendTransEntity";

            AddGroup("PSNPurchasingCardVendTransEntity Details", group =>
            {
                BankAccountId = group.Add(new VocabularyKey(nameof(BankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardHolderName = group.Add(new VocabularyKey(nameof(CardHolderName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingCardInvoice = group.Add(new VocabularyKey(nameof(PurchasingCardInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CardReferenceNumber = group.Add(new VocabularyKey(nameof(CardReferenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasingCardServiceProvider = group.Add(new VocabularyKey(nameof(PurchasingCardServiceProvider), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendTransRecId = group.Add(new VocabularyKey(nameof(VendTransRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BankAccountId { get; private set; }
        public VocabularyKey CardHolderName { get; private set; }
        public VocabularyKey PurchasingCardInvoice { get; private set; }
        public VocabularyKey CardReferenceNumber { get; private set; }
        public VocabularyKey PurchasingCardServiceProvider { get; private set; }
        public VocabularyKey VendTransRecId { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey Voucher { get; private set; }


    }
}