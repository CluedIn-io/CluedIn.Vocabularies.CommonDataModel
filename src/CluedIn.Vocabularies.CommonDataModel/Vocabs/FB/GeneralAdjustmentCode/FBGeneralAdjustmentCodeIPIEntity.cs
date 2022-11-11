using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FBGeneralAdjustmentCodeIPIEntityVocabulary : SimpleVocabulary
    {
        public FBGeneralAdjustmentCodeIPIEntityVocabulary()
        {
            VocabularyName = "Common Data Model FBGeneralAdjustmentCodeIPIEntity";
            KeyPrefix = "commonDataModel.fbgeneraladjustmentcodeipientity";
            KeySeparator = ".";
            Grouping = "/FBGeneralAdjustmentCodeIPIEntity";

            AddGroup("Common Data Model FBGeneralAdjustmentCodeIPIEntity Details", group =>
            {
                AdjustmentCode = group.Add(new VocabularyKey(nameof(AdjustmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsReversal = group.Add(new VocabularyKey(nameof(IsReversal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsTaxRefund = group.Add(new VocabularyKey(nameof(IsTaxRefund), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OtherDebit = group.Add(new VocabularyKey(nameof(OtherDebit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceitaCode = group.Add(new VocabularyKey(nameof(ReceitaCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey AdjustmentCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey IsReversal { get; private set; }
        public VocabularyKey IsTaxRefund { get; private set; }
        public VocabularyKey ValidFromDate { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }
        public VocabularyKey OtherDebit { get; private set; }
        public VocabularyKey ReceitaCode { get; private set; }


    }
}