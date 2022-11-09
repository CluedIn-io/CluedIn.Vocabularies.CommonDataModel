using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerFiscalCloseLedgerOptionsEntityVocabulary : SimpleVocabulary
    {
        public LedgerFiscalCloseLedgerOptionsEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerFiscalCloseLedgerOptionsEntity";
            KeyPrefix = "commonDataModel.ledgerfiscalcloseledgeroptionsentity";
            KeySeparator = ".";
            Grouping = "/LedgerFiscalCloseLedgerOptionsEntity";

            AddGroup("Common Data Model LedgerFiscalCloseLedgerOptionsEntity Details", group =>
            {
                LedgerFiscalCloseGroup = group.Add(new VocabularyKey(nameof(LedgerFiscalCloseGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Ledger = group.Add(new VocabularyKey(nameof(Ledger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetainedEarningsMainAccount = group.Add(new VocabularyKey(nameof(RetainedEarningsMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransferBalanceSheetDimensions = group.Add(new VocabularyKey(nameof(TransferBalanceSheetDimensions), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfitLossCloseDimension = group.Add(new VocabularyKey(nameof(ProfitLossCloseDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfitLossDefaultDimension = group.Add(new VocabularyKey(nameof(ProfitLossDefaultDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerFiscalCloseGroupName = group.Add(new VocabularyKey(nameof(LedgerFiscalCloseGroupName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerName = group.Add(new VocabularyKey(nameof(LedgerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfitLossDefaultDimensionDisplayValue = group.Add(new VocabularyKey(nameof(ProfitLossDefaultDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProfitLossCloseDimensionDisplayValue = group.Add(new VocabularyKey(nameof(ProfitLossCloseDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey LedgerFiscalCloseGroup { get; private set; }
public VocabularyKey Ledger { get; private set; }
public VocabularyKey RetainedEarningsMainAccount { get; private set; }
public VocabularyKey TransferBalanceSheetDimensions { get; private set; }
public VocabularyKey ProfitLossCloseDimension { get; private set; }
public VocabularyKey ProfitLossDefaultDimension { get; private set; }
public VocabularyKey LedgerFiscalCloseGroupName { get; private set; }
public VocabularyKey LedgerName { get; private set; }
public VocabularyKey ProfitLossDefaultDimensionDisplayValue { get; private set; }
public VocabularyKey LegalEntity { get; private set; }
public VocabularyKey ProfitLossCloseDimensionDisplayValue { get; private set; }


    }
}