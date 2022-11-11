using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class NaturalResourcesTaxReportSetupEntityVocabulary : SimpleVocabulary
    {
        public NaturalResourcesTaxReportSetupEntityVocabulary()
        {
            VocabularyName = "Common Data Model NaturalResourcesTaxReportSetupEntity";
            KeyPrefix = "commonDataModel.naturalresourcestaxreportsetupentity";
            KeySeparator = ".";
            Grouping = "/NaturalResourcesTaxReportSetupEntity";

            AddGroup("Common Data Model NaturalResourcesTaxReportSetupEntity Details", group =>
            {
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormNumber = group.Add(new VocabularyKey(nameof(FormNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineCode = group.Add(new VocabularyKey(nameof(LineCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WarehouseId = group.Add(new VocabularyKey(nameof(WarehouseId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PackMaterialCode = group.Add(new VocabularyKey(nameof(PackMaterialCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TotalLineCode = group.Add(new VocabularyKey(nameof(TotalLineCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Description { get; private set; }
        public VocabularyKey FormNumber { get; private set; }
        public VocabularyKey LineCode { get; private set; }
        public VocabularyKey LineType { get; private set; }
        public VocabularyKey WarehouseId { get; private set; }
        public VocabularyKey PackMaterialCode { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }
        public VocabularyKey TaxCode { get; private set; }
        public VocabularyKey TotalLineCode { get; private set; }


    }
}