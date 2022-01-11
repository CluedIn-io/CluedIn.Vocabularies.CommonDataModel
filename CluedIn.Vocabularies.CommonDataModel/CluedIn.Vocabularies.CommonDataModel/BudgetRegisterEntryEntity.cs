using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BudgetRegisterEntryEntityVocabulary : SimpleVocabulary
    {
        public BudgetRegisterEntryEntityVocabulary()
        {
            VocabularyName = "Common Data Model BudgetRegisterEntryEntity";
            KeyPrefix = "commonDataModel.budgetregisterentryentity";
            KeySeparator = ".";
            Grouping = "/BudgetRegisterEntryEntity";

            AddGroup("Common Data Model BudgetRegisterEntryEntity Details", group =>
            {
                AccountingCurrencyAmount = group.Add(new VocabularyKey(nameof(AccountingCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AmountType = group.Add(new VocabularyKey(nameof(AmountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetCode = group.Add(new VocabularyKey(nameof(BudgetCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetModelId = group.Add(new VocabularyKey(nameof(BudgetModelId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetTransactionCode = group.Add(new VocabularyKey(nameof(BudgetTransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetTransactionHeaderRecId = group.Add(new VocabularyKey(nameof(BudgetTransactionHeaderRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BudgetType = group.Add(new VocabularyKey(nameof(BudgetType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Comment = group.Add(new VocabularyKey(nameof(Comment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionAccountStructure = group.Add(new VocabularyKey(nameof(DimensionAccountStructure), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EntryNumber = group.Add(new VocabularyKey(nameof(EntryNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeInCashFlowForecast = group.Add(new VocabularyKey(nameof(IncludeInCashFlowForecast), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InUseBy = group.Add(new VocabularyKey(nameof(InUseBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrimaryLedgerId = group.Add(new VocabularyKey(nameof(PrimaryLedgerId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OneTimeRevision = group.Add(new VocabularyKey(nameof(OneTimeRevision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Price = group.Add(new VocabularyKey(nameof(Price), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Quantity = group.Add(new VocabularyKey(nameof(Quantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonComment = group.Add(new VocabularyKey(nameof(ReasonComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ReasonTableRef = group.Add(new VocabularyKey(nameof(ReasonTableRef), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionCurrencyAmount = group.Add(new VocabularyKey(nameof(TransactionCurrencyAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineWorkflowStatus = group.Add(new VocabularyKey(nameof(LineWorkflowStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentWorkflowStatus = group.Add(new VocabularyKey(nameof(DocumentWorkflowStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey AccountingCurrencyAmount { get; private set; }
public VocabularyKey AmountType { get; private set; }
public VocabularyKey BudgetCode { get; private set; }
public VocabularyKey BudgetModelId { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey BudgetTransactionCode { get; private set; }
public VocabularyKey BudgetTransactionHeaderRecId { get; private set; }
public VocabularyKey BudgetType { get; private set; }
public VocabularyKey Comment { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey Date { get; private set; }
public VocabularyKey Dimension { get; private set; }
public VocabularyKey DimensionAccountStructure { get; private set; }
public VocabularyKey DimensionDisplayValue { get; private set; }
public VocabularyKey EntryNumber { get; private set; }
public VocabularyKey IncludeInCashFlowForecast { get; private set; }
public VocabularyKey InUseBy { get; private set; }
public VocabularyKey PrimaryLedgerId { get; private set; }
public VocabularyKey LegalEntityId { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey OneTimeRevision { get; private set; }
public VocabularyKey Price { get; private set; }
public VocabularyKey Quantity { get; private set; }
public VocabularyKey ReasonCode { get; private set; }
public VocabularyKey ReasonComment { get; private set; }
public VocabularyKey ReasonTableRef { get; private set; }
public VocabularyKey TransactionCurrencyAmount { get; private set; }
public VocabularyKey LineWorkflowStatus { get; private set; }
public VocabularyKey DocumentWorkflowStatus { get; private set; }


    }
}