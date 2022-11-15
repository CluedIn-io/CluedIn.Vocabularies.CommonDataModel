using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class ProjProjectControlCostGroupEntityVocabulary : SimpleVocabulary
    {
        public ProjProjectControlCostGroupEntityVocabulary()
        {
            VocabularyName = "Proj Project Control Cost Group Entity";
            KeyPrefix = "commonDataModel.projprojectcontrolcostgroupentity";
            KeySeparator = ".";
            Grouping = "/ProjProjectControlCostGroupEntity";

            AddGroup("ProjProjectControlCostGroupEntity Details", group =>
            {
                MandatoryCostLine = group.Add(new VocabularyKey(nameof(MandatoryCostLine), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                PercentageOfCompletion = group.Add(new VocabularyKey(nameof(PercentageOfCompletion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostTemplateId = group.Add(new VocabularyKey(nameof(CostTemplateId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostLineId = group.Add(new VocabularyKey(nameof(CostLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                CostToCompleteMethod = group.Add(new VocabularyKey(nameof(CostToCompleteMethod), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey MandatoryCostLine { get; private set; }
        public VocabularyKey PercentageOfCompletion { get; private set; }
        public VocabularyKey CostTemplateId { get; private set; }
        public VocabularyKey CostLineId { get; private set; }
        public VocabularyKey TransactionType { get; private set; }
        public VocabularyKey CostToCompleteMethod { get; private set; }
        public VocabularyKey Name { get; private set; }
    }
}