using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustDirectDebitMandateEntityVocabulary : SimpleVocabulary
    {
        public CustDirectDebitMandateEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustDirectDebitMandateEntity";
            KeyPrefix = "commonDataModel.custdirectdebitmandateentity";
            KeySeparator = ".";
            Grouping = "/CustDirectDebitMandateEntity";

            AddGroup("Common Data Model CustDirectDebitMandateEntity Details", group =>
            {
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MandateId = group.Add(new VocabularyKey(nameof(MandateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerBankAccount = group.Add(new VocabularyKey(nameof(CustomerBankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomerAddress = group.Add(new VocabularyKey(nameof(CustomerAddress), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DaysForFirstBankSubmission = group.Add(new VocabularyKey(nameof(DaysForFirstBankSubmission), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DaysForRecurringBankSubmission = group.Add(new VocabularyKey(nameof(DaysForRecurringBankSubmission), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DaysForFirstPrenotification = group.Add(new VocabularyKey(nameof(DaysForFirstPrenotification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DaysForRecurringPrenotification = group.Add(new VocabularyKey(nameof(DaysForRecurringPrenotification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CancellationDate = group.Add(new VocabularyKey(nameof(CancellationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpirationDate = group.Add(new VocabularyKey(nameof(ExpirationDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MandatePaymentType = group.Add(new VocabularyKey(nameof(MandatePaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MandateScheme = group.Add(new VocabularyKey(nameof(MandateScheme), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SignatureDate = group.Add(new VocabularyKey(nameof(SignatureDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SignatureLocation = group.Add(new VocabularyKey(nameof(SignatureLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExpectedNumberOfPayments = group.Add(new VocabularyKey(nameof(ExpectedNumberOfPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
UsageCount = group.Add(new VocabularyKey(nameof(UsageCount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsPrivate = group.Add(new VocabularyKey(nameof(IsPrivate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrivateForParty = group.Add(new VocabularyKey(nameof(PrivateForParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreditorBankAccount = group.Add(new VocabularyKey(nameof(CreditorBankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CustomerAccount { get; private set; }
public VocabularyKey MandateId { get; private set; }
public VocabularyKey CustomerBankAccount { get; private set; }
public VocabularyKey CustomerAddress { get; private set; }
public VocabularyKey DaysForFirstBankSubmission { get; private set; }
public VocabularyKey DaysForRecurringBankSubmission { get; private set; }
public VocabularyKey DaysForFirstPrenotification { get; private set; }
public VocabularyKey DaysForRecurringPrenotification { get; private set; }
public VocabularyKey CancellationDate { get; private set; }
public VocabularyKey ExpirationDate { get; private set; }
public VocabularyKey MandatePaymentType { get; private set; }
public VocabularyKey MandateScheme { get; private set; }
public VocabularyKey SignatureDate { get; private set; }
public VocabularyKey SignatureLocation { get; private set; }
public VocabularyKey ExpectedNumberOfPayments { get; private set; }
public VocabularyKey UsageCount { get; private set; }
public VocabularyKey Status { get; private set; }
public VocabularyKey IsPrivate { get; private set; }
public VocabularyKey PrivateForParty { get; private set; }
public VocabularyKey CreditorBankAccount { get; private set; }


    }
}