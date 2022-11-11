using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RouteHeaderEntityVocabulary : SimpleVocabulary
    {
        public RouteHeaderEntityVocabulary()
        {
            VocabularyName = "Common Data Model RouteHeaderEntity";
            KeyPrefix = "commonDataModel.routeheaderentity";
            KeySeparator = ".";
            Grouping = "/RouteHeaderEntity";

            AddGroup("Common Data Model RouteHeaderEntity Details", group =>
            {
                IsApproved = group.Add(new VocabularyKey(nameof(IsApproved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteName = group.Add(new VocabularyKey(nameof(RouteName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RouteId = group.Add(new VocabularyKey(nameof(RouteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverPersonnelNumber = group.Add(new VocabularyKey(nameof(ApproverPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsApproved { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey RouteName { get; private set; }
        public VocabularyKey RouteId { get; private set; }
        public VocabularyKey ApproverPersonnelNumber { get; private set; }


    }
}