using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustFormletterCustomerCollectionLetterFormPrintingConfigurationEntityVocabulary : SimpleVocabulary
    {
        public CustFormletterCustomerCollectionLetterFormPrintingConfigurationEntityVocabulary()
        {
            VocabularyName = "Cust Formletter Customer Collection Letter Form Printing Configuration Entity";
            KeyPrefix = "commonDataModel.custformlettercustomercollectionletterformprintingconfigurationentity";
            KeySeparator = ".";
            Grouping = "/CustFormletterCustomerCollectionLetterFormPrintingConfigurationEntity";

            AddGroup("CustFormletterCustomerCollectionLetterFormPrintingConfigurationEntity Details", group =>
            {
                PaperFormat = group.Add(new VocabularyKey(nameof(PaperFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayedPaymentAttachmentType = group.Add(new VocabularyKey(nameof(DisplayedPaymentAttachmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PaperFormat { get; private set; }
        public VocabularyKey DisplayedPaymentAttachmentType { get; private set; }
    }
}