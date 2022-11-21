using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankPromissoryNoteLayoutEntityVocabulary : SimpleVocabulary
    {
        public BankPromissoryNoteLayoutEntityVocabulary()
        {
            VocabularyName = "Bank Promissory Note Layout Entity";
            KeyPrefix = "commonDataModel.bankpromissorynotelayoutentity";
            KeySeparator = ".";
            Grouping = "/BankPromissoryNoteLayoutEntity";

            AddGroup("BankPromissoryNoteLayoutEntity Details", group =>
            {
                AmountPrefix = group.Add(new VocabularyKey(nameof(AmountPrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintBankAccount = group.Add(new VocabularyKey(nameof(PrintBankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BankAccountId = group.Add(new VocabularyKey(nameof(BankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintBankCity = group.Add(new VocabularyKey(nameof(PrintBankCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintBankName = group.Add(new VocabularyKey(nameof(PrintBankName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintBankNumber = group.Add(new VocabularyKey(nameof(PrintBankNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintCompanyLogo = group.Add(new VocabularyKey(nameof(PrintCompanyLogo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintCompanyName = group.Add(new VocabularyKey(nameof(PrintCompanyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintDueDate = group.Add(new VocabularyKey(nameof(PrintDueDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormatNoteNumber = group.Add(new VocabularyKey(nameof(FormatNoteNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormatType = group.Add(new VocabularyKey(nameof(FormatType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberMethod = group.Add(new VocabularyKey(nameof(NumberMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartPositionUnit = group.Add(new VocabularyKey(nameof(StartPositionUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfSlipCopies = group.Add(new VocabularyKey(nameof(NumberOfSlipCopies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartPosition = group.Add(new VocabularyKey(nameof(StartPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaperLength = group.Add(new VocabularyKey(nameof(PaperLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaperLengthUnit = group.Add(new VocabularyKey(nameof(PaperLengthUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaperFormat = group.Add(new VocabularyKey(nameof(PaperFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintFirstSignature = group.Add(new VocabularyKey(nameof(PrintFirstSignature), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstSignatureAmountLimit = group.Add(new VocabularyKey(nameof(FirstSignatureAmountLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintSecondSignature = group.Add(new VocabularyKey(nameof(PrintSecondSignature), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondSignatureAmountLimit = group.Add(new VocabularyKey(nameof(SecondSignatureAmountLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintTransactionDate = group.Add(new VocabularyKey(nameof(PrintTransactionDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey AmountPrefix { get; private set; }
        public VocabularyKey PrintBankAccount { get; private set; }
        public VocabularyKey BankAccountId { get; private set; }
        public VocabularyKey PrintBankCity { get; private set; }
        public VocabularyKey PrintBankName { get; private set; }
        public VocabularyKey PrintBankNumber { get; private set; }
        public VocabularyKey PrintCompanyLogo { get; private set; }
        public VocabularyKey PrintCompanyName { get; private set; }
        public VocabularyKey PrintDueDate { get; private set; }
        public VocabularyKey FormatNoteNumber { get; private set; }
        public VocabularyKey FormatType { get; private set; }
        public VocabularyKey NumberMethod { get; private set; }
        public VocabularyKey StartPositionUnit { get; private set; }
        public VocabularyKey NumberOfSlipCopies { get; private set; }
        public VocabularyKey StartPosition { get; private set; }
        public VocabularyKey PaperLength { get; private set; }
        public VocabularyKey PaperLengthUnit { get; private set; }
        public VocabularyKey PaperFormat { get; private set; }
        public VocabularyKey PrintFirstSignature { get; private set; }
        public VocabularyKey FirstSignatureAmountLimit { get; private set; }
        public VocabularyKey PrintSecondSignature { get; private set; }
        public VocabularyKey SecondSignatureAmountLimit { get; private set; }
        public VocabularyKey PrintTransactionDate { get; private set; }
    }
}