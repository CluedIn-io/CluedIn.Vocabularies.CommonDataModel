using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class ResourceSpecificationVocabulary : SimpleVocabulary
    {
        public ResourceSpecificationVocabulary()
        {
            VocabularyName = "Resource Specification";
            KeyPrefix = "commonDataModel.resourcespecification";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ResourceSpecification;

            AddGroup("ResourceSpecification Details for Service", group =>
            {
                ResourceSpecId = group.Add(new VocabularyKey(nameof(ResourceSpecId), "Resource Spec", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Constraints = group.Add(new VocabularyKey(nameof(Constraints), "Constraints", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EffortRequired = group.Add(new VocabularyKey(nameof(EffortRequired), "Effort Required", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                ObjectiveExpression = group.Add(new VocabularyKey(nameof(ObjectiveExpression), "Objective Expression", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ObjectTypeCode = group.Add(new VocabularyKey(nameof(ObjectTypeCode), "Object Type ", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RequiredCount = group.Add(new VocabularyKey(nameof(RequiredCount), "Required Count", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                SameSite = group.Add(new VocabularyKey(nameof(SameSite), "Same Site", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="CreatedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedOnBehalfBy"/> to Vocab 'User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="BusinessUnitId"/> to Vocab '/core/applicationCommon/BusinessUnit.cdm.json/BusinessUnit' with Property 'BusinessUnitId'
            ///Property <see cref="GroupObjectId"/> to Vocab '/core/applicationCommon/Team.cdm.json/Team' with Property 'TeamId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/foundationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion

            #region Outgoing Relationships
            ///Property <see cref="ResourceSpecId"/> from Vocab 'ActivityParty.cdm.json/ActivityParty' with Property 'ResourceSpecId'
            ///Property <see cref="ResourceSpecId"/> from Vocab 'Resource.cdm.json/Resource' with Property 'ResourceId'
            ///Property <see cref="ResourceSpecId"/> from Vocab 'Service.cdm.json/Service' with Property 'ResourceSpecId'
            #endregion
        }

        public VocabularyKey Constraints { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EffortRequired { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObjectiveExpression { get; private set; }
        public VocabularyKey ObjectTypeCode { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey RequiredCount { get; private set; }
        public VocabularyKey ResourceSpecId { get; private set; }
        public VocabularyKey SameSite { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
    }
}