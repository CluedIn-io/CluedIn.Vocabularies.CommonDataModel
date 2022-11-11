using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollUSTaxTransactionHistoryEntityVocabulary : SimpleVocabulary
    {
        public PayrollUSTaxTransactionHistoryEntityVocabulary()
        {
            VocabularyName = "Common Data Model PayrollUSTaxTransactionHistoryEntity";
            KeyPrefix = "commonDataModel.payrollustaxtransactionhistoryentity";
            KeySeparator = ".";
            Grouping = "/PayrollUSTaxTransactionHistoryEntity";

            AddGroup("Common Data Model PayrollUSTaxTransactionHistoryEntity Details", group =>
            {
                CalculatedTaxAmount = group.Add(new VocabularyKey(nameof(CalculatedTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransDate = group.Add(new VocabularyKey(nameof(TransDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExcessWages = group.Add(new VocabularyKey(nameof(ExcessWages), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossSubjectWages = group.Add(new VocabularyKey(nameof(GrossSubjectWages), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossWages = group.Add(new VocabularyKey(nameof(GrossWages), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Hours = group.Add(new VocabularyKey(nameof(Hours), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatement = group.Add(new VocabularyKey(nameof(PayStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Rate = group.Add(new VocabularyKey(nameof(Rate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Residency = group.Add(new VocabularyKey(nameof(Residency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SubjectWages = group.Add(new VocabularyKey(nameof(SubjectWages), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxationState = group.Add(new VocabularyKey(nameof(TaxationState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxPayType = group.Add(new VocabularyKey(nameof(TaxPayType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UniqueTaxId = group.Add(new VocabularyKey(nameof(UniqueTaxId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                WageBase = group.Add(new VocabularyKey(nameof(WageBase), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Worker = group.Add(new VocabularyKey(nameof(Worker), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PoliticalSubDivisionId = group.Add(new VocabularyKey(nameof(PoliticalSubDivisionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriorState = group.Add(new VocabularyKey(nameof(PriorState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PriorStateWageAmount = group.Add(new VocabularyKey(nameof(PriorStateWageAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PersonnelNumber = group.Add(new VocabularyKey(nameof(PersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatementNumber = group.Add(new VocabularyKey(nameof(PayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SequenceNumber = group.Add(new VocabularyKey(nameof(SequenceNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CalculatedTaxAmount { get; private set; }
        public VocabularyKey TransDate { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ExcessWages { get; private set; }
        public VocabularyKey GrossSubjectWages { get; private set; }
        public VocabularyKey GrossWages { get; private set; }
        public VocabularyKey Hours { get; private set; }
        public VocabularyKey PayStatement { get; private set; }
        public VocabularyKey Rate { get; private set; }
        public VocabularyKey Residency { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey SubjectWages { get; private set; }
        public VocabularyKey TaxationState { get; private set; }
        public VocabularyKey TaxCode { get; private set; }
        public VocabularyKey TaxPayType { get; private set; }
        public VocabularyKey UniqueTaxId { get; private set; }
        public VocabularyKey WageBase { get; private set; }
        public VocabularyKey Worker { get; private set; }
        public VocabularyKey PoliticalSubDivisionId { get; private set; }
        public VocabularyKey PriorState { get; private set; }
        public VocabularyKey PriorStateWageAmount { get; private set; }
        public VocabularyKey PersonnelNumber { get; private set; }
        public VocabularyKey PayStatementNumber { get; private set; }
        public VocabularyKey TaxCodeId { get; private set; }
        public VocabularyKey CountryRegionId { get; private set; }
        public VocabularyKey SequenceNumber { get; private set; }


    }
}