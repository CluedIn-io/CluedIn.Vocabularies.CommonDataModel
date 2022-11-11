using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RouteOperationEntityV2Vocabulary : SimpleVocabulary
    {
        public RouteOperationEntityV2Vocabulary()
        {
            VocabularyName = "Common Data Model RouteOperationEntityV2";
            KeyPrefix = "commonDataModel.routeoperationentityv2";
            KeySeparator = ".";
            Grouping = "/RouteOperationEntityV2";

            AddGroup("Common Data Model RouteOperationEntityV2 Details", group =>
            {
                AccumulatedScrapPercentage = group.Add(new VocabularyKey(nameof(AccumulatedScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextOperationLinkType = group.Add(new VocabularyKey(nameof(NextOperationLinkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NextRouteOperationNumber = group.Add(new VocabularyKey(nameof(NextRouteOperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationId = group.Add(new VocabularyKey(nameof(OperationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationNumber = group.Add(new VocabularyKey(nameof(OperationNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperationPriority = group.Add(new VocabularyKey(nameof(OperationPriority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteId = group.Add(new VocabularyKey(nameof(RouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScrapPercentage = group.Add(new VocabularyKey(nameof(ScrapPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AccumulatedScrapPercentage { get; private set; }
        public VocabularyKey NextOperationLinkType { get; private set; }
        public VocabularyKey NextRouteOperationNumber { get; private set; }
        public VocabularyKey OperationId { get; private set; }
        public VocabularyKey OperationNumber { get; private set; }
        public VocabularyKey OperationPriority { get; private set; }
        public VocabularyKey RouteId { get; private set; }
        public VocabularyKey ScrapPercentage { get; private set; }


    }
}