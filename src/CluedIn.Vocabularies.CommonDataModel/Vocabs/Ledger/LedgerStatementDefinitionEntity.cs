using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerStatementDefinitionEntityVocabulary : SimpleVocabulary
    {
        public LedgerStatementDefinitionEntityVocabulary()
        {
            VocabularyName = "Ledger Statement Definition Entity";
            KeyPrefix = "commonDataModel.ledgerstatementdefinitionentity";
            KeySeparator = ".";
            Grouping = "/LedgerStatementDefinitionEntity";

            AddGroup("LedgerStatementDefinitionEntity Details", group =>
            {
                Line = group.Add(new VocabularyKey(nameof(Line), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Mark = group.Add(new VocabularyKey(nameof(Mark), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                RoundingForm = group.Add(new VocabularyKey(nameof(RoundingForm), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Descritption = group.Add(new VocabularyKey(nameof(Descritption), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                InvertSign = group.Add(new VocabularyKey(nameof(InvertSign), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                Total = group.Add(new VocabularyKey(nameof(Total), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                GroupOfAccounts = group.Add(new VocabularyKey(nameof(GroupOfAccounts), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                MainAccount = group.Add(new VocabularyKey(nameof(MainAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
                LineId = group.Add(new VocabularyKey(nameof(LineId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));
            });
        }
        public VocabularyKey Line { get; private set; }
        public VocabularyKey Mark { get; private set; }
        public VocabularyKey RoundingForm { get; private set; }
        public VocabularyKey Descritption { get; private set; }
        public VocabularyKey InvertSign { get; private set; }
        public VocabularyKey Total { get; private set; }
        public VocabularyKey GroupOfAccounts { get; private set; }
        public VocabularyKey MainAccount { get; private set; }
        public VocabularyKey LineId { get; private set; }
    }
}