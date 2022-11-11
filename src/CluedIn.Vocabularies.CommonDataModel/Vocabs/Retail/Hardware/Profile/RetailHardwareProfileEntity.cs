using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RetailHardwareProfileEntityVocabulary : SimpleVocabulary
    {
        public RetailHardwareProfileEntityVocabulary()
        {
            VocabularyName = "RetailHardwareProfileEntity";
            KeyPrefix = "commonDataModel.retailhardwareprofileentity";
            KeySeparator = ".";
            Grouping = "/RetailHardwareProfileEntity";

            AddGroup("RetailHardwareProfileEntity Details", group =>
            {
                CaptureExtraData = group.Add(new VocabularyKey(nameof(CaptureExtraData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashChanger = group.Add(new VocabularyKey(nameof(CashChanger), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashChangerInitialSettings = group.Add(new VocabularyKey(nameof(CashChangerInitialSettings), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CashChangerPortSettings = group.Add(new VocabularyKey(nameof(CashChangerPortSettings), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClosedCaptionTelevision = group.Add(new VocabularyKey(nameof(ClosedCaptionTelevision), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClosedCaptionTelevisionCamera = group.Add(new VocabularyKey(nameof(ClosedCaptionTelevisionCamera), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClosedCaptionTelevisionHostName = group.Add(new VocabularyKey(nameof(ClosedCaptionTelevisionHostName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ClosedCaptionTelevisionPort = group.Add(new VocabularyKey(nameof(ClosedCaptionTelevisionPort), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DelayForLinkedItems = group.Add(new VocabularyKey(nameof(DelayForLinkedItems), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeviceDescription = group.Add(new VocabularyKey(nameof(DeviceDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DeviceName = group.Add(new VocabularyKey(nameof(DeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayBalanceText = group.Add(new VocabularyKey(nameof(DisplayBalanceText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayBinaryConversion = group.Add(new VocabularyKey(nameof(DisplayBinaryConversion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayCharacterSet = group.Add(new VocabularyKey(nameof(DisplayCharacterSet), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayClosedLine1 = group.Add(new VocabularyKey(nameof(DisplayClosedLine1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayClosedLine2 = group.Add(new VocabularyKey(nameof(DisplayClosedLine2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayDescription = group.Add(new VocabularyKey(nameof(DisplayDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayDevice = group.Add(new VocabularyKey(nameof(DisplayDevice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayDeviceName = group.Add(new VocabularyKey(nameof(DisplayDeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayLinkedItem = group.Add(new VocabularyKey(nameof(DisplayLinkedItem), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayTerminalClosed = group.Add(new VocabularyKey(nameof(DisplayTerminalClosed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DisplayTotalText = group.Add(new VocabularyKey(nameof(DisplayTotalText), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer1DocumentInsertRemovalTimeout = group.Add(new VocabularyKey(nameof(Printer1DocumentInsertRemovalTimeout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer1 = group.Add(new VocabularyKey(nameof(Drawer1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer2 = group.Add(new VocabularyKey(nameof(Drawer2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer2Description = group.Add(new VocabularyKey(nameof(Drawer2Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer2DeviceName = group.Add(new VocabularyKey(nameof(Drawer2DeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer2Make = group.Add(new VocabularyKey(nameof(Drawer2Make), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer2Model = group.Add(new VocabularyKey(nameof(Drawer2Model), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer1Description = group.Add(new VocabularyKey(nameof(Drawer1Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer1DeviceName = group.Add(new VocabularyKey(nameof(Drawer1DeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer1Make = group.Add(new VocabularyKey(nameof(Drawer1Make), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer1Model = group.Add(new VocabularyKey(nameof(Drawer1Model), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DualDisplay = group.Add(new VocabularyKey(nameof(DualDisplay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DualDisplayBrowserUrl = group.Add(new VocabularyKey(nameof(DualDisplayBrowserUrl), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DualDisplayImageInterval = group.Add(new VocabularyKey(nameof(DualDisplayImageInterval), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DualDisplayImagePath = group.Add(new VocabularyKey(nameof(DualDisplayImagePath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DualDisplayReceiptPercentage = group.Add(new VocabularyKey(nameof(DualDisplayReceiptPercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                DualDisplayType = group.Add(new VocabularyKey(nameof(DualDisplayType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransfer = group.Add(new VocabularyKey(nameof(ElectronicFundsTransfer), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransferCompanyId = group.Add(new VocabularyKey(nameof(ElectronicFundsTransferCompanyId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransferConfiguration = group.Add(new VocabularyKey(nameof(ElectronicFundsTransferConfiguration), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransferConnectorName = group.Add(new VocabularyKey(nameof(ElectronicFundsTransferConnectorName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransferConnectorProperties = group.Add(new VocabularyKey(nameof(ElectronicFundsTransferConnectorProperties), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransferData = group.Add(new VocabularyKey(nameof(ElectronicFundsTransferData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransferDescription = group.Add(new VocabularyKey(nameof(ElectronicFundsTransferDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransferMerchantId = group.Add(new VocabularyKey(nameof(ElectronicFundsTransferMerchantId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransferPassword = group.Add(new VocabularyKey(nameof(ElectronicFundsTransferPassword), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransferServerName = group.Add(new VocabularyKey(nameof(ElectronicFundsTransferServerName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransferServerPort = group.Add(new VocabularyKey(nameof(ElectronicFundsTransferServerPort), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransferUserId = group.Add(new VocabularyKey(nameof(ElectronicFundsTransferUserId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticStripeReaderEndTrack1Sentinel = group.Add(new VocabularyKey(nameof(MagneticStripeReaderEndTrack1Sentinel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticStripeReaderEndTrack2Sentinel = group.Add(new VocabularyKey(nameof(MagneticStripeReaderEndTrack2Sentinel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalPrinter = group.Add(new VocabularyKey(nameof(FiscalPrinter), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalPrinterDescription = group.Add(new VocabularyKey(nameof(FiscalPrinterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalPrinterDeviceName = group.Add(new VocabularyKey(nameof(FiscalPrinterDeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormXPosition = group.Add(new VocabularyKey(nameof(FormXPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormYPosition = group.Add(new VocabularyKey(nameof(FormYPosition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HardTotal = group.Add(new VocabularyKey(nameof(HardTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HardTotalDescription = group.Add(new VocabularyKey(nameof(HardTotalDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HardTotalDeviceName = group.Add(new VocabularyKey(nameof(HardTotalDeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ImagePath = group.Add(new VocabularyKey(nameof(ImagePath), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeyboardMappingId = group.Add(new VocabularyKey(nameof(KeyboardMappingId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Keylock = group.Add(new VocabularyKey(nameof(Keylock), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeylockDescription = group.Add(new VocabularyKey(nameof(KeylockDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                KeylockDeviceName = group.Add(new VocabularyKey(nameof(KeylockDeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Logo = group.Add(new VocabularyKey(nameof(Logo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogoAlignment = group.Add(new VocabularyKey(nameof(LogoAlignment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LogoBitmap = group.Add(new VocabularyKey(nameof(LogoBitmap), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsManualInputAllowed = group.Add(new VocabularyKey(nameof(IsManualInputAllowed), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MaxInvoiceLines = group.Add(new VocabularyKey(nameof(MaxInvoiceLines), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticInkCharacterRecognition = group.Add(new VocabularyKey(nameof(MagneticInkCharacterRecognition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticInkCharacterRecognitionDescription = group.Add(new VocabularyKey(nameof(MagneticInkCharacterRecognitionDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticInkCharacterRecognitionDriverName = group.Add(new VocabularyKey(nameof(MagneticInkCharacterRecognitionDriverName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticStripeReader = group.Add(new VocabularyKey(nameof(MagneticStripeReader), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticStripeReaderDescription = group.Add(new VocabularyKey(nameof(MagneticStripeReaderDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticStripeReaderDeviceName = group.Add(new VocabularyKey(nameof(MagneticStripeReaderDeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticStripeReaderMake = group.Add(new VocabularyKey(nameof(MagneticStripeReaderMake), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticStripeReaderModel = group.Add(new VocabularyKey(nameof(MagneticStripeReaderModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Pharmacy = group.Add(new VocabularyKey(nameof(Pharmacy), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PharmacyHost = group.Add(new VocabularyKey(nameof(PharmacyHost), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PharmacyPort = group.Add(new VocabularyKey(nameof(PharmacyPort), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PinPad = group.Add(new VocabularyKey(nameof(PinPad), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PinPadDescription = group.Add(new VocabularyKey(nameof(PinPadDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PinPadDeviceName = group.Add(new VocabularyKey(nameof(PinPadDeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PinPadMake = group.Add(new VocabularyKey(nameof(PinPadMake), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PinPadModel = group.Add(new VocabularyKey(nameof(PinPadModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PrintBinaryConversion = group.Add(new VocabularyKey(nameof(PrintBinaryConversion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer1 = group.Add(new VocabularyKey(nameof(Printer1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer2 = group.Add(new VocabularyKey(nameof(Printer2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer2BinaryConversion = group.Add(new VocabularyKey(nameof(Printer2BinaryConversion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer2Characterset = group.Add(new VocabularyKey(nameof(Printer2Characterset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer2Description = group.Add(new VocabularyKey(nameof(Printer2Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer2DeviceName = group.Add(new VocabularyKey(nameof(Printer2DeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer2DocumentInsertRemovalTimeout = group.Add(new VocabularyKey(nameof(Printer2DocumentInsertRemovalTimeout), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer2Logo = group.Add(new VocabularyKey(nameof(Printer2Logo), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer2LogoAlignment = group.Add(new VocabularyKey(nameof(Printer2LogoAlignment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer2LogoBitmap = group.Add(new VocabularyKey(nameof(Printer2LogoBitmap), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer2Make = group.Add(new VocabularyKey(nameof(Printer2Make), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer2Model = group.Add(new VocabularyKey(nameof(Printer2Model), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer2ReceiptProfileId = group.Add(new VocabularyKey(nameof(Printer2ReceiptProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer1Characterset = group.Add(new VocabularyKey(nameof(Printer1Characterset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer1Description = group.Add(new VocabularyKey(nameof(Printer1Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer1DeviceName = group.Add(new VocabularyKey(nameof(Printer1DeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer1Make = group.Add(new VocabularyKey(nameof(Printer1Make), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer1Model = group.Add(new VocabularyKey(nameof(Printer1Model), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Printer1ReceiptProfileId = group.Add(new VocabularyKey(nameof(Printer1ReceiptProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileId = group.Add(new VocabularyKey(nameof(ProfileId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProfileVersion = group.Add(new VocabularyKey(nameof(ProfileVersion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RadioFrequencyIdDescription = group.Add(new VocabularyKey(nameof(RadioFrequencyIdDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RadioFrequencyIdDeviceName = group.Add(new VocabularyKey(nameof(RadioFrequencyIdDeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RadioFrequencyIdScannerType = group.Add(new VocabularyKey(nameof(RadioFrequencyIdScannerType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scale = group.Add(new VocabularyKey(nameof(Scale), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScaleDescription = group.Add(new VocabularyKey(nameof(ScaleDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScaleDeviceName = group.Add(new VocabularyKey(nameof(ScaleDeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scanner1 = group.Add(new VocabularyKey(nameof(Scanner1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scanner2 = group.Add(new VocabularyKey(nameof(Scanner2), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scanner2Description = group.Add(new VocabularyKey(nameof(Scanner2Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scanner2DeviceName = group.Add(new VocabularyKey(nameof(Scanner2DeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scanner1Description = group.Add(new VocabularyKey(nameof(Scanner1Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scanner1DeviceName = group.Add(new VocabularyKey(nameof(Scanner1DeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ScreenKeyboard = group.Add(new VocabularyKey(nameof(ScreenKeyboard), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticStripeReaderSeparator1 = group.Add(new VocabularyKey(nameof(MagneticStripeReaderSeparator1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ShowPicture = group.Add(new VocabularyKey(nameof(ShowPicture), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SignatureCapture = group.Add(new VocabularyKey(nameof(SignatureCapture), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SignatureCaptureDescription = group.Add(new VocabularyKey(nameof(SignatureCaptureDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SignatureCaptureDeviceName = group.Add(new VocabularyKey(nameof(SignatureCaptureDeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SignatureCaptureFormName = group.Add(new VocabularyKey(nameof(SignatureCaptureFormName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SignatureCaptureMake = group.Add(new VocabularyKey(nameof(SignatureCaptureMake), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SignatureCaptureModel = group.Add(new VocabularyKey(nameof(SignatureCaptureModel), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticStripeReaderStartTrack1 = group.Add(new VocabularyKey(nameof(MagneticStripeReaderStartTrack1), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MagneticStripeReaderStartTrack2After = group.Add(new VocabularyKey(nameof(MagneticStripeReaderStartTrack2After), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TimeoutInSec = group.Add(new VocabularyKey(nameof(TimeoutInSec), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseElectronicFundsTransferService = group.Add(new VocabularyKey(nameof(UseElectronicFundsTransferService), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                UseExternalPaymentsDevice = group.Add(new VocabularyKey(nameof(UseExternalPaymentsDevice), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer2DevicePool = group.Add(new VocabularyKey(nameof(Drawer2DevicePool), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer2UseCashDrawerPool = group.Add(new VocabularyKey(nameof(Drawer2UseCashDrawerPool), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer1DevicePool = group.Add(new VocabularyKey(nameof(Drawer1DevicePool), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Drawer1UseCashDrawerPool = group.Add(new VocabularyKey(nameof(Drawer1UseCashDrawerPool), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ElectronicFundsTransferMaximumCardPayments = group.Add(new VocabularyKey(nameof(ElectronicFundsTransferMaximumCardPayments), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalPrinterConfigId = group.Add(new VocabularyKey(nameof(FiscalPrinterConfigId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalRegister = group.Add(new VocabularyKey(nameof(FiscalRegister), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalRegisterConfigId = group.Add(new VocabularyKey(nameof(FiscalRegisterConfigId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalRegisterDescription = group.Add(new VocabularyKey(nameof(FiscalRegisterDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalRegisterDeviceName = group.Add(new VocabularyKey(nameof(FiscalRegisterDeviceName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scanner2DecodeScanData = group.Add(new VocabularyKey(nameof(Scanner2DecodeScanData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Scanner1DecodeScanData = group.Add(new VocabularyKey(nameof(Scanner1DecodeScanData), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MergedSelfServicePackageReference = group.Add(new VocabularyKey(nameof(MergedSelfServicePackageReference), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey CaptureExtraData { get; private set; }
        public VocabularyKey CashChanger { get; private set; }
        public VocabularyKey CashChangerInitialSettings { get; private set; }
        public VocabularyKey CashChangerPortSettings { get; private set; }
        public VocabularyKey ClosedCaptionTelevision { get; private set; }
        public VocabularyKey ClosedCaptionTelevisionCamera { get; private set; }
        public VocabularyKey ClosedCaptionTelevisionHostName { get; private set; }
        public VocabularyKey ClosedCaptionTelevisionPort { get; private set; }
        public VocabularyKey DelayForLinkedItems { get; private set; }
        public VocabularyKey DeviceDescription { get; private set; }
        public VocabularyKey DeviceName { get; private set; }
        public VocabularyKey DisplayBalanceText { get; private set; }
        public VocabularyKey DisplayBinaryConversion { get; private set; }
        public VocabularyKey DisplayCharacterSet { get; private set; }
        public VocabularyKey DisplayClosedLine1 { get; private set; }
        public VocabularyKey DisplayClosedLine2 { get; private set; }
        public VocabularyKey DisplayDescription { get; private set; }
        public VocabularyKey DisplayDevice { get; private set; }
        public VocabularyKey DisplayDeviceName { get; private set; }
        public VocabularyKey DisplayLinkedItem { get; private set; }
        public VocabularyKey DisplayTerminalClosed { get; private set; }
        public VocabularyKey DisplayTotalText { get; private set; }
        public VocabularyKey Printer1DocumentInsertRemovalTimeout { get; private set; }
        public VocabularyKey Drawer1 { get; private set; }
        public VocabularyKey Drawer2 { get; private set; }
        public VocabularyKey Drawer2Description { get; private set; }
        public VocabularyKey Drawer2DeviceName { get; private set; }
        public VocabularyKey Drawer2Make { get; private set; }
        public VocabularyKey Drawer2Model { get; private set; }
        public VocabularyKey Drawer1Description { get; private set; }
        public VocabularyKey Drawer1DeviceName { get; private set; }
        public VocabularyKey Drawer1Make { get; private set; }
        public VocabularyKey Drawer1Model { get; private set; }
        public VocabularyKey DualDisplay { get; private set; }
        public VocabularyKey DualDisplayBrowserUrl { get; private set; }
        public VocabularyKey DualDisplayImageInterval { get; private set; }
        public VocabularyKey DualDisplayImagePath { get; private set; }
        public VocabularyKey DualDisplayReceiptPercentage { get; private set; }
        public VocabularyKey DualDisplayType { get; private set; }
        public VocabularyKey ElectronicFundsTransfer { get; private set; }
        public VocabularyKey ElectronicFundsTransferCompanyId { get; private set; }
        public VocabularyKey ElectronicFundsTransferConfiguration { get; private set; }
        public VocabularyKey ElectronicFundsTransferConnectorName { get; private set; }
        public VocabularyKey ElectronicFundsTransferConnectorProperties { get; private set; }
        public VocabularyKey ElectronicFundsTransferData { get; private set; }
        public VocabularyKey ElectronicFundsTransferDescription { get; private set; }
        public VocabularyKey ElectronicFundsTransferMerchantId { get; private set; }
        public VocabularyKey ElectronicFundsTransferPassword { get; private set; }
        public VocabularyKey ElectronicFundsTransferServerName { get; private set; }
        public VocabularyKey ElectronicFundsTransferServerPort { get; private set; }
        public VocabularyKey ElectronicFundsTransferUserId { get; private set; }
        public VocabularyKey MagneticStripeReaderEndTrack1Sentinel { get; private set; }
        public VocabularyKey MagneticStripeReaderEndTrack2Sentinel { get; private set; }
        public VocabularyKey FiscalPrinter { get; private set; }
        public VocabularyKey FiscalPrinterDescription { get; private set; }
        public VocabularyKey FiscalPrinterDeviceName { get; private set; }
        public VocabularyKey FormXPosition { get; private set; }
        public VocabularyKey FormYPosition { get; private set; }
        public VocabularyKey HardTotal { get; private set; }
        public VocabularyKey HardTotalDescription { get; private set; }
        public VocabularyKey HardTotalDeviceName { get; private set; }
        public VocabularyKey ImagePath { get; private set; }
        public VocabularyKey KeyboardMappingId { get; private set; }
        public VocabularyKey Keylock { get; private set; }
        public VocabularyKey KeylockDescription { get; private set; }
        public VocabularyKey KeylockDeviceName { get; private set; }
        public VocabularyKey Logo { get; private set; }
        public VocabularyKey LogoAlignment { get; private set; }
        public VocabularyKey LogoBitmap { get; private set; }
        public VocabularyKey IsManualInputAllowed { get; private set; }
        public VocabularyKey MaxInvoiceLines { get; private set; }
        public VocabularyKey MagneticInkCharacterRecognition { get; private set; }
        public VocabularyKey MagneticInkCharacterRecognitionDescription { get; private set; }
        public VocabularyKey MagneticInkCharacterRecognitionDriverName { get; private set; }
        public VocabularyKey MagneticStripeReader { get; private set; }
        public VocabularyKey MagneticStripeReaderDescription { get; private set; }
        public VocabularyKey MagneticStripeReaderDeviceName { get; private set; }
        public VocabularyKey MagneticStripeReaderMake { get; private set; }
        public VocabularyKey MagneticStripeReaderModel { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey Pharmacy { get; private set; }
        public VocabularyKey PharmacyHost { get; private set; }
        public VocabularyKey PharmacyPort { get; private set; }
        public VocabularyKey PinPad { get; private set; }
        public VocabularyKey PinPadDescription { get; private set; }
        public VocabularyKey PinPadDeviceName { get; private set; }
        public VocabularyKey PinPadMake { get; private set; }
        public VocabularyKey PinPadModel { get; private set; }
        public VocabularyKey PrintBinaryConversion { get; private set; }
        public VocabularyKey Printer1 { get; private set; }
        public VocabularyKey Printer2 { get; private set; }
        public VocabularyKey Printer2BinaryConversion { get; private set; }
        public VocabularyKey Printer2Characterset { get; private set; }
        public VocabularyKey Printer2Description { get; private set; }
        public VocabularyKey Printer2DeviceName { get; private set; }
        public VocabularyKey Printer2DocumentInsertRemovalTimeout { get; private set; }
        public VocabularyKey Printer2Logo { get; private set; }
        public VocabularyKey Printer2LogoAlignment { get; private set; }
        public VocabularyKey Printer2LogoBitmap { get; private set; }
        public VocabularyKey Printer2Make { get; private set; }
        public VocabularyKey Printer2Model { get; private set; }
        public VocabularyKey Printer2ReceiptProfileId { get; private set; }
        public VocabularyKey Printer1Characterset { get; private set; }
        public VocabularyKey Printer1Description { get; private set; }
        public VocabularyKey Printer1DeviceName { get; private set; }
        public VocabularyKey Printer1Make { get; private set; }
        public VocabularyKey Printer1Model { get; private set; }
        public VocabularyKey Printer1ReceiptProfileId { get; private set; }
        public VocabularyKey ProfileId { get; private set; }
        public VocabularyKey ProfileVersion { get; private set; }
        public VocabularyKey RadioFrequencyIdDescription { get; private set; }
        public VocabularyKey RadioFrequencyIdDeviceName { get; private set; }
        public VocabularyKey RadioFrequencyIdScannerType { get; private set; }
        public VocabularyKey Scale { get; private set; }
        public VocabularyKey ScaleDescription { get; private set; }
        public VocabularyKey ScaleDeviceName { get; private set; }
        public VocabularyKey Scanner1 { get; private set; }
        public VocabularyKey Scanner2 { get; private set; }
        public VocabularyKey Scanner2Description { get; private set; }
        public VocabularyKey Scanner2DeviceName { get; private set; }
        public VocabularyKey Scanner1Description { get; private set; }
        public VocabularyKey Scanner1DeviceName { get; private set; }
        public VocabularyKey ScreenKeyboard { get; private set; }
        public VocabularyKey MagneticStripeReaderSeparator1 { get; private set; }
        public VocabularyKey ShowPicture { get; private set; }
        public VocabularyKey SignatureCapture { get; private set; }
        public VocabularyKey SignatureCaptureDescription { get; private set; }
        public VocabularyKey SignatureCaptureDeviceName { get; private set; }
        public VocabularyKey SignatureCaptureFormName { get; private set; }
        public VocabularyKey SignatureCaptureMake { get; private set; }
        public VocabularyKey SignatureCaptureModel { get; private set; }
        public VocabularyKey MagneticStripeReaderStartTrack1 { get; private set; }
        public VocabularyKey MagneticStripeReaderStartTrack2After { get; private set; }
        public VocabularyKey TimeoutInSec { get; private set; }
        public VocabularyKey UseElectronicFundsTransferService { get; private set; }
        public VocabularyKey UseExternalPaymentsDevice { get; private set; }
        public VocabularyKey Drawer2DevicePool { get; private set; }
        public VocabularyKey Drawer2UseCashDrawerPool { get; private set; }
        public VocabularyKey Drawer1DevicePool { get; private set; }
        public VocabularyKey Drawer1UseCashDrawerPool { get; private set; }
        public VocabularyKey ElectronicFundsTransferMaximumCardPayments { get; private set; }
        public VocabularyKey FiscalPrinterConfigId { get; private set; }
        public VocabularyKey FiscalRegister { get; private set; }
        public VocabularyKey FiscalRegisterConfigId { get; private set; }
        public VocabularyKey FiscalRegisterDescription { get; private set; }
        public VocabularyKey FiscalRegisterDeviceName { get; private set; }
        public VocabularyKey Scanner2DecodeScanData { get; private set; }
        public VocabularyKey Scanner1DecodeScanData { get; private set; }
        public VocabularyKey MergedSelfServicePackageReference { get; private set; }


    }
}