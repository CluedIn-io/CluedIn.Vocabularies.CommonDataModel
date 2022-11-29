using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class SpecimenVocabulary : SimpleVocabulary
    {
        public SpecimenVocabulary()
        {
            VocabularyName = "Specimen";
            KeyPrefix = "commonDataModel.specimen.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Specimen";

            AddGroup("Specimen Details for ElectronicMedicalRecords", group =>
            {
			    AccessionNumber = group.Add(new VocabularyKey(nameof(AccessionNumber), "Accession Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CollectedQuantity = group.Add(new VocabularyKey(nameof(CollectedQuantity), "Quantity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    CollectionCollectedDateTime = group.Add(new VocabularyKey(nameof(CollectionCollectedDateTime), "Collected Date Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CollectionCollectedPeriodEnd = group.Add(new VocabularyKey(nameof(CollectionCollectedPeriodEnd), "Collected Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CollectionCollectedPeriodStart = group.Add(new VocabularyKey(nameof(CollectionCollectedPeriodStart), "Collected Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CollectionCollectedType = group.Add(new VocabularyKey(nameof(CollectionCollectedType), "Collected Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ReceivedTime = group.Add(new VocabularyKey(nameof(ReceivedTime), "Received Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SpecimenId = group.Add(new VocabularyKey(nameof(SpecimenId), "Specimen", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SpecimenNumber = group.Add(new VocabularyKey(nameof(SpecimenNumber), "Specimen Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SubjectType = group.Add(new VocabularyKey(nameof(SubjectType), "Subject Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AccessionNumber { get; private set; }
        public VocabularyKey CollectedQuantity { get; private set; }
        public VocabularyKey CollectionCollectedDateTime { get; private set; }
        public VocabularyKey CollectionCollectedPeriodEnd { get; private set; }
        public VocabularyKey CollectionCollectedPeriodStart { get; private set; }
        public VocabularyKey CollectionCollectedType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ReceivedTime { get; private set; }
        public VocabularyKey SpecimenId { get; private set; }
        public VocabularyKey SpecimenNumber { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SubjectType { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}