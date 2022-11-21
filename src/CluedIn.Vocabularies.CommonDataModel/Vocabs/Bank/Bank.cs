using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankVocabulary : SimpleVocabulary
    {
        public BankVocabulary()
        {
            VocabularyName = "Bank";
            KeyPrefix = "commonDataModel.bank";
            KeySeparator = ".";
            Grouping = "/Bank";

            AddGroup("Bank Details", group =>
            {
                BankId = group.Add(new VocabularyKey(nameof(BankId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BankId { get; private set; }
    }
}