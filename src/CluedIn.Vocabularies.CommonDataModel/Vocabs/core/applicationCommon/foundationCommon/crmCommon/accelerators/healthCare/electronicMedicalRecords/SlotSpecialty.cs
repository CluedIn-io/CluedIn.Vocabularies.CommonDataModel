using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class SlotSpecialtyVocabulary : SimpleVocabulary
    {
        public SlotSpecialtyVocabulary()
        {
            VocabularyName = "Slot Specialty";
            KeyPrefix = "commonDataModel.slotspecialty.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/SlotSpecialty";

            AddGroup("SlotSpecialty Details for ElectronicMedicalRecords", group =>
            {
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SlotSpecialtyId = group.Add(new VocabularyKey(nameof(SlotSpecialtyId), "Slot Specialty", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey SlotSpecialtyId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}