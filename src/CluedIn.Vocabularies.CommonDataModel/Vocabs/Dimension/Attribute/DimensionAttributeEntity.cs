using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DimensionAttributeEntityVocabulary : SimpleVocabulary
    {
        public DimensionAttributeEntityVocabulary()
        {
            VocabularyName = "DimensionAttributeEntity";
            KeyPrefix = "commonDataModel.dimensionattributeentity";
            KeySeparator = ".";
            Grouping = "/DimensionAttributeEntity";

            AddGroup("DimensionAttributeEntity Details", group =>
            {
                DimensionName = group.Add(new VocabularyKey(nameof(DimensionName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportColumnName = group.Add(new VocabularyKey(nameof(ReportColumnName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ViewName = group.Add(new VocabularyKey(nameof(ViewName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionAttributeRecId = group.Add(new VocabularyKey(nameof(DimensionAttributeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseValuesFrom = group.Add(new VocabularyKey(nameof(UseValuesFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DimensionValueMask = group.Add(new VocabularyKey(nameof(DimensionValueMask), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CopyValuesOnCreate = group.Add(new VocabularyKey(nameof(CopyValuesOnCreate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GiveDerivedDimensionsPrecedence = group.Add(new VocabularyKey(nameof(GiveDerivedDimensionsPrecedence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BalancingDimension_PSN = group.Add(new VocabularyKey(nameof(BalancingDimension_PSN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsBalancing_PSN = group.Add(new VocabularyKey(nameof(IsBalancing_PSN), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey DimensionName { get; private set; }
        public VocabularyKey ReportColumnName { get; private set; }
        public VocabularyKey ViewName { get; private set; }
        public VocabularyKey DimensionAttributeRecId { get; private set; }
        public VocabularyKey UseValuesFrom { get; private set; }
        public VocabularyKey DimensionValueMask { get; private set; }
        public VocabularyKey CopyValuesOnCreate { get; private set; }
        public VocabularyKey GiveDerivedDimensionsPrecedence { get; private set; }
        public VocabularyKey BalancingDimension_PSN { get; private set; }
        public VocabularyKey IsBalancing_PSN { get; private set; }


    }
}