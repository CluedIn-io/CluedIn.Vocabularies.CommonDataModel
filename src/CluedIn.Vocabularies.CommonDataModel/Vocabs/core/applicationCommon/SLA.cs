using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class SLAVocabulary : SimpleVocabulary
    {
        public SLAVocabulary()
        {
            VocabularyName = "SLA";
            KeyPrefix = "commonDataModel.sla.applicationcommon";
            KeySeparator = ".";
            Grouping = "/SLA";

            AddGroup("SLA Details for ApplicationCommon", group =>
            {
			    SLAId = group.Add(new VocabularyKey(nameof(SLAId), "SLA", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BusinessHoursId = group.Add(new VocabularyKey(nameof(BusinessHoursId), "Business Hours", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ObjectTypeCode = group.Add(new VocabularyKey(nameof(ObjectTypeCode), "Object Type Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ChangedAttributeList = group.Add(new VocabularyKey(nameof(ChangedAttributeList), "ChangedAttributeList", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApplicableFrom = group.Add(new VocabularyKey(nameof(ApplicableFrom), "Applicable From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SolutionId = group.Add(new VocabularyKey(nameof(SolutionId), "Solution", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ComponentState = group.Add(new VocabularyKey(nameof(ComponentState), "Component State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverwriteTime = group.Add(new VocabularyKey(nameof(OverwriteTime), "Record Overwrite Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsManaged = group.Add(new VocabularyKey(nameof(IsManaged), "Is Managed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SLAIdUnique = group.Add(new VocabularyKey(nameof(SLAIdUnique), "Unique Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ApplicableFromPickList = group.Add(new VocabularyKey(nameof(ApplicableFromPickList), "Applicable From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), "Workflow ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllowPauseResume = group.Add(new VocabularyKey(nameof(AllowPauseResume), "Allow Pause and Resume", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SLAType = group.Add(new VocabularyKey(nameof(SLAType), "SLA Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PrimaryEntityOTC = group.Add(new VocabularyKey(nameof(PrimaryEntityOTC), "Primary Entity", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SLAId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey BusinessHoursId { get; private set; }
        public VocabularyKey ObjectTypeCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ChangedAttributeList { get; private set; }
        public VocabularyKey ApplicableFrom { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey SolutionId { get; private set; }
        public VocabularyKey ComponentState { get; private set; }
        public VocabularyKey OverwriteTime { get; private set; }
        public VocabularyKey IsManaged { get; private set; }
        public VocabularyKey SLAIdUnique { get; private set; }
        public VocabularyKey ApplicableFromPickList { get; private set; }
        public VocabularyKey WorkflowId { get; private set; }
        public VocabularyKey AllowPauseResume { get; private set; }
        public VocabularyKey SLAType { get; private set; }
        public VocabularyKey PrimaryEntityOTC { get; private set; }
    }
}