using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalDocumentLineEntityVocabulary : SimpleVocabulary
    {
        public FiscalDocumentLineEntityVocabulary()
        {
            VocabularyName = "Fiscal Document Line Entity";
            KeyPrefix = "commonDataModel.fiscaldocumentlineentity";
            KeySeparator = ".";
            Grouping = "/FiscalDocumentLineEntity";

            AddGroup("FiscalDocumentLineEntity Details", group =>
            {
                AccountingAmount = group.Add(new VocabularyKey(nameof(AccountingAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Addition = group.Add(new VocabularyKey(nameof(Addition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproximateTaxAmount = group.Add(new VocabularyKey(nameof(ApproximateTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CEST = group.Add(new VocabularyKey(nameof(CEST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOP = group.Add(new VocabularyKey(nameof(CFOP), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExceptionCode = group.Add(new VocabularyKey(nameof(ExceptionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FCINumber = group.Add(new VocabularyKey(nameof(FCINumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalClassificationCode = group.Add(new VocabularyKey(nameof(FiscalClassificationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocument = group.Add(new VocabularyKey(nameof(FiscalDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentDirection = group.Add(new VocabularyKey(nameof(FiscalDocumentDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentFiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalDocumentFiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentNumber = group.Add(new VocabularyKey(nameof(FiscalDocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentSeries = group.Add(new VocabularyKey(nameof(FiscalDocumentSeries), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentStatus = group.Add(new VocabularyKey(nameof(FiscalDocumentStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentThirdPartyCNPJorCPF = group.Add(new VocabularyKey(nameof(FiscalDocumentThirdPartyCNPJorCPF), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentVoucher = group.Add(new VocabularyKey(nameof(FiscalDocumentVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightNature = group.Add(new VocabularyKey(nameof(FreightNature), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossWeight = group.Add(new VocabularyKey(nameof(GrossWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemType = group.Add(new VocabularyKey(nameof(ItemType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineDiscount = group.Add(new VocabularyKey(nameof(LineDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NetWeight = group.Add(new VocabularyKey(nameof(NetWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceCode = group.Add(new VocabularyKey(nameof(ServiceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SUFRAMACOFINSDiscount = group.Add(new VocabularyKey(nameof(SUFRAMACOFINSDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SUFRAMAICMSDiscount = group.Add(new VocabularyKey(nameof(SUFRAMAICMSDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SUFRAMAPISDiscount = group.Add(new VocabularyKey(nameof(SUFRAMAPISDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationOrigin = group.Add(new VocabularyKey(nameof(TaxationOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Unit = group.Add(new VocabularyKey(nameof(Unit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountingAmount { get; private set; }
        public VocabularyKey Addition { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey ApproximateTaxAmount { get; private set; }
        public VocabularyKey CEST { get; private set; }
        public VocabularyKey CFOP { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExceptionCode { get; private set; }
        public VocabularyKey FixedAssetNumber { get; private set; }
        public VocabularyKey FCINumber { get; private set; }
        public VocabularyKey FiscalClassificationCode { get; private set; }
        public VocabularyKey FiscalDocument { get; private set; }
        public VocabularyKey FiscalDocumentDirection { get; private set; }
        public VocabularyKey FiscalDocumentFiscalEstablishmentId { get; private set; }
        public VocabularyKey FiscalDocumentNumber { get; private set; }
        public VocabularyKey FiscalDocumentSeries { get; private set; }
        public VocabularyKey FiscalDocumentStatus { get; private set; }
        public VocabularyKey FiscalDocumentThirdPartyCNPJorCPF { get; private set; }
        public VocabularyKey FiscalDocumentVoucher { get; private set; }
        public VocabularyKey FreightNature { get; private set; }
        public VocabularyKey GrossWeight { get; private set; }
        public VocabularyKey ItemNumber { get; private set; }
        public VocabularyKey ItemType { get; private set; }
        public VocabularyKey LineDiscount { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey NetWeight { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey ServiceCode { get; private set; }
        public VocabularyKey SUFRAMACOFINSDiscount { get; private set; }
        public VocabularyKey SUFRAMAICMSDiscount { get; private set; }
        public VocabularyKey SUFRAMAPISDiscount { get; private set; }
        public VocabularyKey TaxationOrigin { get; private set; }
        public VocabularyKey Unit { get; private set; }
        public VocabularyKey UnitPrice { get; private set; }
    }
}