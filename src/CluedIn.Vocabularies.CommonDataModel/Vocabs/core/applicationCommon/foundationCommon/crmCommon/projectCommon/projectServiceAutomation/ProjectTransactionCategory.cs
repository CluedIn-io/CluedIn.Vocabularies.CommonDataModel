using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class ProjectTransactionCategoryVocabulary : SimpleVocabulary
    {
        public ProjectTransactionCategoryVocabulary()
        {
            VocabularyName = "Project Transaction Category";
            KeyPrefix = "commonDataModel.projecttransactioncategory.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/ProjectTransactionCategory";

            AddGroup("ProjectTransactionCategory Details for ProjectServiceAutomation", group =>
            {
			    ProjectTransactionCategoryId = group.Add(new VocabularyKey(nameof(ProjectTransactionCategoryId), "Project Transaction Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ProjectTransactionCategoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey BillingType { get; private set; }
    }
}