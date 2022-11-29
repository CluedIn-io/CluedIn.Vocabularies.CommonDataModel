using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class MedicalIdentifierVocabulary : SimpleVocabulary
    {
        public MedicalIdentifierVocabulary()
        {
            VocabularyName = "Medical Identifier";
            KeyPrefix = "commonDataModel.medicalidentifier.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/MedicalIdentifier";

            AddGroup("MedicalIdentifier Details for ElectronicMedicalRecords", group =>
            {
			    IdentifierSystem = group.Add(new VocabularyKey(nameof(IdentifierSystem), "Identifier System", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IdentifierType = group.Add(new VocabularyKey(nameof(IdentifierType), "Identifier Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    MedicalIdentifierId = group.Add(new VocabularyKey(nameof(MedicalIdentifierId), "Medical Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodEnd = group.Add(new VocabularyKey(nameof(PeriodEnd), "Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PeriodStart = group.Add(new VocabularyKey(nameof(PeriodStart), "Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Use = group.Add(new VocabularyKey(nameof(Use), "Use", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Value = group.Add(new VocabularyKey(nameof(Value), "Identifier Value", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey IdentifierSystem { get; private set; }
        public VocabularyKey IdentifierType { get; private set; }
        public VocabularyKey MedicalIdentifierId { get; private set; }
        public VocabularyKey PeriodEnd { get; private set; }
        public VocabularyKey PeriodStart { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey Use { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}