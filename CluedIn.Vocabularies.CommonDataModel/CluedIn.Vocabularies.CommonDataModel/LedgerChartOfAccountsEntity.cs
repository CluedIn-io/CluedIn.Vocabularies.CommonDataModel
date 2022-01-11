using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerChartOfAccountsEntityVocabulary : SimpleVocabulary
    {
        public LedgerChartOfAccountsEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerChartOfAccountsEntity";
            KeyPrefix = "commonDataModel.ledgerchartofaccountsentity";
            KeySeparator = ".";
            Grouping = "/LedgerChartOfAccountsEntity";

            AddGroup("Common Data Model LedgerChartOfAccountsEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountMask = group.Add(new VocabularyKey(nameof(MainAccountMask), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChartOfAccounts = group.Add(new VocabularyKey(nameof(ChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChartOfAccountsRecId = group.Add(new VocabularyKey(nameof(ChartOfAccountsRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Description { get; private set; }
public VocabularyKey MainAccountMask { get; private set; }
public VocabularyKey ChartOfAccounts { get; private set; }
public VocabularyKey ChartOfAccountsRecId { get; private set; }


    }
}