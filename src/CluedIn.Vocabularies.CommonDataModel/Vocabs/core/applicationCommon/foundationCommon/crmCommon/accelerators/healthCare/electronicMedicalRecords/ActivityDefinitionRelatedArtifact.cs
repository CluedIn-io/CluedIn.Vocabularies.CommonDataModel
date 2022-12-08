using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class ActivityDefinitionRelatedArtifactVocabulary : SimpleVocabulary
    {
        public ActivityDefinitionRelatedArtifactVocabulary()
        {
            VocabularyName = "Activity Definition Related Artifact";
            KeyPrefix = "commonDataModel.activitydefinitionrelatedartifact.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.ActivityDefinitionRelatedArtifact;

            AddGroup("ActivityDefinitionRelatedArtifact Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityDefinitionRelatedArtifactId = group.Add(new VocabularyKey(nameof(ActivityDefinitionRelatedArtifactId), "Activity Definition Related Artifact", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Citation = group.Add(new VocabularyKey(nameof(Citation), "Citation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Display = group.Add(new VocabularyKey(nameof(Display), "Display Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Resource = group.Add(new VocabularyKey(nameof(Resource), "Resource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Artifact Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    URI = group.Add(new VocabularyKey(nameof(URI), "URL", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ActivityDefinitionId"/> to Vocab 'ActivityDefinition.cdm.json/ActivityDefinition' with Property 'IdentifiesspecifictimeswhentheeventoccuId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey ActivityDefinitionRelatedArtifactId { get; private set; }
        public VocabularyKey Citation { get; private set; }
        public VocabularyKey Display { get; private set; }
        public VocabularyKey Resource { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey URI { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}