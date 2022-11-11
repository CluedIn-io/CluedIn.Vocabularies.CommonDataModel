using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorReasonsEntityVocabulary : SimpleVocabulary
    {
        public VendVendorReasonsEntityVocabulary()
        {
            VocabularyName = "VendVendorReasonsEntity";
            KeyPrefix = "commonDataModel.vendvendorreasonsentity";
            KeySeparator = ".";
            Grouping = "/VendVendorReasonsEntity";

            AddGroup("VendVendorReasonsEntity Details", group =>
            {
                CancellationReason = group.Add(new VocabularyKey(nameof(CancellationReason), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PurposeCode = group.Add(new VocabularyKey(nameof(PurposeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DefaultComment = group.Add(new VocabularyKey(nameof(DefaultComment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReasonCode = group.Add(new VocabularyKey(nameof(ReasonCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ForVendorTransactionType = group.Add(new VocabularyKey(nameof(ForVendorTransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CancellationReason { get; private set; }
        public VocabularyKey PurposeCode { get; private set; }
        public VocabularyKey DefaultComment { get; private set; }
        public VocabularyKey ReasonCode { get; private set; }
        public VocabularyKey ForVendorTransactionType { get; private set; }


    }
}