using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustFormletterCustomerInterestNoteFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public CustFormletterCustomerInterestNoteFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustFormletterCustomerInterestNoteFormPrintingConfigurationEntity";
            KeyPrefix = "commonDataModel.custformlettercustomerinterestnoteformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/CustFormletterCustomerInterestNoteFormPrintingConfigurationEntity";

            AddGroup("Common Data Model CustFormletterCustomerInterestNoteFormPrintingConfigurationEntity Details", group =>
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