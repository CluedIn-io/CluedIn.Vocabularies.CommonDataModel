using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollEmployerTaxRegionEntityVocabulary : SimpleVocabulary
    {
        public PayrollEmployerTaxRegionEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollEmployerTaxRegionEntity";
            KeyPrefix = "commonDataModel.payrollemployertaxregionentity";
            KeySeparator = ".";
            Grouping = "/PayrollEmployerTaxRegionEntity";

            AddGroup("Common Data Model PayrollEmployerTaxRegionEntity Details", group =>
            {
                IsActive = group.Add(new VocabularyKey(nameof(IsActive), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityId = group.Add(new VocabularyKey(nameof(LegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StateId = group.Add(new VocabularyKey(nameof(StateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntity = group.Add(new VocabularyKey(nameof(LegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey IsActive { get; private set; }
        public VocabularyKey LegalEntityId { get; private set; }
        public VocabularyKey StateId { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey LegalEntity { get; private set; }


    }
}