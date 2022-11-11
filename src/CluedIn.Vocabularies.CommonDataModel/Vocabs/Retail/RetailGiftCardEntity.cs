using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailGiftCardEntityVocabulary : SimpleVocabulary
    {
        public RetailGiftCardEntityVocabulary()
        {
            VocabularyName = "RetailGiftCardEntity";
            KeyPrefix = "commonDataModel.retailgiftcardentity";
            KeySeparator = ".";
            Grouping = "/RetailGiftCardEntity";

            AddGroup("RetailGiftCardEntity Details", group =>
            {
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntryId = group.Add(new VocabularyKey(nameof(EntryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CallCenterGiftCardType = group.Add(new VocabularyKey(nameof(CallCenterGiftCardType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ActiveFrom = group.Add(new VocabularyKey(nameof(ActiveFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpiryDate = group.Add(new VocabularyKey(nameof(ExpiryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FaceValue = group.Add(new VocabularyKey(nameof(FaceValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumBalanceInAccountingCurrency = group.Add(new VocabularyKey(nameof(MaximumBalanceInAccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimumReloadInAccountingCurrency = group.Add(new VocabularyKey(nameof(MinimumReloadInAccountingCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonReloadable = group.Add(new VocabularyKey(nameof(NonReloadable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OneTimeRedemption = group.Add(new VocabularyKey(nameof(OneTimeRedemption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReserved = group.Add(new VocabularyKey(nameof(IsReserved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReservedByRetailChannel = group.Add(new VocabularyKey(nameof(ReservedByRetailChannel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReservedByRetailTerminal = group.Add(new VocabularyKey(nameof(ReservedByRetailTerminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReservedByTransactionId = group.Add(new VocabularyKey(nameof(ReservedByTransactionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey EntryId { get; private set; }
        public VocabularyKey CallCenterGiftCardType { get; private set; }
        public VocabularyKey ActiveFrom { get; private set; }
        public VocabularyKey ExpiryDate { get; private set; }
        public VocabularyKey FaceValue { get; private set; }
        public VocabularyKey MaximumBalanceInAccountingCurrency { get; private set; }
        public VocabularyKey MinimumReloadInAccountingCurrency { get; private set; }
        public VocabularyKey NonReloadable { get; private set; }
        public VocabularyKey OneTimeRedemption { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey IsReserved { get; private set; }
        public VocabularyKey ReservedByRetailChannel { get; private set; }
        public VocabularyKey ReservedByRetailTerminal { get; private set; }
        public VocabularyKey ReservedByTransactionId { get; private set; }


    }
}