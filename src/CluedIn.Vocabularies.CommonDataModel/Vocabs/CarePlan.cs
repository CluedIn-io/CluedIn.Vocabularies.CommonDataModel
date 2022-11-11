using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CarePlanVocabulary : SimpleVocabulary
    {
        public CarePlanVocabulary()
        {
            VocabularyName = "CarePlan";
            KeyPrefix = "commonDataModel.careplan";
            KeySeparator = ".";
            Grouping = "/CarePlan";

            AddGroup("CarePlan Details", group =>
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
                carePlanId = group.Add(new VocabularyKey(nameof(carePlanId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                stateCode = group.Add(new VocabularyKey(nameof(stateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                stateCode_display = group.Add(new VocabularyKey(nameof(stateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                statusCode = group.Add(new VocabularyKey(nameof(statusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                statusCode_display = group.Add(new VocabularyKey(nameof(statusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                title = group.Add(new VocabularyKey(nameof(title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                carePlanIdentifier = group.Add(new VocabularyKey(nameof(carePlanIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                contextType = group.Add(new VocabularyKey(nameof(contextType), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                contextType_display = group.Add(new VocabularyKey(nameof(contextType_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                encounterIdentifier = group.Add(new VocabularyKey(nameof(encounterIdentifier), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                episodeOfCare = group.Add(new VocabularyKey(nameof(episodeOfCare), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                groupIdentifier = group.Add(new VocabularyKey(nameof(groupIdentifier), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                patientIdentifier = group.Add(new VocabularyKey(nameof(patientIdentifier), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                planDescription = group.Add(new VocabularyKey(nameof(planDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                planEndDate = group.Add(new VocabularyKey(nameof(planEndDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                planIntent = group.Add(new VocabularyKey(nameof(planIntent), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                planIntent_display = group.Add(new VocabularyKey(nameof(planIntent_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                planStartDate = group.Add(new VocabularyKey(nameof(planStartDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                planStatus = group.Add(new VocabularyKey(nameof(planStatus), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                planStatus_display = group.Add(new VocabularyKey(nameof(planStatus_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                subjectType = group.Add(new VocabularyKey(nameof(subjectType), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                subjectType_display = group.Add(new VocabularyKey(nameof(subjectType_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

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
        public VocabularyKey carePlanId { get; private set; }
        public VocabularyKey stateCode { get; private set; }
        public VocabularyKey stateCode_display { get; private set; }
        public VocabularyKey statusCode { get; private set; }
        public VocabularyKey statusCode_display { get; private set; }
        public VocabularyKey title { get; private set; }
        public VocabularyKey carePlanIdentifier { get; private set; }
        public VocabularyKey contextType { get; private set; }
        public VocabularyKey contextType_display { get; private set; }
        public VocabularyKey encounterIdentifier { get; private set; }
        public VocabularyKey episodeOfCare { get; private set; }
        public VocabularyKey groupIdentifier { get; private set; }
        public VocabularyKey patientIdentifier { get; private set; }
        public VocabularyKey planDescription { get; private set; }
        public VocabularyKey planEndDate { get; private set; }
        public VocabularyKey planIntent { get; private set; }
        public VocabularyKey planIntent_display { get; private set; }
        public VocabularyKey planStartDate { get; private set; }
        public VocabularyKey planStatus { get; private set; }
        public VocabularyKey planStatus_display { get; private set; }
        public VocabularyKey subjectType { get; private set; }
        public VocabularyKey subjectType_display { get; private set; }


    }
}