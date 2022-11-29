using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class LeadVocabulary : SimpleVocabulary
    {
        public LeadVocabulary()
        {
            VocabularyName = "Lead";
            KeyPrefix = "commonDataModel.lead.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/Lead";

            AddGroup("Lead Details for NonProfitForSales", group =>
            {
			    ApplicationDeadline = group.Add(new VocabularyKey(nameof(ApplicationDeadline), "Application Deadline", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedAmountRequested = group.Add(new VocabularyKey(nameof(ExpectedAmountRequested), "Expected Amount Requested", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExpectedAmountRequested_Base = group.Add(new VocabularyKey(nameof(ExpectedAmountRequested_Base), "Expected Amount Requested (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExpectedDuration = group.Add(new VocabularyKey(nameof(ExpectedDuration), "Expected Duration (Months)", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ExpectedStartDate = group.Add(new VocabularyKey(nameof(ExpectedStartDate), "Expected Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsRenewal = group.Add(new VocabularyKey(nameof(IsRenewal), "Is Renewal", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LetterOfIntentDeadline = group.Add(new VocabularyKey(nameof(LetterOfIntentDeadline), "Letter of Intent Deadline", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    OrganizationalBudget = group.Add(new VocabularyKey(nameof(OrganizationalBudget), "Organization Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OrganizationalBudget_Base = group.Add(new VocabularyKey(nameof(OrganizationalBudget_Base), "Organization Budget (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    OrganizationType = group.Add(new VocabularyKey(nameof(OrganizationType), "Organization Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    RequestType = group.Add(new VocabularyKey(nameof(RequestType), "Request Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TotalProjectBudget = group.Add(new VocabularyKey(nameof(TotalProjectBudget), "Total Project Budget", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    TotalProjectBudget_Base = group.Add(new VocabularyKey(nameof(TotalProjectBudget_Base), "Total Project Budget (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ApplicationDeadline { get; private set; }
        public VocabularyKey ExpectedAmountRequested { get; private set; }
        public VocabularyKey ExpectedAmountRequested_Base { get; private set; }
        public VocabularyKey ExpectedDuration { get; private set; }
        public VocabularyKey ExpectedStartDate { get; private set; }
        public VocabularyKey IsRenewal { get; private set; }
        public VocabularyKey LetterOfIntentDeadline { get; private set; }
        public VocabularyKey OrganizationalBudget { get; private set; }
        public VocabularyKey OrganizationalBudget_Base { get; private set; }
        public VocabularyKey OrganizationType { get; private set; }
        public VocabularyKey RequestType { get; private set; }
        public VocabularyKey TotalProjectBudget { get; private set; }
        public VocabularyKey TotalProjectBudget_Base { get; private set; }
    }
}