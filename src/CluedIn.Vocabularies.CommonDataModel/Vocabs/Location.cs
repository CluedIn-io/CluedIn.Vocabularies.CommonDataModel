using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LocationVocabulary : SimpleVocabulary
    {
        public LocationVocabulary()
        {
            VocabularyName = "Location";
            KeyPrefix = "commonDataModel.location";
            KeySeparator = ".";
            Grouping = "/Location";

            AddGroup("Location Details", group =>
            {
                locationId = group.Add(new VocabularyKey(nameof(locationId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                createdBy = group.Add(new VocabularyKey(nameof(createdBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                modifiedBy = group.Add(new VocabularyKey(nameof(modifiedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                organizationId = group.Add(new VocabularyKey(nameof(organizationId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                stateCode_display = group.Add(new VocabularyKey(nameof(stateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                statusCode_display = group.Add(new VocabularyKey(nameof(statusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                versionNumber = group.Add(new VocabularyKey(nameof(versionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressCity = group.Add(new VocabularyKey(nameof(addressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressCountry = group.Add(new VocabularyKey(nameof(addressCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressDistinct = group.Add(new VocabularyKey(nameof(addressDistinct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressLine1 = group.Add(new VocabularyKey(nameof(addressLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressLine2 = group.Add(new VocabularyKey(nameof(addressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressLine3 = group.Add(new VocabularyKey(nameof(addressLine3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressPeriodEnd = group.Add(new VocabularyKey(nameof(addressPeriodEnd), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                addressPeriodStart = group.Add(new VocabularyKey(nameof(addressPeriodStart), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                addressPostalCode = group.Add(new VocabularyKey(nameof(addressPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressState = group.Add(new VocabularyKey(nameof(addressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressText = group.Add(new VocabularyKey(nameof(addressText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressType = group.Add(new VocabularyKey(nameof(addressType), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                addressType_display = group.Add(new VocabularyKey(nameof(addressType_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                addressUse = group.Add(new VocabularyKey(nameof(addressUse), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                addressUse_display = group.Add(new VocabularyKey(nameof(addressUse_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                description = group.Add(new VocabularyKey(nameof(description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                locationAlias1 = group.Add(new VocabularyKey(nameof(locationAlias1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                locationAlias2 = group.Add(new VocabularyKey(nameof(locationAlias2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                locationAlias3 = group.Add(new VocabularyKey(nameof(locationAlias3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                locationNumber = group.Add(new VocabularyKey(nameof(locationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                locationPositionAltitude = group.Add(new VocabularyKey(nameof(locationPositionAltitude), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                locationPositionLatitude = group.Add(new VocabularyKey(nameof(locationPositionLatitude), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                locationPositionLongitude = group.Add(new VocabularyKey(nameof(locationPositionLongitude), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                managingOrganization = group.Add(new VocabularyKey(nameof(managingOrganization), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                mode = group.Add(new VocabularyKey(nameof(mode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                mode_display = group.Add(new VocabularyKey(nameof(mode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                operationalStatus = group.Add(new VocabularyKey(nameof(operationalStatus), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                operationalStatus_display = group.Add(new VocabularyKey(nameof(operationalStatus_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                partOf = group.Add(new VocabularyKey(nameof(partOf), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                physicalType = group.Add(new VocabularyKey(nameof(physicalType), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                status = group.Add(new VocabularyKey(nameof(status), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                status_display = group.Add(new VocabularyKey(nameof(status_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                type = group.Add(new VocabularyKey(nameof(type), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey locationId { get; private set; }
        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey createdBy { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey modifiedBy { get; private set; }
        public VocabularyKey createdOnBehalfBy { get; private set; }
        public VocabularyKey modifiedOnBehalfBy { get; private set; }
        public VocabularyKey organizationId { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey stateCode_display { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey statusCode_display { get; private set; }
        public VocabularyKey versionNumber { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey addressCity { get; private set; }
        public VocabularyKey addressCountry { get; private set; }
        public VocabularyKey addressDistinct { get; private set; }
        public VocabularyKey addressLine1 { get; private set; }
        public VocabularyKey addressLine2 { get; private set; }
        public VocabularyKey addressLine3 { get; private set; }
        public VocabularyKey addressPeriodEnd { get; private set; }
        public VocabularyKey addressPeriodStart { get; private set; }
        public VocabularyKey addressPostalCode { get; private set; }
        public VocabularyKey addressState { get; private set; }
        public VocabularyKey addressText { get; private set; }
        public VocabularyKey addressType { get; private set; }
        public VocabularyKey addressType_display { get; private set; }
        public VocabularyKey addressUse { get; private set; }
        public VocabularyKey addressUse_display { get; private set; }
        public VocabularyKey description { get; private set; }
        public VocabularyKey locationAlias1 { get; private set; }
        public VocabularyKey locationAlias2 { get; private set; }
        public VocabularyKey locationAlias3 { get; private set; }
        public VocabularyKey locationNumber { get; private set; }
        public VocabularyKey locationPositionAltitude { get; private set; }
        public VocabularyKey locationPositionLatitude { get; private set; }
        public VocabularyKey locationPositionLongitude { get; private set; }
        public VocabularyKey managingOrganization { get; private set; }
        public VocabularyKey mode { get; private set; }
        public VocabularyKey mode_display { get; private set; }
        public VocabularyKey operationalStatus { get; private set; }
        public VocabularyKey operationalStatus_display { get; private set; }
        public VocabularyKey partOf { get; private set; }
        public VocabularyKey physicalType { get; private set; }
        public VocabularyKey status { get; private set; }
        public VocabularyKey status_display { get; private set; }
        public VocabularyKey type { get; private set; }


    }
}