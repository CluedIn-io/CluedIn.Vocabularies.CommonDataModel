using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class BenefitRecipientVocabulary : SimpleVocabulary
    {
        public BenefitRecipientVocabulary()
        {
            VocabularyName = "Benefit Recipient";
            KeyPrefix = "commonDataModel.benefitrecipient.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/BenefitRecipient";

            AddGroup("BenefitRecipient Details for NonProfitCore", group =>
            {
			    BenefitRecipientId = group.Add(new VocabularyKey(nameof(BenefitRecipientId), "Benefit Recipient", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    BenefitRecipientType = group.Add(new VocabularyKey(nameof(BenefitRecipientType), "Benefit Recipient Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Description = group.Add(new VocabularyKey(nameof(Description), "Description", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey BenefitRecipientId { get; private set; }
        public VocabularyKey BenefitRecipientType { get; private set; }
        public VocabularyKey Description { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}