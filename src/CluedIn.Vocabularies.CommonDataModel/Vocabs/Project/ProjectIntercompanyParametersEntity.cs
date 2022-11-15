using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjectIntercompanyParametersEntityVocabulary : SimpleVocabulary
    {
        public ProjectIntercompanyParametersEntityVocabulary()
        {
            VocabularyName = "Project Intercompany Parameters Entity";
            KeyPrefix = "commonDataModel.projectintercompanyparametersentity";
            KeySeparator = ".";
            Grouping = "/ProjectIntercompanyParametersEntity";

            AddGroup("ProjectIntercompanyParametersEntity Details", group =>
            {
                BorrowingLegalEntity = group.Add(new VocabularyKey(nameof(BorrowingLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultExpenseCategory = group.Add(new VocabularyKey(nameof(DefaultExpenseCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultTimesheetCategory = group.Add(new VocabularyKey(nameof(DefaultTimesheetCategory), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccrueRevenue = group.Add(new VocabularyKey(nameof(AccrueRevenue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BorrowingLegalEntity { get; private set; }
        public VocabularyKey DefaultExpenseCategory { get; private set; }
        public VocabularyKey DefaultTimesheetCategory { get; private set; }
        public VocabularyKey AccrueRevenue { get; private set; }
    }
}