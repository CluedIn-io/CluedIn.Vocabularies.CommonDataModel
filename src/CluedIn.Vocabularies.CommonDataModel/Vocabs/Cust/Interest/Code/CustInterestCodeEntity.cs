using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustInterestCodeEntityVocabulary : SimpleVocabulary
    {
        public CustInterestCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustInterestCodeEntity";
            KeyPrefix = "commonDataModel.custinterestcodeentity";
            KeySeparator = ".";
            Grouping = "/CustInterestCodeEntity";

            AddGroup("Common Data Model CustInterestCodeEntity Details", group =>
            {
                InterestCode = group.Add(new VocabularyKey(nameof(InterestCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestType = group.Add(new VocabularyKey(nameof(InterestType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GraceDays = group.Add(new VocabularyKey(nameof(GraceDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FeeType = group.Add(new VocabularyKey(nameof(FeeType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestByRange = group.Add(new VocabularyKey(nameof(InterestByRange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestCalcType = group.Add(new VocabularyKey(nameof(InterestCalcType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestCalculateBy = group.Add(new VocabularyKey(nameof(InterestCalculateBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestCalculateByInterval = group.Add(new VocabularyKey(nameof(InterestCalculateByInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InterestPercent = group.Add(new VocabularyKey(nameof(InterestPercent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerPostingAccount = group.Add(new VocabularyKey(nameof(LedgerPostingAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LedgerPostingAccountDisplayValue = group.Add(new VocabularyKey(nameof(LedgerPostingAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InterestCode { get; private set; }
        public VocabularyKey InterestType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey GraceDays { get; private set; }
        public VocabularyKey FeeType { get; private set; }
        public VocabularyKey InterestByRange { get; private set; }
        public VocabularyKey InterestCalcType { get; private set; }
        public VocabularyKey InterestCalculateBy { get; private set; }
        public VocabularyKey InterestCalculateByInterval { get; private set; }
        public VocabularyKey InterestPercent { get; private set; }
        public VocabularyKey LedgerPostingAccount { get; private set; }
        public VocabularyKey LedgerPostingAccountDisplayValue { get; private set; }


    }
}