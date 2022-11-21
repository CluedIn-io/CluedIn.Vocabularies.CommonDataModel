using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSWaveLabelLayoutV2EntityVocabulary : SimpleVocabulary
    {
        public WHSWaveLabelLayoutV2EntityVocabulary()
        {
            VocabularyName = "WHS Wave Label Layout V2 Entity";
            KeyPrefix = "commonDataModel.whswavelabellayoutv2entity";
            KeySeparator = ".";
            Grouping = "/WHSWaveLabelLayoutV2Entity";

            AddGroup("WHSWaveLabelLayoutV2Entity Details", group =>
            {
                LabelBody = group.Add(new VocabularyKey(nameof(LabelBody), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LabelFooter = group.Add(new VocabularyKey(nameof(LabelFooter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LabelHeader = group.Add(new VocabularyKey(nameof(LabelHeader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutId = group.Add(new VocabularyKey(nameof(LayoutId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutDescription = group.Add(new VocabularyKey(nameof(LayoutDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkQuery = group.Add(new VocabularyKey(nameof(WorkQuery), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey LabelBody { get; private set; }
        public VocabularyKey LabelFooter { get; private set; }
        public VocabularyKey LabelHeader { get; private set; }
        public VocabularyKey LayoutId { get; private set; }
        public VocabularyKey LayoutDescription { get; private set; }
        public VocabularyKey WorkQuery { get; private set; }
    }
}