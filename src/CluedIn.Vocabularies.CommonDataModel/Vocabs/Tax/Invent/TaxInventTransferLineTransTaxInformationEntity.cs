using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxInventTransferLineTransTaxInformationEntityVocabulary : SimpleVocabulary
    {
        public TaxInventTransferLineTransTaxInformationEntityVocabulary()
        {
            VocabularyName = "Tax Invent Transfer Line Trans Tax Information Entity";
            KeyPrefix = "commonDataModel.taxinventtransferlinetranstaxinformationentity";
            KeySeparator = ".";
            Grouping = "/TaxInventTransferLineTransTaxInformationEntity";

            AddGroup("TaxInventTransferLineTransTaxInformationEntity Details", group =>
            {
                LineNum = group.Add(new VocabularyKey(nameof(LineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferId = group.Add(new VocabularyKey(nameof(TransferId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorTaxInformation = group.Add(new VocabularyKey(nameof(VendorTaxInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankLocation = group.Add(new VocabularyKey(nameof(BankLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankTaxInformation = group.Add(new VocabularyKey(nameof(BankTaxInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyLocation = group.Add(new VocabularyKey(nameof(CompanyLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyTaxInformation = group.Add(new VocabularyKey(nameof(CompanyTaxInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CSTSchedule = group.Add(new VocabularyKey(nameof(CSTSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerLocation = group.Add(new VocabularyKey(nameof(CustomerLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerTaxInformation = group.Add(new VocabularyKey(nameof(CustomerTaxInformation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomsIECRegistrationNumber = group.Add(new VocabularyKey(nameof(CustomsIECRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomsTariffCode = group.Add(new VocabularyKey(nameof(CustomsTariffCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomsTariffDirection = group.Add(new VocabularyKey(nameof(CustomsTariffDirection), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Direction = group.Add(new VocabularyKey(nameof(Direction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExciseCENVATCreditAvailed = group.Add(new VocabularyKey(nameof(ExciseCENVATCreditAvailed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExciseConsignment = group.Add(new VocabularyKey(nameof(ExciseConsignment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExciseDirectSettlement = group.Add(new VocabularyKey(nameof(ExciseDirectSettlement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExciseDisposalType = group.Add(new VocabularyKey(nameof(ExciseDisposalType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExciseDSA = group.Add(new VocabularyKey(nameof(ExciseDSA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExciseECCRegistrationNumber = group.Add(new VocabularyKey(nameof(ExciseECCRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExciseIsScrap = group.Add(new VocabularyKey(nameof(ExciseIsScrap), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExciseRecordType = group.Add(new VocabularyKey(nameof(ExciseRecordType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExciseTariffCodes = group.Add(new VocabularyKey(nameof(ExciseTariffCodes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExciseType = group.Add(new VocabularyKey(nameof(ExciseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Exempt = group.Add(new VocabularyKey(nameof(Exempt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GSTINRegistrationNumber = group.Add(new VocabularyKey(nameof(GSTINRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HSNCode = group.Add(new VocabularyKey(nameof(HSNCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InclTax = group.Add(new VocabularyKey(nameof(InclTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ITCCategory = group.Add(new VocabularyKey(nameof(ITCCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NonBusinessUsagePercentage = group.Add(new VocabularyKey(nameof(NonBusinessUsagePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxFormTypes = group.Add(new VocabularyKey(nameof(SalesTaxFormTypes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxRegistrationNumber = group.Add(new VocabularyKey(nameof(SalesTaxRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAccountingCode = group.Add(new VocabularyKey(nameof(ServiceAccountingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceCategory = group.Add(new VocabularyKey(nameof(ServiceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceCode = group.Add(new VocabularyKey(nameof(ServiceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceTaxConsignmentNoteNum = group.Add(new VocabularyKey(nameof(ServiceTaxConsignmentNoteNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceTaxGTAServiceCategory = group.Add(new VocabularyKey(nameof(ServiceTaxGTAServiceCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceTaxIsRecoverable = group.Add(new VocabularyKey(nameof(ServiceTaxIsRecoverable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceTaxRegistrationNumber = group.Add(new VocabularyKey(nameof(ServiceTaxRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TANRegistrationNumber = group.Add(new VocabularyKey(nameof(TANRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxID = group.Add(new VocabularyKey(nameof(TaxID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxInventVATItemId = group.Add(new VocabularyKey(nameof(TaxInventVATItemId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdAcknowledgementNumber = group.Add(new VocabularyKey(nameof(TaxWithholdAcknowledgementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdCountryRegionToRemittance = group.Add(new VocabularyKey(nameof(TaxWithholdCountryRegionToRemittance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdNatureOfAssessee = group.Add(new VocabularyKey(nameof(TaxWithholdNatureOfAssessee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdNatureOfRemittance = group.Add(new VocabularyKey(nameof(TaxWithholdNatureOfRemittance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxWithholdSoftwareDeclReceived = group.Add(new VocabularyKey(nameof(TaxWithholdSoftwareDeclReceived), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATCommodityCode = group.Add(new VocabularyKey(nameof(VATCommodityCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATGoodsType = group.Add(new VocabularyKey(nameof(VATGoodsType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATNonRecoverablePercent = group.Add(new VocabularyKey(nameof(VATNonRecoverablePercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATSchedule = group.Add(new VocabularyKey(nameof(VATSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATTINRegistrationNumber = group.Add(new VocabularyKey(nameof(VATTINRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendorLocation = group.Add(new VocabularyKey(nameof(VendorLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LineNum { get; private set; }
        public VocabularyKey TransferId { get; private set; }
        public VocabularyKey VendorTaxInformation { get; private set; }
        public VocabularyKey BankLocation { get; private set; }
        public VocabularyKey BankTaxInformation { get; private set; }
        public VocabularyKey CompanyLocation { get; private set; }
        public VocabularyKey CompanyTaxInformation { get; private set; }
        public VocabularyKey CSTSchedule { get; private set; }
        public VocabularyKey CustomerLocation { get; private set; }
        public VocabularyKey CustomerTaxInformation { get; private set; }
        public VocabularyKey CustomsIECRegistrationNumber { get; private set; }
        public VocabularyKey CustomsTariffCode { get; private set; }
        public VocabularyKey CustomsTariffDirection { get; private set; }
        public VocabularyKey Direction { get; private set; }
        public VocabularyKey ExciseCENVATCreditAvailed { get; private set; }
        public VocabularyKey ExciseConsignment { get; private set; }
        public VocabularyKey ExciseDirectSettlement { get; private set; }
        public VocabularyKey ExciseDisposalType { get; private set; }
        public VocabularyKey ExciseDSA { get; private set; }
        public VocabularyKey ExciseECCRegistrationNumber { get; private set; }
        public VocabularyKey ExciseIsScrap { get; private set; }
        public VocabularyKey ExciseRecordType { get; private set; }
        public VocabularyKey ExciseTariffCodes { get; private set; }
        public VocabularyKey ExciseType { get; private set; }
        public VocabularyKey Exempt { get; private set; }
        public VocabularyKey GSTINRegistrationNumber { get; private set; }
        public VocabularyKey HSNCode { get; private set; }
        public VocabularyKey InclTax { get; private set; }
        public VocabularyKey ITCCategory { get; private set; }
        public VocabularyKey NonBusinessUsagePercentage { get; private set; }
        public VocabularyKey SalesTaxFormTypes { get; private set; }
        public VocabularyKey SalesTaxRegistrationNumber { get; private set; }
        public VocabularyKey ServiceAccountingCode { get; private set; }
        public VocabularyKey ServiceCategory { get; private set; }
        public VocabularyKey ServiceCode { get; private set; }
        public VocabularyKey ServiceTaxConsignmentNoteNum { get; private set; }
        public VocabularyKey ServiceTaxGTAServiceCategory { get; private set; }
        public VocabularyKey ServiceTaxIsRecoverable { get; private set; }
        public VocabularyKey ServiceTaxRegistrationNumber { get; private set; }
        public VocabularyKey TANRegistrationNumber { get; private set; }
        public VocabularyKey TaxID { get; private set; }
        public VocabularyKey TaxInventVATItemId { get; private set; }
        public VocabularyKey TaxWithholdAcknowledgementNumber { get; private set; }
        public VocabularyKey TaxWithholdCountryRegionToRemittance { get; private set; }
        public VocabularyKey TaxWithholdNatureOfAssessee { get; private set; }
        public VocabularyKey TaxWithholdNatureOfRemittance { get; private set; }
        public VocabularyKey TaxWithholdSoftwareDeclReceived { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey VATCommodityCode { get; private set; }
        public VocabularyKey VATGoodsType { get; private set; }
        public VocabularyKey VATNonRecoverablePercent { get; private set; }
        public VocabularyKey VATSchedule { get; private set; }
        public VocabularyKey VATTINRegistrationNumber { get; private set; }
        public VocabularyKey VendorLocation { get; private set; }
    }
}