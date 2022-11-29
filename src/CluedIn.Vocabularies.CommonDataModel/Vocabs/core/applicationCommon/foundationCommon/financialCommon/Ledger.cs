using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FinancialCommon
{
    public class LedgerVocabulary : SimpleVocabulary
    {
        public LedgerVocabulary()
        {
            VocabularyName = "Ledger";
            KeyPrefix = "commonDataModel.ledger.financialcommon";
            KeySeparator = ".";
            Grouping = "/Ledger";

            AddGroup("Ledger Details for FinancialCommon", group =>
            {
			    LedgerId = group.Add(new VocabularyKey(nameof(LedgerId), "LedgerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey LedgerId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}