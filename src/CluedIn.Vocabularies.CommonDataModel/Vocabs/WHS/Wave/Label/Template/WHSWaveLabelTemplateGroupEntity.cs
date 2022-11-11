using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWaveLabelTemplateGroupEntityVocabulary : SimpleVocabulary
    {
        public WHSWaveLabelTemplateGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSWaveLabelTemplateGroupEntity";
            KeyPrefix = "commonDataModel.whswavelabeltemplategroupentity";
            KeySeparator = ".";
            Grouping = "/WHSWaveLabelTemplateGroupEntity";

            AddGroup("Common Data Model WHSWaveLabelTemplateGroupEntity Details", group =>
            {
                WaveLabelLayoutId = group.Add(new VocabularyKey(nameof(WaveLabelLayoutId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupBy = group.Add(new VocabularyKey(nameof(GroupBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LabelTemplates = group.Add(new VocabularyKey(nameof(LabelTemplates), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintBreakLabel = group.Add(new VocabularyKey(nameof(PrintBreakLabel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableFieldId = group.Add(new VocabularyKey(nameof(GroupTableFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableId = group.Add(new VocabularyKey(nameof(GroupTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrinterName = group.Add(new VocabularyKey(nameof(PrinterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaveLabelTemplateName = group.Add(new VocabularyKey(nameof(WaveLabelTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableName = group.Add(new VocabularyKey(nameof(GroupTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableFieldName = group.Add(new VocabularyKey(nameof(GroupTableFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLabelBuildIdField = group.Add(new VocabularyKey(nameof(IsLabelBuildIdField), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WaveLabelLayoutId { get; private set; }
        public VocabularyKey GroupBy { get; private set; }
        public VocabularyKey LabelTemplates { get; private set; }
        public VocabularyKey PrintBreakLabel { get; private set; }
        public VocabularyKey GroupTableFieldId { get; private set; }
        public VocabularyKey GroupTableId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey PrinterName { get; private set; }
        public VocabularyKey WaveLabelTemplateName { get; private set; }
        public VocabularyKey GroupTableName { get; private set; }
        public VocabularyKey GroupTableFieldName { get; private set; }
        public VocabularyKey IsLabelBuildIdField { get; private set; }


    }
}