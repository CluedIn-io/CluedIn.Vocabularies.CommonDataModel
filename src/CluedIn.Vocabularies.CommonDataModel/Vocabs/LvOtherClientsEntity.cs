using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LvOtherClientsEntityVocabulary : SimpleVocabulary
    {
        public LvOtherClientsEntityVocabulary()
        {
            VocabularyName = "LvOtherClientsEntity";
            KeyPrefix = "commonDataModel.lvotherclientsentity";
            KeySeparator = ".";
            Grouping = "/LvOtherClientsEntity";

            AddGroup("LvOtherClientsEntity Details", group =>
            {
                Bank = group.Add(new VocabularyKey(nameof(Bank), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountNumber = group.Add(new VocabularyKey(nameof(BankAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAddress = group.Add(new VocabularyKey(nameof(BankAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoutingNumber = group.Add(new VocabularyKey(nameof(RoutingNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubAccount = group.Add(new VocabularyKey(nameof(SubAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SWIFTCode = group.Add(new VocabularyKey(nameof(SWIFTCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationNumber = group.Add(new VocabularyKey(nameof(RegistrationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymentTransactionCode = group.Add(new VocabularyKey(nameof(PaymentTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Resident = group.Add(new VocabularyKey(nameof(Resident), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyNumber = group.Add(new VocabularyKey(nameof(PartyNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyType = group.Add(new VocabularyKey(nameof(PartyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Organization = group.Add(new VocabularyKey(nameof(Organization), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LvPaymTransCodes = group.Add(new VocabularyKey(nameof(LvPaymTransCodes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDescription = group.Add(new VocabularyKey(nameof(AddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Address = group.Add(new VocabularyKey(nameof(Address), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLocationRoles = group.Add(new VocabularyKey(nameof(AddressLocationRoles), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressZipCode = group.Add(new VocabularyKey(nameof(AddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCounty = group.Add(new VocabularyKey(nameof(AddressCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressStreet = group.Add(new VocabularyKey(nameof(AddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DistrictName = group.Add(new VocabularyKey(nameof(DistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLongitude = group.Add(new VocabularyKey(nameof(AddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLatitude = group.Add(new VocabularyKey(nameof(AddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressTimeZone = group.Add(new VocabularyKey(nameof(AddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionId = group.Add(new VocabularyKey(nameof(AddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(AddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidFrom = group.Add(new VocabularyKey(nameof(AddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressValidTo = group.Add(new VocabularyKey(nameof(AddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Bank { get; private set; }
        public VocabularyKey BankAccountNumber { get; private set; }
        public VocabularyKey BankAddress { get; private set; }
        public VocabularyKey RoutingNumber { get; private set; }
        public VocabularyKey SubAccount { get; private set; }
        public VocabularyKey SWIFTCode { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey RegistrationNumber { get; private set; }
        public VocabularyKey PaymentTransactionCode { get; private set; }
        public VocabularyKey Resident { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey PartyNumber { get; private set; }
        public VocabularyKey PartyType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Organization { get; private set; }
        public VocabularyKey LvPaymTransCodes { get; private set; }
        public VocabularyKey AddressDescription { get; private set; }
        public VocabularyKey Address { get; private set; }
        public VocabularyKey AddressLocationRoles { get; private set; }
        public VocabularyKey AddressZipCode { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCounty { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey AddressStreet { get; private set; }
        public VocabularyKey DistrictName { get; private set; }
        public VocabularyKey AddressLongitude { get; private set; }
        public VocabularyKey AddressLatitude { get; private set; }
        public VocabularyKey AddressTimeZone { get; private set; }
        public VocabularyKey AddressCountryRegionId { get; private set; }
        public VocabularyKey AddressCountryRegionISOCode { get; private set; }
        public VocabularyKey AddressValidFrom { get; private set; }
        public VocabularyKey AddressValidTo { get; private set; }


    }
}