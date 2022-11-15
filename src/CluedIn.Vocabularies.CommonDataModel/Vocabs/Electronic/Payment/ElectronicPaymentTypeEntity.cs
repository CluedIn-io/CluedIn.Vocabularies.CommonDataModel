using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicPaymentTypeEntityVocabulary : SimpleVocabulary
    {
        public ElectronicPaymentTypeEntityVocabulary()
        {
            VocabularyName = "Electronic Payment Type Entity";
            KeyPrefix = "commonDataModel.electronicpaymenttypeentity";
            KeySeparator = ".";
            Grouping = "/ElectronicPaymentTypeEntity";

            AddGroup("ElectronicPaymentTypeEntity Details", group =>
            {
                PaymentType = group.Add(new VocabularyKey(nameof(PaymentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PaymentType { get; private set; }
        public VocabularyKey Description { get; private set; }
    }
}