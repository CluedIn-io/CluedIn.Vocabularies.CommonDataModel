using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CarePlanVocabulary : SimpleVocabulary
    {
        public CarePlanVocabulary()
        {
            VocabularyName = "Care Plan";
            KeyPrefix = "commonDataModel.careplan";
            KeySeparator = ".";
            Grouping = "/CarePlan";

            AddGroup("CarePlan Details", group =>
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
                CarePlanId = group.Add(new VocabularyKey(nameof(CarePlanId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StateCode_display = group.Add(new VocabularyKey(nameof(StateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StatusCode_display = group.Add(new VocabularyKey(nameof(StatusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Title = group.Add(new VocabularyKey(nameof(Title), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CarePlanIdentifier = group.Add(new VocabularyKey(nameof(CarePlanIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContextType = group.Add(new VocabularyKey(nameof(ContextType), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ContextType_display = group.Add(new VocabularyKey(nameof(ContextType_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EncounterIdentifier = group.Add(new VocabularyKey(nameof(EncounterIdentifier), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                EpisodeOfCare = group.Add(new VocabularyKey(nameof(EpisodeOfCare), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                GroupIdentifier = group.Add(new VocabularyKey(nameof(GroupIdentifier), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                PatientIdentifier = group.Add(new VocabularyKey(nameof(PatientIdentifier), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                PlanDescription = group.Add(new VocabularyKey(nameof(PlanDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanEndDate = group.Add(new VocabularyKey(nameof(PlanEndDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                PlanIntent = group.Add(new VocabularyKey(nameof(PlanIntent), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                PlanIntent_display = group.Add(new VocabularyKey(nameof(PlanIntent_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanStartDate = group.Add(new VocabularyKey(nameof(PlanStartDate), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                PlanStatus = group.Add(new VocabularyKey(nameof(PlanStatus), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                PlanStatus_display = group.Add(new VocabularyKey(nameof(PlanStatus_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                SubjectType_display = group.Add(new VocabularyKey(nameof(SubjectType_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
        public VocabularyKey CarePlanId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StateCode_display { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StatusCode_display { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey CarePlanIdentifier { get; private set; }
        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey ContextType_display { get; private set; }
        public VocabularyKey EncounterIdentifier { get; private set; }
        public VocabularyKey EpisodeOfCare { get; private set; }
        public VocabularyKey GroupIdentifier { get; private set; }
        public VocabularyKey PatientIdentifier { get; private set; }
        public VocabularyKey PlanDescription { get; private set; }
        public VocabularyKey PlanEndDate { get; private set; }
        public VocabularyKey PlanIntent { get; private set; }
        public VocabularyKey PlanIntent_display { get; private set; }
        public VocabularyKey PlanStartDate { get; private set; }
        public VocabularyKey PlanStatus { get; private set; }
        public VocabularyKey PlanStatus_display { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey SubjectType_display { get; private set; }
    }
}