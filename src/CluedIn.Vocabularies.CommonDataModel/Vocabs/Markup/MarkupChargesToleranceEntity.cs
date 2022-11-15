using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MarkupChargesToleranceEntityVocabulary : SimpleVocabulary
    {
        public MarkupChargesToleranceEntityVocabulary()
        {
            VocabularyName = "Markup Charges Tolerance Entity";
            KeyPrefix = "commonDataModel.markupchargestoleranceentity";
            KeySeparator = ".";
            Grouping = "/MarkupChargesToleranceEntity";

            AddGroup("MarkupChargesToleranceEntity Details", group =>
            {
                ChargesCode = group.Add(new VocabularyKey(nameof(ChargesCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ModuleType = group.Add(new VocabularyKey(nameof(ModuleType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ChargesTolerancePercentage = group.Add(new VocabularyKey(nameof(ChargesTolerancePercentage), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatInvoiceValue = group.Add(new VocabularyKey(nameof(IntrastatInvoiceValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IntrastatStatisticalValue = group.Add(new VocabularyKey(nameof(IntrastatStatisticalValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                IsLetterofCreditEnabled = group.Add(new VocabularyKey(nameof(IsLetterofCreditEnabled), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey ChargesCode { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey ModuleType { get; private set; }
        public VocabularyKey ChargesTolerancePercentage { get; private set; }
        public VocabularyKey IntrastatInvoiceValue { get; private set; }
        public VocabularyKey IntrastatStatisticalValue { get; private set; }
        public VocabularyKey IsLetterofCreditEnabled { get; private set; }
    }
}