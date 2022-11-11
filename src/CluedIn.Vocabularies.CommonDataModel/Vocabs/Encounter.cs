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
                createdOn = group.Add(new VocabularyKey(nameof(createdOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                createdBy = group.Add(new VocabularyKey(nameof(createdBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                modifiedOn = group.Add(new VocabularyKey(nameof(modifiedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                modifiedBy = group.Add(new VocabularyKey(nameof(modifiedBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                createdOnBehalfBy = group.Add(new VocabularyKey(nameof(createdOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                modifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(modifiedOnBehalfBy), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                overriddenCreatedOn = group.Add(new VocabularyKey(nameof(overriddenCreatedOn), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                importSequenceNumber = group.Add(new VocabularyKey(nameof(importSequenceNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ownerId = group.Add(new VocabularyKey(nameof(ownerId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                ownerIdType = group.Add(new VocabularyKey(nameof(ownerIdType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                owningBusinessUnit = group.Add(new VocabularyKey(nameof(owningBusinessUnit), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                owningUser = group.Add(new VocabularyKey(nameof(owningUser), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                owningTeam = group.Add(new VocabularyKey(nameof(owningTeam), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                timeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(timeZoneRuleVersionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                versionNumber = group.Add(new VocabularyKey(nameof(versionNumber), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                encounterId = group.Add(new VocabularyKey(nameof(encounterId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                stateCode_display = group.Add(new VocabularyKey(nameof(stateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                statusCode_display = group.Add(new VocabularyKey(nameof(statusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                name = group.Add(new VocabularyKey(nameof(name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                emrAppointment = group.Add(new VocabularyKey(nameof(emrAppointment), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                @class = group.Add(new VocabularyKey(nameof(@class), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                class_display = group.Add(new VocabularyKey(nameof(class_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                contextEncounter = group.Add(new VocabularyKey(nameof(contextEncounter), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                contextEpisodeofCare = group.Add(new VocabularyKey(nameof(contextEpisodeofCare), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                duration = group.Add(new VocabularyKey(nameof(duration), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                encounterClass = group.Add(new VocabularyKey(nameof(encounterClass), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                encounterClass_display = group.Add(new VocabularyKey(nameof(encounterClass_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                encounterEndDate = group.Add(new VocabularyKey(nameof(encounterEndDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                encounterGroupIdentifier = group.Add(new VocabularyKey(nameof(encounterGroupIdentifier), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                encounterIdentifier = group.Add(new VocabularyKey(nameof(encounterIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                encounterLength = group.Add(new VocabularyKey(nameof(encounterLength), VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                encounterParentEncounterIdentifier = group.Add(new VocabularyKey(nameof(encounterParentEncounterIdentifier), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                encounterPatientIdentifier = group.Add(new VocabularyKey(nameof(encounterPatientIdentifier), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                encounterPriority = group.Add(new VocabularyKey(nameof(encounterPriority), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                encounterStartDate = group.Add(new VocabularyKey(nameof(encounterStartDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                encounterStatus = group.Add(new VocabularyKey(nameof(encounterStatus), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                encounterStatus_display = group.Add(new VocabularyKey(nameof(encounterStatus_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                hospitalizationAdmitSource = group.Add(new VocabularyKey(nameof(hospitalizationAdmitSource), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                hospitalizationDestination = group.Add(new VocabularyKey(nameof(hospitalizationDestination), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                hospitalizationDischargeDisposition = group.Add(new VocabularyKey(nameof(hospitalizationDischargeDisposition), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                hospitalizationOrigin = group.Add(new VocabularyKey(nameof(hospitalizationOrigin), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                hospitalizationPreAdmissionNumber = group.Add(new VocabularyKey(nameof(hospitalizationPreAdmissionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                hospitalizationReadmission = group.Add(new VocabularyKey(nameof(hospitalizationReadmission), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                onBehalfOf = group.Add(new VocabularyKey(nameof(onBehalfOf), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                periodEnd = group.Add(new VocabularyKey(nameof(periodEnd), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                periodStart = group.Add(new VocabularyKey(nameof(periodStart), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                priority = group.Add(new VocabularyKey(nameof(priority), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                priority_display = group.Add(new VocabularyKey(nameof(priority_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                subjectPatient = group.Add(new VocabularyKey(nameof(subjectPatient), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey createdOn { get; private set; }
        public VocabularyKey createdBy { get; private set; }
        public VocabularyKey modifiedOn { get; private set; }
        public VocabularyKey modifiedBy { get; private set; }
        public VocabularyKey createdOnBehalfBy { get; private set; }
        public VocabularyKey modifiedOnBehalfBy { get; private set; }
        public VocabularyKey overriddenCreatedOn { get; private set; }
        public VocabularyKey importSequenceNumber { get; private set; }
        public VocabularyKey ownerId { get; private set; }
        public VocabularyKey ownerIdType { get; private set; }
        public VocabularyKey owningBusinessUnit { get; private set; }
        public VocabularyKey owningUser { get; private set; }
        public VocabularyKey owningTeam { get; private set; }
        public VocabularyKey timeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey versionNumber { get; private set; }
        public VocabularyKey encounterId { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey stateCode_display { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey statusCode_display { get; private set; }
        public VocabularyKey name { get; private set; }
        public VocabularyKey emrAppointment { get; private set; }
        public VocabularyKey @class { get; private set; }
        public VocabularyKey class_display { get; private set; }
        public VocabularyKey contextEncounter { get; private set; }
        public VocabularyKey contextEpisodeofCare { get; private set; }
        public VocabularyKey duration { get; private set; }
        public VocabularyKey encounterClass { get; private set; }
        public VocabularyKey encounterClass_display { get; private set; }
        public VocabularyKey encounterEndDate { get; private set; }
        public VocabularyKey encounterGroupIdentifier { get; private set; }
        public VocabularyKey encounterIdentifier { get; private set; }
        public VocabularyKey encounterLength { get; private set; }
        public VocabularyKey encounterParentEncounterIdentifier { get; private set; }
        public VocabularyKey encounterPatientIdentifier { get; private set; }
        public VocabularyKey encounterPriority { get; private set; }
        public VocabularyKey encounterStartDate { get; private set; }
        public VocabularyKey encounterStatus { get; private set; }
        public VocabularyKey encounterStatus_display { get; private set; }
        public VocabularyKey hospitalizationAdmitSource { get; private set; }
        public VocabularyKey hospitalizationDestination { get; private set; }
        public VocabularyKey hospitalizationDischargeDisposition { get; private set; }
        public VocabularyKey hospitalizationOrigin { get; private set; }
        public VocabularyKey hospitalizationPreAdmissionNumber { get; private set; }
        public VocabularyKey hospitalizationReadmission { get; private set; }
        public VocabularyKey onBehalfOf { get; private set; }
        public VocabularyKey periodEnd { get; private set; }
        public VocabularyKey periodStart { get; private set; }
        public VocabularyKey priority { get; private set; }
        public VocabularyKey priority_display { get; private set; }
        public VocabularyKey subjectPatient { get; private set; }


    }
}