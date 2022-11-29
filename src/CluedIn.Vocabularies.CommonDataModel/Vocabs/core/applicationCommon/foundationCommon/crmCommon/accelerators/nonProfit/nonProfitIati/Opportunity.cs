using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitIati
{
    public class OpportunityVocabulary : SimpleVocabulary
    {
        public OpportunityVocabulary()
        {
            VocabularyName = "Opportunity";
            KeyPrefix = "commonDataModel.opportunity.nonprofitiati";
            KeySeparator = ".";
            Grouping = "/Opportunity";

            AddGroup("Opportunity Details for NonProfitIati", group =>
            {
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    AskReadiness = group.Add(new VocabularyKey(nameof(AskReadiness), "Ask Readiness", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedGivingAmount = group.Add(new VocabularyKey(nameof(ExpectedGivingAmount), "Expected Giving Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    Expectedgivingamount_Base = group.Add(new VocabularyKey(nameof(Expectedgivingamount_Base), "Expected Giving Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ProspectiveGiftType = group.Add(new VocabularyKey(nameof(ProspectiveGiftType), "Prospective Gift Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SolicitationType = group.Add(new VocabularyKey(nameof(SolicitationType), "Solicitation Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SourceCode = group.Add(new VocabularyKey(nameof(SourceCode), "Source Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey AskReadiness { get; private set; }
        public VocabularyKey ExpectedGivingAmount { get; private set; }
        public VocabularyKey Expectedgivingamount_Base { get; private set; }
        public VocabularyKey ProspectiveGiftType { get; private set; }
        public VocabularyKey SolicitationType { get; private set; }
        public VocabularyKey SourceCode { get; private set; }
    }
}