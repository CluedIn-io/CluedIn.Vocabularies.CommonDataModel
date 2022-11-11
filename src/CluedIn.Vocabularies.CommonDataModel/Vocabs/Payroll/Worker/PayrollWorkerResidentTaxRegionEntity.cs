using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerResidentTaxRegionEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerResidentTaxRegionEntityVocabulary()
        {
            VocabularyName = "PayrollWorkerResidentTaxRegionEntity";
            KeyPrefix = "commonDataModel.payrollworkerresidenttaxregionentity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerResidentTaxRegionEntity";

            AddGroup("PayrollWorkerResidentTaxRegionEntity Details", group =>
            {
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTaxRegion = group.Add(new VocabularyKey(nameof(WorkerTaxRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsApplyingCourtesyWithholding = group.Add(new VocabularyKey(nameof(IsApplyingCourtesyWithholding), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegion = group.Add(new VocabularyKey(nameof(TaxRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey WorkerTaxRegion { get; private set; }
        public VocabularyKey IsApplyingCourtesyWithholding { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey TaxRegion { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey LocationId { get; private set; }


    }
}