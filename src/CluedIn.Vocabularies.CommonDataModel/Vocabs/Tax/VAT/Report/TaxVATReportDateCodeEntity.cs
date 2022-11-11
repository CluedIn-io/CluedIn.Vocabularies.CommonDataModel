using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxVATReportDateCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxVATReportDateCodeEntityVocabulary()
        {
            VocabularyName = "TaxVATReportDateCodeEntity";
            KeyPrefix = "commonDataModel.taxvatreportdatecodeentity";
            KeySeparator = ".";
            Grouping = "/TaxVATReportDateCodeEntity";

            AddGroup("TaxVATReportDateCodeEntity Details", group =>
            {
                VATReportDateCode = group.Add(new VocabularyKey(nameof(VATReportDateCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IncludeInVATReport = group.Add(new VocabularyKey(nameof(IncludeInVATReport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfDays = group.Add(new VocabularyKey(nameof(NumberOfDays), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountedFrom = group.Add(new VocabularyKey(nameof(CountedFrom), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PartialSettlement = group.Add(new VocabularyKey(nameof(PartialSettlement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                VatDateIsPaymentDate = group.Add(new VocabularyKey(nameof(VatDateIsPaymentDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey VATReportDateCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IncludeInVATReport { get; private set; }
        public VocabularyKey NumberOfDays { get; private set; }
        public VocabularyKey CountedFrom { get; private set; }
        public VocabularyKey PartialSettlement { get; private set; }
        public VocabularyKey VatDateIsPaymentDate { get; private set; }


    }
}