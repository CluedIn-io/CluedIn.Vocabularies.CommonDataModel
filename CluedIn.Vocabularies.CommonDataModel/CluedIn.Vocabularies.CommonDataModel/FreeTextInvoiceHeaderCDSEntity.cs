using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FreeTextInvoiceHeaderCDSEntityVocabulary : SimpleVocabulary
    {
        public FreeTextInvoiceHeaderCDSEntityVocabulary()
        {
            VocabularyName = "Common Data Model FreeTextInvoiceHeaderCDSEntity";
            KeyPrefix = "commonDataModel.freetextinvoiceheadercdsentity";
            KeySeparator = ".";
            Grouping = "/FreeTextInvoiceHeaderCDSEntity";

            AddGroup("Common Data Model FreeTextInvoiceHeaderCDSEntity Details", group =>
            {
                ExternalInvoiceId = group.Add(new VocabularyKey(nameof(ExternalInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountCode = group.Add(new VocabularyKey(nameof(CashDiscountCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CashDiscountDate = group.Add(new VocabularyKey(nameof(CashDiscountDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ComplimentedInvoiceId = group.Add(new VocabularyKey(nameof(ComplimentedInvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ContactPersonId = group.Add(new VocabularyKey(nameof(ContactPersonId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerGroup = group.Add(new VocabularyKey(nameof(CustomerGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerReference = group.Add(new VocabularyKey(nameof(CustomerReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerRequisition = group.Add(new VocabularyKey(nameof(CustomerRequisition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentDate = group.Add(new VocabularyKey(nameof(DocumentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DueDate = group.Add(new VocabularyKey(nameof(DueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FreeTextNumber = group.Add(new VocabularyKey(nameof(FreeTextNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
GiroType = group.Add(new VocabularyKey(nameof(GiroType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InclTax = group.Add(new VocabularyKey(nameof(InclTax), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceAccount = group.Add(new VocabularyKey(nameof(InvoiceAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceId = group.Add(new VocabularyKey(nameof(InvoiceId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceName = group.Add(new VocabularyKey(nameof(InvoiceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
InvoiceOriginType = group.Add(new VocabularyKey(nameof(InvoiceOriginType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPosted = group.Add(new VocabularyKey(nameof(IsPosted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPostedViaIntercompany = group.Add(new VocabularyKey(nameof(IsPostedViaIntercompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LanguageId = group.Add(new VocabularyKey(nameof(LanguageId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MethodOfPayment = group.Add(new VocabularyKey(nameof(MethodOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentSchedule = group.Add(new VocabularyKey(nameof(PaymentSchedule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentTermsBaseDate = group.Add(new VocabularyKey(nameof(PaymentTermsBaseDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PaymentTermsBaseDays = group.Add(new VocabularyKey(nameof(PaymentTermsBaseDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxGroupId = group.Add(new VocabularyKey(nameof(SalesTaxGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxItemGroupId = group.Add(new VocabularyKey(nameof(SalesTaxItemGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ExternalInvoiceId { get; private set; }
public VocabularyKey CashDiscountCode { get; private set; }
public VocabularyKey CashDiscountDate { get; private set; }
public VocabularyKey ComplimentedInvoiceId { get; private set; }
public VocabularyKey ContactPersonId { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey CustomerAccount { get; private set; }
public VocabularyKey CustomerGroup { get; private set; }
public VocabularyKey CustomerReference { get; private set; }
public VocabularyKey CustomerRequisition { get; private set; }
public VocabularyKey DocumentDate { get; private set; }
public VocabularyKey DueDate { get; private set; }
public VocabularyKey FreeTextNumber { get; private set; }
public VocabularyKey GiroType { get; private set; }
public VocabularyKey InclTax { get; private set; }
public VocabularyKey InvoiceAccount { get; private set; }
public VocabularyKey InvoiceDate { get; private set; }
public VocabularyKey InvoiceId { get; private set; }
public VocabularyKey InvoiceName { get; private set; }
public VocabularyKey InvoiceOriginType { get; private set; }
public VocabularyKey IsPosted { get; private set; }
public VocabularyKey IsPostedViaIntercompany { get; private set; }
public VocabularyKey LanguageId { get; private set; }
public VocabularyKey MethodOfPayment { get; private set; }
public VocabularyKey PaymentSchedule { get; private set; }
public VocabularyKey PaymentTermsBaseDate { get; private set; }
public VocabularyKey PaymentTermsBaseDays { get; private set; }
public VocabularyKey SalesTaxGroupId { get; private set; }
public VocabularyKey SalesTaxItemGroupId { get; private set; }
public VocabularyKey TermsOfPayment { get; private set; }


    }
}