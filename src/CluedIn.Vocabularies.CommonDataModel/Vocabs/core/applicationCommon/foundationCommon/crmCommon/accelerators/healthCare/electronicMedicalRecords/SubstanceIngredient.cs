using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class SubstanceIngredientVocabulary : SimpleVocabulary
    {
        public SubstanceIngredientVocabulary()
        {
            VocabularyName = "Substance Ingredient";
            KeyPrefix = "commonDataModel.substanceingredient";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SubstanceIngredient;

            AddGroup("SubstanceIngredient Details for ElectronicMedicalRecords", group =>
            {
                CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IngredientQuantityDenominatorComparator = group.Add(new VocabularyKey(nameof(IngredientQuantityDenominatorComparator), "Quantity Denominator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IngredientQuantityDenominatorSystem = group.Add(new VocabularyKey(nameof(IngredientQuantityDenominatorSystem), "Quantity Denominator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IngredientQuantityDenominatorUnit = group.Add(new VocabularyKey(nameof(IngredientQuantityDenominatorUnit), "Quantity Denominator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IngredientQuantityDenominatorValue = group.Add(new VocabularyKey(nameof(IngredientQuantityDenominatorValue), "Quantity Denominator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                IngredientQuantityNumeratorComparator = group.Add(new VocabularyKey(nameof(IngredientQuantityNumeratorComparator), "Quantity Numerator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IngredientQuantityNumeratorSystem = group.Add(new VocabularyKey(nameof(IngredientQuantityNumeratorSystem), "Quantity Numerator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IngredientQuantityNumeratorUnit = group.Add(new VocabularyKey(nameof(IngredientQuantityNumeratorUnit), "Quantity Numerator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IngredientQuantityNumeratorValue = group.Add(new VocabularyKey(nameof(IngredientQuantityNumeratorValue), "Quantity Numerator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));
                IngredientSubstanceType = group.Add(new VocabularyKey(nameof(IngredientSubstanceType), "Ingredient Substance Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubstanceIngredientId = group.Add(new VocabularyKey(nameof(SubstanceIngredientId), "Substance Ingredient", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
                UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));
            });

            #region Incoming Relationships
            ///Property <see cref="IngredientQuantityDenominatorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="IngredientQuantityNumeratorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="IngredientSubstanceCodeableConceptId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="SubstanceId"/> to Vocab 'Substance.cdm.json/Substance' with Property 'SubstanceId'
            ///Property <see cref="SubstanceReferenceId"/> to Vocab 'Substance.cdm.json/Substance' with Property 'SubstanceId'
            ///Property <see cref="CreatedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="ModifiedBy"/> to Vocab '/core/applicationCommon/User.cdm.json/User' with Property 'SystemUserId'
            ///Property <see cref="OrganizationId"/> to Vocab '/core/applicationCommon/Organization.cdm.json/Organization' with Property 'OrganizationId'
            #endregion

            #region Outgoing Relationships

            #endregion
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey IngredientQuantityDenominatorComparator { get; private set; }
        public VocabularyKey IngredientQuantityDenominatorSystem { get; private set; }
        public VocabularyKey IngredientQuantityDenominatorUnit { get; private set; }
        public VocabularyKey IngredientQuantityDenominatorValue { get; private set; }
        public VocabularyKey IngredientQuantityNumeratorComparator { get; private set; }
        public VocabularyKey IngredientQuantityNumeratorSystem { get; private set; }
        public VocabularyKey IngredientQuantityNumeratorUnit { get; private set; }
        public VocabularyKey IngredientQuantityNumeratorValue { get; private set; }
        public VocabularyKey IngredientSubstanceType { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SubstanceIngredientId { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}