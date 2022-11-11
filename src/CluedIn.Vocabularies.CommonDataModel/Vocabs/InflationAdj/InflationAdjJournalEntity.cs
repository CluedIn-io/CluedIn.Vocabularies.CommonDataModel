using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class InflationAdjJournalEntityVocabulary : SimpleVocabulary
    {
        public InflationAdjJournalEntityVocabulary()
        {
            VocabularyName = "InflationAdjJournalEntity";
            KeyPrefix = "commonDataModel.inflationadjjournalentity";
            KeySeparator = ".";
            Grouping = "/InflationAdjJournalEntity";

            AddGroup("InflationAdjJournalEntity Details", group =>
            {
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingDate = group.Add(new VocabularyKey(nameof(PostingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PostingLayer = group.Add(new VocabularyKey(nameof(PostingLayer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Voucher = group.Add(new VocabularyKey(nameof(Voucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversedVoucher = group.Add(new VocabularyKey(nameof(ReversedVoucher), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey PostingDate { get; private set; }
        public VocabularyKey PostingLayer { get; private set; }
        public VocabularyKey Voucher { get; private set; }
        public VocabularyKey ReversedVoucher { get; private set; }


    }
}