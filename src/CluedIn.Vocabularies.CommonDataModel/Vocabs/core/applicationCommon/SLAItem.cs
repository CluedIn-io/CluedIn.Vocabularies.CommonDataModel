using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class SLAItemVocabulary : SimpleVocabulary
    {
        public SLAItemVocabulary()
        {
            VocabularyName = "SLA Item";
            KeyPrefix = "commonDataModel.slaitem.applicationcommon";
            KeySeparator = ".";
            Grouping = "/SLAItem";

            AddGroup("SLAItem Details for ApplicationCommon", group =>
            {
			    SLAItemId = group.Add(new VocabularyKey(nameof(SLAItemId), "SLA Item", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningBusinessUnit = group.Add(new VocabularyKey(nameof(OwningBusinessUnit), "Owning Business Unit", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RelatedField = group.Add(new VocabularyKey(nameof(RelatedField), "Related Case Field", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApplicableWhenXml = group.Add(new VocabularyKey(nameof(ApplicableWhenXml), "ApplicableWhenXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SuccessConditionsXml = group.Add(new VocabularyKey(nameof(SuccessConditionsXml), "SuccessConditionsXml", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SolutionId = group.Add(new VocabularyKey(nameof(SolutionId), "Solution", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    ComponentState = group.Add(new VocabularyKey(nameof(ComponentState), "Component State", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OverwriteTime = group.Add(new VocabularyKey(nameof(OverwriteTime), "Record Overwrite Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsManaged = group.Add(new VocabularyKey(nameof(IsManaged), "Is Managed", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SLAItemIdUnique = group.Add(new VocabularyKey(nameof(SLAItemIdUnique), "Unique Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), "Sequence", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    FailureAfter = group.Add(new VocabularyKey(nameof(FailureAfter), "Failure After", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    WarnAfter = group.Add(new VocabularyKey(nameof(WarnAfter), "Warn After", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), "Owning User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WorkflowId = group.Add(new VocabularyKey(nameof(WorkflowId), "Workflow ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SLAItemId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey OwningBusinessUnit { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RelatedField { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey ApplicableWhenXml { get; private set; }
        public VocabularyKey SuccessConditionsXml { get; private set; }
        public VocabularyKey SolutionId { get; private set; }
        public VocabularyKey ComponentState { get; private set; }
        public VocabularyKey OverwriteTime { get; private set; }
        public VocabularyKey IsManaged { get; private set; }
        public VocabularyKey SLAItemIdUnique { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey FailureAfter { get; private set; }
        public VocabularyKey WarnAfter { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey WorkflowId { get; private set; }
    }
}