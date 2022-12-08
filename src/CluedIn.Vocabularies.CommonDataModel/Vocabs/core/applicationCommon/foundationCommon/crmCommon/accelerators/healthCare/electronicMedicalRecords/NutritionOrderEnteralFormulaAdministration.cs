using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class NutritionOrderEnteralFormulaAdministrationVocabulary : SimpleVocabulary
    {
        public NutritionOrderEnteralFormulaAdministrationVocabulary()
        {
            VocabularyName = "Nutrition Order Enteral Formula Administration";
            KeyPrefix = "commonDataModel.nutritionorderenteralformulaadministration.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.NutritionOrderEnteralFormulaAdministration;

            AddGroup("NutritionOrderEnteralFormulaAdministration Details for ElectronicMedicalRecords", group =>
            {
			    AdministrationQuantity = group.Add(new VocabularyKey(nameof(AdministrationQuantity), "Administration Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AdministrationRateQuantity = group.Add(new VocabularyKey(nameof(AdministrationRateQuantity), "Rate Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AdministrationRateType = group.Add(new VocabularyKey(nameof(AdministrationRateType), "Rate Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NutritionorderenteralformulaadministratId = group.Add(new VocabularyKey(nameof(NutritionorderenteralformulaadministratId), "Nutrition Order Enteral Formula Administration", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityDenominatorComparator = group.Add(new VocabularyKey(nameof(RateRatioQuantityDenominatorComparator), "Ratio Denominator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityDenominatorUnit = group.Add(new VocabularyKey(nameof(RateRatioQuantityDenominatorUnit), "Ratio Denominator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityDenominatorValue = group.Add(new VocabularyKey(nameof(RateRatioQuantityDenominatorValue), "Ratio Denominator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityNumeratorComparator = group.Add(new VocabularyKey(nameof(RateRatioQuantityNumeratorComparator), "Ratio Numerator Comparator", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityNumeratorSystem = group.Add(new VocabularyKey(nameof(RateRatioQuantityNumeratorSystem), "Ratio Numerator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityNumeratorUnit = group.Add(new VocabularyKey(nameof(RateRatioQuantityNumeratorUnit), "Ratio Numerator Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RateRatioQuantityNumeratorValue = group.Add(new VocabularyKey(nameof(RateRatioQuantityNumeratorValue), "Ratio Numerator Value", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RateRatiotQuantityDenominatorSystem = group.Add(new VocabularyKey(nameof(RateRatiotQuantityDenominatorSystem), "Ratio Denominator System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="RateRatioQuantityDenominatorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="RateRatioQuantityNumeratorCodeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="NutritionOrderId"/> to Vocab 'NutritionOrder.cdm.json/NutritionOrder' with Property 'NutritionOrderId'
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
            ///Property <see cref="AdministrationScheduleId"/> to Vocab 'Timing.cdm.json/Timing' with Property 'TimingId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey AdministrationQuantity { get; private set; }
        public VocabularyKey AdministrationRateQuantity { get; private set; }
        public VocabularyKey AdministrationRateType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NutritionorderenteralformulaadministratId { get; private set; }
        public VocabularyKey RateRatioQuantityDenominatorComparator { get; private set; }
        public VocabularyKey RateRatioQuantityDenominatorUnit { get; private set; }
        public VocabularyKey RateRatioQuantityDenominatorValue { get; private set; }
        public VocabularyKey RateRatioQuantityNumeratorComparator { get; private set; }
        public VocabularyKey RateRatioQuantityNumeratorSystem { get; private set; }
        public VocabularyKey RateRatioQuantityNumeratorUnit { get; private set; }
        public VocabularyKey RateRatioQuantityNumeratorValue { get; private set; }
        public VocabularyKey RateRatiotQuantityDenominatorSystem { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}