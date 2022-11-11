using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTax25TaxTableEntityVocabulary : SimpleVocabulary
    {
        public RTax25TaxTableEntityVocabulary()
        {
            VocabularyName = "Common Data Model RTax25TaxTableEntity";
            KeyPrefix = "commonDataModel.rtax25taxtableentity";
            KeySeparator = ".";
            Grouping = "/RTax25TaxTableEntity";

            AddGroup("Common Data Model RTax25TaxTableEntity Details", group =>
            {
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeOfTax = group.Add(new VocabularyKey(nameof(TypeOfTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Module = group.Add(new VocabularyKey(nameof(Module), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseCode = group.Add(new VocabularyKey(nameof(ExpenseCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccountDisplayValue = group.Add(new VocabularyKey(nameof(MainAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey TypeOfTax { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey Module { get; private set; }
        public VocabularyKey ExpenseCode { get; private set; }
        public VocabularyKey MainAccountDisplayValue { get; private set; }


    }
}