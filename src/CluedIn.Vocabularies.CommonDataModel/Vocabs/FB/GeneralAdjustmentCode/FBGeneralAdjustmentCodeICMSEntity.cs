using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FBGeneralAdjustmentCodeICMSEntityVocabulary : SimpleVocabulary
    {
        public FBGeneralAdjustmentCodeICMSEntityVocabulary()
        {
            VocabularyName = "Common Data Model FBGeneralAdjustmentCodeICMSEntity";
            KeyPrefix = "commonDataModel.fbgeneraladjustmentcodeicmsentity";
            KeySeparator = ".";
            Grouping = "/FBGeneralAdjustmentCodeICMSEntity";

            AddGroup("Common Data Model FBGeneralAdjustmentCodeICMSEntity Details", group =>
            {
                Identification = group.Add(new VocabularyKey(nameof(Identification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TaxType = group.Add(new VocabularyKey(nameof(TaxType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ICMSType = group.Add(new VocabularyKey(nameof(ICMSType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Classification = group.Add(new VocabularyKey(nameof(Classification), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OccurrenceCode = group.Add(new VocabularyKey(nameof(OccurrenceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                SpedAdjustmentCode = group.Add(new VocabularyKey(nameof(SpedAdjustmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GIAAdjustmentCode = group.Add(new VocabularyKey(nameof(GIAAdjustmentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidFromDate = group.Add(new VocabularyKey(nameof(ValidFromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                OtherDebit = group.Add(new VocabularyKey(nameof(OtherDebit), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ReceitaCode = group.Add(new VocabularyKey(nameof(ReceitaCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey Identification { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey State { get; private set; }
        public VocabularyKey TaxType { get; private set; }
        public VocabularyKey ICMSType { get; private set; }
        public VocabularyKey Classification { get; private set; }
        public VocabularyKey OccurrenceCode { get; private set; }
        public VocabularyKey SpedAdjustmentCode { get; private set; }
        public VocabularyKey GIAAdjustmentCode { get; private set; }
        public VocabularyKey ValidFromDate { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }
        public VocabularyKey OtherDebit { get; private set; }
        public VocabularyKey ReceitaCode { get; private set; }


    }
}