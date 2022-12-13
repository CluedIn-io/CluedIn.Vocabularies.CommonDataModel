using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class LayoutVocabulary : SimpleVocabulary
    {
        public LayoutVocabulary()
        {
            VocabularyName = "Layout";
            KeyPrefix = "commonDataModel.layout";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Layout;

            AddGroup("Layout Details for EventManagement", group =>
            {
                LayoutId = group.Add(new VocabularyKey(nameof(LayoutId), "Layout", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Capacity = group.Add(new VocabularyKey(nameof(Capacity), "Capacity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisabledAccess = group.Add(new VocabularyKey(nameof(DisabledAccess), "Disabled access", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisabledCapacity = group.Add(new VocabularyKey(nameof(DisabledCapacity), "Disabled capacity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                FloorPlan = group.Add(new VocabularyKey(nameof(FloorPlan), "Floor Plan", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Units = group.Add(new VocabularyKey(nameof(Units), "Units", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsableArea = group.Add(new VocabularyKey(nameof(UsableArea), "Usable area", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/service/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="Room"/> to Vocab 'Room.cdm.json/Room' with Property 'RoomId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey Capacity { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DisabledAccess { get; private set; }
        public VocabularyKey DisabledCapacity { get; private set; }
        public VocabularyKey FloorPlan { get; private set; }
        public VocabularyKey LayoutId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Units { get; private set; }
        public VocabularyKey UsableArea { get; private set; }
    }
}