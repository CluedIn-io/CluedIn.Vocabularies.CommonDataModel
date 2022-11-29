using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class EmploymentHistoryVocabulary : SimpleVocabulary
    {
        public EmploymentHistoryVocabulary()
        {
            VocabularyName = "Employment History";
            KeyPrefix = "commonDataModel.employmenthistory.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/EmploymentHistory";

            AddGroup("EmploymentHistory Details for NonProfitCore", group =>
            {
			    CurrentEmployment = group.Add(new VocabularyKey(nameof(CurrentEmployment), "Current Employment", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible)); 
			    EmployerName = group.Add(new VocabularyKey(nameof(EmployerName), "Employer Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmploymentEndDate = group.Add(new VocabularyKey(nameof(EmploymentEndDate), "Employment End Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmploymentHistoryId = group.Add(new VocabularyKey(nameof(EmploymentHistoryId), "Employment History", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    EmploymentStartDate = group.Add(new VocabularyKey(nameof(EmploymentStartDate), "Employment Start Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Industry = group.Add(new VocabularyKey(nameof(Industry), "Industry", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Occupation = group.Add(new VocabularyKey(nameof(Occupation), "Occupation", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Title = group.Add(new VocabularyKey(nameof(Title), "Title", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CurrentEmployment { get; private set; }
        public VocabularyKey EmployerName { get; private set; }
        public VocabularyKey EmploymentEndDate { get; private set; }
        public VocabularyKey EmploymentHistoryId { get; private set; }
        public VocabularyKey EmploymentStartDate { get; private set; }
        public VocabularyKey Industry { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Occupation { get; private set; }
        public VocabularyKey Title { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}