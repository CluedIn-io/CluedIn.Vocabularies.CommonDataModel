using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ElectronicMedicalRecords
{
    public class TaskVocabulary : SimpleVocabulary
    {
        public TaskVocabulary()
        {
            VocabularyName = "Task";
            KeyPrefix = "commonDataModel.task.electronicmedicalrecords";
            KeySeparator = ".";
            Grouping = "/Task";

            AddGroup("Task Details for ElectronicMedicalRecords", group =>
            {
			    ContextType = group.Add(new VocabularyKey(nameof(ContextType), "Context Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DefinitionUri = group.Add(new VocabularyKey(nameof(DefinitionUri), "Definition Uri", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DescriptionFocus = group.Add(new VocabularyKey(nameof(DescriptionFocus), "Description Focus", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DescriptionFor = group.Add(new VocabularyKey(nameof(DescriptionFor), "Description For", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GroupIdentifier = group.Add(new VocabularyKey(nameof(GroupIdentifier), "Group Identifier", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Intent = group.Add(new VocabularyKey(nameof(Intent), "Intent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PerformerOwnerType = group.Add(new VocabularyKey(nameof(PerformerOwnerType), "Performer type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequesterAgent = group.Add(new VocabularyKey(nameof(RequesterAgent), "Requester Agent", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RestrictionPeriodEndDate = group.Add(new VocabularyKey(nameof(RestrictionPeriodEndDate), "Restriction Period End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RestrictionPeriodStartDate = group.Add(new VocabularyKey(nameof(RestrictionPeriodStartDate), "Restriction Period Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RestrictionRepetitions = group.Add(new VocabularyKey(nameof(RestrictionRepetitions), "Restriction Repetitions", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TaskNumber = group.Add(new VocabularyKey(nameof(TaskNumber), "Task Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TaskPriority = group.Add(new VocabularyKey(nameof(TaskPriority), "Task Priority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ContextType { get; private set; }
        public VocabularyKey DefinitionUri { get; private set; }
        public VocabularyKey DescriptionFocus { get; private set; }
        public VocabularyKey DescriptionFor { get; private set; }
        public VocabularyKey GroupIdentifier { get; private set; }
        public VocabularyKey Intent { get; private set; }
        public VocabularyKey PerformerOwnerType { get; private set; }
        public VocabularyKey RequesterAgent { get; private set; }
        public VocabularyKey RestrictionPeriodEndDate { get; private set; }
        public VocabularyKey RestrictionPeriodStartDate { get; private set; }
        public VocabularyKey RestrictionRepetitions { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey TaskNumber { get; private set; }
        public VocabularyKey TaskPriority { get; private set; }
    }
}