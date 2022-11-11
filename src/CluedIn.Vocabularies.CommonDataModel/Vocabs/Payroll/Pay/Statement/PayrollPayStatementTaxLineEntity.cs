using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PayrollPayStatementTaxLineEntityVocabulary : SimpleVocabulary
    {
        public PayrollPayStatementTaxLineEntityVocabulary()
        {
            VocabularyName = "PayrollPayStatementTaxLineEntity";
            KeyPrefix = "commonDataModel.payrollpaystatementtaxlineentity";
            KeySeparator = ".";
            Grouping = "/PayrollPayStatementTaxLineEntity";

            AddGroup("PayrollPayStatementTaxLineEntity Details", group =>
            {
                AmountInTransactionCurrency = group.Add(new VocabularyKey(nameof(AmountInTransactionCurrency), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDate = group.Add(new VocabularyKey(nameof(AccountingDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TemplateId = group.Add(new VocabularyKey(nameof(TemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                EmployerContribution = group.Add(new VocabularyKey(nameof(EmployerContribution), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineToRemove = group.Add(new VocabularyKey(nameof(LineToRemove), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineOverridden = group.Add(new VocabularyKey(nameof(LineOverridden), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatement = group.Add(new VocabularyKey(nameof(PayStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversedPayStatementLine = group.Add(new VocabularyKey(nameof(ReversedPayStatementLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatementLineSource = group.Add(new VocabularyKey(nameof(PayStatementLineSource), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SourceDocumentLine = group.Add(new VocabularyKey(nameof(SourceDocumentLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCode = group.Add(new VocabularyKey(nameof(TaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionTemplateId = group.Add(new VocabularyKey(nameof(AccountingDistributionTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionLegalEntityId = group.Add(new VocabularyKey(nameof(AccountingDistributionLegalEntityId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AccountingDistributionLegalEntity = group.Add(new VocabularyKey(nameof(AccountingDistributionLegalEntity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PayStatementNumber = group.Add(new VocabularyKey(nameof(PayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PositionId = group.Add(new VocabularyKey(nameof(PositionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversedPayStatement = group.Add(new VocabularyKey(nameof(ReversedPayStatement), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversedPayStatementLineNum = group.Add(new VocabularyKey(nameof(ReversedPayStatementLineNum), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReversedPayStatementNumber = group.Add(new VocabularyKey(nameof(ReversedPayStatementNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeId = group.Add(new VocabularyKey(nameof(TaxCodeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxCodeCountryRegionId = group.Add(new VocabularyKey(nameof(TaxCodeCountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AmountInTransactionCurrency { get; private set; }
        public VocabularyKey AccountingDate { get; private set; }
        public VocabularyKey TemplateId { get; private set; }
        public VocabularyKey EmployerContribution { get; private set; }
        public VocabularyKey LineToRemove { get; private set; }
        public VocabularyKey LineOverridden { get; private set; }
        public VocabularyKey PayStatement { get; private set; }
        public VocabularyKey Position { get; private set; }
        public VocabularyKey ReversedPayStatementLine { get; private set; }
        public VocabularyKey PayStatementLineSource { get; private set; }
        public VocabularyKey SourceDocumentLine { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey Company { get; private set; }
        public VocabularyKey TaxCode { get; private set; }
        public VocabularyKey AccountingDistributionTemplateId { get; private set; }
        public VocabularyKey AccountingDistributionLegalEntityId { get; private set; }
        public VocabularyKey AccountingDistributionLegalEntity { get; private set; }
        public VocabularyKey PayStatementNumber { get; private set; }
        public VocabularyKey PositionId { get; private set; }
        public VocabularyKey ReversedPayStatement { get; private set; }
        public VocabularyKey ReversedPayStatementLineNum { get; private set; }
        public VocabularyKey ReversedPayStatementNumber { get; private set; }
        public VocabularyKey TaxCodeId { get; private set; }
        public VocabularyKey TaxCodeCountryRegionId { get; private set; }


    }
}