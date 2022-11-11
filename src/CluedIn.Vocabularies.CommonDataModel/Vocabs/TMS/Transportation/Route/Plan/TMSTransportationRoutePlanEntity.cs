using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSTransportationRoutePlanEntityVocabulary : SimpleVocabulary
    {
        public TMSTransportationRoutePlanEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSTransportationRoutePlanEntity";
            KeyPrefix = "commonDataModel.tmstransportationrouteplanentity";
            KeySeparator = ".";
            Grouping = "/TMSTransportationRoutePlanEntity";

            AddGroup("Common Data Model TMSTransportationRoutePlanEntity Details", group =>
            {
                PlanId = group.Add(new VocabularyKey(nameof(PlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanName = group.Add(new VocabularyKey(nameof(PlanName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey PlanId { get; private set; }
        public VocabularyKey PlanName { get; private set; }


    }
}