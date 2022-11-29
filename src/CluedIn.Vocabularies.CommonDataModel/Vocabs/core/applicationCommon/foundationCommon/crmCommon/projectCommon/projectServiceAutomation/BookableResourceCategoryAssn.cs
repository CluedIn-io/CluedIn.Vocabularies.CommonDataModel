using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.ProjectServiceAutomation
{
    public class BookableResourceCategoryAssnVocabulary : SimpleVocabulary
    {
        public BookableResourceCategoryAssnVocabulary()
        {
            VocabularyName = "Bookable Resource Category Assn";
            KeyPrefix = "commonDataModel.bookableresourcecategoryassn.projectserviceautomation";
            KeySeparator = ".";
            Grouping = "/BookableResourceCategoryAssn";

            AddGroup("BookableResourceCategoryAssn Details for ProjectServiceAutomation", group =>
            {
			    IsDefault = group.Add(new VocabularyKey(nameof(IsDefault), "Is Default", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey IsDefault { get; private set; }
    }
}