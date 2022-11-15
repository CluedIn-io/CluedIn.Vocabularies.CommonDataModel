using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PmfFormulaHeaderEntityVocabulary : SimpleVocabulary
    {
        public PmfFormulaHeaderEntityVocabulary()
        {
            VocabularyName = "Pmf Formula Header Entity";
            KeyPrefix = "commonDataModel.pmfformulaheaderentity";
            KeySeparator = ".";
            Grouping = "/PmfFormulaHeaderEntity";

            AddGroup("PmfFormulaHeaderEntity Details", group =>
            {
                IsApproved = group.Add(new VocabularyKey(nameof(IsApproved), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverId = group.Add(new VocabularyKey(nameof(ApproverId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaId = group.Add(new VocabularyKey(nameof(FormulaId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductGroupId = group.Add(new VocabularyKey(nameof(ProductGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                FormulaName = group.Add(new VocabularyKey(nameof(FormulaName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ProductionSiteId = group.Add(new VocabularyKey(nameof(ProductionSiteId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                ApproverPersonnelNumber = group.Add(new VocabularyKey(nameof(ApproverPersonnelNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey IsApproved { get; private set; }
        public VocabularyKey ApproverId { get; private set; }
        public VocabularyKey FormulaId { get; private set; }
        public VocabularyKey ProductGroupId { get; private set; }
        public VocabularyKey FormulaName { get; private set; }
        public VocabularyKey ProductionSiteId { get; private set; }
        public VocabularyKey ApproverPersonnelNumber { get; private set; }
    }
}