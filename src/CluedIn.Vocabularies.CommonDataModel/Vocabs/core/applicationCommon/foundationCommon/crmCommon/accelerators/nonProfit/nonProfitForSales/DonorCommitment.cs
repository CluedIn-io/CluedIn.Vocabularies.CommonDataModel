using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies.NonProfitForSales
{
    public class DonorCommitmentVocabulary : SimpleVocabulary
    {
        public DonorCommitmentVocabulary()
        {
            VocabularyName = "Donor Commitment";
            KeyPrefix = "commonDataModel.donorcommitment.nonprofitforsales";
            KeySeparator = ".";
            Grouping = "/DonorCommitment";

            AddGroup("DonorCommitment Details for NonProfitForSales", group =>
            {
			                 
            });
        }

        
    }
}