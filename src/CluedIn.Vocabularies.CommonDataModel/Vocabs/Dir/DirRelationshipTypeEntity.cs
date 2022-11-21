using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class DirRelationshipTypeEntityVocabulary : SimpleVocabulary
    {
        public DirRelationshipTypeEntityVocabulary()
        {
            VocabularyName = "Dir Relationship Type Entity";
            KeyPrefix = "commonDataModel.dirrelationshiptypeentity";
            KeySeparator = ".";
            Grouping = "/DirRelationshipTypeEntity";

            AddGroup("DirRelationshipTypeEntity Details", group =>
            {
                RelationshipAToB = group.Add(new VocabularyKey(nameof(RelationshipAToB), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyAType = group.Add(new VocabularyKey(nameof(PartyAType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Symmetric = group.Add(new VocabularyKey(nameof(Symmetric), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RelationshipBToA = group.Add(new VocabularyKey(nameof(RelationshipBToA), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartyBType = group.Add(new VocabularyKey(nameof(PartyBType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ID = group.Add(new VocabularyKey(nameof(ID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SystemType = group.Add(new VocabularyKey(nameof(SystemType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RelationshipAToB { get; private set; }
        public VocabularyKey PartyAType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Symmetric { get; private set; }
        public VocabularyKey RelationshipBToA { get; private set; }
        public VocabularyKey PartyBType { get; private set; }
        public VocabularyKey ID { get; private set; }
        public VocabularyKey SystemType { get; private set; }
    }
}