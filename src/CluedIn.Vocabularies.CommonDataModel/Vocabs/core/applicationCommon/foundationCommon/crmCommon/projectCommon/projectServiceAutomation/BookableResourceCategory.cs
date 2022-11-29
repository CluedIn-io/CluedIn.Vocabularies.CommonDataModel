using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class BookableResourceCategoryVocabulary : SimpleVocabulary
    {
        public BookableResourceCategoryVocabulary()
        {
            VocabularyName = "Bookable Resource Category";
            KeyPrefix = "commonDataModel.bookableresourcecategory.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/BookableResourceCategory";

            AddGroup("BookableResourceCategory Details for ProjectServiceAutomation", group =>
            {
			    BillingType = group.Add(new VocabularyKey(nameof(BillingType), "Billing Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    TargetUtilization = group.Add(new VocabularyKey(nameof(TargetUtilization), "Target Utilization", VocabularyKeyDataType.Integer, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BillingType { get; private set; }
        public VocabularyKey TargetUtilization { get; private set; }
    }
}