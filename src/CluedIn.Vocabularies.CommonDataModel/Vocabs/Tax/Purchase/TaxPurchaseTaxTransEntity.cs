using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxPurchaseTaxTransEntityVocabulary : SimpleVocabulary
    {
        public TaxPurchaseTaxTransEntityVocabulary()
        {
            VocabularyName = "Tax Purchase Tax Trans Entity";
            KeyPrefix = "commonDataModel.taxpurchasetaxtransentity";
            KeySeparator = ".";
            Grouping = "/TaxPurchaseTaxTransEntity";

            AddGroup("TaxPurchaseTaxTransEntity Details", group =>
            {
                Base = group.Add(new VocabularyKey(nameof(Base), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingDate = group.Add(new VocabularyKey(nameof(ReportingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingVoucher = group.Add(new VocabularyKey(nameof(ReportingVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reversed = group.Add(new VocabularyKey(nameof(Reversed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Duty = group.Add(new VocabularyKey(nameof(Duty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxCode = group.Add(new VocabularyKey(nameof(SalesTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SettlementPeriod = group.Add(new VocabularyKey(nameof(SettlementPeriod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseDuty = group.Add(new VocabularyKey(nameof(PurchaseDuty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TraceNumber = group.Add(new VocabularyKey(nameof(TraceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Percent = group.Add(new VocabularyKey(nameof(Percent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransID = group.Add(new VocabularyKey(nameof(TransID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxPurchaseTaxTransRecId = group.Add(new VocabularyKey(nameof(TaxPurchaseTaxTransRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Base { get; private set; }
        public VocabularyKey ReportingDate { get; private set; }
        public VocabularyKey ReportingVoucher { get; private set; }
        public VocabularyKey Reversed { get; private set; }
        public VocabularyKey Duty { get; private set; }
        public VocabularyKey SalesTaxCode { get; private set; }
        public VocabularyKey SettlementPeriod { get; private set; }
        public VocabularyKey PurchaseDuty { get; private set; }
        public VocabularyKey TraceNumber { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey Percent { get; private set; }
        public VocabularyKey TransID { get; private set; }
        public VocabularyKey TaxPurchaseTaxTransRecId { get; private set; }
    }
}