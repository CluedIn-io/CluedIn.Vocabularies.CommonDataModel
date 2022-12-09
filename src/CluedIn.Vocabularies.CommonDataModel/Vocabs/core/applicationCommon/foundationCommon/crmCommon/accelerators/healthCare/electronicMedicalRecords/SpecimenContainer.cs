using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class SpecimenContainerVocabulary : SimpleVocabulary
    {
        public SpecimenContainerVocabulary()
        {
            VocabularyName = "Specimen Container";
            KeyPrefix = "commonDataModel.specimencontainer";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SpecimenContainer;

            AddGroup("SpecimenContainer Details for ElectronicMedicalRecords", group =>
            {
			    ContainerAdditiveType = group.Add(new VocabularyKey(nameof(ContainerAdditiveType), "Container Additive Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContainerCapacity = group.Add(new VocabularyKey(nameof(ContainerCapacity), "Container Capacity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ContainerDescription = group.Add(new VocabularyKey(nameof(ContainerDescription), "Container Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContainerNumber = group.Add(new VocabularyKey(nameof(ContainerNumber), "Container Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContainerSpecimenQuantity = group.Add(new VocabularyKey(nameof(ContainerSpecimenQuantity), "Specimen Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SpecimenContainerId = group.Add(new VocabularyKey(nameof(SpecimenContainerId), "Specimen Container", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="ContainerAdditiveCodeableConceptId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="ContainerTypeId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
            ///Property <see cref="SpecimenId"/> to Vocab 'Specimen.cdm.json/Specimen' with Property 'SpecimenId'
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
            ///Property <see cref="ContainerAdditiveReferenceId"/> to Vocab 'Substance.cdm.json/Substance' with Property 'SubstanceId'
            #endregion
            
            #region Outgoing Relationships
            
            #endregion
        }

        public VocabularyKey ContainerAdditiveType { get; private set; }
        public VocabularyKey ContainerCapacity { get; private set; }
        public VocabularyKey ContainerDescription { get; private set; }
        public VocabularyKey ContainerNumber { get; private set; }
        public VocabularyKey ContainerSpecimenQuantity { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey SpecimenContainerId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}