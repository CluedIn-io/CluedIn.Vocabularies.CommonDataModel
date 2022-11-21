using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AddressVocabulary : SimpleVocabulary
    {
        public AddressVocabulary()
        {
            VocabularyName = "Address";
            KeyPrefix = "commonDataModel.address";
            KeySeparator = ".";
            Grouping = "/Address";

            AddGroup("Address Details", group =>
            {
                ParentId = group.Add(new VocabularyKey(nameof(ParentId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ParentIdTypeCode = group.Add(new VocabularyKey(nameof(ParentIdTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomerAddressId = group.Add(new VocabularyKey(nameof(CustomerAddressId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                AddressNumber = group.Add(new VocabularyKey(nameof(AddressNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ObjectTypeCode = group.Add(new VocabularyKey(nameof(ObjectTypeCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ObjectTypeCode_display = group.Add(new VocabularyKey(nameof(ObjectTypeCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressTypeCode = group.Add(new VocabularyKey(nameof(AddressTypeCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                AddressTypeCode_display = group.Add(new VocabularyKey(nameof(AddressTypeCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrimaryContactName = group.Add(new VocabularyKey(nameof(PrimaryContactName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Line1 = group.Add(new VocabularyKey(nameof(Line1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Line2 = group.Add(new VocabularyKey(nameof(Line2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Line3 = group.Add(new VocabularyKey(nameof(Line3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateOrProvince = group.Add(new VocabularyKey(nameof(StateOrProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                County = group.Add(new VocabularyKey(nameof(County), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Country = group.Add(new VocabularyKey(nameof(Country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostOfficeBox = group.Add(new VocabularyKey(nameof(PostOfficeBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostalCode = group.Add(new VocabularyKey(nameof(PostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCOffset = group.Add(new VocabularyKey(nameof(UTCOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FreightTermsCode = group.Add(new VocabularyKey(nameof(FreightTermsCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                FreightTermsCode_display = group.Add(new VocabularyKey(nameof(FreightTermsCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UPSZone = group.Add(new VocabularyKey(nameof(UPSZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Latitude = group.Add(new VocabularyKey(nameof(Latitude), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                Telephone1 = group.Add(new VocabularyKey(nameof(Telephone1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Longitude = group.Add(new VocabularyKey(nameof(Longitude), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ShippingMethodCode = group.Add(new VocabularyKey(nameof(ShippingMethodCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ShippingMethodCode_display = group.Add(new VocabularyKey(nameof(ShippingMethodCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telephone2 = group.Add(new VocabularyKey(nameof(Telephone2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Telephone3 = group.Add(new VocabularyKey(nameof(Telephone3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Fax = group.Add(new VocabularyKey(nameof(Fax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                CreatedBy = group.Add(new VocabularyKey(nameof(CreatedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ModifiedBy = group.Add(new VocabularyKey(nameof(ModifiedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                OwningBusinessUnit = group.Add(new VocabularyKey(nameof(OwningBusinessUnit), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OwnerId = group.Add(new VocabularyKey(nameof(OwnerId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                TransactionCurrencyId = group.Add(new VocabularyKey(nameof(TransactionCurrencyId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                Composite = group.Add(new VocabularyKey(nameof(Composite), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ParentId { get; private set; }
        public VocabularyKey ParentIdTypeCode { get; private set; }
        public VocabularyKey CustomerAddressId { get; private set; }
        public VocabularyKey AddressNumber { get; private set; }
        public VocabularyKey ObjectTypeCode { get; private set; }
        public VocabularyKey ObjectTypeCode_display { get; private set; }
        public VocabularyKey AddressTypeCode { get; private set; }
        public VocabularyKey AddressTypeCode_display { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PrimaryContactName { get; private set; }
        public VocabularyKey Line1 { get; private set; }
        public VocabularyKey Line2 { get; private set; }
        public VocabularyKey Line3 { get; private set; }
        public VocabularyKey City { get; private set; }
        public VocabularyKey StateOrProvince { get; private set; }
        public VocabularyKey County { get; private set; }
        public VocabularyKey Country { get; private set; }
        public VocabularyKey PostOfficeBox { get; private set; }
        public VocabularyKey PostalCode { get; private set; }
        public VocabularyKey UTCOffset { get; private set; }
        public VocabularyKey FreightTermsCode { get; private set; }
        public VocabularyKey FreightTermsCode_display { get; private set; }
        public VocabularyKey UPSZone { get; private set; }
        public VocabularyKey Latitude { get; private set; }
        public VocabularyKey Telephone1 { get; private set; }
        public VocabularyKey Longitude { get; private set; }
        public VocabularyKey ShippingMethodCode { get; private set; }
        public VocabularyKey ShippingMethodCode_display { get; private set; }
        public VocabularyKey Telephone2 { get; private set; }
        public VocabularyKey Telephone3 { get; private set; }
        public VocabularyKey Fax { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey CreatedBy { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedBy { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey OwningBusinessUnit { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OwnerId { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey TransactionCurrencyId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Composite { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey StartDate { get; private set; }
    }
}