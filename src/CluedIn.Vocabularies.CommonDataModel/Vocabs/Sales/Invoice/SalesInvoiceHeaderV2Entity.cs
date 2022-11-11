using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesInvoiceHeaderV2EntityVocabulary : SimpleVocabulary
    {
        public SalesInvoiceHeaderV2EntityVocabulary()
        {
            VocabularyName = "SalesInvoiceHeaderV2Entity";
            KeyPrefix = "commonDataModel.salesinvoiceheaderv2entity";
            KeySeparator = ".";
            Grouping = "/SalesInvoiceHeaderV2Entity";

            AddGroup("SalesInvoiceHeaderV2Entity Details", group =>
            {
                InvoiceNumber = group.Add(new VocabularyKey(nameof(InvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomersOrderReference = group.Add(new VocabularyKey(nameof(CustomersOrderReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryModeCode = group.Add(new VocabularyKey(nameof(DeliveryModeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeliveryTermsCode = group.Add(new VocabularyKey(nameof(DeliveryTermsCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTermsName = group.Add(new VocabularyKey(nameof(PaymentTermsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalInvoiceAmount = group.Add(new VocabularyKey(nameof(TotalInvoiceAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceHeaderTaxAmount = group.Add(new VocabularyKey(nameof(InvoiceHeaderTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalTaxAmount = group.Add(new VocabularyKey(nameof(TotalTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalChargeAmount = group.Add(new VocabularyKey(nameof(TotalChargeAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountCustomerGroupCode = group.Add(new VocabularyKey(nameof(TotalDiscountCustomerGroupCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(InvoiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderNumber = group.Add(new VocabularyKey(nameof(SalesOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressState = group.Add(new VocabularyKey(nameof(InvoiceAddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreet = group.Add(new VocabularyKey(nameof(InvoiceAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressStreetNumber = group.Add(new VocabularyKey(nameof(InvoiceAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressZipCode = group.Add(new VocabularyKey(nameof(InvoiceAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCity = group.Add(new VocabularyKey(nameof(InvoiceAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionId = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(InvoiceAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(SalesOrderResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalDiscountAmount = group.Add(new VocabularyKey(nameof(TotalDiscountAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesOrderOriginCode = group.Add(new VocabularyKey(nameof(SalesOrderOriginCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerVoucher = group.Add(new VocabularyKey(nameof(LedgerVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAddressRecId = group.Add(new VocabularyKey(nameof(InvoiceAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InvoiceNumber { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey CustomersOrderReference { get; private set; }
        public VocabularyKey DeliveryModeCode { get; private set; }
        public VocabularyKey DeliveryTermsCode { get; private set; }
        public VocabularyKey PaymentTermsName { get; private set; }
        public VocabularyKey TotalInvoiceAmount { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey InvoiceHeaderTaxAmount { get; private set; }
        public VocabularyKey TotalTaxAmount { get; private set; }
        public VocabularyKey TotalChargeAmount { get; private set; }
        public VocabularyKey TotalDiscountCustomerGroupCode { get; private set; }
        public VocabularyKey InvoiceCustomerAccountNumber { get; private set; }
        public VocabularyKey SalesOrderNumber { get; private set; }
        public VocabularyKey InvoiceAddressState { get; private set; }
        public VocabularyKey InvoiceAddressStreet { get; private set; }
        public VocabularyKey InvoiceAddressStreetNumber { get; private set; }
        public VocabularyKey InvoiceAddressZipCode { get; private set; }
        public VocabularyKey InvoiceAddressCity { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionId { get; private set; }
        public VocabularyKey InvoiceAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey SalesOrderResponsiblePersonnelNumber { get; private set; }
        public VocabularyKey TotalDiscountAmount { get; private set; }
        public VocabularyKey SalesOrderOriginCode { get; private set; }
        public VocabularyKey LedgerVoucher { get; private set; }
        public VocabularyKey InvoiceAddressRecId { get; private set; }


    }
}