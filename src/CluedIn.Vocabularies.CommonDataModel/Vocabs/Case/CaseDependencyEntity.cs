using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CaseDependencyEntityVocabulary : SimpleVocabulary
    {
        public CaseDependencyEntityVocabulary()
        {
            VocabularyName = "Case Dependency Entity";
            KeyPrefix = "commonDataModel.casedependencyentity";
            KeySeparator = ".";
            Grouping = "/CaseDependencyEntity";

            AddGroup("CaseDependencyEntity Details", group =>
            {
                Case = group.Add(new VocabularyKey(nameof(Case), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentCase = group.Add(new VocabularyKey(nameof(ParentCase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CaseId = group.Add(new VocabularyKey(nameof(CaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentCaseId = group.Add(new VocabularyKey(nameof(ParentCaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Case { get; private set; }
        public VocabularyKey ParentCase { get; private set; }
        public VocabularyKey CaseId { get; private set; }
        public VocabularyKey ParentCaseId { get; private set; }
    }
}