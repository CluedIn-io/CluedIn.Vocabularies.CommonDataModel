using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesOrderOriginEntityVocabulary : SimpleVocabulary
    {
        public SalesOrderOriginEntityVocabulary()
        {
            VocabularyName = "Sales Order Origin Entity";
            KeyPrefix = "commonDataModel.salesorderoriginentity";
            KeySeparator = ".";
            Grouping = "/SalesOrderOriginEntity";

            AddGroup("SalesOrderOriginEntity Details", group =>
            {
                OriginDescription = group.Add(new VocabularyKey(nameof(OriginDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginCode = group.Add(new VocabularyKey(nameof(OriginCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OriginType = group.Add(new VocabularyKey(nameof(OriginType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsOriginTypeAssigned = group.Add(new VocabularyKey(nameof(IsOriginTypeAssigned), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey OriginDescription { get; private set; }
        public VocabularyKey OriginCode { get; private set; }
        public VocabularyKey OriginType { get; private set; }
        public VocabularyKey IsOriginTypeAssigned { get; private set; }
    }
}