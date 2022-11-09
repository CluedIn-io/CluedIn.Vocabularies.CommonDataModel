using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class RDeferralsFactorCalculationEntityVocabulary : SimpleVocabulary
    {
        public RDeferralsFactorCalculationEntityVocabulary()
        {
            VocabularyName = "Common Data Model RDeferralsFactorCalculationEntity";
            KeyPrefix = "commonDataModel.rdeferralsfactorcalculationentity";
            KeySeparator = ".";
            Grouping = "/RDeferralsFactorCalculationEntity";

            AddGroup("Common Data Model RDeferralsFactorCalculationEntity Details", group =>
            {
                Calculated = group.Add(new VocabularyKey(nameof(Calculated), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
EndDate = group.Add(new VocabularyKey(nameof(EndDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PeriodType = group.Add(new VocabularyKey(nameof(PeriodType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
StartDate = group.Add(new VocabularyKey(nameof(StartDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Calculated { get; private set; }
public VocabularyKey EndDate { get; private set; }
public VocabularyKey PeriodType { get; private set; }
public VocabularyKey StartDate { get; private set; }


    }
}