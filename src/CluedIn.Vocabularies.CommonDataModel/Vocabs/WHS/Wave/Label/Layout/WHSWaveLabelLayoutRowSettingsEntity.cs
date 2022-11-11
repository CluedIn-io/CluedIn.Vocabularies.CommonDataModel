using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWaveLabelLayoutRowSettingsEntityVocabulary : SimpleVocabulary
    {
        public WHSWaveLabelLayoutRowSettingsEntityVocabulary()
        {
            VocabularyName = "WHSWaveLabelLayoutRowSettingsEntity";
            KeyPrefix = "commonDataModel.whswavelabellayoutrowsettingsentity";
            KeySeparator = ".";
            Grouping = "/WHSWaveLabelLayoutRowSettingsEntity";

            AddGroup("WHSWaveLabelLayoutRowSettingsEntity Details", group =>
            {
                LabelLayout = group.Add(new VocabularyKey(nameof(LabelLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowHeight = group.Add(new VocabularyKey(nameof(RowHeight), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowId = group.Add(new VocabularyKey(nameof(RowId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowsPerPage = group.Add(new VocabularyKey(nameof(RowsPerPage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowStartPosition = group.Add(new VocabularyKey(nameof(RowStartPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RowTableName = group.Add(new VocabularyKey(nameof(RowTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaveLabelLayoutId = group.Add(new VocabularyKey(nameof(WaveLabelLayoutId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LabelLayout { get; private set; }
        public VocabularyKey RowHeight { get; private set; }
        public VocabularyKey RowId { get; private set; }
        public VocabularyKey RowsPerPage { get; private set; }
        public VocabularyKey RowStartPosition { get; private set; }
        public VocabularyKey RowTableName { get; private set; }
        public VocabularyKey WaveLabelLayoutId { get; private set; }


    }
}