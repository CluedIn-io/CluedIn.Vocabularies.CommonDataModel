using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWaveLabelTemplateDetailsV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWaveLabelTemplateDetailsV2EntityVocabulary()
        {
            VocabularyName = "WHSWaveLabelTemplateDetailsV2Entity";
            KeyPrefix = "commonDataModel.whswavelabeltemplatedetailsv2entity";
            KeySeparator = ".";
            Grouping = "/WHSWaveLabelTemplateDetailsV2Entity";

            AddGroup("WHSWaveLabelTemplateDetailsV2Entity Details", group =>
            {
                WaveLabelGeneratorType = group.Add(new VocabularyKey(nameof(WaveLabelGeneratorType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaveLabelLayoutId = group.Add(new VocabularyKey(nameof(WaveLabelLayoutId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LabelTemplates = group.Add(new VocabularyKey(nameof(LabelTemplates), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkQuery = group.Add(new VocabularyKey(nameof(WorkQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrinterName = group.Add(new VocabularyKey(nameof(PrinterName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RunWorkQuery = group.Add(new VocabularyKey(nameof(RunWorkQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WaveLabelTemplateName = group.Add(new VocabularyKey(nameof(WaveLabelTemplateName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey WaveLabelGeneratorType { get; private set; }
        public VocabularyKey WaveLabelLayoutId { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey LabelTemplates { get; private set; }
        public VocabularyKey WorkQuery { get; private set; }
        public VocabularyKey PrinterName { get; private set; }
        public VocabularyKey RunWorkQuery { get; private set; }
        public VocabularyKey WaveLabelTemplateName { get; private set; }


    }
}