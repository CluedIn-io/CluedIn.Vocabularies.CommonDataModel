using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ApplicationCommon
{
    public class SLAKPIInstanceVocabulary : SimpleVocabulary
    {
        public SLAKPIInstanceVocabulary()
        {
            VocabularyName = "SLAKPI Instance";
            KeyPrefix = "commonDataModel.slakpiinstance.applicationcommon";
            KeySeparator = ".";
            Grouping = "/SLAKPIInstance";

            AddGroup("SLAKPIInstance Details for ApplicationCommon", group =>
            {
			    SLAKPIInstanceId = group.Add(new VocabularyKey(nameof(SLAKPIInstanceId), "SLA KPI InstanceId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ComputedFailureTime = group.Add(new VocabularyKey(nameof(ComputedFailureTime), "Computed Failure Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ComputedWarningTime = group.Add(new VocabularyKey(nameof(ComputedWarningTime), "Computed Warning Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FailureTime = group.Add(new VocabularyKey(nameof(FailureTime), "Failure Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningUser = group.Add(new VocabularyKey(nameof(OwningUser), "Owning User", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OwningTeam = group.Add(new VocabularyKey(nameof(OwningTeam), "Owning Team", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Status = group.Add(new VocabularyKey(nameof(Status), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SucceededOn = group.Add(new VocabularyKey(nameof(SucceededOn), "Succeeded On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WarningTime = group.Add(new VocabularyKey(nameof(WarningTime), "Warning Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    CreatedOn = group.Add(new VocabularyKey(nameof(CreatedOn), "Created On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedOn = group.Add(new VocabularyKey(nameof(ModifiedOn), "Modified On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    VersionNumber = group.Add(new VocabularyKey(nameof(VersionNumber), "Version Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WarningTimeReached = group.Add(new VocabularyKey(nameof(WarningTimeReached), "Warning Time Reached", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey SLAKPIInstanceId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ComputedFailureTime { get; private set; }
        public VocabularyKey ComputedWarningTime { get; private set; }
        public VocabularyKey FailureTime { get; private set; }
        public VocabularyKey OwningUser { get; private set; }
        public VocabularyKey OwningTeam { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey SucceededOn { get; private set; }
        public VocabularyKey WarningTime { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey CreatedOn { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ModifiedOn { get; private set; }
        public VocabularyKey VersionNumber { get; private set; }
        public VocabularyKey WarningTimeReached { get; private set; }
    }
}