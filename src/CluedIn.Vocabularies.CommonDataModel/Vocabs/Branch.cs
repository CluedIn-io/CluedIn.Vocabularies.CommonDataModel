using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BranchVocabulary : SimpleVocabulary
    {
        public BranchVocabulary()
        {
            VocabularyName = "Branch";
            KeyPrefix = "commonDataModel.branch";
            KeySeparator = ".";
            Grouping = "/Branch";

            AddGroup("Branch Details", group =>
            {
                BranchId = group.Add(new VocabularyKey(nameof(BranchId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BranchId { get; private set; }
    }
}