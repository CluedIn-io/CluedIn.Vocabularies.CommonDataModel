using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class VisionPrescriptionDispenseVocabulary : SimpleVocabulary
    {
        public VisionPrescriptionDispenseVocabulary()
        {
            VocabularyName = "Vision Prescription Dispense";
            KeyPrefix = "commonDataModel.visionprescriptiondispense.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.VisionPrescriptionDispense;

            AddGroup("VisionPrescriptionDispense Details for ElectronicMedicalRecords", group =>
            {
			    DispenseAdd = group.Add(new VocabularyKey(nameof(DispenseAdd), "Add", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DispenseAxis = group.Add(new VocabularyKey(nameof(DispenseAxis), "Axis", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DispenseBackCurve = group.Add(new VocabularyKey(nameof(DispenseBackCurve), "Back Curve", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DispenseBase = group.Add(new VocabularyKey(nameof(DispenseBase), "Base", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DispenseBrand = group.Add(new VocabularyKey(nameof(DispenseBrand), "Brand", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DispenseColor = group.Add(new VocabularyKey(nameof(DispenseColor), "Color", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DispenseCylinder = group.Add(new VocabularyKey(nameof(DispenseCylinder), "Cylinder", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DispenseDiameter = group.Add(new VocabularyKey(nameof(DispenseDiameter), "Diameter", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DispenseDuration = group.Add(new VocabularyKey(nameof(DispenseDuration), "Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DispenseEye = group.Add(new VocabularyKey(nameof(DispenseEye), "Eye", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DispensePower = group.Add(new VocabularyKey(nameof(DispensePower), "Power", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DispensePrism = group.Add(new VocabularyKey(nameof(DispensePrism), "Prism", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    DispenseSphere = group.Add(new VocabularyKey(nameof(DispenseSphere), "Sphere", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VisionprescriptiondispensId = group.Add(new VocabularyKey(nameof(VisionprescriptiondispensId), "Vision Prescription Dispense", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="DispenseProductId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="VisionPrescriptionId"/> to Vocab 'VisionPrescription.cdm.json/VisionPrescription' with Property 'VisionPrescriptionId'
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

        public VocabularyKey DispenseAdd { get; private set; }
        public VocabularyKey DispenseAxis { get; private set; }
        public VocabularyKey DispenseBackCurve { get; private set; }
        public VocabularyKey DispenseBase { get; private set; }
        public VocabularyKey DispenseBrand { get; private set; }
        public VocabularyKey DispenseColor { get; private set; }
        public VocabularyKey DispenseCylinder { get; private set; }
        public VocabularyKey DispenseDiameter { get; private set; }
        public VocabularyKey DispenseDuration { get; private set; }
        public VocabularyKey DispenseEye { get; private set; }
        public VocabularyKey DispensePower { get; private set; }
        public VocabularyKey DispensePrism { get; private set; }
        public VocabularyKey DispenseSphere { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey VisionprescriptiondispensId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}