using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxInfoManagementEntityVocabulary : SimpleVocabulary
    {
        public TaxInfoManagementEntityVocabulary()
        {
            VocabularyName = "TaxInfoManagementEntity";
            KeyPrefix = "commonDataModel.taxinfomanagemententity";
            KeySeparator = ".";
            Grouping = "/TaxInfoManagementEntity";

            AddGroup("TaxInfoManagementEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GSTNumber = group.Add(new VocabularyKey(nameof(GSTNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumSeqGroup = group.Add(new VocabularyKey(nameof(NumSeqGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Range = group.Add(new VocabularyKey(nameof(Range), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ECCNumberOthers = group.Add(new VocabularyKey(nameof(ECCNumberOthers), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationType = group.Add(new VocabularyKey(nameof(RegistrationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GSTIN = group.Add(new VocabularyKey(nameof(GSTIN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ECCNumber = group.Add(new VocabularyKey(nameof(ECCNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ManECCRegistrationNumberTable = group.Add(new VocabularyKey(nameof(ManECCRegistrationNumberTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TraderECCRegistrationNumberTable = group.Add(new VocabularyKey(nameof(TraderECCRegistrationNumberTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IECRegistrationNumberTable = group.Add(new VocabularyKey(nameof(IECRegistrationNumberTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                STCRegistrationNumberTable = group.Add(new VocabularyKey(nameof(STCRegistrationNumberTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxRegistrationNumberTable = group.Add(new VocabularyKey(nameof(SalesTaxRegistrationNumberTable), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TIN = group.Add(new VocabularyKey(nameof(TIN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TAN = group.Add(new VocabularyKey(nameof(TAN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
        public VocabularyKey GSTNumber { get; private set; }
        public VocabularyKey NumSeqGroup { get; private set; }
        public VocabularyKey Range { get; private set; }
        public VocabularyKey ECCNumberOthers { get; private set; }
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
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey RegistrationType { get; private set; }
        public VocabularyKey GSTIN { get; private set; }
        public VocabularyKey ECCNumber { get; private set; }
        public VocabularyKey ManECCRegistrationNumberTable { get; private set; }
        public VocabularyKey TraderECCRegistrationNumberTable { get; private set; }
        public VocabularyKey IECRegistrationNumberTable { get; private set; }
        public VocabularyKey STCRegistrationNumberTable { get; private set; }
        public VocabularyKey SalesTaxRegistrationNumberTable { get; private set; }
        public VocabularyKey TIN { get; private set; }
        public VocabularyKey TAN { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}