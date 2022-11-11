using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TrvPayMethodEntityVocabulary : SimpleVocabulary
    {
        public TrvPayMethodEntityVocabulary()
        {
            VocabularyName = "TrvPayMethodEntity";
            KeyPrefix = "commonDataModel.trvpaymethodentity";
            KeySeparator = ".";
            Grouping = "/TrvPayMethodEntity";

            AddGroup("TrvPayMethodEntity Details", group =>
            {
                AutomaticPayment = group.Add(new VocabularyKey(nameof(AutomaticPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostOwner = group.Add(new VocabularyKey(nameof(CostOwner), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetLedgerDimension = group.Add(new VocabularyKey(nameof(OffsetLedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayedByTxt = group.Add(new VocabularyKey(nameof(PayedByTxt), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayMethod = group.Add(new VocabularyKey(nameof(PayMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostMethod = group.Add(new VocabularyKey(nameof(PostMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OffsetLedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(OffsetLedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AutomaticPayment { get; private set; }
        public VocabularyKey CostOwner { get; private set; }
        public VocabularyKey OffsetLedgerDimension { get; private set; }
        public VocabularyKey PayedByTxt { get; private set; }
        public VocabularyKey PayMethod { get; private set; }
        public VocabularyKey PostMethod { get; private set; }
        public VocabularyKey OffsetLedgerDimensionDisplayValue { get; private set; }


    }
}