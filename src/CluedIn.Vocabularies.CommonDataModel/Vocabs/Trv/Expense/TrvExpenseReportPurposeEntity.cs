using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvExpenseReportPurposeEntityVocabulary : SimpleVocabulary
    {
        public TrvExpenseReportPurposeEntityVocabulary()
        {
            VocabularyName = "TrvExpenseReportPurposeEntity";
            KeyPrefix = "commonDataModel.trvexpensereportpurposeentity";
            KeySeparator = ".";
            Grouping = "/TrvExpenseReportPurposeEntity";

            AddGroup("TrvExpenseReportPurposeEntity Details", group =>
            {
                Purpose = group.Add(new VocabularyKey(nameof(Purpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Purpose { get; private set; }


    }
}