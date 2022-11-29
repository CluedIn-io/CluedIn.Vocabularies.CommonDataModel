using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Marketing
{
    public class LeadVocabulary : SimpleVocabulary
    {
        public LeadVocabulary()
        {
            VocabularyName = "Lead";
            KeyPrefix = "commonDataModel.lead.marketing";
            KeySeparator = ".";
            Grouping = "/Lead";

            AddGroup("Lead Details for Marketing", group =>
            {
			    LeadSourceCode = group.Add(new VocabularyKey(nameof(LeadSourceCode), "Lead Source", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Code = group.Add(new VocabularyKey(nameof(Code), "Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LeadSourceType = group.Add(new VocabularyKey(nameof(LeadSourceType), "Lead source type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Scores = group.Add(new VocabularyKey(nameof(Scores), "Scores", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible)); 
			    ScoringGrade = group.Add(new VocabularyKey(nameof(ScoringGrade), "Scoring grade", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    InsightsPlaceholder = group.Add(new VocabularyKey(nameof(InsightsPlaceholder), "Insights", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Profileid = group.Add(new VocabularyKey(nameof(Profileid), "Profile ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ContactId = group.Add(new VocabularyKey(nameof(ContactId), "Contact ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LeadId = group.Add(new VocabularyKey(nameof(LeadId), "Lead ID", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PurchaseNeed = group.Add(new VocabularyKey(nameof(PurchaseNeed), "Purchase need", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TriggerRecycle = group.Add(new VocabularyKey(nameof(TriggerRecycle), "Recycle", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    Recycled = group.Add(new VocabularyKey(nameof(Recycled), "Recycled", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SalesAccepted = group.Add(new VocabularyKey(nameof(SalesAccepted), "Sales accepted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SalesReady = group.Add(new VocabularyKey(nameof(SalesReady), "Sales ready", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    SasToken = group.Add(new VocabularyKey(nameof(SasToken), "SAS token", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TeleProspectAccepted = group.Add(new VocabularyKey(nameof(TeleProspectAccepted), "Teleprospecting accepted", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    TeleProspectReady = group.Add(new VocabularyKey(nameof(TeleProspectReady), "Teleprospecting ready", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    CompanySize = group.Add(new VocabularyKey(nameof(CompanySize), "Company size", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Degree = group.Add(new VocabularyKey(nameof(Degree), "Degree", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    FieldOfStudy = group.Add(new VocabularyKey(nameof(FieldOfStudy), "Field of study", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    GraduationDate = group.Add(new VocabularyKey(nameof(GraduationDate), "Graduation date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Industry = group.Add(new VocabularyKey(nameof(Industry), "Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    JobFunction = group.Add(new VocabularyKey(nameof(JobFunction), "Job function", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LatestFormSubmissionDate = group.Add(new VocabularyKey(nameof(LatestFormSubmissionDate), "Latest Form Submission Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    School = group.Add(new VocabularyKey(nameof(School), "School", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Seniority = group.Add(new VocabularyKey(nameof(Seniority), "Seniority", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StartDate = group.Add(new VocabularyKey(nameof(StartDate), "Start date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    LinkedInFormSubmissions = group.Add(new VocabularyKey(nameof(LinkedInFormSubmissions), "LinkedIn Form Submissions", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LeadSourceCode { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey LeadSourceType { get; private set; }
        public VocabularyKey Scores { get; private set; }
        public VocabularyKey ScoringGrade { get; private set; }
        public VocabularyKey InsightsPlaceholder { get; private set; }
        public VocabularyKey Profileid { get; private set; }
        public VocabularyKey ContactId { get; private set; }
        public VocabularyKey LeadId { get; private set; }
        public VocabularyKey PurchaseNeed { get; private set; }
        public VocabularyKey TriggerRecycle { get; private set; }
        public VocabularyKey Recycled { get; private set; }
        public VocabularyKey SalesAccepted { get; private set; }
        public VocabularyKey SalesReady { get; private set; }
        public VocabularyKey SasToken { get; private set; }
        public VocabularyKey TeleProspectAccepted { get; private set; }
        public VocabularyKey TeleProspectReady { get; private set; }
        public VocabularyKey CompanySize { get; private set; }
        public VocabularyKey Degree { get; private set; }
        public VocabularyKey FieldOfStudy { get; private set; }
        public VocabularyKey GraduationDate { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey JobFunction { get; private set; }
        public VocabularyKey LatestFormSubmissionDate { get; private set; }
        public VocabularyKey School { get; private set; }
        public VocabularyKey Seniority { get; private set; }
        public VocabularyKey StartDate { get; private set; }
        public VocabularyKey LinkedInFormSubmissions { get; private set; }
    }
}