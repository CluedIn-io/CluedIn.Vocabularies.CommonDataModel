using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxReport347AccountEntityVocabulary : SimpleVocabulary
    {
        public TaxReport347AccountEntityVocabulary()
        {
            VocabularyName = "Tax Report 347 Account Entity";
            KeyPrefix = "commonDataModel.taxreport347accountentity";
            KeySeparator = ".";
            Grouping = "/TaxReport347AccountEntity";

            AddGroup("TaxReport347AccountEntity Details", group =>
            {
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}