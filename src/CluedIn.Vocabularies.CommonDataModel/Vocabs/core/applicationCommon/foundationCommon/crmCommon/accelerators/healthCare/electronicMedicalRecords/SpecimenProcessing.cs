using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.ElectronicMedicalRecords
{
    public class SpecimenProcessingVocabulary : SimpleVocabulary
    {
        public SpecimenProcessingVocabulary()
        {
            VocabularyName = "Specimen Processing";
            KeyPrefix = "commonDataModel.specimenprocessing.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.SpecimenProcessing;

            AddGroup("SpecimenProcessing Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessingDescription = group.Add(new VocabularyKey(nameof(ProcessingDescription), "Processing Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessingTimeType = group.Add(new VocabularyKey(nameof(ProcessingTimeType), "Processing Time Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessingTimeTypeDateTime = group.Add(new VocabularyKey(nameof(ProcessingTimeTypeDateTime), "Processing Date Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessingTimeTypePeriodEndDate = group.Add(new VocabularyKey(nameof(ProcessingTimeTypePeriodEndDate), "Processing Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessingTimeTypePeriodStartDate = group.Add(new VocabularyKey(nameof(ProcessingTimeTypePeriodStartDate), "Processing Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SpecimenProcessingId = group.Add(new VocabularyKey(nameof(SpecimenProcessingId), "Specimen Processing", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="ProcessingProcedureId"/> to Vocab 'CodeableConcept.cdm.json/CodeableConcept' with Property 'CodeableConceptId'
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
            ///Property <see cref="SpecimenProcessingId"/> to Vocab 'SpecimenProcessing.cdm.json/SpecimenProcessing' with Property 'SpecimenProcessingId'
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
            ///Property <see cref="ProcessingAdditiveId"/> to Vocab 'Substance.cdm.json/Substance' with Property 'SubstanceId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="SpecimenProcessingId"/> from Vocab 'SpecimenProcessingAdditive.cdm.json/SpecimenProcessingAdditive' with Property 'SpecimenProcessingId'
            #endregion
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessingDescription { get; private set; }
        public VocabularyKey ProcessingTimeType { get; private set; }
        public VocabularyKey ProcessingTimeTypeDateTime { get; private set; }
        public VocabularyKey ProcessingTimeTypePeriodEndDate { get; private set; }
        public VocabularyKey ProcessingTimeTypePeriodStartDate { get; private set; }
        public VocabularyKey SpecimenProcessingId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}