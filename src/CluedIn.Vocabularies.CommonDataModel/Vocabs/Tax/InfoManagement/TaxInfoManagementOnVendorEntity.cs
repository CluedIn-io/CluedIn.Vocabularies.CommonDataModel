using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxInfoManagementOnVendorEntityVocabulary : SimpleVocabulary
    {
        public TaxInfoManagementOnVendorEntityVocabulary()
        {
            VocabularyName = "TaxInfoManagementOnVendorEntity";
            KeyPrefix = "commonDataModel.taxinfomanagementonvendorentity";
            KeySeparator = ".";
            Grouping = "/TaxInfoManagementOnVendorEntity";

            AddGroup("TaxInfoManagementOnVendorEntity Details", group =>
            {
                VendorId = group.Add(new VocabularyKey(nameof(VendorId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GSTNumber = group.Add(new VocabularyKey(nameof(GSTNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Range = group.Add(new VocabularyKey(nameof(Range), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManufacturerECCNumber = group.Add(new VocabularyKey(nameof(ManufacturerECCNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Commissionarate = group.Add(new VocabularyKey(nameof(Commissionarate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Division = group.Add(new VocabularyKey(nameof(Division), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TraderECCNumber = group.Add(new VocabularyKey(nameof(TraderECCNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LargeTaxpayerUnitCode = group.Add(new VocabularyKey(nameof(LargeTaxpayerUnitCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IECNumber = group.Add(new VocabularyKey(nameof(IECNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                STCNumber = group.Add(new VocabularyKey(nameof(STCNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxRegistrationNumber = group.Add(new VocabularyKey(nameof(SalesTaxRegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxIdentificationNumber = group.Add(new VocabularyKey(nameof(TaxIdentificationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxAccountNumber = group.Add(new VocabularyKey(nameof(TaxAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationType = group.Add(new VocabularyKey(nameof(RegistrationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey VendorId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
        public VocabularyKey GSTNumber { get; private set; }
        public VocabularyKey Range { get; private set; }
        public VocabularyKey ManufacturerECCNumber { get; private set; }
        public VocabularyKey Commissionarate { get; private set; }
        public VocabularyKey Division { get; private set; }
        public VocabularyKey TraderECCNumber { get; private set; }
        public VocabularyKey LargeTaxpayerUnitCode { get; private set; }
        public VocabularyKey IECNumber { get; private set; }
        public VocabularyKey STCNumber { get; private set; }
        public VocabularyKey SalesTaxRegistrationNumber { get; private set; }
        public VocabularyKey TaxIdentificationNumber { get; private set; }
        public VocabularyKey TaxAccountNumber { get; private set; }
        public VocabularyKey RegistrationType { get; private set; }


    }
}