using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerDateIntervalEntityVocabulary : SimpleVocabulary
    {
        public LedgerDateIntervalEntityVocabulary()
        {
            VocabularyName = "LedgerDateIntervalEntity";
            KeyPrefix = "commonDataModel.ledgerdateintervalentity";
            KeySeparator = ".";
            Grouping = "/LedgerDateIntervalEntity";

            AddGroup("LedgerDateIntervalEntity Details", group =>
            {
                DateIntervalCode = group.Add(new VocabularyKey(nameof(DateIntervalCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartPeriodType = group.Add(new VocabularyKey(nameof(StartPeriodType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartFunction = group.Add(new VocabularyKey(nameof(StartFunction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartChange = group.Add(new VocabularyKey(nameof(StartChange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartAdjustmentUnit = group.Add(new VocabularyKey(nameof(StartAdjustmentUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartPeriodTypeAdjustment = group.Add(new VocabularyKey(nameof(StartPeriodTypeAdjustment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartFunctionAdjustment = group.Add(new VocabularyKey(nameof(StartFunctionAdjustment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LockedStartDate = group.Add(new VocabularyKey(nameof(LockedStartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndPeriodType = group.Add(new VocabularyKey(nameof(EndPeriodType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndFunction = group.Add(new VocabularyKey(nameof(EndFunction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndChange = group.Add(new VocabularyKey(nameof(EndChange), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndAdjustmentUnit = group.Add(new VocabularyKey(nameof(EndAdjustmentUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndPeriodTypeAdjustment = group.Add(new VocabularyKey(nameof(EndPeriodTypeAdjustment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EndFunctionAdjustment = group.Add(new VocabularyKey(nameof(EndFunctionAdjustment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LockedEndDate = group.Add(new VocabularyKey(nameof(LockedEndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DateIntervalCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey StartPeriodType { get; private set; }
        public VocabularyKey StartFunction { get; private set; }
        public VocabularyKey StartChange { get; private set; }
        public VocabularyKey StartAdjustmentUnit { get; private set; }
        public VocabularyKey StartPeriodTypeAdjustment { get; private set; }
        public VocabularyKey StartFunctionAdjustment { get; private set; }
        public VocabularyKey LockedStartDate { get; private set; }
        public VocabularyKey EndPeriodType { get; private set; }
        public VocabularyKey EndFunction { get; private set; }
        public VocabularyKey EndChange { get; private set; }
        public VocabularyKey EndAdjustmentUnit { get; private set; }
        public VocabularyKey EndPeriodTypeAdjustment { get; private set; }
        public VocabularyKey EndFunctionAdjustment { get; private set; }
        public VocabularyKey LockedEndDate { get; private set; }


    }
}