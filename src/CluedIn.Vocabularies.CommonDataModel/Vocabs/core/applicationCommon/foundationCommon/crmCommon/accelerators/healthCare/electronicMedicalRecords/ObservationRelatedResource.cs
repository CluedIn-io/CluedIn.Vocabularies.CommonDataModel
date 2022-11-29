using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ObservationRelatedResourceVocabulary : SimpleVocabulary
    {
        public ObservationRelatedResourceVocabulary()
        {
            VocabularyName = "Observation Related Resource";
            KeyPrefix = "commonDataModel.observationrelatedresource.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ObservationRelatedResource";

            AddGroup("ObservationRelatedResource Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObservationRelatedResourceId = group.Add(new VocabularyKey(nameof(ObservationRelatedResourceId), "Observation Related Resource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObsRelatedResourceTargetType = group.Add(new VocabularyKey(nameof(ObsRelatedResourceTargetType), "Target Resource Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObsRelatedResourceType = group.Add(new VocabularyKey(nameof(ObsRelatedResourceType), "Related Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey ObservationRelatedResourceId { get; private set; }
        public VocabularyKey ObsRelatedResourceTargetType { get; private set; }
        public VocabularyKey ObsRelatedResourceType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}