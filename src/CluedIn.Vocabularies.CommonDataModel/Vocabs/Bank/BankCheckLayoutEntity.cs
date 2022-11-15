using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class BankCheckLayoutEntityVocabulary : SimpleVocabulary
    {
        public BankCheckLayoutEntityVocabulary()
        {
            VocabularyName = "Bank Check Layout Entity";
            KeyPrefix = "commonDataModel.bankchecklayoutentity";
            KeySeparator = ".";
            Grouping = "/BankCheckLayoutEntity";

            AddGroup("BankCheckLayoutEntity Details", group =>
            {
                BankAccountId = group.Add(new VocabularyKey(nameof(BankAccountId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AmountPrefix = group.Add(new VocabularyKey(nameof(AmountPrefix), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintBankAccount = group.Add(new VocabularyKey(nameof(PrintBankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomWatermark = group.Add(new VocabularyKey(nameof(CustomWatermark), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintBankName = group.Add(new VocabularyKey(nameof(PrintBankName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintBankNumber = group.Add(new VocabularyKey(nameof(PrintBankNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ACode = group.Add(new VocabularyKey(nameof(ACode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                BCode = group.Add(new VocabularyKey(nameof(BCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CCode = group.Add(new VocabularyKey(nameof(CCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateFormat = group.Add(new VocabularyKey(nameof(DateFormat), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DateSeparator = group.Add(new VocabularyKey(nameof(DateSeparator), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormatType = group.Add(new VocabularyKey(nameof(FormatType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckNumberMethod = group.Add(new VocabularyKey(nameof(CheckNumberMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartPositionUnit = group.Add(new VocabularyKey(nameof(StartPositionUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                NumberOfSlipCopies = group.Add(new VocabularyKey(nameof(NumberOfSlipCopies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                StartPosition = group.Add(new VocabularyKey(nameof(StartPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintCompanyLogo = group.Add(new VocabularyKey(nameof(PrintCompanyLogo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintCompanyName = group.Add(new VocabularyKey(nameof(PrintCompanyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CopySignatureType = group.Add(new VocabularyKey(nameof(CopySignatureType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CopyWatermarkType = group.Add(new VocabularyKey(nameof(CopyWatermarkType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FooterText = group.Add(new VocabularyKey(nameof(FooterText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HeaderText = group.Add(new VocabularyKey(nameof(HeaderText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintMICRLine = group.Add(new VocabularyKey(nameof(PrintMICRLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MICRLine = group.Add(new VocabularyKey(nameof(MICRLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CheckNumberLength = group.Add(new VocabularyKey(nameof(CheckNumberLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintLeadingZerosOnMICRLine = group.Add(new VocabularyKey(nameof(PrintLeadingZerosOnMICRLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AllowOtherCurrencies = group.Add(new VocabularyKey(nameof(AllowOtherCurrencies), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaperLength = group.Add(new VocabularyKey(nameof(PaperLength), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PaperLengthUnit = group.Add(new VocabularyKey(nameof(PaperLengthUnit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintFirstSignature = group.Add(new VocabularyKey(nameof(PrintFirstSignature), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FirstSignatureAmountLimit = group.Add(new VocabularyKey(nameof(FirstSignatureAmountLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintSecondSignature = group.Add(new VocabularyKey(nameof(PrintSecondSignature), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SecondSignatureAmountLimit = group.Add(new VocabularyKey(nameof(SecondSignatureAmountLimit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintACode = group.Add(new VocabularyKey(nameof(PrintACode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintBCode = group.Add(new VocabularyKey(nameof(PrintBCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintCCode = group.Add(new VocabularyKey(nameof(PrintCCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomChequeLayout = group.Add(new VocabularyKey(nameof(CustomChequeLayout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CustomChequeLayoutId = group.Add(new VocabularyKey(nameof(CustomChequeLayoutId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey BankAccountId { get; private set; }
        public VocabularyKey AmountPrefix { get; private set; }
        public VocabularyKey PrintBankAccount { get; private set; }
        public VocabularyKey CustomWatermark { get; private set; }
        public VocabularyKey PrintBankName { get; private set; }
        public VocabularyKey PrintBankNumber { get; private set; }
        public VocabularyKey ACode { get; private set; }
        public VocabularyKey BCode { get; private set; }
        public VocabularyKey CCode { get; private set; }
        public VocabularyKey DateFormat { get; private set; }
        public VocabularyKey DateSeparator { get; private set; }
        public VocabularyKey FormatType { get; private set; }
        public VocabularyKey CheckNumberMethod { get; private set; }
        public VocabularyKey StartPositionUnit { get; private set; }
        public VocabularyKey NumberOfSlipCopies { get; private set; }
        public VocabularyKey StartPosition { get; private set; }
        public VocabularyKey PrintCompanyLogo { get; private set; }
        public VocabularyKey PrintCompanyName { get; private set; }
        public VocabularyKey CopySignatureType { get; private set; }
        public VocabularyKey CopyWatermarkType { get; private set; }
        public VocabularyKey FooterText { get; private set; }
        public VocabularyKey HeaderText { get; private set; }
        public VocabularyKey PrintMICRLine { get; private set; }
        public VocabularyKey MICRLine { get; private set; }
        public VocabularyKey CheckNumberLength { get; private set; }
        public VocabularyKey PrintLeadingZerosOnMICRLine { get; private set; }
        public VocabularyKey AllowOtherCurrencies { get; private set; }
        public VocabularyKey PaperLength { get; private set; }
        public VocabularyKey PaperLengthUnit { get; private set; }
        public VocabularyKey PrintFirstSignature { get; private set; }
        public VocabularyKey FirstSignatureAmountLimit { get; private set; }
        public VocabularyKey PrintSecondSignature { get; private set; }
        public VocabularyKey SecondSignatureAmountLimit { get; private set; }
        public VocabularyKey PrintACode { get; private set; }
        public VocabularyKey PrintBCode { get; private set; }
        public VocabularyKey PrintCCode { get; private set; }
        public VocabularyKey CustomChequeLayout { get; private set; }
        public VocabularyKey CustomChequeLayoutId { get; private set; }
    }
}