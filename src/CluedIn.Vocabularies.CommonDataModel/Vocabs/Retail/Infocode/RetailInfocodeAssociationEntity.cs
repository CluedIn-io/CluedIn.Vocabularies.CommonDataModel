using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailInfocodeAssociationEntityVocabulary : SimpleVocabulary
    {
        public RetailInfocodeAssociationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RetailInfocodeAssociationEntity";
            KeyPrefix = "commonDataModel.retailinfocodeassociationentity";
            KeySeparator = ".";
            Grouping = "/RetailInfocodeAssociationEntity";

            AddGroup("Common Data Model RetailInfocodeAssociationEntity Details", group =>
            {
                InfocodeId = group.Add(new VocabularyKey(nameof(InfocodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InputRequired = group.Add(new VocabularyKey(nameof(InputRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefRelation1 = group.Add(new VocabularyKey(nameof(RefRelation1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefRelation2 = group.Add(new VocabularyKey(nameof(RefRelation2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefRelation3 = group.Add(new VocabularyKey(nameof(RefRelation3), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RefTableId = group.Add(new VocabularyKey(nameof(RefTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Sequence = group.Add(new VocabularyKey(nameof(Sequence), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WhenRequired = group.Add(new VocabularyKey(nameof(WhenRequired), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey InfocodeId { get; private set; }
        public VocabularyKey InputRequired { get; private set; }
        public VocabularyKey RefRelation1 { get; private set; }
        public VocabularyKey RefRelation2 { get; private set; }
        public VocabularyKey RefRelation3 { get; private set; }
        public VocabularyKey RefTableId { get; private set; }
        public VocabularyKey Sequence { get; private set; }
        public VocabularyKey WhenRequired { get; private set; }


    }
}