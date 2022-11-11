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
                bankId = group.Add(new VocabularyKey(nameof(bankId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey bankId { get; private set; }


    }
}