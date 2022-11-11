using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvExpensePurposeEntityVocabulary : SimpleVocabulary
    {
        public TrvExpensePurposeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TrvExpensePurposeEntity";
            KeyPrefix = "commonDataModel.trvexpensepurposeentity";
            KeySeparator = ".";
            Grouping = "/TrvExpensePurposeEntity";

            AddGroup("Common Data Model TrvExpensePurposeEntity Details", group =>
            {
                BusinessPurpose = group.Add(new VocabularyKey(nameof(BusinessPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseType = group.Add(new VocabularyKey(nameof(ExpenseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey BusinessPurpose { get; private set; }
        public VocabularyKey ExpenseType { get; private set; }


    }
}