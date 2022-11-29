using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class CaseResolutionVocabulary : SimpleVocabulary
    {
        public CaseResolutionVocabulary()
        {
            VocabularyName = "Case Resolution";
            KeyPrefix = "commonDataModel.caseresolution.service";
            KeySeparator = ".";
            Grouping = "/CaseResolution";

            AddGroup("CaseResolution Details for Service", group =>
            {
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    LastOnHoldTime = group.Add(new VocabularyKey(nameof(LastOnHoldTime), "Last On Hold Time", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OnHoldTime = group.Add(new VocabularyKey(nameof(OnHoldTime), "On Hold Time (Minutes)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Process Stage", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TimeSpent = group.Add(new VocabularyKey(nameof(TimeSpent), "Time Spent", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    CreatedByExternalParty = group.Add(new VocabularyKey(nameof(CreatedByExternalParty), "Created By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ModifiedByExternalParty = group.Add(new VocabularyKey(nameof(ModifiedByExternalParty), "Modified By (External Party)", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey LastOnHoldTime { get; private set; }
        public VocabularyKey OnHoldTime { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey TimeSpent { get; private set; }
        public VocabularyKey CreatedByExternalParty { get; private set; }
        public VocabularyKey ModifiedByExternalParty { get; private set; }
    }
}