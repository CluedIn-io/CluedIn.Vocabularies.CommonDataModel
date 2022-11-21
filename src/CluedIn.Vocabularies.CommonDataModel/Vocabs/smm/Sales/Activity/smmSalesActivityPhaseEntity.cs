using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SmmSalesActivityPhaseEntityVocabulary : SimpleVocabulary
    {
        public SmmSalesActivityPhaseEntityVocabulary()
        {
            VocabularyName = "Smm Sales Activity Phase Entity";
            KeyPrefix = "commonDataModel.smmsalesactivityphaseentity";
            KeySeparator = ".";
            Grouping = "/SmmSalesActivityPhaseEntity";

            AddGroup("SmmSalesActivityPhaseEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PhaseId = group.Add(new VocabularyKey(nameof(PhaseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey PhaseId { get; private set; }
    }
}