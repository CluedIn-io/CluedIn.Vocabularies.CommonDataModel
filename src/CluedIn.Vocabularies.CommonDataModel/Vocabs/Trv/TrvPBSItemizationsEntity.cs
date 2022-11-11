using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvPBSItemizationsEntityVocabulary : SimpleVocabulary
    {
        public TrvPBSItemizationsEntityVocabulary()
        {
            VocabularyName = "TrvPBSItemizationsEntity";
            KeyPrefix = "commonDataModel.trvpbsitemizationsentity";
            KeySeparator = ".";
            Grouping = "/TrvPBSItemizationsEntity";

            AddGroup("TrvPBSItemizationsEntity Details", group =>
            {
                CCTransUniqueID = group.Add(new VocabularyKey(nameof(CCTransUniqueID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubcategoryCode = group.Add(new VocabularyKey(nameof(SubcategoryCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount_CreditCardCurrency = group.Add(new VocabularyKey(nameof(Amount_CreditCardCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Amount_LocalCurrency = group.Add(new VocabularyKey(nameof(Amount_LocalCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchCode_CreditCardCurrency = group.Add(new VocabularyKey(nameof(ExchCode_CreditCardCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExchCode_LocalCurrency = group.Add(new VocabularyKey(nameof(ExchCode_LocalCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CCTransUniqueID { get; private set; }
        public VocabularyKey SubcategoryCode { get; private set; }
        public VocabularyKey Amount_CreditCardCurrency { get; private set; }
        public VocabularyKey Amount_LocalCurrency { get; private set; }
        public VocabularyKey ExchCode_CreditCardCurrency { get; private set; }
        public VocabularyKey ExchCode_LocalCurrency { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }


    }
}