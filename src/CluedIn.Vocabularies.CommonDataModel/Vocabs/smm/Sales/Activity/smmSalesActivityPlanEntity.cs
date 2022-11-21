using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmSalesActivityPlanEntityVocabulary : SimpleVocabulary
    {
        public SmmSalesActivityPlanEntityVocabulary()
        {
            VocabularyName = "Smm Sales Activity Plan Entity";
            KeyPrefix = "commonDataModel.smmsalesactivityplanentity";
            KeySeparator = ".";
            Grouping = "/SmmSalesActivityPlanEntity";

            AddGroup("SmmSalesActivityPlanEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanId = group.Add(new VocabularyKey(nameof(PlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PlanId { get; private set; }
    }
}