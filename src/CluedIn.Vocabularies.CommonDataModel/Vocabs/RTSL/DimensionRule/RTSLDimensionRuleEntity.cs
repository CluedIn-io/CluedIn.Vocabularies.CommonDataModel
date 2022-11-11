using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RTSLDimensionRuleEntityVocabulary : SimpleVocabulary
    {
        public RTSLDimensionRuleEntityVocabulary()
        {
            VocabularyName = "Common Data Model RTSLDimensionRuleEntity";
            KeyPrefix = "commonDataModel.rtsldimensionruleentity";
            KeySeparator = ".";
            Grouping = "/RTSLDimensionRuleEntity";

            AddGroup("Common Data Model RTSLDimensionRuleEntity Details", group =>
            {
                ConversionMethod = group.Add(new VocabularyKey(nameof(ConversionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FromDimensionCode = group.Add(new VocabularyKey(nameof(FromDimensionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionCodeTo = group.Add(new VocabularyKey(nameof(DimensionCodeTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDimension = group.Add(new VocabularyKey(nameof(ToDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDimensionCode = group.Add(new VocabularyKey(nameof(ToDimensionCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttribute_Name = group.Add(new VocabularyKey(nameof(DimensionAttribute_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttribute_Type = group.Add(new VocabularyKey(nameof(DimensionAttribute_Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDimensionAttribute_Name = group.Add(new VocabularyKey(nameof(ToDimensionAttribute_Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ToDimensionAttribute_Type = group.Add(new VocabularyKey(nameof(ToDimensionAttribute_Type), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RuleGroup = group.Add(new VocabularyKey(nameof(RuleGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimesionRuleGroup = group.Add(new VocabularyKey(nameof(DimesionRuleGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ConversionMethod { get; private set; }
        public VocabularyKey Dimension { get; private set; }
        public VocabularyKey FromDimensionCode { get; private set; }
        public VocabularyKey DimensionCodeTo { get; private set; }
        public VocabularyKey ToDimension { get; private set; }
        public VocabularyKey ToDimensionCode { get; private set; }
        public VocabularyKey LineId { get; private set; }
        public VocabularyKey DimensionAttribute_Name { get; private set; }
        public VocabularyKey DimensionAttribute_Type { get; private set; }
        public VocabularyKey ToDimensionAttribute_Name { get; private set; }
        public VocabularyKey ToDimensionAttribute_Type { get; private set; }
        public VocabularyKey RuleGroup { get; private set; }
        public VocabularyKey DimesionRuleGroup { get; private set; }


    }
}