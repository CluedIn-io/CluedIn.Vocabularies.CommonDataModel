using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CAMImportedCostObjectDimensionMemberEntityVocabulary : SimpleVocabulary
    {
        public CAMImportedCostObjectDimensionMemberEntityVocabulary()
        {
            VocabularyName = "CAM Imported Cost Object Dimension Member Entity";
            KeyPrefix = "commonDataModel.camimportedcostobjectdimensionmemberentity";
            KeySeparator = ".";
            Grouping = "/CAMImportedCostObjectDimensionMemberEntity";

            AddGroup("CAMImportedCostObjectDimensionMemberEntity Details", group =>
            {
                SourceIdentifier = group.Add(new VocabularyKey(nameof(SourceIdentifier), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MemberName = group.Add(new VocabularyKey(nameof(MemberName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MemberDescription = group.Add(new VocabularyKey(nameof(MemberDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey SourceIdentifier { get; private set; }
        public VocabularyKey MemberName { get; private set; }
        public VocabularyKey MemberDescription { get; private set; }
    }
}