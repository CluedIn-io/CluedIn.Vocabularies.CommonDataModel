using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustIntentLetterEntity_ITVocabulary : SimpleVocabulary
    {
        public CustIntentLetterEntity_ITVocabulary()
        {
            VocabularyName = "Cust Intent Letter Entity _IT";
            KeyPrefix = "commonDataModel.custintentletterentity_it";
            KeySeparator = ".";
            Grouping = "/CustIntentLetterEntity_IT";

            AddGroup("CustIntentLetterEntity_IT Details", group =>
            {
                AccountNum = group.Add(new VocabularyKey(nameof(AccountNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClosedDate = group.Add(new VocabularyKey(nameof(ClosedDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateLetter = group.Add(new VocabularyKey(nameof(DateLetter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateRegister = group.Add(new VocabularyKey(nameof(DateRegister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntentLetterAmountMST = group.Add(new VocabularyKey(nameof(IntentLetterAmountMST), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntentLetterType = group.Add(new VocabularyKey(nameof(IntentLetterType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InternalLetterId = group.Add(new VocabularyKey(nameof(InternalLetterId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LetterId = group.Add(new VocabularyKey(nameof(LetterId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Protocol = group.Add(new VocabularyKey(nameof(Protocol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Status = group.Add(new VocabularyKey(nameof(Status), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntentLetterYear = group.Add(new VocabularyKey(nameof(IntentLetterYear), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AccountNum { get; private set; }
        public VocabularyKey ClosedDate { get; private set; }
        public VocabularyKey DateLetter { get; private set; }
        public VocabularyKey DateRegister { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey IntentLetterAmountMST { get; private set; }
        public VocabularyKey IntentLetterType { get; private set; }
        public VocabularyKey InternalLetterId { get; private set; }
        public VocabularyKey LetterId { get; private set; }
        public VocabularyKey Notes { get; private set; }
        public VocabularyKey Protocol { get; private set; }
        public VocabularyKey Status { get; private set; }
        public VocabularyKey ToDate { get; private set; }
        public VocabularyKey IntentLetterYear { get; private set; }
    }
}