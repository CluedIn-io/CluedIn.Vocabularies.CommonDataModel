using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ElectronicPaymentRemittanceOccurrenceCodeEntityVocabulary : SimpleVocabulary
    {
        public ElectronicPaymentRemittanceOccurrenceCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model ElectronicPaymentRemittanceOccurrenceCodeEntity";
            KeyPrefix = "commonDataModel.electronicpaymentremittanceoccurrencecodeentity";
            KeySeparator = ".";
            Grouping = "/ElectronicPaymentRemittanceOccurrenceCodeEntity";

            AddGroup("Common Data Model ElectronicPaymentRemittanceOccurrenceCodeEntity Details", group =>
            {
                LayoutGroupId = group.Add(new VocabularyKey(nameof(LayoutGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutRemittanceOccurrenceCode = group.Add(new VocabularyKey(nameof(LayoutRemittanceOccurrenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RemittanceOccurrenceCode = group.Add(new VocabularyKey(nameof(RemittanceOccurrenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LayoutGroupId { get; private set; }
        public VocabularyKey LayoutRemittanceOccurrenceCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey RemittanceOccurrenceCode { get; private set; }


    }
}