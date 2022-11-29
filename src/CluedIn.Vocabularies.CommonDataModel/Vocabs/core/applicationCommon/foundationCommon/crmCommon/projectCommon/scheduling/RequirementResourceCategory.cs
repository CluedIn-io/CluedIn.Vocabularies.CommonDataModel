using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Scheduling
{
    public class RequirementResourceCategoryVocabulary : SimpleVocabulary
    {
        public RequirementResourceCategoryVocabulary()
        {
            VocabularyName = "Requirement Resource Category";
            KeyPrefix = "commonDataModel.requirementresourcecategory.scheduling";
            KeySeparator = ".";
            Grouping = "/RequirementResourceCategory";

            AddGroup("RequirementResourceCategory Details for Scheduling", group =>
            {
			    RequirementResourceCategoryId = group.Add(new VocabularyKey(nameof(RequirementResourceCategoryId), "Requirement Resource Category", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IsPrimary = group.Add(new VocabularyKey(nameof(IsPrimary), "Is Primary", VocabularyKeyDataType.Boolean, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey RequirementResourceCategoryId { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey IsPrimary { get; private set; }
    }
}