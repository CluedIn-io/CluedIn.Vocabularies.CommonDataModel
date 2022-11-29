using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class SlotVocabulary : SimpleVocabulary
    {
        public SlotVocabulary()
        {
            VocabularyName = "Slot";
            KeyPrefix = "commonDataModel.slot.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Slot";

            AddGroup("Slot Details for ElectronicMedicalRecords", group =>
            {
			    AppointmentTypeNew = group.Add(new VocabularyKey(nameof(AppointmentTypeNew), "AppointmentType", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Comment = group.Add(new VocabularyKey(nameof(Comment), "Comment", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    End = group.Add(new VocabularyKey(nameof(End), "End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Overbooked = group.Add(new VocabularyKey(nameof(Overbooked), "Overbooked", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SlotId = group.Add(new VocabularyKey(nameof(SlotId), "Slot", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Start = group.Add(new VocabularyKey(nameof(Start), "Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AppointmentTypeNew { get; private set; }
        public VocabularyKey Comment { get; private set; }
        public VocabularyKey End { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Overbooked { get; private set; }
        public VocabularyKey SlotId { get; private set; }
        public VocabularyKey Start { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}