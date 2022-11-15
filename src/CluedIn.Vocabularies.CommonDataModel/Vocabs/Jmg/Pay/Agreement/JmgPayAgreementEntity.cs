using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgPayAgreementEntityVocabulary : SimpleVocabulary
    {
        public JmgPayAgreementEntityVocabulary()
        {
            VocabularyName = "Jmg Pay Agreement Entity";
            KeyPrefix = "commonDataModel.jmgpayagreemententity";
            KeySeparator = ".";
            Grouping = "/JmgPayAgreementEntity";

            AddGroup("JmgPayAgreementEntity Details", group =>
            {
                PayAgreementCode = group.Add(new VocabularyKey(nameof(PayAgreementCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OvertimeRoundingValue = group.Add(new VocabularyKey(nameof(OvertimeRoundingValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OvertimeRoundingType = group.Add(new VocabularyKey(nameof(OvertimeRoundingType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinutesToDeductWhenLate = group.Add(new VocabularyKey(nameof(MinutesToDeductWhenLate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDate = group.Add(new VocabularyKey(nameof(ToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey PayAgreementCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey OvertimeRoundingValue { get; private set; }
        public VocabularyKey OvertimeRoundingType { get; private set; }
        public VocabularyKey MinutesToDeductWhenLate { get; private set; }
        public VocabularyKey FromDate { get; private set; }
        public VocabularyKey ToDate { get; private set; }
    }
}