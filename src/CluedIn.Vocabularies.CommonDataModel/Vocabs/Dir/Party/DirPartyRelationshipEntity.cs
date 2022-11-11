using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirPartyRelationshipEntityVocabulary : SimpleVocabulary
    {
        public DirPartyRelationshipEntityVocabulary()
        {
            VocabularyName = "DirPartyRelationshipEntity";
            KeyPrefix = "commonDataModel.dirpartyrelationshipentity";
            KeySeparator = ".";
            Grouping = "/DirPartyRelationshipEntity";

            AddGroup("DirPartyRelationshipEntity Details", group =>
            {
                LegalEntityDataArea = group.Add(new VocabularyKey(nameof(LegalEntityDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelationshipType = group.Add(new VocabularyKey(nameof(RelationshipType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChildPartyId = group.Add(new VocabularyKey(nameof(ChildPartyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChildParty = group.Add(new VocabularyKey(nameof(ChildParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentParty = group.Add(new VocabularyKey(nameof(ParentParty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NullableParentPartyId = group.Add(new VocabularyKey(nameof(NullableParentPartyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentPartyId = group.Add(new VocabularyKey(nameof(ParentPartyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemType = group.Add(new VocabularyKey(nameof(SystemType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LegalEntityDataArea { get; private set; }
        public VocabularyKey RelationshipType { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey ChildPartyId { get; private set; }
        public VocabularyKey ChildParty { get; private set; }
        public VocabularyKey ParentParty { get; private set; }
        public VocabularyKey NullableParentPartyId { get; private set; }
        public VocabularyKey ParentPartyId { get; private set; }
        public VocabularyKey SystemType { get; private set; }


    }
}