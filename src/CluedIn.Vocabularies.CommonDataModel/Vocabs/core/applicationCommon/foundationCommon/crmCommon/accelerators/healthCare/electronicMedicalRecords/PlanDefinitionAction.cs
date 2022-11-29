using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class PlanDefinitionActionVocabulary : SimpleVocabulary
    {
        public PlanDefinitionActionVocabulary()
        {
            VocabularyName = "Plan Definition Action";
            KeyPrefix = "commonDataModel.plandefinitionaction.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/PlanDefinitionAction";

            AddGroup("PlanDefinitionAction Details for ElectronicMedicalRecords", group =>
            {
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreatedOnBehalfBy = group.Add(new VocabularyKey(nameof(CreatedOnBehalfBy), "Created By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ImportSequenceNumber = group.Add(new VocabularyKey(nameof(ImportSequenceNumber), "Import Sequence Number", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOnBehalfBy = group.Add(new VocabularyKey(nameof(ModifiedOnBehalfBy), "Modified By (Delegate)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CardinalityBehavior = group.Add(new VocabularyKey(nameof(CardinalityBehavior), "Cardinality Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefinitionType = group.Add(new VocabularyKey(nameof(DefinitionType), "Definition Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GroupingBehavior = group.Add(new VocabularyKey(nameof(GroupingBehavior), "Grouping Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Label = group.Add(new VocabularyKey(nameof(Label), "Label", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PlanDefinitionActionId = group.Add(new VocabularyKey(nameof(PlanDefinitionActionId), "Plan Definition Action", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PreCheckBehavior = group.Add(new VocabularyKey(nameof(PreCheckBehavior), "Pre-Check Behavior", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    RequiredBehavior = group.Add(new VocabularyKey(nameof(RequiredBehavior), "Required Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SelectionBehavior = group.Add(new VocabularyKey(nameof(SelectionBehavior), "Selection Behavior", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TextEquivalent = group.Add(new VocabularyKey(nameof(TextEquivalent), "Text Equivalent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timingdatetime = group.Add(new VocabularyKey(nameof(Timingdatetime), "Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timingduration = group.Add(new VocabularyKey(nameof(Timingduration), "Duration", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Timingenddate = group.Add(new VocabularyKey(nameof(Timingenddate), "End Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timinglowerlimit = group.Add(new VocabularyKey(nameof(Timinglowerlimit), "Lower Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Timingstartdate = group.Add(new VocabularyKey(nameof(Timingstartdate), "Start Date/Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimingType = group.Add(new VocabularyKey(nameof(TimingType), "Timing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Timingupperlimit = group.Add(new VocabularyKey(nameof(Timingupperlimit), "Upper Limit", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
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
        public VocabularyKey CardinalityBehavior { get; private set; }
        public VocabularyKey DefinitionType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey GroupingBehavior { get; private set; }
        public VocabularyKey Label { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PlanDefinitionActionId { get; private set; }
        public VocabularyKey PreCheckBehavior { get; private set; }
        public VocabularyKey RequiredBehavior { get; private set; }
        public VocabularyKey SelectionBehavior { get; private set; }
        public VocabularyKey TextEquivalent { get; private set; }
        public VocabularyKey Timingdatetime { get; private set; }
        public VocabularyKey Timingduration { get; private set; }
        public VocabularyKey Timingenddate { get; private set; }
        public VocabularyKey Timinglowerlimit { get; private set; }
        public VocabularyKey Timingstartdate { get; private set; }
        public VocabularyKey TimingType { get; private set; }
        public VocabularyKey Timingupperlimit { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey OverriddenCreatedOn { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TimeZoneRuleVersionNumber { get; private set; }
        public VocabularyKey UTCConversionTimeZoneCode { get; private set; }
    }
}