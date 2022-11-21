using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DeliveryReasonEntityVocabulary : SimpleVocabulary
    {
        public DeliveryReasonEntityVocabulary()
        {
            VocabularyName = "Delivery Reason Entity";
            KeyPrefix = "commonDataModel.deliveryreasonentity";
            KeySeparator = ".";
            Grouping = "/DeliveryReasonEntity";

            AddGroup("DeliveryReasonEntity Details", group =>
            {
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonDescription = group.Add(new VocabularyKey(nameof(ReasonDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Free_IT = group.Add(new VocabularyKey(nameof(Free_IT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceAccount_IT = group.Add(new VocabularyKey(nameof(InvoiceAccount_IT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaymTermId_IT = group.Add(new VocabularyKey(nameof(PaymTermId_IT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey ReasonDescription { get; private set; }
        public VocabularyKey Free_IT { get; private set; }
        public VocabularyKey InvoiceAccount_IT { get; private set; }
        public VocabularyKey PaymTermId_IT { get; private set; }
    }
}