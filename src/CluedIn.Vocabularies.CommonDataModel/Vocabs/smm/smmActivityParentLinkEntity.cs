using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmActivityParentLinkEntityVocabulary : SimpleVocabulary
    {
        public smmActivityParentLinkEntityVocabulary()
        {
            VocabularyName = "Common Data Model smmActivityParentLinkEntity";
            KeyPrefix = "commonDataModel.smmactivityparentlinkentity";
            KeySeparator = ".";
            Grouping = "/smmActivityParentLinkEntity";

            AddGroup("Common Data Model smmActivityParentLinkEntity Details", group =>
            {
                ActivityNumber = group.Add(new VocabularyKey(nameof(ActivityNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentType = group.Add(new VocabularyKey(nameof(ParentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsPrimaryLink = group.Add(new VocabularyKey(nameof(IsPrimaryLink), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Reference = group.Add(new VocabularyKey(nameof(Reference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReferenceTableID = group.Add(new VocabularyKey(nameof(ReferenceTableID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentId = group.Add(new VocabularyKey(nameof(ParentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ParentSecondaryId = group.Add(new VocabularyKey(nameof(ParentSecondaryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ActivityNumber { get; private set; }
        public VocabularyKey ParentType { get; private set; }
        public VocabularyKey IsPrimaryLink { get; private set; }
        public VocabularyKey Reference { get; private set; }
        public VocabularyKey ReferenceTableID { get; private set; }
        public VocabularyKey ParentId { get; private set; }
        public VocabularyKey ParentSecondaryId { get; private set; }


    }
}