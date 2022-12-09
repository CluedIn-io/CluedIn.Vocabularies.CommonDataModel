using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class SubstanceVocabulary : SimpleVocabulary
    {
        public SubstanceVocabulary()
        {
            VocabularyName = "Substance";
            KeyPrefix = "commonDataModel.substance";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Substance;

            AddGroup("Substance Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubstanceId = group.Add(new VocabularyKey(nameof(SubstanceId), "Substance", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubstanceNumber = group.Add(new VocabularyKey(nameof(SubstanceNumber), "Substance Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CategoryId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="IngredientQuantityDenominatorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="IngredientQuantityNumeratorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="IngredientSubstanceCodeableConceptId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            ///Property <see cref="SubstanceId"/> to Vocab 'Substance.cdm.json/Substance' with Property 'SubstanceId'
            ///Property <see cref="SubstanceId"/> to Vocab 'Substance.cdm.json/Substance' with Property 'SubstanceId'
            ///Property <see cref="SubstanceReferenceId"/> to Vocab 'Substance.cdm.json/Substance' with Property 'SubstanceId'
            ///Property <see cref="SubstanceId"/> to Vocab 'Substance.cdm.json/Substance' with Property 'SubstanceId'
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
            ///Property <see cref="SubstanceId"/> from Vocab 'CarePlanActivity.cdm.json/CarePlanActivity' with Property 'ActivityProductReferenceTypeSubstanceId'
            ///Property <see cref="SubstanceId"/> from Vocab 'ActivityDefinition.cdm.json/ActivityDefinition' with Property 'ProductsubstanceId'
            ///Property <see cref="SubstanceId"/> from Vocab 'MedicationIngredient.cdm.json/MedicationIngredient' with Property 'IngredientItemSubstanceId'
            ///Property <see cref="SubstanceId"/> from Vocab 'ProcedureUsedReference.cdm.json/ProcedureUsedReference' with Property 'RefSubstanceId'
            ///Property <see cref="SubstanceId"/> from Vocab 'Specimen.cdm.json/Specimen' with Property 'SubjectTypeSubstanceId'
            ///Property <see cref="SubstanceId"/> from Vocab 'SpecimenContainer.cdm.json/SpecimenContainer' with Property 'ContainerAdditiveReferenceId'
            ///Property <see cref="SubstanceId"/> from Vocab 'SpecimenProcessingAdditive.cdm.json/SpecimenProcessingAdditive' with Property 'ProcessingAdditiveId'
            ///Property <see cref="SubstanceId"/> from Vocab 'SubstanceCategory.cdm.json/SubstanceCategory' with Property 'SubstanceId'
            ///Property <see cref="SubstanceId"/> from Vocab 'SubstanceIngredient.cdm.json/SubstanceIngredient' with Property 'SubstanceId'
            ///Property <see cref="SubstanceId"/> from Vocab 'SubstanceIngredient.cdm.json/SubstanceIngredient' with Property 'SubstanceReferenceId'
            ///Property <see cref="SubstanceId"/> from Vocab 'SubstanceInstance.cdm.json/SubstanceInstance' with Property 'SubstanceId'
            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubstanceId { get; private set; }
        public VocabularyKey SubstanceNumber { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}