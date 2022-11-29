using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class FamilyMemberHistoryVocabulary : SimpleVocabulary
    {
        public FamilyMemberHistoryVocabulary()
        {
            VocabularyName = "Family Member History";
            KeyPrefix = "commonDataModel.familymemberhistory.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/FamilyMemberHistory";

            AddGroup("FamilyMemberHistory Details for ElectronicMedicalRecords", group =>
            {
			    Age = group.Add(new VocabularyKey(nameof(Age), "Age", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AgeRangeHigh = group.Add(new VocabularyKey(nameof(AgeRangeHigh), "Age Range High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AgeRangeLow = group.Add(new VocabularyKey(nameof(AgeRangeLow), "Age Range Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    AgeString = group.Add(new VocabularyKey(nameof(AgeString), "Age", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AgeType = group.Add(new VocabularyKey(nameof(AgeType), "Age Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BornDate = group.Add(new VocabularyKey(nameof(BornDate), "Date of Birth", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BornDateString = group.Add(new VocabularyKey(nameof(BornDateString), "Born String", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BornPeriodEndDate = group.Add(new VocabularyKey(nameof(BornPeriodEndDate), "Date of Birth Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BornPeriodStartDate = group.Add(new VocabularyKey(nameof(BornPeriodStartDate), "Date of Birth Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BornType = group.Add(new VocabularyKey(nameof(BornType), "Born Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Date = group.Add(new VocabularyKey(nameof(Date), "Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeceasedAge = group.Add(new VocabularyKey(nameof(DeceasedAge), "Deceased Age", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DeceasedAgeHigh = group.Add(new VocabularyKey(nameof(DeceasedAgeHigh), "Deceased Age High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DeceasedAgeLow = group.Add(new VocabularyKey(nameof(DeceasedAgeLow), "Deceased Age Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    DeceasedBoolean = group.Add(new VocabularyKey(nameof(DeceasedBoolean), "Deceased", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    DeceasedDate = group.Add(new VocabularyKey(nameof(DeceasedDate), "Deceased Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeceasedDateString = group.Add(new VocabularyKey(nameof(DeceasedDateString), "Deceased Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DeceasedType = group.Add(new VocabularyKey(nameof(DeceasedType), "Deceased Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FamilyMemberHistoryId = group.Add(new VocabularyKey(nameof(FamilyMemberHistoryId), "Family Member History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FamilyMemberHistoryNumber = group.Add(new VocabularyKey(nameof(FamilyMemberHistoryNumber), "Family Member History Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Gender = group.Add(new VocabularyKey(nameof(Gender), "Gender", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    NotDone = group.Add(new VocabularyKey(nameof(NotDone), "Not Done", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Age { get; private set; }
        public VocabularyKey AgeRangeHigh { get; private set; }
        public VocabularyKey AgeRangeLow { get; private set; }
        public VocabularyKey AgeString { get; private set; }
        public VocabularyKey AgeType { get; private set; }
        public VocabularyKey BornDate { get; private set; }
        public VocabularyKey BornDateString { get; private set; }
        public VocabularyKey BornPeriodEndDate { get; private set; }
        public VocabularyKey BornPeriodStartDate { get; private set; }
        public VocabularyKey BornType { get; private set; }
        public VocabularyKey Date { get; private set; }
        public VocabularyKey DeceasedAge { get; private set; }
        public VocabularyKey DeceasedAgeHigh { get; private set; }
        public VocabularyKey DeceasedAgeLow { get; private set; }
        public VocabularyKey DeceasedBoolean { get; private set; }
        public VocabularyKey DeceasedDate { get; private set; }
        public VocabularyKey DeceasedDateString { get; private set; }
        public VocabularyKey DeceasedType { get; private set; }
        public VocabularyKey FamilyMemberHistoryId { get; private set; }
        public VocabularyKey FamilyMemberHistoryNumber { get; private set; }
        public VocabularyKey Gender { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey NotDone { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}