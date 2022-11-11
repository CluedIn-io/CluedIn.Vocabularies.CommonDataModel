using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvExpenseMerchantEntityVocabulary : SimpleVocabulary
    {
        public TrvExpenseMerchantEntityVocabulary()
        {
            VocabularyName = "TrvExpenseMerchantEntity";
            KeyPrefix = "commonDataModel.trvexpensemerchantentity";
            KeySeparator = ".";
            Grouping = "/TrvExpenseMerchantEntity";

            AddGroup("TrvExpenseMerchantEntity Details", group =>
            {
                ExpenseType = group.Add(new VocabularyKey(nameof(ExpenseType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MerchantId = group.Add(new VocabularyKey(nameof(MerchantId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Preferred = group.Add(new VocabularyKey(nameof(Preferred), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ExpenseType { get; private set; }
        public VocabularyKey MerchantId { get; private set; }
        public VocabularyKey Preferred { get; private set; }


    }
}