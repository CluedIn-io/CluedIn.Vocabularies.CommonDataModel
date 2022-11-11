using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollWorkerTaxRegionEntityVocabulary : SimpleVocabulary
    {
        public PayrollWorkerTaxRegionEntityVocabulary()
        {
            VocabularyName = "PayrollWorkerTaxRegionEntity";
            KeyPrefix = "commonDataModel.payrollworkertaxregionentity";
            KeySeparator = ".";
            Grouping = "/PayrollWorkerTaxRegionEntity";

            AddGroup("PayrollWorkerTaxRegionEntity Details", group =>
            {
                TaxRegion = group.Add(new VocabularyKey(nameof(TaxRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Location = group.Add(new VocabularyKey(nameof(Location), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerResidentTaxRegionRecId = group.Add(new VocabularyKey(nameof(WorkerResidentTaxRegionRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFrom = group.Add(new VocabularyKey(nameof(ValidFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidTo = group.Add(new VocabularyKey(nameof(ValidTo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsResident = group.Add(new VocabularyKey(nameof(IsResident), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PoliticalSubDivisionId = group.Add(new VocabularyKey(nameof(PoliticalSubDivisionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MunicipalityId = group.Add(new VocabularyKey(nameof(MunicipalityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SchoolDistrictId = group.Add(new VocabularyKey(nameof(SchoolDistrictId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey TaxRegion { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey Location { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey WorkerResidentTaxRegionRecId { get; private set; }
        public VocabularyKey ValidFrom { get; private set; }
        public VocabularyKey ValidTo { get; private set; }
        public VocabularyKey IsResident { get; private set; }
        public VocabularyKey PoliticalSubDivisionId { get; private set; }
        public VocabularyKey MunicipalityId { get; private set; }
        public VocabularyKey SchoolDistrictId { get; private set; }


    }
}