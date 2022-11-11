using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerBalanceSheetDefinitionEntityVocabulary : SimpleVocabulary
    {
        public LedgerBalanceSheetDefinitionEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerBalanceSheetDefinitionEntity";
            KeyPrefix = "commonDataModel.ledgerbalancesheetdefinitionentity";
            KeySeparator = ".";
            Grouping = "/LedgerBalanceSheetDefinitionEntity";

            AddGroup("Common Data Model LedgerBalanceSheetDefinitionEntity Details", group =>
            {
                LineType = group.Add(new VocabularyKey(nameof(LineType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Line = group.Add(new VocabularyKey(nameof(Line), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mark = group.Add(new VocabularyKey(nameof(Mark), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingForm = group.Add(new VocabularyKey(nameof(RoundingForm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossInvertSign = group.Add(new VocabularyKey(nameof(GrossInvertSign), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossTotal = group.Add(new VocabularyKey(nameof(GrossTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossGroupOfAccounts = group.Add(new VocabularyKey(nameof(GrossGroupOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossMainAccount = group.Add(new VocabularyKey(nameof(GrossMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GrossLineId = group.Add(new VocabularyKey(nameof(GrossLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustmentInvertSign = group.Add(new VocabularyKey(nameof(AdjustmentInvertSign), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustmentTotal = group.Add(new VocabularyKey(nameof(AdjustmentTotal), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustmentGroupOfAccounts = group.Add(new VocabularyKey(nameof(AdjustmentGroupOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustmentMainAccount = group.Add(new VocabularyKey(nameof(AdjustmentMainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                AdjustmentLineId = group.Add(new VocabularyKey(nameof(AdjustmentLineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));

            });
        }

        public VocabularyKey LineType { get; private set; }
        public VocabularyKey Line { get; private set; }
        public VocabularyKey Mark { get; private set; }
        public VocabularyKey RoundingForm { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey GrossInvertSign { get; private set; }
        public VocabularyKey GrossTotal { get; private set; }
        public VocabularyKey GrossGroupOfAccounts { get; private set; }
        public VocabularyKey GrossMainAccount { get; private set; }
        public VocabularyKey GrossLineId { get; private set; }
        public VocabularyKey AdjustmentInvertSign { get; private set; }
        public VocabularyKey AdjustmentTotal { get; private set; }
        public VocabularyKey AdjustmentGroupOfAccounts { get; private set; }
        public VocabularyKey AdjustmentMainAccount { get; private set; }
        public VocabularyKey AdjustmentLineId { get; private set; }


    }
}