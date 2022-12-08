using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class DataRequirementCodeFilterVocabulary : SimpleVocabulary
    {
        public DataRequirementCodeFilterVocabulary()
        {
            VocabularyName = "Data Requirement Code Filter";
            KeyPrefix = "commonDataModel.datarequirementcodefilter.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DataRequirementCodeFilter;

            AddGroup("DataRequirementCodeFilter Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CodeFilterPath = group.Add(new VocabularyKey(nameof(CodeFilterPath), "Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CodeFilterValueSetString = group.Add(new VocabularyKey(nameof(CodeFilterValueSetString), "Value Set String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CodeFilterValueSetType = group.Add(new VocabularyKey(nameof(CodeFilterValueSetType), "Value Set Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataRequirementCodeFilterId = group.Add(new VocabularyKey(nameof(DataRequirementCodeFilterId), "Data Requirement Code Filter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="CodeFilterValueSetReferenceId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CodeFilterValueCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CodeFilterValueCodingId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="DataRequirementId"/> to Vocab 'DataRequirement.cdm.json/DataRequirement' with Property 'DataRequirementId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="DataRequirementCodeFilterId"/> to Vocab 'DataRequirementCodeFilter.cdm.json/DataRequirementCodeFilter' with Property 'DataRequirementCodeFilterId'
            ///Property <see cref="DataRequirementCodeFilterId"/> to Vocab 'DataRequirementCodeFilter.cdm.json/DataRequirementCodeFilter' with Property 'DataRequirementCodeFilterId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="DataRequirementCodeFilterId"/> from Vocab 'DataRequirementCodeFilterValueCode.cdm.json/DataRequirementCodeFilterValueCode' with Property 'DataRequirementCodeFilterId'
            ///Property <see cref="DataRequirementCodeFilterId"/> from Vocab 'DataReqCodeFilterValueCodeableConcept.cdm.json/DataReqCodeFilterValueCodeableConcept' with Property 'DataRequirementCodeFilterId'
            ///Property <see cref="DataRequirementCodeFilterId"/> from Vocab 'DataRequirementCodeFilterValueCoding.cdm.json/DataRequirementCodeFilterValueCoding' with Property 'DataRequirementCodeFilterId'
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey CodeFilterPath { get; private set; }
        public VocabularyKey CodeFilterValueSetString { get; private set; }
        public VocabularyKey CodeFilterValueSetType { get; private set; }
        public VocabularyKey DataRequirementCodeFilterId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}