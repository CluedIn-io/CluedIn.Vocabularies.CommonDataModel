using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFMSalesAgreementPaymentOrderEntityVocabulary : SimpleVocabulary
    {
        public CFMSalesAgreementPaymentOrderEntityVocabulary()
        {
            VocabularyName = "Common Data Model CFMSalesAgreementPaymentOrderEntity";
            KeyPrefix = "commonDataModel.cfmsalesagreementpaymentorderentity";
            KeySeparator = ".";
            Grouping = "/CFMSalesAgreementPaymentOrderEntity";

            AddGroup("Common Data Model CFMSalesAgreementPaymentOrderEntity Details", group =>
            {
                PurposeText = group.Add(new VocabularyKey(nameof(PurposeText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginPayment = group.Add(new VocabularyKey(nameof(OriginPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BudgetRevenueCode = group.Add(new VocabularyKey(nameof(BudgetRevenueCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrderOfPayment = group.Add(new VocabularyKey(nameof(OrderOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodCode = group.Add(new VocabularyKey(nameof(PeriodCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodNumber = group.Add(new VocabularyKey(nameof(PeriodNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RRCPrinting = group.Add(new VocabularyKey(nameof(RRCPrinting), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RCOAD = group.Add(new VocabularyKey(nameof(RCOAD), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberStatus = group.Add(new VocabularyKey(nameof(NumberStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PeriodDate = group.Add(new VocabularyKey(nameof(PeriodDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentType = group.Add(new VocabularyKey(nameof(PaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UCI = group.Add(new VocabularyKey(nameof(UCI), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesAgreement = group.Add(new VocabularyKey(nameof(SalesAgreement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PurposeText { get; private set; }
        public VocabularyKey OriginPayment { get; private set; }
        public VocabularyKey BudgetRevenueCode { get; private set; }
        public VocabularyKey DocumentDate { get; private set; }
        public VocabularyKey DocumentNumber { get; private set; }
        public VocabularyKey OrderOfPayment { get; private set; }
        public VocabularyKey PeriodCode { get; private set; }
        public VocabularyKey PeriodNumber { get; private set; }
        public VocabularyKey RRCPrinting { get; private set; }
        public VocabularyKey RCOAD { get; private set; }
        public VocabularyKey NumberStatus { get; private set; }
        public VocabularyKey PeriodDate { get; private set; }
        public VocabularyKey PaymentType { get; private set; }
        public VocabularyKey UCI { get; private set; }
        public VocabularyKey SalesAgreement { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }


    }
}