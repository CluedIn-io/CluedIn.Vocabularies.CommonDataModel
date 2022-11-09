using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxWithholdCertificateEntityVocabulary : SimpleVocabulary
    {
        public TaxWithholdCertificateEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxWithholdCertificateEntity";
            KeyPrefix = "commonDataModel.taxwithholdcertificateentity";
            KeySeparator = ".";
            Grouping = "/TaxWithholdCertificateEntity";

            AddGroup("Common Data Model TaxWithholdCertificateEntity Details", group =>
            {
                CertificateAmount = group.Add(new VocabularyKey(nameof(CertificateAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CertificateNumber = group.Add(new VocabularyKey(nameof(CertificateNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Closed = group.Add(new VocabularyKey(nameof(Closed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountType = group.Add(new VocabularyKey(nameof(AccountType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Date = group.Add(new VocabularyKey(nameof(Date), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
AccountDisplayValue = group.Add(new VocabularyKey(nameof(AccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Account = group.Add(new VocabularyKey(nameof(Account), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CertificateAmount { get; private set; }
public VocabularyKey CertificateNumber { get; private set; }
public VocabularyKey Closed { get; private set; }
public VocabularyKey AccountType { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey TaxType { get; private set; }
public VocabularyKey Date { get; private set; }
public VocabularyKey AccountDisplayValue { get; private set; }
public VocabularyKey Account { get; private set; }


    }
}