using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class HcmLaborUnionEntityVocabulary : SimpleVocabulary
    {
        public HcmLaborUnionEntityVocabulary()
        {
            VocabularyName = "Hcm Labor Union Entity";
            KeyPrefix = "commonDataModel.hcmlaborunionentity";
            KeySeparator = ".";
            Grouping = "/HcmLaborUnionEntity";

            AddGroup("HcmLaborUnionEntity Details", group =>
            {
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EntitledToNegotiate = group.Add(new VocabularyKey(nameof(EntitledToNegotiate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UnionId = group.Add(new VocabularyKey(nameof(UnionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey EntitledToNegotiate { get; private set; }
        public VocabularyKey UnionId { get; private set; }
    }
}