using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EpisodeOfCareVocabulary : SimpleVocabulary
    {
        public EpisodeOfCareVocabulary()
        {
            VocabularyName = "Episode Of Care";
            KeyPrefix = "commonDataModel.episodeofcare";
            KeySeparator = ".";
            Grouping = "/EpisodeOfCare";

            AddGroup("EpisodeOfCare Details", group =>
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
                EpisodeOfCareId = group.Add(new VocabularyKey(nameof(EpisodeOfCareId), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StateCode_display = group.Add(new VocabularyKey(nameof(StateCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                StatusCode_display = group.Add(new VocabularyKey(nameof(StatusCode_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CareManager = group.Add(new VocabularyKey(nameof(CareManager), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                EndDateTime = group.Add(new VocabularyKey(nameof(EndDateTime), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Identifier = group.Add(new VocabularyKey(nameof(Identifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Organization = group.Add(new VocabularyKey(nameof(Organization), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                Patient = group.Add(new VocabularyKey(nameof(Patient), VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible));
                StartDateTime = group.Add(new VocabularyKey(nameof(StartDateTime), VocabularyKeyDataType.DateTime, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Status_display = group.Add(new VocabularyKey(nameof(Status_display), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
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
        public VocabularyKey EpisodeOfCareId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StateCode_display { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey StatusCode_display { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey CareManager { get; private set; }
        public VocabularyKey EndDateTime { get; private set; }
        public VocabularyKey Identifier { get; private set; }
        public VocabularyKey Organization { get; private set; }
        public VocabularyKey Patient { get; private set; }
        public VocabularyKey StartDateTime { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Status_display { get; private set; }
    }
}