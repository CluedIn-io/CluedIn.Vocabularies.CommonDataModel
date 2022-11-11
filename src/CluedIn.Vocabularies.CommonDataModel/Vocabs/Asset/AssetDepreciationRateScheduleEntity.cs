using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class AssetDepreciationRateScheduleEntityVocabulary : SimpleVocabulary
    {
        public AssetDepreciationRateScheduleEntityVocabulary()
        {
            VocabularyName = "AssetDepreciationRateScheduleEntity";
            KeyPrefix = "commonDataModel.assetdepreciationratescheduleentity";
            KeySeparator = ".";
            Grouping = "/AssetDepreciationRateScheduleEntity";

            AddGroup("AssetDepreciationRateScheduleEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UsefulLife = group.Add(new VocabularyKey(nameof(UsefulLife), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OSLDepRate = group.Add(new VocabularyKey(nameof(OSLDepRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ODBDepRate = group.Add(new VocabularyKey(nameof(ODBDepRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NSLDepRate = group.Add(new VocabularyKey(nameof(NSLDepRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NDB250DepRate = group.Add(new VocabularyKey(nameof(NDB250DepRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NDB250GuaranteedDepRate = group.Add(new VocabularyKey(nameof(NDB250GuaranteedDepRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NDB250RevisedDepRate = group.Add(new VocabularyKey(nameof(NDB250RevisedDepRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NDB200DepRate = group.Add(new VocabularyKey(nameof(NDB200DepRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NDB200GuaranteedDepRate = group.Add(new VocabularyKey(nameof(NDB200GuaranteedDepRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NDB200RevisedDepRate = group.Add(new VocabularyKey(nameof(NDB200RevisedDepRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicDepRate = group.Add(new VocabularyKey(nameof(ElectronicDepRate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Name { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey UsefulLife { get; private set; }
        public VocabularyKey OSLDepRate { get; private set; }
        public VocabularyKey ODBDepRate { get; private set; }
        public VocabularyKey NSLDepRate { get; private set; }
        public VocabularyKey NDB250DepRate { get; private set; }
        public VocabularyKey NDB250GuaranteedDepRate { get; private set; }
        public VocabularyKey NDB250RevisedDepRate { get; private set; }
        public VocabularyKey NDB200DepRate { get; private set; }
        public VocabularyKey NDB200GuaranteedDepRate { get; private set; }
        public VocabularyKey NDB200RevisedDepRate { get; private set; }
        public VocabularyKey ElectronicDepRate { get; private set; }


    }
}