using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.Banking
{
    public class LeadVocabulary : SimpleVocabulary
    {
        public LeadVocabulary()
        {
            VocabularyName = "Lead";
            KeyPrefix = "commonDataModel.lead.banking";
            KeySeparator = ".";
            Grouping = "/Lead";

            AddGroup("Lead Details for Banking", group =>
            {
			    EntityImage = group.Add(new VocabularyKey(nameof(EntityImage), "Entity Image", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ExchangeRate = group.Add(new VocabularyKey(nameof(ExchangeRate), "Exchange Rate", VocabularyKeyDataType.Number, VocabularyKeyVisibility.Visible)); 
			    Employer = group.Add(new VocabularyKey(nameof(Employer), "Employer", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    IDNumber = group.Add(new VocabularyKey(nameof(IDNumber), "ID Number", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ProspectType = group.Add(new VocabularyKey(nameof(ProspectType), "Prospect Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey EntityImage { get; private set; }
        public VocabularyKey ExchangeRate { get; private set; }
        public VocabularyKey Employer { get; private set; }
        public VocabularyKey IDNumber { get; private set; }
        public VocabularyKey ProspectType { get; private set; }
    }
}