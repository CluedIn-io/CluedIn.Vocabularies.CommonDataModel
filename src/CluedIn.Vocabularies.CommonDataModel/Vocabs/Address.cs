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
                parentId = group.Add(new VocabularyKey(nameof(parentId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                parentIdTypeCode = group.Add(new VocabularyKey(nameof(parentIdTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                customerAddressId = group.Add(new VocabularyKey(nameof(customerAddressId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                addressNumber = group.Add(new VocabularyKey(nameof(addressNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                objectTypeCode = group.Add(new VocabularyKey(nameof(objectTypeCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                objectTypeCode_display = group.Add(new VocabularyKey(nameof(objectTypeCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressTypeCode = group.Add(new VocabularyKey(nameof(addressTypeCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                addressTypeCode_display = group.Add(new VocabularyKey(nameof(addressTypeCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                primaryContactName = group.Add(new VocabularyKey(nameof(primaryContactName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                line1 = group.Add(new VocabularyKey(nameof(line1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                line2 = group.Add(new VocabularyKey(nameof(line2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                line3 = group.Add(new VocabularyKey(nameof(line3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                city = group.Add(new VocabularyKey(nameof(city), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                stateOrProvince = group.Add(new VocabularyKey(nameof(stateOrProvince), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                county = group.Add(new VocabularyKey(nameof(county), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                country = group.Add(new VocabularyKey(nameof(country), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                postOfficeBox = group.Add(new VocabularyKey(nameof(postOfficeBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                postalCode = group.Add(new VocabularyKey(nameof(postalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UTCOffset = group.Add(new VocabularyKey(nameof(UTCOffset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                freightTermsCode = group.Add(new VocabularyKey(nameof(freightTermsCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                freightTermsCode_display = group.Add(new VocabularyKey(nameof(freightTermsCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UPSZone = group.Add(new VocabularyKey(nameof(UPSZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                latitude = group.Add(new VocabularyKey(nameof(latitude), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                telephone1 = group.Add(new VocabularyKey(nameof(telephone1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                longitude = group.Add(new VocabularyKey(nameof(longitude), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                shippingMethodCode = group.Add(new VocabularyKey(nameof(shippingMethodCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                shippingMethodCode_display = group.Add(new VocabularyKey(nameof(shippingMethodCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                telephone2 = group.Add(new VocabularyKey(nameof(telephone2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                telephone3 = group.Add(new VocabularyKey(nameof(telephone3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                fax = group.Add(new VocabularyKey(nameof(fax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                versionNumber = group.Add(new VocabularyKey(nameof(versionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                createdBy = group.Add(new VocabularyKey(nameof(createdBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                modifiedBy = group.Add(new VocabularyKey(nameof(modifiedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                owningBusinessUnit = group.Add(new VocabularyKey(nameof(owningBusinessUnit), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                owningUser = group.Add(new VocabularyKey(nameof(owningUser), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ownerId = group.Add(new VocabularyKey(nameof(ownerId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                transactionCurrencyId = group.Add(new VocabularyKey(nameof(transactionCurrencyId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                exchangeRate = group.Add(new VocabularyKey(nameof(exchangeRate), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                composite = group.Add(new VocabularyKey(nameof(composite), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                endDate = group.Add(new VocabularyKey(nameof(endDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                startDate = group.Add(new VocabularyKey(nameof(startDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey parentId { get; private set; }
        public VocabularyKey parentIdTypeCode { get; private set; }
        public VocabularyKey customerAddressId { get; private set; }
        public VocabularyKey addressNumber { get; private set; }
        public VocabularyKey objectTypeCode { get; private set; }
        public VocabularyKey objectTypeCode_display { get; private set; }
        public VocabularyKey addressTypeCode { get; private set; }
        public VocabularyKey addressTypeCode_display { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey primaryContactName { get; private set; }
        public VocabularyKey line1 { get; private set; }
        public VocabularyKey line2 { get; private set; }
        public VocabularyKey line3 { get; private set; }
        public VocabularyKey city { get; private set; }
        public VocabularyKey stateOrProvince { get; private set; }
        public VocabularyKey county { get; private set; }
        public VocabularyKey country { get; private set; }
        public VocabularyKey postOfficeBox { get; private set; }
        public VocabularyKey postalCode { get; private set; }
        public VocabularyKey UTCOffset { get; private set; }
        public VocabularyKey freightTermsCode { get; private set; }
        public VocabularyKey freightTermsCode_display { get; private set; }
        public VocabularyKey UPSZone { get; private set; }
        public VocabularyKey latitude { get; private set; }
        public VocabularyKey telephone1 { get; private set; }
        public VocabularyKey longitude { get; private set; }
        public VocabularyKey shippingMethodCode { get; private set; }
        public VocabularyKey shippingMethodCode_display { get; private set; }
        public VocabularyKey telephone2 { get; private set; }
        public VocabularyKey telephone3 { get; private set; }
        public VocabularyKey fax { get; private set; }
        public VocabularyKey versionNumber { get; private set; }
        public VocabularyKey createdBy { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey modifiedBy { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey owningBusinessUnit { get; private set; }
        public VocabularyKey owningUser { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey ownerId { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey createdOnBehalfBy { get; private set; }
        public VocabularyKey modifiedOnBehalfBy { get; private set; }
        public VocabularyKey transactionCurrencyId { get; private set; }
        public VocabularyKey exchangeRate { get; private set; }
        public VocabularyKey composite { get; private set; }
        public VocabularyKey endDate { get; private set; }
        public VocabularyKey startDate { get; private set; }


    }
}