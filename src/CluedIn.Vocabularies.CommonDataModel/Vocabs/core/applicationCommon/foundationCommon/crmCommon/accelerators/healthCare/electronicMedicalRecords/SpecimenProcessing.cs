using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class SpecimenProcessingVocabulary : SimpleVocabulary
    {
        public SpecimenProcessingVocabulary()
        {
            VocabularyName = "Specimen Processing";
            KeyPrefix = "commonDataModel.specimenprocessing.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/SpecimenProcessing";

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