using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class GrantVocabulary : SimpleVocabulary
    {
        public GrantVocabulary()
        {
            VocabularyName = "Grant";
            KeyPrefix = "commonDataModel.grant.highereducation";
            KeySeparator = ".";
            Grouping = "/Grant";

            AddGroup("Grant Details for HigherEducation", group =>
            {
			    GrantId = group.Add(new VocabularyKey(nameof(GrantId), "Grant", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Amount = group.Add(new VocabularyKey(nameof(Amount), "Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Amount_Base = group.Add(new VocabularyKey(nameof(Amount_Base), "Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ApplicationDeadlineDate = group.Add(new VocabularyKey(nameof(ApplicationDeadlineDate), "Application Deadline Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Qualifications = group.Add(new VocabularyKey(nameof(Qualifications), "Qualifications", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), "Valid From", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), "Valid To", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebsiteURL = group.Add(new VocabularyKey(nameof(WebsiteURL), "Website URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    WorkDescription = group.Add(new VocabularyKey(nameof(WorkDescription), "Work Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey GrantId { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Amount { get; private set; }
        public VocabularyKey Amount_Base { get; private set; }
        public VocabularyKey ApplicationDeadlineDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Qualifications { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey WebsiteURL { get; private set; }
        public VocabularyKey WorkDescription { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}