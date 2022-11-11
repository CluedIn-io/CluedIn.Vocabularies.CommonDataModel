using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class JmgTimeAndAttendanceFlexGroupEntityVocabulary : SimpleVocabulary
    {
        public JmgTimeAndAttendanceFlexGroupEntityVocabulary()
        {
            VocabularyName = "JmgTimeAndAttendanceFlexGroupEntity";
            KeyPrefix = "commonDataModel.jmgtimeandattendanceflexgroupentity";
            KeySeparator = ".";
            Grouping = "/JmgTimeAndAttendanceFlexGroupEntity";

            AddGroup("JmgTimeAndAttendanceFlexGroupEntity Details", group =>
            {
                FlexGroupId = group.Add(new VocabularyKey(nameof(FlexGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFlexMaximumBalanceAdjusted = group.Add(new VocabularyKey(nameof(IsFlexMaximumBalanceAdjusted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFlexMinimumBalanceAdjusted = group.Add(new VocabularyKey(nameof(IsFlexMinimumBalanceAdjusted), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FlexMaximumPayTypeCode = group.Add(new VocabularyKey(nameof(FlexMaximumPayTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FlexMinumumPayTypeCode = group.Add(new VocabularyKey(nameof(FlexMinumumPayTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayTypeCodeForMaximumFlexBalance = group.Add(new VocabularyKey(nameof(PayTypeCodeForMaximumFlexBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayTypeCodeForMinimumFlexBalance = group.Add(new VocabularyKey(nameof(PayTypeCodeForMinimumFlexBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayFactorForAdjustedMaximumBalance = group.Add(new VocabularyKey(nameof(PayFactorForAdjustedMaximumBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayFactorForAdjustedMinimumBalance = group.Add(new VocabularyKey(nameof(PayFactorForAdjustedMinimumBalance), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaximumFlexBalanceInTimePresentationUnits = group.Add(new VocabularyKey(nameof(MaximumFlexBalanceInTimePresentationUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MinimunFlexBalanceInTimePresentationUnits = group.Add(new VocabularyKey(nameof(MinimunFlexBalanceInTimePresentationUnits), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsFlexBalanceCalculatedFromPayTypeCode = group.Add(new VocabularyKey(nameof(IsFlexBalanceCalculatedFromPayTypeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey FlexGroupId { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsFlexMaximumBalanceAdjusted { get; private set; }
        public VocabularyKey IsFlexMinimumBalanceAdjusted { get; private set; }
        public VocabularyKey FlexMaximumPayTypeCode { get; private set; }
        public VocabularyKey FlexMinumumPayTypeCode { get; private set; }
        public VocabularyKey PayTypeCodeForMaximumFlexBalance { get; private set; }
        public VocabularyKey PayTypeCodeForMinimumFlexBalance { get; private set; }
        public VocabularyKey PayFactorForAdjustedMaximumBalance { get; private set; }
        public VocabularyKey PayFactorForAdjustedMinimumBalance { get; private set; }
        public VocabularyKey MaximumFlexBalanceInTimePresentationUnits { get; private set; }
        public VocabularyKey MinimunFlexBalanceInTimePresentationUnits { get; private set; }
        public VocabularyKey IsFlexBalanceCalculatedFromPayTypeCode { get; private set; }


    }
}