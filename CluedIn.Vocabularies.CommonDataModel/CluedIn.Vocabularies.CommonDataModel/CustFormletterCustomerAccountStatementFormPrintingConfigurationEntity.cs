using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustFormletterCustomerAccountStatementFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public CustFormletterCustomerAccountStatementFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustFormletterCustomerAccountStatementFormPrintingConfigurationEntity";
            KeyPrefix = "commonDataModel.custformlettercustomeraccountstatementformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/CustFormletterCustomerAccountStatementFormPrintingConfigurationEntity";

            AddGroup("Common Data Model CustFormletterCustomerAccountStatementFormPrintingConfigurationEntity Details", group =>
            {
                PaperFormat = group.Add(new VocabularyKey(nameof(PaperFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsTaxExemptNumberDisplayed = group.Add(new VocabularyKey(nameof(IsTaxExemptNumberDisplayed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DisplayedPaymentAttachmentType = group.Add(new VocabularyKey(nameof(DisplayedPaymentAttachmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PaperFormat { get; private set; }
public VocabularyKey IsTaxExemptNumberDisplayed { get; private set; }
public VocabularyKey DisplayedPaymentAttachmentType { get; private set; }


    }
}