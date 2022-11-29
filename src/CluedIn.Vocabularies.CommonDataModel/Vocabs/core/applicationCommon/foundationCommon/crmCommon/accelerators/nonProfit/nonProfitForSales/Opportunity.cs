using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class OpportunityVocabulary : SimpleVocabulary
    {
        public OpportunityVocabulary()
        {
            VocabularyName = "Opportunity";
            KeyPrefix = "commonDataModel.opportunity.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/Opportunity";

            AddGroup("Opportunity Details for NonProfitForSales", group =>
            {
			    AskReadiness = group.Add(new VocabularyKey(nameof(AskReadiness), "Ask Readiness", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExpectedGivingAmount = group.Add(new VocabularyKey(nameof(ExpectedGivingAmount), "Expected Giving Amount", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ExpectedGivingAmount_Base = group.Add(new VocabularyKey(nameof(ExpectedGivingAmount_Base), "Expected Giving Amount (Base)", VocabularyKeyDataType.Currency, VocabularyKeyVisibility.Visible)); 
			    ProspectiveGiftType = group.Add(new VocabularyKey(nameof(ProspectiveGiftType), "Prospective Gift Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SolicitationType = group.Add(new VocabularyKey(nameof(SolicitationType), "Solicitation Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    SourceCode = group.Add(new VocabularyKey(nameof(SourceCode), "Source Code", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey AskReadiness { get; private set; }
        public VocabularyKey ExpectedGivingAmount { get; private set; }
        public VocabularyKey ExpectedGivingAmount_Base { get; private set; }
        public VocabularyKey ProspectiveGiftType { get; private set; }
        public VocabularyKey SolicitationType { get; private set; }
        public VocabularyKey SourceCode { get; private set; }
    }
}