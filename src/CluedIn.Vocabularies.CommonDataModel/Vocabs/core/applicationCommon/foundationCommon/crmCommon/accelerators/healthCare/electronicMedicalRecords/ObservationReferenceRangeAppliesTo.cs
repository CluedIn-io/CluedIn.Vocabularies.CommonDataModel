using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ObservationReferenceRangeAppliesToVocabulary : SimpleVocabulary
    {
        public ObservationReferenceRangeAppliesToVocabulary()
        {
            VocabularyName = "Observation Reference Range Applies To";
            KeyPrefix = "commonDataModel.observationreferencerangeappliesto.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ObservationReferenceRangeAppliesTo";

            AddGroup("ObservationReferenceRangeAppliesTo Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObservationReferenceRangeAppliesToId = group.Add(new VocabularyKey(nameof(ObservationReferenceRangeAppliesToId), "Observation Reference Range Applies To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObservationReferenceRangeAppliesToId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}