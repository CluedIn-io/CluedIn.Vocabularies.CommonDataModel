using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RouteOperationEntityVocabulary : SimpleVocabulary
    {
        public RouteOperationEntityVocabulary()
        {
            VocabularyName = "Route Operation Entity";
            KeyPrefix = "commonDataModel.routeoperationentity";
            KeySeparator = ".";
            Grouping = "/RouteOperationEntity";

            AddGroup("RouteOperationEntity Details", group =>
            {
                OperationName = group.Add(new VocabularyKey(nameof(OperationName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationId = group.Add(new VocabularyKey(nameof(OperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey OperationName { get; private set; }
        public VocabularyKey OperationId { get; private set; }
    }
}