using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class DeviceContactPointVocabulary : SimpleVocabulary
    {
        public DeviceContactPointVocabulary()
        {
            VocabularyName = "Device Contact Point";
            KeyPrefix = "commonDataModel.devicecontactpoint";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DeviceContactPoint;

            AddGroup("DeviceContactPoint Details for ElectronicMedicalRecords", group =>
            {
                ContactPointPeriodEndDate = group.Add(new VocabularyKey(nameof(ContactPointPeriodEndDate), "Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPointPeriodStartDate = group.Add(new VocabularyKey(nameof(ContactPointPeriodStartDate), "Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPointRank = group.Add(new VocabularyKey(nameof(ContactPointRank), "Rank", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ContactPointSystem = group.Add(new VocabularyKey(nameof(ContactPointSystem), "System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPointUse = group.Add(new VocabularyKey(nameof(ContactPointUse), "Use", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ContactPointValue = group.Add(new VocabularyKey(nameof(ContactPointValue), "Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeviceContactPointId = group.Add(new VocabularyKey(nameof(DeviceContactPointId), "Device Contact Point", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="DeviceIdentifierId"/> to Vocab 'Device.cdm.json/Device' with Property 'DeviceId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwnerId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OwningBusinessUnit"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningUser"/> to Vocab '/core/applicationCommon/foundationCommon/crmCommon/projectCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OwningTeam"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey ContactPointPeriodEndDate { get; private set; }
        public VocabularyKey ContactPointPeriodStartDate { get; private set; }
        public VocabularyKey ContactPointRank { get; private set; }
        public VocabularyKey ContactPointSystem { get; private set; }
        public VocabularyKey ContactPointUse { get; private set; }
        public VocabularyKey ContactPointValue { get; private set; }
        public VocabularyKey DeviceContactPointId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}