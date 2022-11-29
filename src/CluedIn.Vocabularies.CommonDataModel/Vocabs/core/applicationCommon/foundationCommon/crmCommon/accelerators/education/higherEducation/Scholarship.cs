using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class ScholarshipVocabulary : SimpleVocabulary
    {
        public ScholarshipVocabulary()
        {
            VocabularyName = "Scholarship";
            KeyPrefix = "commonDataModel.scholarship.highereducation";
            KeySeparator = ".";
            Grouping = "/Scholarship";

            AddGroup("Scholarship Details for HigherEducation", group =>
            {
			    ScholarshipId = group.Add(new VocabularyKey(nameof(ScholarshipId), "Scholarship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Amount_Base = group.Add(new VocabularyKey(nameof(Amount_Base), "Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ApplicationDeadlineDate = group.Add(new VocabularyKey(nameof(ApplicationDeadlineDate), "Application Deadline Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostedDate = group.Add(new VocabularyKey(nameof(PostedDate), "Posted Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Qualifications = group.Add(new VocabularyKey(nameof(Qualifications), "Qualifications", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Type = group.Add(new VocabularyKey(nameof(Type), "Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebsiteURL = group.Add(new VocabularyKey(nameof(WebsiteURL), "Website URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ScholarshipId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Amount_Base { get; private set; }
        public VocabularyKey ApplicationDeadlineDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey PostedDate { get; private set; }
        public VocabularyKey Qualifications { get; private set; }
        public VocabularyKey Type { get; private set; }
        public VocabularyKey WebsiteURL { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}