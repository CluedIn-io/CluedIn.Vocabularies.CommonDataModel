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
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CreatedBy = group.Add(new VocabularyKey(nameof(CreatedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ModifiedBy = group.Add(new VocabularyKey(nameof(ModifiedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OrganizationId = group.Add(new VocabularyKey(nameof(OrganizationId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StateCode_display = group.Add(new VocabularyKey(nameof(StateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StatusCode_display = group.Add(new VocabularyKey(nameof(StatusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCity = group.Add(new VocabularyKey(nameof(AddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressCountry = group.Add(new VocabularyKey(nameof(AddressCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressDistinct = group.Add(new VocabularyKey(nameof(AddressDistinct), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine1 = group.Add(new VocabularyKey(nameof(AddressLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine2 = group.Add(new VocabularyKey(nameof(AddressLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressLine3 = group.Add(new VocabularyKey(nameof(AddressLine3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressPeriodEnd = group.Add(new VocabularyKey(nameof(AddressPeriodEnd), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                AddressPeriodStart = group.Add(new VocabularyKey(nameof(AddressPeriodStart), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                AddressPostalCode = group.Add(new VocabularyKey(nameof(AddressPostalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressState = group.Add(new VocabularyKey(nameof(AddressState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressText = group.Add(new VocabularyKey(nameof(AddressText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressType = group.Add(new VocabularyKey(nameof(AddressType), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                AddressType_display = group.Add(new VocabularyKey(nameof(AddressType_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AddressUse = group.Add(new VocabularyKey(nameof(AddressUse), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                AddressUse_display = group.Add(new VocabularyKey(nameof(AddressUse_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationAlias1 = group.Add(new VocabularyKey(nameof(LocationAlias1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationAlias2 = group.Add(new VocabularyKey(nameof(LocationAlias2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationAlias3 = group.Add(new VocabularyKey(nameof(LocationAlias3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationNumber = group.Add(new VocabularyKey(nameof(LocationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationPositionAltitude = group.Add(new VocabularyKey(nameof(LocationPositionAltitude), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                LocationPositionLatitude = group.Add(new VocabularyKey(nameof(LocationPositionLatitude), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                LocationPositionLongitude = group.Add(new VocabularyKey(nameof(LocationPositionLongitude), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ManagingOrganization = group.Add(new VocabularyKey(nameof(ManagingOrganization), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                Mode = group.Add(new VocabularyKey(nameof(Mode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Mode_display = group.Add(new VocabularyKey(nameof(Mode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationalStatus = group.Add(new VocabularyKey(nameof(OperationalStatus), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OperationalStatus_display = group.Add(new VocabularyKey(nameof(OperationalStatus_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartOf = group.Add(new VocabularyKey(nameof(PartOf), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                PhysicalType = group.Add(new VocabularyKey(nameof(PhysicalType), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Status_display = group.Add(new VocabularyKey(nameof(Status_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Type = group.Add(new VocabularyKey(nameof(Type), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedBy { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedBy { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey OrganizationId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StateCode_display { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StatusCode_display { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey AddressCity { get; private set; }
        public VocabularyKey AddressCountry { get; private set; }
        public VocabularyKey AddressDistinct { get; private set; }
        public VocabularyKey AddressLine1 { get; private set; }
        public VocabularyKey AddressLine2 { get; private set; }
        public VocabularyKey AddressLine3 { get; private set; }
        public VocabularyKey AddressPeriodEnd { get; private set; }
        public VocabularyKey AddressPeriodStart { get; private set; }
        public VocabularyKey AddressPostalCode { get; private set; }
        public VocabularyKey AddressState { get; private set; }
        public VocabularyKey AddressText { get; private set; }
        public VocabularyKey AddressType { get; private set; }
        public VocabularyKey AddressType_display { get; private set; }
        public VocabularyKey AddressUse { get; private set; }
        public VocabularyKey AddressUse_display { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey LocationAlias1 { get; private set; }
        public VocabularyKey LocationAlias2 { get; private set; }
        public VocabularyKey LocationAlias3 { get; private set; }
        public VocabularyKey LocationNumber { get; private set; }
        public VocabularyKey LocationPositionAltitude { get; private set; }
        public VocabularyKey LocationPositionLatitude { get; private set; }
        public VocabularyKey LocationPositionLongitude { get; private set; }
        public VocabularyKey ManagingOrganization { get; private set; }
        public VocabularyKey Mode { get; private set; }
        public VocabularyKey Mode_display { get; private set; }
        public VocabularyKey OperationalStatus { get; private set; }
        public VocabularyKey OperationalStatus_display { get; private set; }
        public VocabularyKey PartOf { get; private set; }
        public VocabularyKey PhysicalType { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Status_display { get; private set; }
        public VocabularyKey Type { get; private set; }
    }
}