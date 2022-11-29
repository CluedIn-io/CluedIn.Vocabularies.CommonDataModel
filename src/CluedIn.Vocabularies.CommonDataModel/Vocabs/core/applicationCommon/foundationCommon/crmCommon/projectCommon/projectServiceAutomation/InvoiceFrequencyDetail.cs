using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class InvoiceFrequencyDetailVocabulary : SimpleVocabulary
    {
        public InvoiceFrequencyDetailVocabulary()
        {
            VocabularyName = "Invoice Frequency Detail";
            KeyPrefix = "commonDataModel.invoicefrequencydetail.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/InvoiceFrequencyDetail";

            AddGroup("InvoiceFrequencyDetail Details for ProjectServiceAutomation", group =>
            {
			    InvoiceFrequencyDetailId = group.Add(new VocabularyKey(nameof(InvoiceFrequencyDetailId), "Invoice Frequency Detail", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DayOfMonth = group.Add(new VocabularyKey(nameof(DayOfMonth), "Day of month", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OccurrenceOfWeekday = group.Add(new VocabularyKey(nameof(OccurrenceOfWeekday), "Occurrence of weekday", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Weekday = group.Add(new VocabularyKey(nameof(Weekday), "Weekday", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey InvoiceFrequencyDetailId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey DayOfMonth { get; private set; }
        public VocabularyKey OccurrenceOfWeekday { get; private set; }
        public VocabularyKey Weekday { get; private set; }
    }
}