using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalOrganizationEntityVocabulary : SimpleVocabulary
    {
        public FiscalOrganizationEntityVocabulary()
        {
            VocabularyName = "Fiscal Organization Entity";
            KeyPrefix = "commonDataModel.fiscalorganizationentity";
            KeySeparator = ".";
            Grouping = "/FiscalOrganizationEntity";

            AddGroup("FiscalOrganizationEntity Details", group =>
            {
                TypeOfActivity = group.Add(new VocabularyKey(nameof(TypeOfActivity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TypeOfAssessmentContribution = group.Add(new VocabularyKey(nameof(TypeOfAssessmentContribution), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BookingAndAssessmentCriteria = group.Add(new VocabularyKey(nameof(BookingAndAssessmentCriteria), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AssessmentRegimen = group.Add(new VocabularyKey(nameof(AssessmentRegimen), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxCOFINSExpense = group.Add(new VocabularyKey(nameof(SalesTaxCOFINSExpense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConstitutionArchiveDate = group.Add(new VocabularyKey(nameof(ConstitutionArchiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConversionArchiveDate = group.Add(new VocabularyKey(nameof(ConversionArchiveDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CreditAllocationMethod = group.Add(new VocabularyKey(nameof(CreditAllocationMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RootFiscalEstablishmentDataArea = group.Add(new VocabularyKey(nameof(RootFiscalEstablishmentDataArea), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RootFiscalEstablishment = group.Add(new VocabularyKey(nameof(RootFiscalEstablishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalEntityType = group.Add(new VocabularyKey(nameof(LegalEntityType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LayoutVersion = group.Add(new VocabularyKey(nameof(LayoutVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompanyType = group.Add(new VocabularyKey(nameof(CompanyType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LargeCompany = group.Add(new VocabularyKey(nameof(LargeCompany), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LegalNature = group.Add(new VocabularyKey(nameof(LegalNature), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxPISExpense = group.Add(new VocabularyKey(nameof(SalesTaxPISExpense), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SCPCode = group.Add(new VocabularyKey(nameof(SCPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SCPParticipation = group.Add(new VocabularyKey(nameof(SCPParticipation), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxCOFINSExpenseDisplayValue = group.Add(new VocabularyKey(nameof(SalesTaxCOFINSExpenseDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SalesTaxPISExpenseDisplayValue = group.Add(new VocabularyKey(nameof(SalesTaxPISExpenseDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey TypeOfActivity { get; private set; }
        public VocabularyKey TypeOfAssessmentContribution { get; private set; }
        public VocabularyKey BookingAndAssessmentCriteria { get; private set; }
        public VocabularyKey AssessmentRegimen { get; private set; }
        public VocabularyKey SalesTaxCOFINSExpense { get; private set; }
        public VocabularyKey ConstitutionArchiveDate { get; private set; }
        public VocabularyKey ConversionArchiveDate { get; private set; }
        public VocabularyKey CreditAllocationMethod { get; private set; }
        public VocabularyKey RootFiscalEstablishmentDataArea { get; private set; }
        public VocabularyKey RootFiscalEstablishment { get; private set; }
        public VocabularyKey LegalEntityType { get; private set; }
        public VocabularyKey LayoutVersion { get; private set; }
        public VocabularyKey CompanyType { get; private set; }
        public VocabularyKey LargeCompany { get; private set; }
        public VocabularyKey LegalNature { get; private set; }
        public VocabularyKey SalesTaxPISExpense { get; private set; }
        public VocabularyKey SCPCode { get; private set; }
        public VocabularyKey SCPParticipation { get; private set; }
        public VocabularyKey SalesTaxCOFINSExpenseDisplayValue { get; private set; }
        public VocabularyKey SalesTaxPISExpenseDisplayValue { get; private set; }
    }
}