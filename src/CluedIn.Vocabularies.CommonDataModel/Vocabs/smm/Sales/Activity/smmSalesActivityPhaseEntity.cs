using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class smmSalesActivityPhaseEntityVocabulary : SimpleVocabulary
    {
        public smmSalesActivityPhaseEntityVocabulary()
        {
            VocabularyName = "smmSalesActivityPhaseEntity";
            KeyPrefix = "commonDataModel.smmsalesactivityphaseentity";
            KeySeparator = ".";
            Grouping = "/smmSalesActivityPhaseEntity";

            AddGroup("smmSalesActivityPhaseEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhaseId = group.Add(new VocabularyKey(nameof(PhaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey PhaseId { get; private set; }


    }
}