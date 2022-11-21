using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CAMImportedStatisticalDimensionMemberEntityVocabulary : SimpleVocabulary
    {
        public CAMImportedStatisticalDimensionMemberEntityVocabulary()
        {
            VocabularyName = "CAM Imported Statistical Dimension Member Entity";
            KeyPrefix = "commonDataModel.camimportedstatisticaldimensionmemberentity";
            KeySeparator = ".";
            Grouping = "/CAMImportedStatisticalDimensionMemberEntity";

            AddGroup("CAMImportedStatisticalDimensionMemberEntity Details", group =>
            {
                SourceIdentifier = group.Add(new VocabularyKey(nameof(SourceIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MemberName = group.Add(new VocabularyKey(nameof(MemberName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MemberDescription = group.Add(new VocabularyKey(nameof(MemberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnitOfMeasureSymbol = group.Add(new VocabularyKey(nameof(UnitOfMeasureSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SourceIdentifier { get; private set; }
        public VocabularyKey MemberName { get; private set; }
        public VocabularyKey MemberDescription { get; private set; }
        public VocabularyKey UnitOfMeasureSymbol { get; private set; }
    }
}