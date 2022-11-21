using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSShippingCarrierNumberSequenceEntityVocabulary : SimpleVocabulary
    {
        public TMSShippingCarrierNumberSequenceEntityVocabulary()
        {
            VocabularyName = "TMS Shipping Carrier Number Sequence Entity";
            KeyPrefix = "commonDataModel.tmsshippingcarriernumbersequenceentity";
            KeySeparator = ".";
            Grouping = "/TMSShippingCarrierNumberSequenceEntity";

            AddGroup("TMSShippingCarrierNumberSequenceEntity Details", group =>
            {
                TransportationGenericEngineCheckDigitCode = group.Add(new VocabularyKey(nameof(TransportationGenericEngineCheckDigitCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndingSequenceNumber = group.Add(new VocabularyKey(nameof(EndingSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceName = group.Add(new VocabularyKey(nameof(SequenceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextSequenceNumber = group.Add(new VocabularyKey(nameof(NextSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceCode = group.Add(new VocabularyKey(nameof(SequenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceType = group.Add(new VocabularyKey(nameof(SequenceType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceSuffix = group.Add(new VocabularyKey(nameof(SequenceSuffix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequencePrefix = group.Add(new VocabularyKey(nameof(SequencePrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceLength = group.Add(new VocabularyKey(nameof(SequenceLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BeginningSequenceNumber = group.Add(new VocabularyKey(nameof(BeginningSequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceThreshold = group.Add(new VocabularyKey(nameof(SequenceThreshold), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TransportationGenericEngineCheckDigitCode { get; private set; }
        public VocabularyKey EndingSequenceNumber { get; private set; }
        public VocabularyKey SequenceName { get; private set; }
        public VocabularyKey NextSequenceNumber { get; private set; }
        public VocabularyKey SequenceCode { get; private set; }
        public VocabularyKey SequenceType { get; private set; }
        public VocabularyKey SequenceSuffix { get; private set; }
        public VocabularyKey SequencePrefix { get; private set; }
        public VocabularyKey SequenceLength { get; private set; }
        public VocabularyKey BeginningSequenceNumber { get; private set; }
        public VocabularyKey SequenceThreshold { get; private set; }
    }
}