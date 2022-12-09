using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class DataRequirementVocabulary : SimpleVocabulary
    {
        public DataRequirementVocabulary()
        {
            VocabularyName = "Data Requirement";
            KeyPrefix = "commonDataModel.datarequirement";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.DataRequirement;

            AddGroup("DataRequirement Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DataRequirementId = group.Add(new VocabularyKey(nameof(DataRequirementId), "Data Requirement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="TypeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CodeFilterValueSetReferenceId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CodeFilterValueCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CodeFilterValueCodingId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="DataRequirementId"/> to Vocab 'DataRequirement.cdm.json/DataRequirement' with Property 'DataRequirementId'
            ///Property <see cref="DataRequirementId"/> to Vocab 'DataRequirement.cdm.json/DataRequirement' with Property 'DataRequirementId'
            ///Property <see cref="DataRequirementId"/> to Vocab 'DataRequirement.cdm.json/DataRequirement' with Property 'DataRequirementId'
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
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="DataRequirementId"/> from Vocab 'DataRequirementCodeFilter.cdm.json/DataRequirementCodeFilter' with Property 'DataRequirementId'
            ///Property <see cref="DataRequirementId"/> from Vocab 'DataRequirementDateFilter.cdm.json/DataRequirementDateFilter' with Property 'DataRequirementId'
            ///Property <see cref="DataRequirementId"/> from Vocab 'DataRequirementMustSupport.cdm.json/DataRequirementMustSupport' with Property 'DataRequirementId'
            ///Property <see cref="DataRequirementId"/> from Vocab 'DataRequirementProfile.cdm.json/DataRequirementProfile' with Property 'DataRequirementId'
            ///Property <see cref="DataRequirementId"/> from Vocab 'PlanDefinitionActionInput.cdm.json/PlanDefinitionActionInput' with Property 'ActionInputId'
            ///Property <see cref="DataRequirementId"/> from Vocab 'PlanDefinitionActionOutput.cdm.json/PlanDefinitionActionOutput' with Property 'ActionOutputId'
            ///Property <see cref="DataRequirementId"/> from Vocab 'PlanDefinitionActionTriggerDefinition.cdm.json/PlanDefinitionActionTriggerDefinition' with Property 'EventDataId'
            ///Property <see cref="DataRequirementCodeFilterId"/> from Vocab 'DataRequirementCodeFilterValueCode.cdm.json/DataRequirementCodeFilterValueCode' with Property 'DataRequirementCodeFilterId'
            ///Property <see cref="DataRequirementCodeFilterId"/> from Vocab 'DataReqCodeFilterValueCodeableConcept.cdm.json/DataReqCodeFilterValueCodeableConcept' with Property 'DataRequirementCodeFilterId'
            ///Property <see cref="DataRequirementCodeFilterId"/> from Vocab 'DataRequirementCodeFilterValueCoding.cdm.json/DataRequirementCodeFilterValueCoding' with Property 'DataRequirementCodeFilterId'
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey DataRequirementId { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}