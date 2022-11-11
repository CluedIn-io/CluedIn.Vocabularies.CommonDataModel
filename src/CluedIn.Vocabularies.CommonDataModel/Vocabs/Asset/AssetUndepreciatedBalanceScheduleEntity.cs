using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetUndepreciatedBalanceScheduleEntityVocabulary : SimpleVocabulary
    {
        public AssetUndepreciatedBalanceScheduleEntityVocabulary()
        {
            VocabularyName = "Common Data Model AssetUndepreciatedBalanceScheduleEntity";
            KeyPrefix = "commonDataModel.assetundepreciatedbalancescheduleentity";
            KeySeparator = ".";
            Grouping = "/AssetUndepreciatedBalanceScheduleEntity";

            AddGroup("Common Data Model AssetUndepreciatedBalanceScheduleEntity Details", group =>
            {
                ScheduleDescription = group.Add(new VocabularyKey(nameof(ScheduleDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromMethod = group.Add(new VocabularyKey(nameof(FromMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToMethod = group.Add(new VocabularyKey(nameof(ToMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceLife = group.Add(new VocabularyKey(nameof(ServiceLife), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LowerLimitRate = group.Add(new VocabularyKey(nameof(LowerLimitRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UpperLimitRate = group.Add(new VocabularyKey(nameof(UpperLimitRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                YearsPassed = group.Add(new VocabularyKey(nameof(YearsPassed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ScheduleDescription { get; private set; }
        public VocabularyKey FromMethod { get; private set; }
        public VocabularyKey ToMethod { get; private set; }
        public VocabularyKey ServiceLife { get; private set; }
        public VocabularyKey LowerLimitRate { get; private set; }
        public VocabularyKey UpperLimitRate { get; private set; }
        public VocabularyKey YearsPassed { get; private set; }


    }
}