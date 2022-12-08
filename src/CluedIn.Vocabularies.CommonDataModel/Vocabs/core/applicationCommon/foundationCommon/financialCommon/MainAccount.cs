using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel.FinancialCommon
{
    public class MainAccountVocabulary : SimpleVocabulary
    {
        public MainAccountVocabulary()
        {
            VocabularyName = "Main Account";
            KeyPrefix = "commonDataModel.mainaccount.financialcommon";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.MainAccount;

            AddGroup("MainAccount Details for FinancialCommon", group =>
            {
			    MainAccountId = group.Add(new VocabularyKey(nameof(MainAccountId), "MainAccountId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Number = group.Add(new VocabularyKey(nameof(Number), "Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
            
            #region Incoming Relationships
            ///Property <see cref="MainAccountCategoryKey"/> to Vocab 'MainAccountCategory.cdm.json/MainAccountCategory' with Property 'MainAccountCategoryId'
            ///Property <see cref="CurrencyKey"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="MainAccountCategoryId"/> from Vocab 'FinancialActivity.cdm.json/FinancialActivity' with Property 'MainAccountCategoryKey'
            ///Property <see cref="MainAccountId"/> from Vocab 'FinancialActivity.cdm.json/FinancialActivity' with Property 'MainAccountKey'
            ///Property <see cref="MainAccountCategoryId"/> from Vocab 'MainAccount.cdm.json/MainAccount' with Property 'MainAccountCategoryKey'
            #endregion
        }

        public VocabularyKey MainAccountId { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Number { get; private set; }
    }
}