using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CollectionLetterCourseEntityVocabulary : SimpleVocabulary
    {
        public CollectionLetterCourseEntityVocabulary()
        {
            VocabularyName = "CollectionLetterCourseEntity";
            KeyPrefix = "commonDataModel.collectionlettercourseentity";
            KeySeparator = ".";
            Grouping = "/CollectionLetterCourseEntity";

            AddGroup("CollectionLetterCourseEntity Details", group =>
            {
                CollectionLetterSequence = group.Add(new VocabularyKey(nameof(CollectionLetterSequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TermsOfPayment = group.Add(new VocabularyKey(nameof(TermsOfPayment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionLetterCode = group.Add(new VocabularyKey(nameof(CollectionLetterCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionLetterCodeDescription = group.Add(new VocabularyKey(nameof(CollectionLetterCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CollectionsFee = group.Add(new VocabularyKey(nameof(CollectionsFee), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxItemGroup = group.Add(new VocabularyKey(nameof(TaxItemGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinAmountToGenLetter = group.Add(new VocabularyKey(nameof(MinAmountToGenLetter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfDaysBETWLetters = group.Add(new VocabularyKey(nameof(NumberOfDaysBETWLetters), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BlockCustomer = group.Add(new VocabularyKey(nameof(BlockCustomer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Notes = group.Add(new VocabularyKey(nameof(Notes), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CollectionLetterSequence { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TermsOfPayment { get; private set; }
        public VocabularyKey CollectionLetterCode { get; private set; }
        public VocabularyKey CollectionLetterCodeDescription { get; private set; }
        public VocabularyKey CurrencyCode { get; private set; }
        public VocabularyKey LedgerDimension { get; private set; }
        public VocabularyKey LedgerDimensionDisplayValue { get; private set; }
        public VocabularyKey CollectionsFee { get; private set; }
        public VocabularyKey TaxItemGroup { get; private set; }
        public VocabularyKey MinAmountToGenLetter { get; private set; }
        public VocabularyKey NumberOfDaysBETWLetters { get; private set; }
        public VocabularyKey BlockCustomer { get; private set; }
        public VocabularyKey Notes { get; private set; }


    }
}