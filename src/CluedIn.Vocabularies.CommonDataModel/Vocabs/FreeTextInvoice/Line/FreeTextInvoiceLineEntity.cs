using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FreeTextInvoiceLineEntityVocabulary : SimpleVocabulary
    {
        public FreeTextInvoiceLineEntityVocabulary()
        {
            VocabularyName = "Free Text Invoice Line Entity";
            KeyPrefix = "commonDataModel.freetextinvoicelineentity";
            KeySeparator = ".";
            Grouping = "/FreeTextInvoiceLineEntity";

            AddGroup("FreeTextInvoiceLineEntity Details", group =>
            {
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCurrencyAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountDetails = group.Add(new VocabularyKey(nameof(AmountDetails), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValueModel = group.Add(new VocabularyKey(nameof(ValueModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FixedAssetNumber = group.Add(new VocabularyKey(nameof(FixedAssetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingCode = group.Add(new VocabularyKey(nameof(BillingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CorrectedInvoiceLineId = group.Add(new VocabularyKey(nameof(CorrectedInvoiceLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BillingCodeReferenceId = group.Add(new VocabularyKey(nameof(BillingCodeReferenceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimension = group.Add(new VocabularyKey(nameof(DefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceText = group.Add(new VocabularyKey(nameof(InvoiceText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateOfOrigin = group.Add(new VocabularyKey(nameof(StateOfOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentRecId = group.Add(new VocabularyKey(nameof(ParentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundingSourceId = group.Add(new VocabularyKey(nameof(FundingSourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectID = group.Add(new VocabularyKey(nameof(ProjectID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionID = group.Add(new VocabularyKey(nameof(TransactionID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PropertyNumber = group.Add(new VocabularyKey(nameof(PropertyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonTableReference = group.Add(new VocabularyKey(nameof(ReasonTableReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxAmount = group.Add(new VocabularyKey(nameof(SalesTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxGroupId = group.Add(new VocabularyKey(nameof(SalesTaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxItemGroupId = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WithholdingTaxGroup = group.Add(new VocabularyKey(nameof(WithholdingTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintCode = group.Add(new VocabularyKey(nameof(PrintCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionCode = group.Add(new VocabularyKey(nameof(TransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitPrice = group.Add(new VocabularyKey(nameof(UnitPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalWeight = group.Add(new VocabularyKey(nameof(TotalWeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(DefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NGPCode = group.Add(new VocabularyKey(nameof(NGPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EInvoiceAccountCode = group.Add(new VocabularyKey(nameof(EInvoiceAccountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NGPCodeRecId = group.Add(new VocabularyKey(nameof(NGPCodeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPCode = group.Add(new VocabularyKey(nameof(CFOPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CFOPTableRecId = group.Add(new VocabularyKey(nameof(CFOPTableRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsServiceInvoice = group.Add(new VocabularyKey(nameof(IsServiceInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalInformationServiceCode = group.Add(new VocabularyKey(nameof(FiscalInformationServiceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExternalInvoiceId = group.Add(new VocabularyKey(nameof(ExternalInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssetId = group.Add(new VocabularyKey(nameof(AssetId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryName = group.Add(new VocabularyKey(nameof(CountryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceGTD = group.Add(new VocabularyKey(nameof(InvoiceGTD), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesUnit = group.Add(new VocabularyKey(nameof(SalesUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey TransactionCurrencyAmount { get; private set; }
        public VocabularyKey AmountDetails { get; private set; }
        public VocabularyKey ValueModel { get; private set; }
        public VocabularyKey FixedAssetNumber { get; private set; }
        public VocabularyKey BillingCode { get; private set; }
        public VocabularyKey CorrectedInvoiceLineId { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey BillingCodeReferenceId { get; private set; }
        public VocabularyKey DefaultDimension { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey InvoiceText { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey StateOfOrigin { get; private set; }
        public VocabularyKey ParentRecId { get; private set; }
        public VocabularyKey CategoryId { get; private set; }
        public VocabularyKey FundingSourceId { get; private set; }
        public VocabularyKey ProjectID { get; private set; }
        public VocabularyKey TransactionID { get; private set; }
        public VocabularyKey PropertyNumber { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey ReasonTableReference { get; private set; }
        public VocabularyKey SalesTaxAmount { get; private set; }
        public VocabularyKey SalesTaxGroupId { get; private set; }
        public VocabularyKey SalesTaxItemGroupId { get; private set; }
        public VocabularyKey WithholdingTaxGroup { get; private set; }
        public VocabularyKey PrintCode { get; private set; }
        public VocabularyKey TransactionCode { get; private set; }
        public VocabularyKey UnitPrice { get; private set; }
        public VocabularyKey TotalWeight { get; private set; }
        public VocabularyKey DefaultDimensionDisplayValue { get; private set; }
        public VocabularyKey MainAccountDisplayValue { get; private set; }
        public VocabularyKey NGPCode { get; private set; }
        public VocabularyKey EInvoiceAccountCode { get; private set; }
        public VocabularyKey NGPCodeRecId { get; private set; }
        public VocabularyKey CFOPCode { get; private set; }
        public VocabularyKey CFOPTableRecId { get; private set; }
        public VocabularyKey IsServiceInvoice { get; private set; }
        public VocabularyKey FiscalInformationServiceCode { get; private set; }
        public VocabularyKey ExternalInvoiceId { get; private set; }
        public VocabularyKey AssetId { get; private set; }
        public VocabularyKey CountryName { get; private set; }
        public VocabularyKey InvoiceGTD { get; private set; }
        public VocabularyKey SalesUnit { get; private set; }
    }
}