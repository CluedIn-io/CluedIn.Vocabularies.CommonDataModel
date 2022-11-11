using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class WHSOutboundSortingTemplateGroupEntityVocabulary : SimpleVocabulary
    {
        public WHSOutboundSortingTemplateGroupEntityVocabulary()
        {
            VocabularyName = "Common Data Model WHSOutboundSortingTemplateGroupEntity";
            KeyPrefix = "commonDataModel.whsoutboundsortingtemplategroupentity";
            KeySeparator = ".";
            Grouping = "/WHSOutboundSortingTemplateGroupEntity";

            AddGroup("Common Data Model WHSOutboundSortingTemplateGroupEntity Details", group =>
            {
                SortTemplateId = group.Add(new VocabularyKey(nameof(SortTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableFieldId = group.Add(new VocabularyKey(nameof(GroupTableFieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableId = group.Add(new VocabularyKey(nameof(GroupTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SortGroupBy = group.Add(new VocabularyKey(nameof(SortGroupBy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableFieldName = group.Add(new VocabularyKey(nameof(GroupTableFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupTableName = group.Add(new VocabularyKey(nameof(GroupTableName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey SortTemplateId { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey GroupTableFieldId { get; private set; }
        public VocabularyKey GroupTableId { get; private set; }
        public VocabularyKey SortGroupBy { get; private set; }
        public VocabularyKey GroupTableFieldName { get; private set; }
        public VocabularyKey GroupTableName { get; private set; }


    }
}