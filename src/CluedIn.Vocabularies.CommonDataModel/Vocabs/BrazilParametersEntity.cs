using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BrazilParametersEntityVocabulary : SimpleVocabulary
    {
        public BrazilParametersEntityVocabulary()
        {
            VocabularyName = "Brazil Parameters Entity";
            KeyPrefix = "commonDataModel.brazilparametersentity";
            KeySeparator = ".";
            Grouping = "/BrazilParametersEntity";

            AddGroup("BrazilParametersEntity Details", group =>
            {
                ApproximateTaxesPrintOnlyFinalUser = group.Add(new VocabularyKey(nameof(ApproximateTaxesPrintOnlyFinalUser), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproximateTaxesSource = group.Add(new VocabularyKey(nameof(ApproximateTaxesSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproximateTaxesText = group.Add(new VocabularyKey(nameof(ApproximateTaxesText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BasicTaxValueForCOFINSInCumulativeRegimen = group.Add(new VocabularyKey(nameof(BasicTaxValueForCOFINSInCumulativeRegimen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BasicTaxValueForCOFINSInNonCumulativeRegimen = group.Add(new VocabularyKey(nameof(BasicTaxValueForCOFINSInNonCumulativeRegimen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BasicTaxValueForPISInCumulativeRegimen = group.Add(new VocabularyKey(nameof(BasicTaxValueForPISInCumulativeRegimen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BasicTaxValueForPISInNonCumulativeRegimen = group.Add(new VocabularyKey(nameof(BasicTaxValueForPISInNonCumulativeRegimen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentEnableFixIssueDate = group.Add(new VocabularyKey(nameof(FiscalDocumentEnableFixIssueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxComplementaryFiscalDocumentSalesTaxCodeForCOFINS = group.Add(new VocabularyKey(nameof(TaxComplementaryFiscalDocumentSalesTaxCodeForCOFINS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxComplementaryFiscalDocumentSalesTaxCodeForPIS = group.Add(new VocabularyKey(nameof(TaxComplementaryFiscalDocumentSalesTaxCodeForPIS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ComplementaryFiscalDocumentSourceText = group.Add(new VocabularyKey(nameof(ComplementaryFiscalDocumentSourceText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialDimensionForCostCenterRecId = group.Add(new VocabularyKey(nameof(FinancialDimensionForCostCenterRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EnableCFPSCode = group.Add(new VocabularyKey(nameof(EnableCFPSCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerIntegrationStatus = group.Add(new VocabularyKey(nameof(LedgerIntegrationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FCIText = group.Add(new VocabularyKey(nameof(FCIText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxFiscalDocumentItem = group.Add(new VocabularyKey(nameof(TaxFiscalDocumentItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTextDocumentType = group.Add(new VocabularyKey(nameof(FiscalDocumentTextDocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialDimensionForFiscalEstablishmentRecId = group.Add(new VocabularyKey(nameof(FinancialDimensionForFiscalEstablishmentRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreeTextInvoiceItem = group.Add(new VocabularyKey(nameof(FreeTextInvoiceItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreeTextInvoiceServiceItem = group.Add(new VocabularyKey(nameof(FreeTextInvoiceServiceItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportDeclarationText = group.Add(new VocabularyKey(nameof(ImportDeclarationText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportDeclarationLineAmountIsBasedOn = group.Add(new VocabularyKey(nameof(ImportDeclarationLineAmountIsBasedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GoodsToConsumeProductType = group.Add(new VocabularyKey(nameof(GoodsToConsumeProductType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferencedFiscalDocumentModel02SalesTaxCodeForCOFINS = group.Add(new VocabularyKey(nameof(ReferencedFiscalDocumentModel02SalesTaxCodeForCOFINS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferencedFiscalDocumentModel02SalesTaxCodeForICMS = group.Add(new VocabularyKey(nameof(ReferencedFiscalDocumentModel02SalesTaxCodeForICMS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferencedFiscalDocumentModel02SalesTaxCodeForPIS = group.Add(new VocabularyKey(nameof(ReferencedFiscalDocumentModel02SalesTaxCodeForPIS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectFiscalDocumentUnit = group.Add(new VocabularyKey(nameof(ProjectFiscalDocumentUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePrimaryMethodOfPaymentDescription = group.Add(new VocabularyKey(nameof(PurchasePrimaryMethodOfPaymentDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchasePrimaryMethodOfPayment = group.Add(new VocabularyKey(nameof(PurchasePrimaryMethodOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestForQuotationOperationTypeRecId = group.Add(new VocabularyKey(nameof(RequestForQuotationOperationTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRequisitionOperationTypeRecId = group.Add(new VocabularyKey(nameof(PurchaseRequisitionOperationTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrimaryMethodOfPaymentDescription = group.Add(new VocabularyKey(nameof(SalesPrimaryMethodOfPaymentDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesPrimaryMethodOfPayment = group.Add(new VocabularyKey(nameof(SalesPrimaryMethodOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SuframaTextForIssueFiscalDocument = group.Add(new VocabularyKey(nameof(SuframaTextForIssueFiscalDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxFiscalDocumentsSalesTaxCodeForCOFINS = group.Add(new VocabularyKey(nameof(TaxFiscalDocumentsSalesTaxCodeForCOFINS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxFiscalDocumentsSalesTaxCodeForPIS = group.Add(new VocabularyKey(nameof(TaxFiscalDocumentsSalesTaxCodeForPIS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentTextForWithholdingTax = group.Add(new VocabularyKey(nameof(FiscalDocumentTextForWithholdingTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VolumeQuantity = group.Add(new VocabularyKey(nameof(VolumeQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VolumeType = group.Add(new VocabularyKey(nameof(VolumeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ICMSTaxationCodeOverridesICMSST = group.Add(new VocabularyKey(nameof(ICMSTaxationCodeOverridesICMSST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurchaseRequisitionOperationType = group.Add(new VocabularyKey(nameof(PurchaseRequisitionOperationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequestForQuotationOperationType = group.Add(new VocabularyKey(nameof(RequestForQuotationOperationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialDimensionForCostCenter = group.Add(new VocabularyKey(nameof(FinancialDimensionForCostCenter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FinancialDimensionForFiscalEstablishment = group.Add(new VocabularyKey(nameof(FinancialDimensionForFiscalEstablishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetailApproximateTaxValueTextId = group.Add(new VocabularyKey(nameof(RetailApproximateTaxValueTextId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ApproximateTaxesPrintOnlyFinalUser { get; private set; }
        public VocabularyKey ApproximateTaxesSource { get; private set; }
        public VocabularyKey ApproximateTaxesText { get; private set; }
        public VocabularyKey BasicTaxValueForCOFINSInCumulativeRegimen { get; private set; }
        public VocabularyKey BasicTaxValueForCOFINSInNonCumulativeRegimen { get; private set; }
        public VocabularyKey BasicTaxValueForPISInCumulativeRegimen { get; private set; }
        public VocabularyKey BasicTaxValueForPISInNonCumulativeRegimen { get; private set; }
        public VocabularyKey FiscalDocumentEnableFixIssueDate { get; private set; }
        public VocabularyKey TaxComplementaryFiscalDocumentSalesTaxCodeForCOFINS { get; private set; }
        public VocabularyKey TaxComplementaryFiscalDocumentSalesTaxCodeForPIS { get; private set; }
        public VocabularyKey ComplementaryFiscalDocumentSourceText { get; private set; }
        public VocabularyKey FinancialDimensionForCostCenterRecId { get; private set; }
        public VocabularyKey EnableCFPSCode { get; private set; }
        public VocabularyKey LedgerIntegrationStatus { get; private set; }
        public VocabularyKey FCIText { get; private set; }
        public VocabularyKey TaxFiscalDocumentItem { get; private set; }
        public VocabularyKey FiscalDocumentTextDocumentType { get; private set; }
        public VocabularyKey FinancialDimensionForFiscalEstablishmentRecId { get; private set; }
        public VocabularyKey FreeTextInvoiceItem { get; private set; }
        public VocabularyKey FreeTextInvoiceServiceItem { get; private set; }
        public VocabularyKey ImportDeclarationText { get; private set; }
        public VocabularyKey ImportDeclarationLineAmountIsBasedOn { get; private set; }
        public VocabularyKey GoodsToConsumeProductType { get; private set; }
        public VocabularyKey ReferencedFiscalDocumentModel02SalesTaxCodeForCOFINS { get; private set; }
        public VocabularyKey ReferencedFiscalDocumentModel02SalesTaxCodeForICMS { get; private set; }
        public VocabularyKey ReferencedFiscalDocumentModel02SalesTaxCodeForPIS { get; private set; }
        public VocabularyKey ProjectFiscalDocumentUnit { get; private set; }
        public VocabularyKey PurchasePrimaryMethodOfPaymentDescription { get; private set; }
        public VocabularyKey PurchasePrimaryMethodOfPayment { get; private set; }
        public VocabularyKey RequestForQuotationOperationTypeRecId { get; private set; }
        public VocabularyKey PurchaseRequisitionOperationTypeRecId { get; private set; }
        public VocabularyKey SalesPrimaryMethodOfPaymentDescription { get; private set; }
        public VocabularyKey SalesPrimaryMethodOfPayment { get; private set; }
        public VocabularyKey SuframaTextForIssueFiscalDocument { get; private set; }
        public VocabularyKey TaxFiscalDocumentsSalesTaxCodeForCOFINS { get; private set; }
        public VocabularyKey TaxFiscalDocumentsSalesTaxCodeForPIS { get; private set; }
        public VocabularyKey FiscalDocumentTextForWithholdingTax { get; private set; }
        public VocabularyKey VolumeQuantity { get; private set; }
        public VocabularyKey VolumeType { get; private set; }
        public VocabularyKey ICMSTaxationCodeOverridesICMSST { get; private set; }
        public VocabularyKey PurchaseRequisitionOperationType { get; private set; }
        public VocabularyKey RequestForQuotationOperationType { get; private set; }
        public VocabularyKey FinancialDimensionForCostCenter { get; private set; }
        public VocabularyKey FinancialDimensionForFiscalEstablishment { get; private set; }
        public VocabularyKey RetailApproximateTaxValueTextId { get; private set; }
    }
}