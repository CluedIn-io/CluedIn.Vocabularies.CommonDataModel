using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjContractEntityVocabulary : SimpleVocabulary
    {
        public ProjContractEntityVocabulary()
        {
            VocabularyName = "Common Data Model ProjContractEntity";
            KeyPrefix = "commonDataModel.projcontractentity";
            KeySeparator = ".";
            Grouping = "/ProjContractEntity";

            AddGroup("Common Data Model ProjContractEntity Details", group =>
            {
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CentralBankPurposeCode = group.Add(new VocabularyKey(nameof(CentralBankPurposeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurposeText = group.Add(new VocabularyKey(nameof(PurposeText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceFrequency = group.Add(new VocabularyKey(nameof(InvoiceFrequency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ListCodeId = group.Add(new VocabularyKey(nameof(ListCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MinimumTimeIncrement = group.Add(new VocabularyKey(nameof(MinimumTimeIncrement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoicingName = group.Add(new VocabularyKey(nameof(InvoicingName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
NetPrice = group.Add(new VocabularyKey(nameof(NetPrice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProjectContractID = group.Add(new VocabularyKey(nameof(ProjectContractID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LockContractSalesCurrency = group.Add(new VocabularyKey(nameof(LockContractSalesCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PriceGroup = group.Add(new VocabularyKey(nameof(PriceGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContractDate = group.Add(new VocabularyKey(nameof(ContractDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContractLines = group.Add(new VocabularyKey(nameof(ContractLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProgressInvoicing = group.Add(new VocabularyKey(nameof(ProgressInvoicing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetainagePercent = group.Add(new VocabularyKey(nameof(RetainagePercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerRetentionTermId = group.Add(new VocabularyKey(nameof(CustomerRetentionTermId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesResponsible = group.Add(new VocabularyKey(nameof(SalesResponsible), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroup = group.Add(new VocabularyKey(nameof(SalesTaxGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceOnDeliveryAddress = group.Add(new VocabularyKey(nameof(ServiceOnDeliveryAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DefaultPostingLevel = group.Add(new VocabularyKey(nameof(DefaultPostingLevel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionCode = group.Add(new VocabularyKey(nameof(TransactionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesResponsiblePersonnelNumber = group.Add(new VocabularyKey(nameof(SalesResponsiblePersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesCurrency = group.Add(new VocabularyKey(nameof(SalesCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BankAccount { get; private set; }
public VocabularyKey CentralBankPurposeCode { get; private set; }
public VocabularyKey PurposeText { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey InvoiceFrequency { get; private set; }
public VocabularyKey ListCodeId { get; private set; }
public VocabularyKey MinimumTimeIncrement { get; private set; }
public VocabularyKey InvoicingName { get; private set; }
public VocabularyKey NetPrice { get; private set; }
public VocabularyKey ProjectContractID { get; private set; }
public VocabularyKey LockContractSalesCurrency { get; private set; }
public VocabularyKey PriceGroup { get; private set; }
public VocabularyKey ContractDate { get; private set; }
public VocabularyKey ContractLines { get; private set; }
public VocabularyKey ProgressInvoicing { get; private set; }
public VocabularyKey RetainagePercent { get; private set; }
public VocabularyKey CustomerRetentionTermId { get; private set; }
public VocabularyKey SalesResponsible { get; private set; }
public VocabularyKey SalesTaxGroup { get; private set; }
public VocabularyKey ServiceOnDeliveryAddress { get; private set; }
public VocabularyKey DefaultPostingLevel { get; private set; }
public VocabularyKey TransactionCode { get; private set; }
public VocabularyKey SalesResponsiblePersonnelNumber { get; private set; }
public VocabularyKey SalesCurrency { get; private set; }


    }
}