using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxNIPTableEntityVocabulary : SimpleVocabulary
    {
        public TaxNIPTableEntityVocabulary()
        {
            VocabularyName = "Tax NIP Table Entity";
            KeyPrefix = "commonDataModel.taxniptableentity";
            KeySeparator = ".";
            Grouping = "/TaxNIPTableEntity";

            AddGroup("TaxNIPTableEntity Details", group =>
            {
                AccountName = group.Add(new VocabularyKey(nameof(AccountName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Addressing = group.Add(new VocabularyKey(nameof(Addressing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Code = group.Add(new VocabularyKey(nameof(Code), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NIPNumber = group.Add(new VocabularyKey(nameof(NIPNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountName { get; private set; }
        public VocabularyKey Addressing { get; private set; }
        public VocabularyKey Code { get; private set; }
        public VocabularyKey NIPNumber { get; private set; }
    }
}