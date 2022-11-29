using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Service
{
    public class EntitlementVocabulary : SimpleVocabulary
    {
        public EntitlementVocabulary()
        {
            VocabularyName = "Entitlement";
            KeyPrefix = "commonDataModel.entitlement.service";
            KeySeparator = ".";
            Grouping = "/Entitlement";

            AddGroup("Entitlement Details for Service", group =>
            {
			    EntitlementId = group.Add(new VocabularyKey(nameof(EntitlementId), "Entitlement", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmailAddress = group.Add(new VocabularyKey(nameof(EmailAddress), "Email Address", VocabularyKeyDataType.Email, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Entitlement Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProcessId = group.Add(new VocabularyKey(nameof(ProcessId), "Process Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    StageId = group.Add(new VocabularyKey(nameof(StageId), "Stage Id", VocabularyKeyDataType.Guid, VocabularyKeyVisibility.Visible)); 
			    TraversedPath = group.Add(new VocabularyKey(nameof(TraversedPath), "Traversed Path", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    AllocationTypeCode = group.Add(new VocabularyKey(nameof(AllocationTypeCode), "Allocation Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    DecreaseRemainingOn = group.Add(new VocabularyKey(nameof(DecreaseRemainingOn), "Decrease Remaining On", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EndDate = group.Add(new VocabularyKey(nameof(EndDate), "End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EntitlementTemplateId = group.Add(new VocabularyKey(nameof(EntitlementTemplateId), "Entitlement Template", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    KbAccessLevel = group.Add(new VocabularyKey(nameof(KbAccessLevel), "KB Access Level", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RemainingTerms = group.Add(new VocabularyKey(nameof(RemainingTerms), "Remaining Terms", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    RestrictCaseCreation = group.Add(new VocabularyKey(nameof(RestrictCaseCreation), "Restrict based on entitlement terms", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalTerms = group.Add(new VocabularyKey(nameof(TotalTerms), "Total Terms", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EntitlementId { get; private set; }
        public VocabularyKey EmailAddress { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ProcessId { get; private set; }
        public VocabularyKey StageId { get; private set; }
        public VocabularyKey TraversedPath { get; private set; }
        public VocabularyKey AllocationTypeCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey DecreaseRemainingOn { get; private set; }
        public VocabularyKey EndDate { get; private set; }
        public VocabularyKey EntitlementTemplateId { get; private set; }
        public VocabularyKey KbAccessLevel { get; private set; }
        public VocabularyKey RemainingTerms { get; private set; }
        public VocabularyKey RestrictCaseCreation { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey TotalTerms { get; private set; }
        public VocabularyKey IsDefault { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
    }
}