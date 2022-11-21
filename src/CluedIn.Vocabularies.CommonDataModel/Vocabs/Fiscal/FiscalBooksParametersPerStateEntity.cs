using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalBooksParametersPerStateEntityVocabulary : SimpleVocabulary
    {
        public FiscalBooksParametersPerStateEntityVocabulary()
        {
            VocabularyName = "Fiscal Books Parameters Per State Entity";
            KeyPrefix = "commonDataModel.fiscalbooksparametersperstateentity";
            KeySeparator = ".";
            Grouping = "/FiscalBooksParametersPerStateEntity";

            AddGroup("FiscalBooksParametersPerStateEntity Details", group =>
            {
                CIAPCalculateInstallmentForOutgoing = group.Add(new VocabularyKey(nameof(CIAPCalculateInstallmentForOutgoing), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ByFiscalDocument = group.Add(new VocabularyKey(nameof(ByFiscalDocument), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ICMSObservationCode = group.Add(new VocabularyKey(nameof(ICMSObservationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ICMSFiscalDocumentAdjustmentCodeFixedAsset = group.Add(new VocabularyKey(nameof(ICMSFiscalDocumentAdjustmentCodeFixedAsset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ICMSFiscalDocumentAdjustmentCode = group.Add(new VocabularyKey(nameof(ICMSFiscalDocumentAdjustmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ICMSGeneralAdjustmentCode = group.Add(new VocabularyKey(nameof(ICMSGeneralAdjustmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ICMSGeneralAdjustmentCodeFixedAsset = group.Add(new VocabularyKey(nameof(ICMSGeneralAdjustmentCodeFixedAsset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentAdjustmentCode = group.Add(new VocabularyKey(nameof(FiscalDocumentAdjustmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralAdjustmentCode = group.Add(new VocabularyKey(nameof(GeneralAdjustmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ObservationCode = group.Add(new VocabularyKey(nameof(ObservationCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FiscalDocumentAdjustmentCodeFixedAsset = group.Add(new VocabularyKey(nameof(FiscalDocumentAdjustmentCodeFixedAsset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GeneralAdjustmentCodeFixedAsset = group.Add(new VocabularyKey(nameof(GeneralAdjustmentCodeFixedAsset), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CIAPCalculateInstallmentForOutgoing { get; private set; }
        public VocabularyKey ByFiscalDocument { get; private set; }
        public VocabularyKey ICMSObservationCode { get; private set; }
        public VocabularyKey ICMSFiscalDocumentAdjustmentCodeFixedAsset { get; private set; }
        public VocabularyKey ICMSFiscalDocumentAdjustmentCode { get; private set; }
        public VocabularyKey ICMSGeneralAdjustmentCode { get; private set; }
        public VocabularyKey ICMSGeneralAdjustmentCodeFixedAsset { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey FiscalDocumentAdjustmentCode { get; private set; }
        public VocabularyKey GeneralAdjustmentCode { get; private set; }
        public VocabularyKey ObservationCode { get; private set; }
        public VocabularyKey FiscalDocumentAdjustmentCodeFixedAsset { get; private set; }
        public VocabularyKey GeneralAdjustmentCodeFixedAsset { get; private set; }
    }
}