using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankGroupEntityVocabulary : SimpleVocabulary
    {
        public BankGroupEntityVocabulary()
        {
            VocabularyName = "BankGroupEntity";
            KeyPrefix = "commonDataModel.bankgroupentity";
            KeySeparator = ".";
            Grouping = "/BankGroupEntity";

            AddGroup("BankGroupEntity Details", group =>
            {
                RoutingNumberType = group.Add(new VocabularyKey(nameof(RoutingNumberType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContractPostAccount = group.Add(new VocabularyKey(nameof(ContractPostAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankGroupId = group.Add(new VocabularyKey(nameof(BankGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementFormatRefRecId = group.Add(new VocabularyKey(nameof(StatementFormatRefRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatementFormatId = group.Add(new VocabularyKey(nameof(StatementFormatId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankStatementName = group.Add(new VocabularyKey(nameof(BankStatementName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Suffix = group.Add(new VocabularyKey(nameof(Suffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer = group.Add(new VocabularyKey(nameof(Drawer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BranchCode = group.Add(new VocabularyKey(nameof(BranchCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BranchName = group.Add(new VocabularyKey(nameof(BranchName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BranchKanaName = group.Add(new VocabularyKey(nameof(BranchKanaName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CellularPhone = group.Add(new VocabularyKey(nameof(CellularPhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankCode = group.Add(new VocabularyKey(nameof(BankCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BanksIdentificationOfCompany = group.Add(new VocabularyKey(nameof(BanksIdentificationOfCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactName = group.Add(new VocabularyKey(nameof(ContactName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Currency = group.Add(new VocabularyKey(nameof(Currency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactEmail = group.Add(new VocabularyKey(nameof(ContactEmail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KanaName = group.Add(new VocabularyKey(nameof(KanaName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPager = group.Add(new VocabularyKey(nameof(ContactPager), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPhone = group.Add(new VocabularyKey(nameof(ContactPhone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPhoneExtension = group.Add(new VocabularyKey(nameof(ContactPhoneExtension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoutingNumber = group.Add(new VocabularyKey(nameof(RoutingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactSMS = group.Add(new VocabularyKey(nameof(ContactSMS), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactFax = group.Add(new VocabularyKey(nameof(ContactFax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactTelex = group.Add(new VocabularyKey(nameof(ContactTelex), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactURL = group.Add(new VocabularyKey(nameof(ContactURL), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FullPrimaryAddress = group.Add(new VocabularyKey(nameof(FullPrimaryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationId = group.Add(new VocabularyKey(nameof(AddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
                AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankName = group.Add(new VocabularyKey(nameof(BankName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OrganizationNumber = group.Add(new VocabularyKey(nameof(OrganizationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankArchive_RU = group.Add(new VocabularyKey(nameof(BankArchive_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountOpenedIn_RU = group.Add(new VocabularyKey(nameof(BankAccountOpenedIn_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankBIC_RU = group.Add(new VocabularyKey(nameof(BankBIC_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankDescription_RU = group.Add(new VocabularyKey(nameof(BankDescription_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankShortAddressing_RU = group.Add(new VocabularyKey(nameof(BankShortAddressing_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankType_RU = group.Add(new VocabularyKey(nameof(BankType_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BaseBankId_RU = group.Add(new VocabularyKey(nameof(BaseBankId_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VendAccountNum_RU = group.Add(new VocabularyKey(nameof(VendAccountNum_RU), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey RoutingNumberType { get; private set; }
        public VocabularyKey ContractPostAccount { get; private set; }
        public VocabularyKey BankGroupId { get; private set; }
        public VocabularyKey StatementFormatRefRecId { get; private set; }
        public VocabularyKey StatementFormatId { get; private set; }
        public VocabularyKey BankStatementName { get; private set; }
        public VocabularyKey Suffix { get; private set; }
        public VocabularyKey Drawer { get; private set; }
        public VocabularyKey BranchCode { get; private set; }
        public VocabularyKey BranchName { get; private set; }
        public VocabularyKey BranchKanaName { get; private set; }
        public VocabularyKey CellularPhone { get; private set; }
        public VocabularyKey BankCode { get; private set; }
        public VocabularyKey BanksIdentificationOfCompany { get; private set; }
        public VocabularyKey ContactName { get; private set; }
        public VocabularyKey Currency { get; private set; }
        public VocabularyKey ContactEmail { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey KanaName { get; private set; }
        public VocabularyKey ContactPager { get; private set; }
        public VocabularyKey ContactPhone { get; private set; }
        public VocabularyKey ContactPhoneExtension { get; private set; }
        public VocabularyKey RoutingNumber { get; private set; }
        public VocabularyKey ContactSMS { get; private set; }
        public VocabularyKey ContactFax { get; private set; }
        public VocabularyKey ContactTelex { get; private set; }
        public VocabularyKey ContactURL { get; private set; }
        public VocabularyKey FullPrimaryAddress { get; private set; }
        public VocabularyKey AddressLocationId { get; private set; }
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
        public VocabularyKey AddressTimeZone { get; private set; }
        public VocabularyKey BankName { get; private set; }
        public VocabularyKey OrganizationNumber { get; private set; }
        public VocabularyKey BankArchive_RU { get; private set; }
        public VocabularyKey BankAccountOpenedIn_RU { get; private set; }
        public VocabularyKey BankBIC_RU { get; private set; }
        public VocabularyKey BankDescription_RU { get; private set; }
        public VocabularyKey BankShortAddressing_RU { get; private set; }
        public VocabularyKey BankType_RU { get; private set; }
        public VocabularyKey BaseBankId_RU { get; private set; }
        public VocabularyKey VendAccountNum_RU { get; private set; }


    }
}