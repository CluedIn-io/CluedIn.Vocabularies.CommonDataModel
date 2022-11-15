using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectControlEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectControlEntityVocabulary()
        {
            VocabularyName = "Proj Project Control Entity";
            KeyPrefix = "commonDataModel.projprojectcontrolentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectControlEntity";

            AddGroup("ProjProjectControlEntity Details", group =>
            {
                CompletionBasedOn = group.Add(new VocabularyKey(nameof(CompletionBasedOn), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CompletionMethod = group.Add(new VocabularyKey(nameof(CompletionMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostTemplateId = group.Add(new VocabularyKey(nameof(CostTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ExpenseCostLineId = group.Add(new VocabularyKey(nameof(ExpenseCostLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                HourCostLineId = group.Add(new VocabularyKey(nameof(HourCostLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ItemCostLineId = group.Add(new VocabularyKey(nameof(ItemCostLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey CompletionBasedOn { get; private set; }
        public VocabularyKey CompletionMethod { get; private set; }
        public VocabularyKey CostTemplateId { get; private set; }
        public VocabularyKey ExpenseCostLineId { get; private set; }
        public VocabularyKey HourCostLineId { get; private set; }
        public VocabularyKey ItemCostLineId { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}