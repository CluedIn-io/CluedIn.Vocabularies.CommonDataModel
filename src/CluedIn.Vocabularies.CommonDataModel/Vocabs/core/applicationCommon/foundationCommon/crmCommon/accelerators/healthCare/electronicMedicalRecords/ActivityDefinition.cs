using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class ActivityDefinitionVocabulary : SimpleVocabulary
    {
        public ActivityDefinitionVocabulary()
        {
            VocabularyName = "Activity Definition";
            KeyPrefix = "commonDataModel.activitydefinition.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/ActivityDefinition";

            AddGroup("ActivityDefinition Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActivityDefinitionNumber = group.Add(new VocabularyKey(nameof(ActivityDefinitionNumber), "Activity Definition Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApprovalDate = group.Add(new VocabularyKey(nameof(ApprovalDate), "Approval Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Copyright = group.Add(new VocabularyKey(nameof(Copyright), "Copyright", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Datetime = group.Add(new VocabularyKey(nameof(Datetime), "Activity Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectivePeriodEndDate = group.Add(new VocabularyKey(nameof(EffectivePeriodEndDate), "Effective Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EffectivePeriodStartDate = group.Add(new VocabularyKey(nameof(EffectivePeriodStartDate), "Effective Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Enddatetime = group.Add(new VocabularyKey(nameof(Enddatetime), "Activity End Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Experimental = group.Add(new VocabularyKey(nameof(Experimental), "Experimental", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    IdentifiesspecifictimeswhentheeventoccuId = group.Add(new VocabularyKey(nameof(IdentifiesspecifictimeswhentheeventoccuId), "Activity Definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LastReviewDate = group.Add(new VocabularyKey(nameof(LastReviewDate), "Last Review Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Lowerlimit = group.Add(new VocabularyKey(nameof(Lowerlimit), "Activity Lower Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProductType = group.Add(new VocabularyKey(nameof(ProductType), "Product Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Publishdate = group.Add(new VocabularyKey(nameof(Publishdate), "Published Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Publisher = group.Add(new VocabularyKey(nameof(Publisher), "Publisher", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Quantity = group.Add(new VocabularyKey(nameof(Quantity), "Quantity", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Startdatetime = group.Add(new VocabularyKey(nameof(Startdatetime), "Activity Start Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimingType = group.Add(new VocabularyKey(nameof(TimingType), "Timing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Upperlimit = group.Add(new VocabularyKey(nameof(Upperlimit), "Activity Upper Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Uri = group.Add(new VocabularyKey(nameof(Uri), "Activity URL", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Usage = group.Add(new VocabularyKey(nameof(Usage), "Usage", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Version = group.Add(new VocabularyKey(nameof(Version), "Version", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey CreatedOnBehalfBy { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ModifiedOnBehalfBy { get; private set; }
        public VocabularyKey ActivityDefinitionNumber { get; private set; }
        public VocabularyKey ApprovalDate { get; private set; }
        public VocabularyKey Copyright { get; private set; }
        public VocabularyKey Datetime { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EffectivePeriodEndDate { get; private set; }
        public VocabularyKey EffectivePeriodStartDate { get; private set; }
        public VocabularyKey Enddatetime { get; private set; }
        public VocabularyKey Experimental { get; private set; }
        public VocabularyKey IdentifiesspecifictimeswhentheeventoccuId { get; private set; }
        public VocabularyKey LastReviewDate { get; private set; }
        public VocabularyKey Lowerlimit { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProductType { get; private set; }
        public VocabularyKey Publishdate { get; private set; }
        public VocabularyKey Publisher { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey Quantity { get; private set; }
        public VocabularyKey Startdatetime { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey TimingType { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Upperlimit { get; private set; }
        public VocabularyKey Uri { get; private set; }
        public VocabularyKey Usage { get; private set; }
        public VocabularyKey Version { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}