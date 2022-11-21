using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TAMTradeAllowanceAgreementMerchandisingEventBillBackLineEntityVocabulary : SimpleVocabulary
    {
        public TAMTradeAllowanceAgreementMerchandisingEventBillBackLineEntityVocabulary()
        {
            VocabularyName = "TAM Trade Allowance Agreement Merchandising Event Bill Back Line Entity";
            KeyPrefix = "commonDataModel.tamtradeallowanceagreementmerchandisingeventbillbacklineentity";
            KeySeparator = ".";
            Grouping = "/TAMTradeAllowanceAgreementMerchandisingEventBillBackLineEntity";

            AddGroup("TAMTradeAllowanceAgreementMerchandisingEventBillBackLineEntity Details", group =>
            {
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RebateAgreementRefRecId = group.Add(new VocabularyKey(nameof(RebateAgreementRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillBackAmountType = group.Add(new VocabularyKey(nameof(BillBackAmountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromBillBackQuantity = group.Add(new VocabularyKey(nameof(FromBillBackQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToBillBackQuantity = group.Add(new VocabularyKey(nameof(ToBillBackQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillBackQuantityUnitSymbol = group.Add(new VocabularyKey(nameof(BillBackQuantityUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillBackAmount = group.Add(new VocabularyKey(nameof(BillBackAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAllowanceAgreementMerchandisingEventBillBackId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementMerchandisingEventBillBackId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillBackAmountCurrencyCode = group.Add(new VocabularyKey(nameof(BillBackAmountCurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAllowanceAgreementId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccountNumber = group.Add(new VocabularyKey(nameof(CustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TradeAllowanceAgreementMerchandisingEventId = group.Add(new VocabularyKey(nameof(TradeAllowanceAgreementMerchandisingEventId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey RebateAgreementRefRecId { get; private set; }
        public VocabularyKey BillBackAmountType { get; private set; }
        public VocabularyKey FromBillBackQuantity { get; private set; }
        public VocabularyKey ToBillBackQuantity { get; private set; }
        public VocabularyKey BillBackQuantityUnitSymbol { get; private set; }
        public VocabularyKey BillBackAmount { get; private set; }
        public VocabularyKey TradeAllowanceAgreementMerchandisingEventBillBackId { get; private set; }
        public VocabularyKey BillBackAmountCurrencyCode { get; private set; }
        public VocabularyKey TradeAllowanceAgreementId { get; private set; }
        public VocabularyKey CustomerAccountNumber { get; private set; }
        public VocabularyKey TradeAllowanceAgreementMerchandisingEventId { get; private set; }
    }
}