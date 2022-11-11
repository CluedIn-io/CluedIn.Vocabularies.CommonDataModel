using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollFormW2BoxReportingAdjustmentEntityVocabulary : SimpleVocabulary
    {
        public PayrollFormW2BoxReportingAdjustmentEntityVocabulary()
        {
            VocabularyName = "PayrollFormW2BoxReportingAdjustmentEntity";
            KeyPrefix = "commonDataModel.payrollformw2boxreportingadjustmententity";
            KeySeparator = ".";
            Grouping = "/PayrollFormW2BoxReportingAdjustmentEntity";

            AddGroup("PayrollFormW2BoxReportingAdjustmentEntity Details", group =>
            {
                Amount = group.Add(new VocabularyKey(nameof(Amount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingDate = group.Add(new VocabularyKey(nameof(ReportingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                W2BoxLabel = group.Add(new VocabularyKey(nameof(W2BoxLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                W2BoxNumber = group.Add(new VocabularyKey(nameof(W2BoxNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Amount { get; private set; }
        public VocabularyKey ReportingDate { get; private set; }
        public VocabularyKey W2BoxLabel { get; private set; }
        public VocabularyKey W2BoxNumber { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }


    }
}