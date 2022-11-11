using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicPaymentReturnOccurrenceCodeEntityVocabulary : SimpleVocabulary
    {
        public ElectronicPaymentReturnOccurrenceCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model ElectronicPaymentReturnOccurrenceCodeEntity";
            KeyPrefix = "commonDataModel.electronicpaymentreturnoccurrencecodeentity";
            KeySeparator = ".";
            Grouping = "/ElectronicPaymentReturnOccurrenceCodeEntity";

            AddGroup("Common Data Model ElectronicPaymentReturnOccurrenceCodeEntity Details", group =>
            {
                LayoutGroupId = group.Add(new VocabularyKey(nameof(LayoutGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutReturnOccurrenceCode = group.Add(new VocabularyKey(nameof(LayoutReturnOccurrenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReturnOccurrenceCode = group.Add(new VocabularyKey(nameof(ReturnOccurrenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LayoutGroupId { get; private set; }
        public VocabularyKey LayoutReturnOccurrenceCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ReturnOccurrenceCode { get; private set; }


    }
}