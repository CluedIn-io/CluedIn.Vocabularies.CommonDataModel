using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EncounterVocabulary : SimpleVocabulary
    {
        public EncounterVocabulary()
        {
            VocabularyName = "Encounter";
            KeyPrefix = "commonDataModel.encounter";
            KeySeparator = ".";
            Grouping = "/Encounter";

            AddGroup("Encounter Details", group =>
            {
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                CreatedBy = group.Add(new VocabularyKey(nameof(CreatedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ModifiedBy = group.Add(new VocabularyKey(nameof(ModifiedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OwnerId = group.Add(new VocabularyKey(nameof(OwnerId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OwnerIdType = group.Add(new VocabularyKey(nameof(OwnerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OwningBusinessUnit = group.Add(new VocabularyKey(nameof(OwningBusinessUnit), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OwningTeam = group.Add(new VocabularyKey(nameof(OwningTeam), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                EncounterId = group.Add(new VocabularyKey(nameof(EncounterId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StateCode_display = group.Add(new VocabularyKey(nameof(StateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StatusCode_display = group.Add(new VocabularyKey(nameof(StatusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmrAppointment = group.Add(new VocabularyKey(nameof(EmrAppointment), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                @Class = group.Add(new VocabularyKey(nameof(@Class), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Class_display = group.Add(new VocabularyKey(nameof(Class_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContextEncounter = group.Add(new VocabularyKey(nameof(ContextEncounter), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ContextEpisodeofCare = group.Add(new VocabularyKey(nameof(ContextEpisodeofCare), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                Duration = group.Add(new VocabularyKey(nameof(Duration), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                EncounterClass = group.Add(new VocabularyKey(nameof(EncounterClass), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                EncounterClass_display = group.Add(new VocabularyKey(nameof(EncounterClass_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EncounterEndDate = group.Add(new VocabularyKey(nameof(EncounterEndDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                EncounterGroupIdentifier = group.Add(new VocabularyKey(nameof(EncounterGroupIdentifier), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                EncounterIdentifier = group.Add(new VocabularyKey(nameof(EncounterIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EncounterLength = group.Add(new VocabularyKey(nameof(EncounterLength), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                EncounterParentEncounterIdentifier = group.Add(new VocabularyKey(nameof(EncounterParentEncounterIdentifier), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                EncounterPatientIdentifier = group.Add(new VocabularyKey(nameof(EncounterPatientIdentifier), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                EncounterPriority = group.Add(new VocabularyKey(nameof(EncounterPriority), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                EncounterStartDate = group.Add(new VocabularyKey(nameof(EncounterStartDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                EncounterStatus = group.Add(new VocabularyKey(nameof(EncounterStatus), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                EncounterStatus_display = group.Add(new VocabularyKey(nameof(EncounterStatus_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HospitalizationAdmitSource = group.Add(new VocabularyKey(nameof(HospitalizationAdmitSource), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                HospitalizationDestination = group.Add(new VocabularyKey(nameof(HospitalizationDestination), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                HospitalizationDischargeDisposition = group.Add(new VocabularyKey(nameof(HospitalizationDischargeDisposition), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                HospitalizationOrigin = group.Add(new VocabularyKey(nameof(HospitalizationOrigin), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                HospitalizationPreAdmissionNumber = group.Add(new VocabularyKey(nameof(HospitalizationPreAdmissionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HospitalizationReadmission = group.Add(new VocabularyKey(nameof(HospitalizationReadmission), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                OnBehalfOf = group.Add(new VocabularyKey(nameof(OnBehalfOf), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                PeriodEnd = group.Add(new VocabularyKey(nameof(PeriodEnd), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                PeriodStart = group.Add(new VocabularyKey(nameof(PeriodStart), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Priority_display = group.Add(new VocabularyKey(nameof(Priority_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubjectPatient = group.Add(new VocabularyKey(nameof(SubjectPatient), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedBy { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedBy { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OwnerId { get; private set; }
        public VocabularyKey OwnerIdType { get; private set; }
        public VocabularyKey OwningBusinessUnit { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey OwningTeam { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey EncounterId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StateCode_display { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StatusCode_display { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey EmrAppointment { get; private set; }
        public VocabularyKey @Class { get; private set; }
        public VocabularyKey Class_display { get; private set; }
        public VocabularyKey ContextEncounter { get; private set; }
        public VocabularyKey ContextEpisodeofCare { get; private set; }
        public VocabularyKey Duration { get; private set; }
        public VocabularyKey EncounterClass { get; private set; }
        public VocabularyKey EncounterClass_display { get; private set; }
        public VocabularyKey EncounterEndDate { get; private set; }
        public VocabularyKey EncounterGroupIdentifier { get; private set; }
        public VocabularyKey EncounterIdentifier { get; private set; }
        public VocabularyKey EncounterLength { get; private set; }
        public VocabularyKey EncounterParentEncounterIdentifier { get; private set; }
        public VocabularyKey EncounterPatientIdentifier { get; private set; }
        public VocabularyKey EncounterPriority { get; private set; }
        public VocabularyKey EncounterStartDate { get; private set; }
        public VocabularyKey EncounterStatus { get; private set; }
        public VocabularyKey EncounterStatus_display { get; private set; }
        public VocabularyKey HospitalizationAdmitSource { get; private set; }
        public VocabularyKey HospitalizationDestination { get; private set; }
        public VocabularyKey HospitalizationDischargeDisposition { get; private set; }
        public VocabularyKey HospitalizationOrigin { get; private set; }
        public VocabularyKey HospitalizationPreAdmissionNumber { get; private set; }
        public VocabularyKey HospitalizationReadmission { get; private set; }
        public VocabularyKey OnBehalfOf { get; private set; }
        public VocabularyKey PeriodEnd { get; private set; }
        public VocabularyKey PeriodStart { get; private set; }
        public VocabularyKey Priority { get; private set; }
        public VocabularyKey Priority_display { get; private set; }
        public VocabularyKey SubjectPatient { get; private set; }
    }
}