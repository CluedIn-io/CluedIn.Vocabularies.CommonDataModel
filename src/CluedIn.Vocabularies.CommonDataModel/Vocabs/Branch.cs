using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BranchVocabulary : SimpleVocabulary
    {
        public BranchVocabulary()
        {
            VocabularyName = "Common Data Model Branch";
            KeyPrefix = "commonDataModel.branch";
            KeySeparator = ".";
            Grouping = "/Branch";

            AddGroup("Common Data Model Branch Details", group =>
            {
                branchId = group.Add(new VocabularyKey(nameof(branchId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey branchId { get; private set; }


    }
}