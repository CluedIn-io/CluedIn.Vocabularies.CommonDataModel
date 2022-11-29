using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class RequestGroupActionVocabulary : SimpleVocabulary
    {
        public RequestGroupActionVocabulary()
        {
            VocabularyName = "Request Group Action";
            KeyPrefix = "commonDataModel.requestgroupaction.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/RequestGroupAction";

            AddGroup("RequestGroupAction Details for ElectronicMedicalRecords", group =>
            {
			    ActionCardinalityBehavior = group.Add(new VocabularyKey(nameof(ActionCardinalityBehavior), "Cardinality Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionDescription = group.Add(new VocabularyKey(nameof(ActionDescription), "Action Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionGroupingBehavior = group.Add(new VocabularyKey(nameof(ActionGroupingBehavior), "Grouping Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionLabel = group.Add(new VocabularyKey(nameof(ActionLabel), "Action Label", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionPrecheckBehavior = group.Add(new VocabularyKey(nameof(ActionPrecheckBehavior), "Pre check Behavior", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ActionRequiredBehavior = group.Add(new VocabularyKey(nameof(ActionRequiredBehavior), "Required Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionResource = group.Add(new VocabularyKey(nameof(ActionResource), "Action Resource", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionSelectionBehavior = group.Add(new VocabularyKey(nameof(ActionSelectionBehavior), "Selection Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionTextEquivalent = group.Add(new VocabularyKey(nameof(ActionTextEquivalent), "Action Text Equivalent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionTimingDateTime = group.Add(new VocabularyKey(nameof(ActionTimingDateTime), "Timing DateTime", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionTimingDuration = group.Add(new VocabularyKey(nameof(ActionTimingDuration), "Timing Duration", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    ActionTimingPeriodEnd = group.Add(new VocabularyKey(nameof(ActionTimingPeriodEnd), "Timing Period End", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionTimingPeriodStart = group.Add(new VocabularyKey(nameof(ActionTimingPeriodStart), "Timing Period Start", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionTimingRangeHigh = group.Add(new VocabularyKey(nameof(ActionTimingRangeHigh), "Timing Range High", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ActionTimingRangeLow = group.Add(new VocabularyKey(nameof(ActionTimingRangeLow), "Timing Range Low", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ActionTimingType = group.Add(new VocabularyKey(nameof(ActionTimingType), "Timing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionTitle = group.Add(new VocabularyKey(nameof(ActionTitle), "Action Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ActionType = group.Add(new VocabularyKey(nameof(ActionType), "Action Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestGroupActionId = group.Add(new VocabularyKey(nameof(RequestGroupActionId), "Request Group Action", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ActionCardinalityBehavior { get; private set; }
        public VocabularyKey ActionDescription { get; private set; }
        public VocabularyKey ActionGroupingBehavior { get; private set; }
        public VocabularyKey ActionLabel { get; private set; }
        public VocabularyKey ActionPrecheckBehavior { get; private set; }
        public VocabularyKey ActionRequiredBehavior { get; private set; }
        public VocabularyKey ActionResource { get; private set; }
        public VocabularyKey ActionSelectionBehavior { get; private set; }
        public VocabularyKey ActionTextEquivalent { get; private set; }
        public VocabularyKey ActionTimingDateTime { get; private set; }
        public VocabularyKey ActionTimingDuration { get; private set; }
        public VocabularyKey ActionTimingPeriodEnd { get; private set; }
        public VocabularyKey ActionTimingPeriodStart { get; private set; }
        public VocabularyKey ActionTimingRangeHigh { get; private set; }
        public VocabularyKey ActionTimingRangeLow { get; private set; }
        public VocabularyKey ActionTimingType { get; private set; }
        public VocabularyKey ActionTitle { get; private set; }
        public VocabularyKey ActionType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey RequestGroupActionId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}