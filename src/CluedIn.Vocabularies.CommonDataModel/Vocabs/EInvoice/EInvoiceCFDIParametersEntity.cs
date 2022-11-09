using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class EInvoiceCFDIParametersEntityVocabulary : SimpleVocabulary
    {
        public EInvoiceCFDIParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model EInvoiceCFDIParametersEntity";
            KeyPrefix = "commonDataModel.einvoicecfdiparametersentity";
            KeySeparator = ".";
            Grouping = "/EInvoiceCFDIParametersEntity";

            AddGroup("Common Data Model EInvoiceCFDIParametersEntity Details", group =>
            {
                Certificate = group.Add(new VocabularyKey(nameof(Certificate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CFDIDigestAlgorithm = group.Add(new VocabularyKey(nameof(CFDIDigestAlgorithm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CFDIEnvironment = group.Add(new VocabularyKey(nameof(CFDIEnvironment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CFDIPACCertificate = group.Add(new VocabularyKey(nameof(CFDIPACCertificate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CFDIVersion = group.Add(new VocabularyKey(nameof(CFDIVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CFDIXMLSchemaFile = group.Add(new VocabularyKey(nameof(CFDIXMLSchemaFile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EmailId = group.Add(new VocabularyKey(nameof(EmailId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EnabledCFDI = group.Add(new VocabularyKey(nameof(EnabledCFDI), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Key = group.Add(new VocabularyKey(nameof(Key), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PACAccountId = group.Add(new VocabularyKey(nameof(PACAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SendByMail = group.Add(new VocabularyKey(nameof(SendByMail), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SendReportFile = group.Add(new VocabularyKey(nameof(SendReportFile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailEnableRelatedCFDIInReturns = group.Add(new VocabularyKey(nameof(RetailEnableRelatedCFDIInReturns), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailExcludeCustOrdersFromCFDIGlobal = group.Add(new VocabularyKey(nameof(RetailExcludeCustOrdersFromCFDIGlobal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailInvoiceRFC = group.Add(new VocabularyKey(nameof(RetailInvoiceRFC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailItemDescription = group.Add(new VocabularyKey(nameof(RetailItemDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailPaymMethod = group.Add(new VocabularyKey(nameof(RetailPaymMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailProductCode = group.Add(new VocabularyKey(nameof(RetailProductCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailPurpose = group.Add(new VocabularyKey(nameof(RetailPurpose), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailRecalculateRoundingOfTaxBaseAmount = group.Add(new VocabularyKey(nameof(RetailRecalculateRoundingOfTaxBaseAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RetailUnitCode = group.Add(new VocabularyKey(nameof(RetailUnitCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SplitTaxAmountPerLines = group.Add(new VocabularyKey(nameof(SplitTaxAmountPerLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Certificate { get; private set; }
public VocabularyKey CFDIDigestAlgorithm { get; private set; }
public VocabularyKey CFDIEnvironment { get; private set; }
public VocabularyKey CFDIPACCertificate { get; private set; }
public VocabularyKey CFDIVersion { get; private set; }
public VocabularyKey CFDIXMLSchemaFile { get; private set; }
public VocabularyKey EmailId { get; private set; }
public VocabularyKey EnabledCFDI { get; private set; }
public VocabularyKey Key { get; private set; }
public VocabularyKey PACAccountId { get; private set; }
public VocabularyKey SendByMail { get; private set; }
public VocabularyKey SendReportFile { get; private set; }
public VocabularyKey RetailEnableRelatedCFDIInReturns { get; private set; }
public VocabularyKey RetailExcludeCustOrdersFromCFDIGlobal { get; private set; }
public VocabularyKey RetailInvoiceRFC { get; private set; }
public VocabularyKey RetailItemDescription { get; private set; }
public VocabularyKey RetailPaymMethod { get; private set; }
public VocabularyKey RetailProductCode { get; private set; }
public VocabularyKey RetailPurpose { get; private set; }
public VocabularyKey RetailRecalculateRoundingOfTaxBaseAmount { get; private set; }
public VocabularyKey RetailUnitCode { get; private set; }
public VocabularyKey SplitTaxAmountPerLines { get; private set; }


    }
}