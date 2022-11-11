using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmSalesActivityPlanEntityVocabulary : SimpleVocabulary
    {
        public smmSalesActivityPlanEntityVocabulary()
        {
            VocabularyName = "smmSalesActivityPlanEntity";
            KeyPrefix = "commonDataModel.smmsalesactivityplanentity";
            KeySeparator = ".";
            Grouping = "/smmSalesActivityPlanEntity";

            AddGroup("smmSalesActivityPlanEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PlanId = group.Add(new VocabularyKey(nameof(PlanId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey PlanId { get; private set; }


    }
}