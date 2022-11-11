using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustomChequeLayoutEntityVocabulary : SimpleVocabulary
    {
        public CustomChequeLayoutEntityVocabulary()
        {
            VocabularyName = "CustomChequeLayoutEntity";
            KeyPrefix = "commonDataModel.customchequelayoutentity";
            KeySeparator = ".";
            Grouping = "/CustomChequeLayoutEntity";

            AddGroup("CustomChequeLayoutEntity Details", group =>
            {
                LayoutId = group.Add(new VocabularyKey(nameof(LayoutId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportName = group.Add(new VocabularyKey(nameof(ReportName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LayoutId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ReportName { get; private set; }


    }
}