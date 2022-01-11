using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendorPaymentJournalLineSettledInvoiceEntityVocabulary : SimpleVocabulary
    {
        public VendorPaymentJournalLineSettledInvoiceEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendorPaymentJournalLineSettledInvoiceEntity";
            KeyPrefix = "commonDataModel.vendorpaymentjournallinesettledinvoiceentity";
            KeySeparator = ".";
            Grouping = "/VendorPaymentJournalLineSettledInvoiceEntity";

            AddGroup("Common Data Model VendorPaymentJournalLineSettledInvoiceEntity Details", group =>
            {
                SettlementAmountInInvoiceCurrency = group.Add(new VocabularyKey(nameof(SettlementAmountInInvoiceCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountToTakeInInvoiceCurrency = group.Add(new VocabularyKey(nameof(CashDiscountToTakeInInvoiceCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceToPaymentCrossRate = group.Add(new VocabularyKey(nameof(InvoiceToPaymentCrossRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalLineCompany = group.Add(new VocabularyKey(nameof(JournalLineCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalBatchNumber = group.Add(new VocabularyKey(nameof(JournalBatchNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalLineAccountType = group.Add(new VocabularyKey(nameof(JournalLineAccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
JournalLineNumber = group.Add(new VocabularyKey(nameof(JournalLineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceNumber = group.Add(new VocabularyKey(nameof(InvoiceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceCompany = group.Add(new VocabularyKey(nameof(InvoiceCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceDueDate = group.Add(new VocabularyKey(nameof(InvoiceDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
invoiceAccount = group.Add(new VocabularyKey(nameof(invoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SettlementAmountInInvoiceCurrency { get; private set; }
public VocabularyKey CashDiscountToTakeInInvoiceCurrency { get; private set; }
public VocabularyKey InvoiceToPaymentCrossRate { get; private set; }
public VocabularyKey JournalLineCompany { get; private set; }
public VocabularyKey JournalBatchNumber { get; private set; }
public VocabularyKey JournalLineAccountType { get; private set; }
public VocabularyKey JournalLineNumber { get; private set; }
public VocabularyKey InvoiceNumber { get; private set; }
public VocabularyKey InvoiceCompany { get; private set; }
public VocabularyKey InvoiceDueDate { get; private set; }
public VocabularyKey Account { get; private set; }
public VocabularyKey AccountDisplayValue { get; private set; }
public VocabularyKey invoiceAccount { get; private set; }


    }
}