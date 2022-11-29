using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitCore
{
    public class CreditPlanVocabulary : SimpleVocabulary
    {
        public CreditPlanVocabulary()
        {
            VocabularyName = "Credit Plan";
            KeyPrefix = "commonDataModel.creditplan.nonprofitcore";
            KeySeparator = ".";
            Grouping = "/CreditPlan";

            AddGroup("CreditPlan Details for NonProfitCore", group =>
            {
			    CreditPlanId = group.Add(new VocabularyKey(nameof(CreditPlanId), "Credit Plan", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    CreditType = group.Add(new VocabularyKey(nameof(CreditType), "Credit Type", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    Name = group.Add(new VocabularyKey(nameof(Name), "Name", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    ValidToDate = group.Add(new VocabularyKey(nameof(ValidToDate), "Valid To Date", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StateCode = group.Add(new VocabularyKey(nameof(StateCode), "Status", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
			    StatusCode = group.Add(new VocabularyKey(nameof(StatusCode), "Status Reason", VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible));             
            });
        }

        public VocabularyKey CreditPlanId { get; private set; }
        public VocabularyKey CreditType { get; private set; }
        public VocabularyKey Name { get; private set; }
        public VocabularyKey ValidToDate { get; private set; }
        public VocabularyKey StateCode { get; private set; }
        public VocabularyKey StatusCode { get; private set; }
    }
}