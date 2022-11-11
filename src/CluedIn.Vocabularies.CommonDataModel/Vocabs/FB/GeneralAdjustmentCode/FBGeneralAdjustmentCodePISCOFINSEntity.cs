using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FBGeneralAdjustmentCodePISCOFINSEntityVocabulary : SimpleVocabulary
    {
        public FBGeneralAdjustmentCodePISCOFINSEntityVocabulary()
        {
            VocabularyName = "FBGeneralAdjustmentCodePISCOFINSEntity";
            KeyPrefix = "commonDataModel.fbgeneraladjustmentcodepiscofinsentity";
            KeySeparator = ".";
            Grouping = "/FBGeneralAdjustmentCodePISCOFINSEntity";

            AddGroup("FBGeneralAdjustmentCodePISCOFINSEntity Details", group =>
            {
                Identification = group.Add(new VocabularyKey(nameof(Identification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustmentType = group.Add(new VocabularyKey(nameof(AdjustmentType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpedAdjustmentCode = group.Add(new VocabularyKey(nameof(SpedAdjustmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransferEvent = group.Add(new VocabularyKey(nameof(TransferEvent), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OtherDebit = group.Add(new VocabularyKey(nameof(OtherDebit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceitaCode = group.Add(new VocabularyKey(nameof(ReceitaCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Identification { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey AdjustmentType { get; private set; }
        public VocabularyKey SpedAdjustmentCode { get; private set; }
        public VocabularyKey TransferEvent { get; private set; }
        public VocabularyKey ValidFromDate { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }
        public VocabularyKey OtherDebit { get; private set; }
        public VocabularyKey ReceitaCode { get; private set; }


    }
}