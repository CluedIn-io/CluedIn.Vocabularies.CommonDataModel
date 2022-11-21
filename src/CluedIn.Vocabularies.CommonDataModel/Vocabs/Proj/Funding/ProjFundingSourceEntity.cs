using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjFundingSourceEntityVocabulary : SimpleVocabulary
    {
        public ProjFundingSourceEntityVocabulary()
        {
            VocabularyName = "Proj Funding Source Entity";
            KeyPrefix = "commonDataModel.projfundingsourceentity";
            KeySeparator = ".";
            Grouping = "/ProjFundingSourceEntity";

            AddGroup("ProjFundingSourceEntity Details", group =>
            {
                CashDiscount = group.Add(new VocabularyKey(nameof(CashDiscount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactID = group.Add(new VocabularyKey(nameof(ContactID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerOrOrganization = group.Add(new VocabularyKey(nameof(CustomerOrOrganization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerRequisition = group.Add(new VocabularyKey(nameof(CustomerRequisition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerReference = group.Add(new VocabularyKey(nameof(CustomerReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAccount = group.Add(new VocabularyKey(nameof(DimensionAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EInvoiceLineSpec = group.Add(new VocabularyKey(nameof(EInvoiceLineSpec), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundingSourceId = group.Add(new VocabularyKey(nameof(FundingSourceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FundingType = group.Add(new VocabularyKey(nameof(FundingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssociatedPaymentAttachmentOnTheProjectInvoice = group.Add(new VocabularyKey(nameof(AssociatedPaymentAttachmentOnTheProjectInvoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IndividualBufferDays = group.Add(new VocabularyKey(nameof(IndividualBufferDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceName = group.Add(new VocabularyKey(nameof(InvoiceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Language = group.Add(new VocabularyKey(nameof(Language), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberSequenceGroup = group.Add(new VocabularyKey(nameof(NumberSequenceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentSchedule = group.Add(new VocabularyKey(nameof(PaymentSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingProfile = group.Add(new VocabularyKey(nameof(PostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectGrant = group.Add(new VocabularyKey(nameof(ProjectGrant), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerPaymentRetentionTerms = group.Add(new VocabularyKey(nameof(CustomerPaymentRetentionTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceFormat = group.Add(new VocabularyKey(nameof(InvoiceFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VATReportDateCode = group.Add(new VocabularyKey(nameof(VATReportDateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrantId = group.Add(new VocabularyKey(nameof(GrantId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RetentionTermId = group.Add(new VocabularyKey(nameof(RetentionTermId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountry = group.Add(new VocabularyKey(nameof(AddressCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryISOCode = group.Add(new VocabularyKey(nameof(AddressCountryISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistrictName = group.Add(new VocabularyKey(nameof(AddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceLocationId = group.Add(new VocabularyKey(nameof(InvoiceLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceLocation = group.Add(new VocabularyKey(nameof(InvoiceLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreateDefaultFundingRule = group.Add(new VocabularyKey(nameof(CreateDefaultFundingRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryFundingSource = group.Add(new VocabularyKey(nameof(IsPrimaryFundingSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CashDiscount { get; private set; }
        public VocabularyKey ContactID { get; private set; }
        public VocabularyKey ProjectContractID { get; private set; }
        public VocabularyKey CustomerOrOrganization { get; private set; }
        public VocabularyKey CustomerRequisition { get; private set; }
        public VocabularyKey CustomerReference { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey DimensionAccount { get; private set; }
        public VocabularyKey EInvoiceLineSpec { get; private set; }
        public VocabularyKey FundingSourceId { get; private set; }
        public VocabularyKey FundingType { get; private set; }
        public VocabularyKey AssociatedPaymentAttachmentOnTheProjectInvoice { get; private set; }
        public VocabularyKey IndividualBufferDays { get; private set; }
        public VocabularyKey InvoiceName { get; private set; }
        public VocabularyKey Language { get; private set; }
        public VocabularyKey NumberSequenceGroup { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PaymentSchedule { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey PostingProfile { get; private set; }
        public VocabularyKey ProjectGrant { get; private set; }
        public VocabularyKey CustomerPaymentRetentionTerms { get; private set; }
        public VocabularyKey InvoiceFormat { get; private set; }
        public VocabularyKey VATReportDateCode { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey GrantId { get; private set; }
        public VocabularyKey RetentionTermId { get; private set; }
        public VocabularyKey DimensionDisplayValue { get; private set; }
        public VocabularyKey AddressTimeZone { get; private set; }
        public VocabularyKey AddressDescription { get; private set; }
        public VocabularyKey AddressCountry { get; private set; }
        public VocabularyKey AddressCountryISOCode { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey AddressCounty { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressDistrictName { get; private set; }
        public VocabularyKey AddressLatitude { get; private set; }
        public VocabularyKey AddressLongitude { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey InvoiceLocationId { get; private set; }
        public VocabularyKey InvoiceLocation { get; private set; }
        public VocabularyKey CreateDefaultFundingRule { get; private set; }
        public VocabularyKey IsPrimaryFundingSource { get; private set; }
    }
}