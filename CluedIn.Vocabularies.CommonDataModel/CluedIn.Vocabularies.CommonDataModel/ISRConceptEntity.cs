using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ISRConceptEntityVocabulary : SimpleVocabulary
    {
        public ISRConceptEntityVocabulary()
        {
            VocabularyName = "Common Data Model ISRConceptEntity";
            KeyPrefix = "commonDataModel.isrconceptentity";
            KeySeparator = ".";
            Grouping = "/ISRConceptEntity";

            AddGroup("Common Data Model ISRConceptEntity Details", group =>
            {
                DebitCreditIndicator = group.Add(new VocabularyKey(nameof(DebitCreditIndicator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Concept = group.Add(new VocabularyKey(nameof(Concept), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ConceptId = group.Add(new VocabularyKey(nameof(ConceptId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerChartOfAccounts = group.Add(new VocabularyKey(nameof(LedgerChartOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ChartOfAccountsName = group.Add(new VocabularyKey(nameof(ChartOfAccountsName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey DebitCreditIndicator { get; private set; }
public VocabularyKey Concept { get; private set; }
public VocabularyKey MainAccount { get; private set; }
public VocabularyKey ConceptId { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey LedgerChartOfAccounts { get; private set; }
public VocabularyKey MainAccountId { get; private set; }
public VocabularyKey ChartOfAccountsName { get; private set; }


    }
}