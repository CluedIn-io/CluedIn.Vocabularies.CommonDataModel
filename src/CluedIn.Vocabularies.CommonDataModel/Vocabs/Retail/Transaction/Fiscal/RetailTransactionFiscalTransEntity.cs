using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailTransactionFiscalTransEntityVocabulary : SimpleVocabulary
    {
        public RetailTransactionFiscalTransEntityVocabulary()
        {
            VocabularyName = "Retail Transaction Fiscal Trans Entity";
            KeyPrefix = "commonDataModel.retailtransactionfiscaltransentity";
            KeySeparator = ".";
            Grouping = "/RetailTransactionFiscalTransEntity";

            AddGroup("RetailTransactionFiscalTransEntity Details", group =>
            {
                RecordGuid = group.Add(new VocabularyKey(nameof(RecordGuid), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitNumber = group.Add(new VocabularyKey(nameof(OperatingUnitNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Channel = group.Add(new VocabularyKey(nameof(Channel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OperatingUnitID = group.Add(new VocabularyKey(nameof(OperatingUnitID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Terminal = group.Add(new VocabularyKey(nameof(Terminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionNumber = group.Add(new VocabularyKey(nameof(TransactionNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionDate = group.Add(new VocabularyKey(nameof(TransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionTime = group.Add(new VocabularyKey(nameof(TransactionTime), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisterStore = group.Add(new VocabularyKey(nameof(RegisterStore), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisterTerminal = group.Add(new VocabularyKey(nameof(RegisterTerminal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StaffId = group.Add(new VocabularyKey(nameof(StaffId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisterResponse = group.Add(new VocabularyKey(nameof(RegisterResponse), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceiptCopy = group.Add(new VocabularyKey(nameof(ReceiptCopy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationProcessId = group.Add(new VocabularyKey(nameof(RegistrationProcessId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConnectorName = group.Add(new VocabularyKey(nameof(ConnectorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConnectorFunctionalityProfileId = group.Add(new VocabularyKey(nameof(ConnectorFunctionalityProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationStatus = group.Add(new VocabularyKey(nameof(RegistrationStatus), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ConnectorGroup = group.Add(new VocabularyKey(nameof(ConnectorGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegisterInfo = group.Add(new VocabularyKey(nameof(RegisterInfo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DocumentNumber = group.Add(new VocabularyKey(nameof(DocumentNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RegistrationType = group.Add(new VocabularyKey(nameof(RegistrationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ServiceName = group.Add(new VocabularyKey(nameof(ServiceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey RecordGuid { get; private set; }
        public VocabularyKey OperatingUnitNumber { get; private set; }
        public VocabularyKey Channel { get; private set; }
        public VocabularyKey OperatingUnitID { get; private set; }
        public VocabularyKey Terminal { get; private set; }
        public VocabularyKey TransactionNumber { get; private set; }
        public VocabularyKey LineNumber { get; private set; }
        public VocabularyKey TransactionDate { get; private set; }
        public VocabularyKey TransactionTime { get; private set; }
        public VocabularyKey RegisterStore { get; private set; }
        public VocabularyKey RegisterTerminal { get; private set; }
        public VocabularyKey StaffId { get; private set; }
        public VocabularyKey RegisterResponse { get; private set; }
        public VocabularyKey ReceiptCopy { get; private set; }
        public VocabularyKey RegistrationProcessId { get; private set; }
        public VocabularyKey ConnectorName { get; private set; }
        public VocabularyKey ConnectorFunctionalityProfileId { get; private set; }
        public VocabularyKey RegistrationStatus { get; private set; }
        public VocabularyKey ConnectorGroup { get; private set; }
        public VocabularyKey RegisterInfo { get; private set; }
        public VocabularyKey DocumentNumber { get; private set; }
        public VocabularyKey CountryRegion { get; private set; }
        public VocabularyKey RegistrationType { get; private set; }
        public VocabularyKey ServiceName { get; private set; }
    }
}