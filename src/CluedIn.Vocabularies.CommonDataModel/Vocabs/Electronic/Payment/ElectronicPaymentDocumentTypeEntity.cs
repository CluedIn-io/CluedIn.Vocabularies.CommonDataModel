using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicPaymentDocumentTypeEntityVocabulary : SimpleVocabulary
    {
        public ElectronicPaymentDocumentTypeEntityVocabulary()
        {
            VocabularyName = "ElectronicPaymentDocumentTypeEntity";
            KeyPrefix = "commonDataModel.electronicpaymentdocumenttypeentity";
            KeySeparator = ".";
            Grouping = "/ElectronicPaymentDocumentTypeEntity";

            AddGroup("ElectronicPaymentDocumentTypeEntity Details", group =>
            {
                LayoutGroupId = group.Add(new VocabularyKey(nameof(LayoutGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentType = group.Add(new VocabularyKey(nameof(DocumentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LayoutGroupId { get; private set; }
        public VocabularyKey DocumentType { get; private set; }
        public VocabularyKey Description { get; private set; }


    }
}