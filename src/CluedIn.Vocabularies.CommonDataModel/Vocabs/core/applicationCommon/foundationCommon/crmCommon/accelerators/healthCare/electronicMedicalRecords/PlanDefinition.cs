using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class PlanDefinitionVocabulary : SimpleVocabulary
    {
        public PlanDefinitionVocabulary()
        {
            VocabularyName = "Plan Definition";
            KeyPrefix = "commonDataModel.plandefinition.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/PlanDefinition";

            AddGroup("PlanDefinition Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApprovalDate = group.Add(new VocabularyKey(nameof(ApprovalDate), "Approval Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Copyright = group.Add(new VocabularyKey(nameof(Copyright), "Copyright", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Experimental = group.Add(new VocabularyKey(nameof(Experimental), "Experimental", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LastReviewDate = group.Add(new VocabularyKey(nameof(LastReviewDate), "Last Review Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanDefinitionId = group.Add(new VocabularyKey(nameof(PlanDefinitionId), "Plan Definition", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanDefinitionNumber = group.Add(new VocabularyKey(nameof(PlanDefinitionNumber), "Plan Definition Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Publisher = group.Add(new VocabularyKey(nameof(Publisher), "Publisher", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Purpose = group.Add(new VocabularyKey(nameof(Purpose), "Purpose", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RevisionDate = group.Add(new VocabularyKey(nameof(RevisionDate), "Revision Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    URL = group.Add(new VocabularyKey(nameof(URL), "URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
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
        public VocabularyKey ApprovalDate { get; private set; }
        public VocabularyKey Copyright { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey Experimental { get; private set; }
        public VocabularyKey LastReviewDate { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PlanDefinitionId { get; private set; }
        public VocabularyKey PlanDefinitionNumber { get; private set; }
        public VocabularyKey Publisher { get; private set; }
        public VocabularyKey Purpose { get; private set; }
        public VocabularyKey RevisionDate { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey URL { get; private set; }
        public VocabularyKey Usage { get; private set; }
        public VocabularyKey Version { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}