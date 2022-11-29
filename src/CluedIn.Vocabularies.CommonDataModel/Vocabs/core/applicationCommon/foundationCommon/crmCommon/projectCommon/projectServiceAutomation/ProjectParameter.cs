using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ProjectParameterVocabulary : SimpleVocabulary
    {
        public ProjectParameterVocabulary()
        {
            VocabularyName = "Project Parameter";
            KeyPrefix = "commonDataModel.projectparameter.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ProjectParameter";

            AddGroup("ProjectParameter Details for ProjectServiceAutomation", group =>
            {
			    ProjectParameterId = group.Add(new VocabularyKey(nameof(ProjectParameterId), "Project Parameter", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OverriddenCreatedOn = group.Add(new VocabularyKey(nameof(OverriddenCreatedOn), "Record Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeZoneRuleVersionNumber = group.Add(new VocabularyKey(nameof(TimeZoneRuleVersionNumber), "Time Zone Rule Version Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    UTCConversionTimeZoneCode = group.Add(new VocabularyKey(nameof(UTCConversionTimeZoneCode), "UTC Conversion Time Zone Code", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllowSkillUpdateByResource = group.Add(new VocabularyKey(nameof(AllowSkillUpdateByResource), "Allow skill update by resource (Deprecated in v3.0)", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ProjectResourceRequirementsVisibleToRe = group.Add(new VocabularyKey(nameof(ProjectResourceRequirementsVisibleToRe), "Resource requirements visible to resources (Deprecated in v3.0)", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ResourceAllocationMode = group.Add(new VocabularyKey(nameof(ResourceAllocationMode), "Resource allocation mode", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ProjectParameterId { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ImportSequenceNumber { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey AllowSkillUpdateByResource { get; private set; }
        public VocabularyKey ProjectResourceRequirementsVisibleToRe { get; private set; }
        public VocabularyKey ResourceAllocationMode { get; private set; }
    }
}