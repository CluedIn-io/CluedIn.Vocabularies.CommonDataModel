using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class SpecimenRequestVocabulary : SimpleVocabulary
    {
        public SpecimenRequestVocabulary()
        {
            VocabularyName = "Specimen Request";
            KeyPrefix = "commonDataModel.specimenrequest.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/SpecimenRequest";

            AddGroup("SpecimenRequest Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SpecimenRequestId = group.Add(new VocabularyKey(nameof(SpecimenRequestId), "Specimen Request", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey SpecimenRequestId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}