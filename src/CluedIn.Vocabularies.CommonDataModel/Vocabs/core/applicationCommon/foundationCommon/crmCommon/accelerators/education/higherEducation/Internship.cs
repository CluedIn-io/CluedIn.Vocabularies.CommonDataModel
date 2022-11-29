using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.HigherEducation
{
    public class InternshipVocabulary : SimpleVocabulary
    {
        public InternshipVocabulary()
        {
            VocabularyName = "Internship";
            KeyPrefix = "commonDataModel.internship.highereducation";
            KeySeparator = ".";
            Grouping = "/Internship";

            AddGroup("Internship Details for HigherEducation", group =>
            {
			    InternshipId = group.Add(new VocabularyKey(nameof(InternshipId), "Internship", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ApplicationDeadlineDate = group.Add(new VocabularyKey(nameof(ApplicationDeadlineDate), "Application Deadline Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsPaid = group.Add(new VocabularyKey(nameof(IsPaid), "IsPaid", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    LocationDescription = group.Add(new VocabularyKey(nameof(LocationDescription), "Location Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    PostedDate = group.Add(new VocabularyKey(nameof(PostedDate), "PostedDate", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Qualifications = group.Add(new VocabularyKey(nameof(Qualifications), "Qualifications", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), "ValidFrom", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), "ValidTo", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    WebsiteURL = group.Add(new VocabularyKey(nameof(WebsiteURL), "Website URL", VocabularyKeyDataType.Uri, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey InternshipId { get; private set; }
        public VocabularyKey ApplicationDeadlineDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsPaid { get; private set; }
        public VocabularyKey LocationDescription { get; private set; }
        public VocabularyKey PostedDate { get; private set; }
        public VocabularyKey Qualifications { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey WebsiteURL { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}