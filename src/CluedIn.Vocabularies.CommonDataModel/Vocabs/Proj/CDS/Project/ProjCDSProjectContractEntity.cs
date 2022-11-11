using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjCDSProjectContractEntityVocabulary : SimpleVocabulary
    {
        public ProjCDSProjectContractEntityVocabulary()
        {
            VocabularyName = "ProjCDSProjectContractEntity";
            KeyPrefix = "commonDataModel.projcdsprojectcontractentity";
            KeySeparator = ".";
            Grouping = "/ProjCDSProjectContractEntity";

            AddGroup("ProjCDSProjectContractEntity Details", group =>
            {
                ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTerms = group.Add(new VocabularyKey(nameof(PaymentTerms), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerReference = group.Add(new VocabularyKey(nameof(CustomerReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceDataID = group.Add(new VocabularyKey(nameof(SourceDataID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine1 = group.Add(new VocabularyKey(nameof(AddressLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceLocation = group.Add(new VocabularyKey(nameof(InvoiceLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ProjectContractID { get; private set; }
        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey PaymentTerms { get; private set; }
        public VocabularyKey CustomerReference { get; private set; }
        public VocabularyKey SourceDataID { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }
        public VocabularyKey AddressDescription { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey AddressCountryRegionId { get; private set; }
        public VocabularyKey InvoiceLocation { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }


    }
}