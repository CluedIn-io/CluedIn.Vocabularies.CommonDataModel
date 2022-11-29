using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.FinancialCommon
{
    public class MainAccountVocabulary : SimpleVocabulary
    {
        public MainAccountVocabulary()
        {
            VocabularyName = "Main Account";
            KeyPrefix = "commonDataModel.mainaccount.financialcommon";
            KeySeparator = ".";
            Grouping = "/MainAccount";

            AddGroup("MainAccount Details for FinancialCommon", group =>
            {
			    MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), "MainAccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Number = group.Add(new VocabularyKey(nameof(Number), "Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Number { get; private set; }
    }
}