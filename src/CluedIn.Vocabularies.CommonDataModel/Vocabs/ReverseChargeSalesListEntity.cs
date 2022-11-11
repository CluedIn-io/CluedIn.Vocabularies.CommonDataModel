using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ReverseChargeSalesListEntityVocabulary : SimpleVocabulary
    {
        public ReverseChargeSalesListEntityVocabulary()
        {
            VocabularyName = "ReverseChargeSalesListEntity";
            KeyPrefix = "commonDataModel.reversechargesaleslistentity";
            KeySeparator = ".";
            Grouping = "/ReverseChargeSalesListEntity";

            AddGroup("ReverseChargeSalesListEntity Details", group =>
            {
                CustomerAccount = group.Add(new VocabularyKey(nameof(CustomerAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Correction = group.Add(new VocabularyKey(nameof(Correction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Dispatch = group.Add(new VocabularyKey(nameof(Dispatch), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Invoice = group.Add(new VocabularyKey(nameof(Invoice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Listcode = group.Add(new VocabularyKey(nameof(Listcode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Log = group.Add(new VocabularyKey(nameof(Log), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Number = group.Add(new VocabularyKey(nameof(Number), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReportingStatus = group.Add(new VocabularyKey(nameof(ReportingStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvoiceDate = group.Add(new VocabularyKey(nameof(InvoiceDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransQuarter = group.Add(new VocabularyKey(nameof(TransQuarter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Years = group.Add(new VocabularyKey(nameof(Years), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxExemptNumber = group.Add(new VocabularyKey(nameof(TaxExemptNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CustomerAccount { get; private set; }
        public VocabularyKey Value { get; private set; }
        public VocabularyKey Correction { get; private set; }
        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey Dispatch { get; private set; }
        public VocabularyKey Invoice { get; private set; }
        public VocabularyKey Listcode { get; private set; }
        public VocabularyKey Log { get; private set; }
        public VocabularyKey Number { get; private set; }
        public VocabularyKey ReportingStatus { get; private set; }
        public VocabularyKey InvoiceDate { get; private set; }
        public VocabularyKey TransQuarter { get; private set; }
        public VocabularyKey Years { get; private set; }
        public VocabularyKey TaxExemptNumber { get; private set; }
        public VocabularyKey Company { get; private set; }


    }
}