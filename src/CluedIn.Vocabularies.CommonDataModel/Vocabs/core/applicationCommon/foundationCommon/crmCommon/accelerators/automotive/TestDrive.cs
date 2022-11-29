using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Automotive
{
    public class TestDriveVocabulary : SimpleVocabulary
    {
        public TestDriveVocabulary()
        {
            VocabularyName = "Test Drive";
            KeyPrefix = "commonDataModel.testdrive.automotive";
            KeySeparator = ".";
            Grouping = "/TestDrive";

            AddGroup("TestDrive Details for Automotive", group =>
            {
			    ActualDuration = group.Add(new VocabularyKey(nameof(ActualDuration), "Actual Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ActualEnd = group.Add(new VocabularyKey(nameof(ActualEnd), "Actual End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActualStart = group.Add(new VocabularyKey(nameof(ActualStart), "Actual Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IdentificationExpiresOn = group.Add(new VocabularyKey(nameof(IdentificationExpiresOn), "Identification Expires On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IdentificationNumber = group.Add(new VocabularyKey(nameof(IdentificationNumber), "Identification Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IdentificationType = group.Add(new VocabularyKey(nameof(IdentificationType), "Identification Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledDuration = group.Add(new VocabularyKey(nameof(ScheduledDuration), "Scheduled Duration", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ScheduledEnd = group.Add(new VocabularyKey(nameof(ScheduledEnd), "Scheduled End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ScheduledStart = group.Add(new VocabularyKey(nameof(ScheduledStart), "Scheduled Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TestDriveId = group.Add(new VocabularyKey(nameof(TestDriveId), "Test Drive", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Year = group.Add(new VocabularyKey(nameof(Year), "Year", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActualDuration { get; private set; }
        public VocabularyKey ActualEnd { get; private set; }
        public VocabularyKey ActualStart { get; private set; }
        public VocabularyKey IdentificationExpiresOn { get; private set; }
        public VocabularyKey IdentificationNumber { get; private set; }
        public VocabularyKey IdentificationType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ScheduledDuration { get; private set; }
        public VocabularyKey ScheduledEnd { get; private set; }
        public VocabularyKey ScheduledStart { get; private set; }
        public VocabularyKey TestDriveId { get; private set; }
        public VocabularyKey Year { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}