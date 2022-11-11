using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SMAServiceOrderHeaderEntityVocabulary : SimpleVocabulary
    {
        public SMAServiceOrderHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model SMAServiceOrderHeaderEntity";
            KeyPrefix = "commonDataModel.smaserviceorderheaderentity";
            KeySeparator = ".";
            Grouping = "/SMAServiceOrderHeaderEntity";

            AddGroup("Common Data Model SMAServiceOrderHeaderEntity Details", group =>
            {
                ServiceOrderNumber = group.Add(new VocabularyKey(nameof(ServiceOrderNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceOrderDescription = group.Add(new VocabularyKey(nameof(ServiceOrderDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceCustomerAccountNumber = group.Add(new VocabularyKey(nameof(ServiceCustomerAccountNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectId = group.Add(new VocabularyKey(nameof(ProjectId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAgreementId = group.Add(new VocabularyKey(nameof(ServiceAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsServiceOrderSignedOff = group.Add(new VocabularyKey(nameof(IsServiceOrderSignedOff), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceOrderSignOffDateTime = group.Add(new VocabularyKey(nameof(ServiceOrderSignOffDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceOrderPriority = group.Add(new VocabularyKey(nameof(ServiceOrderPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceLevelAgreementId = group.Add(new VocabularyKey(nameof(ServiceLevelAgreementId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeRecordingStatus = group.Add(new VocabularyKey(nameof(TimeRecordingStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceLevelAgreementCompliancePercentage = group.Add(new VocabularyKey(nameof(ServiceLevelAgreementCompliancePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferredServiceDateTime = group.Add(new VocabularyKey(nameof(PreferredServiceDateTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceOrderOrigin = group.Add(new VocabularyKey(nameof(ServiceOrderOrigin), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceOrderStageId = group.Add(new VocabularyKey(nameof(ServiceOrderStageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceOrderProgress = group.Add(new VocabularyKey(nameof(ServiceOrderProgress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HasCalendarConflict = group.Add(new VocabularyKey(nameof(HasCalendarConflict), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PreferredTechnicianPersonnelNumber = group.Add(new VocabularyKey(nameof(PreferredTechnicianPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(ServiceResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultLineActivityTypeId = group.Add(new VocabularyKey(nameof(DefaultLineActivityTypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProjectActivityNumber = group.Add(new VocabularyKey(nameof(ProjectActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressName = group.Add(new VocabularyKey(nameof(ServiceAddressName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServicePostalAddress = group.Add(new VocabularyKey(nameof(ServicePostalAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormattedServiceAddress = group.Add(new VocabularyKey(nameof(FormattedServiceAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressZipCode = group.Add(new VocabularyKey(nameof(ServiceAddressZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressLocationId = group.Add(new VocabularyKey(nameof(ServiceAddressLocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressBuildingCompliment = group.Add(new VocabularyKey(nameof(ServiceAddressBuildingCompliment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressCity = group.Add(new VocabularyKey(nameof(ServiceAddressCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressCityInKana = group.Add(new VocabularyKey(nameof(ServiceAddressCityInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressCountryRegionId = group.Add(new VocabularyKey(nameof(ServiceAddressCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressCountryRegionISOCode = group.Add(new VocabularyKey(nameof(ServiceAddressCountryRegionISOCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressCountyId = group.Add(new VocabularyKey(nameof(ServiceAddressCountyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressDescription = group.Add(new VocabularyKey(nameof(ServiceAddressDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressDistrictName = group.Add(new VocabularyKey(nameof(ServiceAddressDistrictName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressDunsNumber = group.Add(new VocabularyKey(nameof(ServiceAddressDunsNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressLatitude = group.Add(new VocabularyKey(nameof(ServiceAddressLatitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsServiceAddressPrivate = group.Add(new VocabularyKey(nameof(IsServiceAddressPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressLongitude = group.Add(new VocabularyKey(nameof(ServiceAddressLongitude), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressPostBox = group.Add(new VocabularyKey(nameof(ServiceAddressPostBox), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressStateId = group.Add(new VocabularyKey(nameof(ServiceAddressStateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressStreet = group.Add(new VocabularyKey(nameof(ServiceAddressStreet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressStreetInKana = group.Add(new VocabularyKey(nameof(ServiceAddressStreetInKana), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressStreetNumber = group.Add(new VocabularyKey(nameof(ServiceAddressStreetNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressValidFrom = group.Add(new VocabularyKey(nameof(ServiceAddressValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressValidTo = group.Add(new VocabularyKey(nameof(ServiceAddressValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServicePostalAddressRecId = group.Add(new VocabularyKey(nameof(ServicePostalAddressRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceAddressTimeZone = group.Add(new VocabularyKey(nameof(ServiceAddressTimeZone), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsServiceAddressOrderSpecific = group.Add(new VocabularyKey(nameof(IsServiceAddressOrderSpecific), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ServiceOrderNumber { get; private set; }
        public VocabularyKey ServiceOrderDescription { get; private set; }
        public VocabularyKey ServiceCustomerAccountNumber { get; private set; }
        public VocabularyKey ProjectId { get; private set; }
        public VocabularyKey ServiceAgreementId { get; private set; }
        public VocabularyKey ContactPersonId { get; private set; }
        public VocabularyKey IsServiceOrderSignedOff { get; private set; }
        public VocabularyKey ServiceOrderSignOffDateTime { get; private set; }
        public VocabularyKey ServiceOrderPriority { get; private set; }
        public VocabularyKey ServiceLevelAgreementId { get; private set; }
        public VocabularyKey TimeRecordingStatus { get; private set; }
        public VocabularyKey ServiceLevelAgreementCompliancePercentage { get; private set; }
        public VocabularyKey PreferredServiceDateTime { get; private set; }
        public VocabularyKey ServiceOrderOrigin { get; private set; }
        public VocabularyKey ServiceOrderStageId { get; private set; }
        public VocabularyKey ServiceOrderProgress { get; private set; }
        public VocabularyKey HasCalendarConflict { get; private set; }
        public VocabularyKey PreferredTechnicianPersonnelNumber { get; private set; }
        public VocabularyKey ServiceResponsiblePersonnelNumber { get; private set; }
        public VocabularyKey DefaultLineActivityTypeId { get; private set; }
        public VocabularyKey ProjectActivityNumber { get; private set; }
        public VocabularyKey ServiceAddressName { get; private set; }
        public VocabularyKey ServicePostalAddress { get; private set; }
        public VocabularyKey FormattedServiceAddress { get; private set; }
        public VocabularyKey ServiceAddressZipCode { get; private set; }
        public VocabularyKey ServiceAddressLocationId { get; private set; }
        public VocabularyKey ServiceAddressBuildingCompliment { get; private set; }
        public VocabularyKey ServiceAddressCity { get; private set; }
        public VocabularyKey ServiceAddressCityInKana { get; private set; }
        public VocabularyKey ServiceAddressCountryRegionId { get; private set; }
        public VocabularyKey ServiceAddressCountryRegionISOCode { get; private set; }
        public VocabularyKey ServiceAddressCountyId { get; private set; }
        public VocabularyKey ServiceAddressDescription { get; private set; }
        public VocabularyKey ServiceAddressDistrictName { get; private set; }
        public VocabularyKey ServiceAddressDunsNumber { get; private set; }
        public VocabularyKey ServiceAddressLatitude { get; private set; }
        public VocabularyKey IsServiceAddressPrivate { get; private set; }
        public VocabularyKey ServiceAddressLongitude { get; private set; }
        public VocabularyKey ServiceAddressPostBox { get; private set; }
        public VocabularyKey ServiceAddressStateId { get; private set; }
        public VocabularyKey ServiceAddressStreet { get; private set; }
        public VocabularyKey ServiceAddressStreetInKana { get; private set; }
        public VocabularyKey ServiceAddressStreetNumber { get; private set; }
        public VocabularyKey ServiceAddressValidFrom { get; private set; }
        public VocabularyKey ServiceAddressValidTo { get; private set; }
        public VocabularyKey ServicePostalAddressRecId { get; private set; }
        public VocabularyKey ServiceAddressTimeZone { get; private set; }
        public VocabularyKey IsServiceAddressOrderSpecific { get; private set; }


    }
}