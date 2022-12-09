using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Vocabularies.CommonDataModel
{
    public class LedgerVocabulary : SimpleVocabulary
    {
        public LedgerVocabulary()
        {
            VocabularyName = "Ledger";
            KeyPrefix = "commonDataModel.ledger";
            KeySeparator = ".";
            Grouping = CommonDataModelEntityTypes.Ledger;

            AddGroup("Ledger Details for FinancialCommon", group =>
            {
			    LedgerId = group.Add(new VocabularyKey(nameof(LedgerId), "LedgerId", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
            });
            
            #region Incoming Relationships
            ///Property <see cref="CompanyKey"/> to Vocab '/core/applicationCommon/foundationCommon/Company.cdm.json/Company' with Property 'CompanyId'
            ///Property <see cref="AccountingCurrencyKey"/> to Vocab '/core/applicationCommon/Currency.cdm.json/Currency' with Property 'TransactionCurrencyId'
            #endregion
            
            #region Outgoing Relationships
            ///Property <see cref="LedgerId"/> from Vocab 'FinancialActivity.cdm.json/FinancialActivity' with Property 'LedgerId'
            #endregion
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey LedgerId { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}