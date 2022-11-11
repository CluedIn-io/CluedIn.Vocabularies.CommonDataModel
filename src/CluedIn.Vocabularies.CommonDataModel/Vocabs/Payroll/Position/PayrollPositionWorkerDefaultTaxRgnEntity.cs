using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPositionWorkerDefaultTaxRgnEntityVocabulary : SimpleVocabulary
    {
        public PayrollPositionWorkerDefaultTaxRgnEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollPositionWorkerDefaultTaxRgnEntity";
            KeyPrefix = "commonDataModel.payrollpositionworkerdefaulttaxrgnentity";
            KeySeparator = ".";
            Grouping = "/PayrollPositionWorkerDefaultTaxRgnEntity";

            AddGroup("Common Data Model PayrollPositionWorkerDefaultTaxRgnEntity Details", group =>
            {
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTaxRegion = group.Add(new VocabularyKey(nameof(WorkerTaxRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxRegion = group.Add(new VocabularyKey(nameof(TaxRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WorkerTaxRegionWorker = group.Add(new VocabularyKey(nameof(WorkerTaxRegionWorker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogisticsLocation = group.Add(new VocabularyKey(nameof(LogisticsLocation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LocationId = group.Add(new VocabularyKey(nameof(LocationId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Position { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey WorkerTaxRegion { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey TaxRegion { get; private set; }
        public VocabularyKey WorkerTaxRegionWorker { get; private set; }
        public VocabularyKey LogisticsLocation { get; private set; }
        public VocabularyKey LocationId { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }


    }
}