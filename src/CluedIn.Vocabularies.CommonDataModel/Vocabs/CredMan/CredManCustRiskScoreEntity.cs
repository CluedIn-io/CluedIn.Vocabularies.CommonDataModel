using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CredManCustRiskScoreEntityVocabulary : SimpleVocabulary
    {
        public CredManCustRiskScoreEntityVocabulary()
        {
            VocabularyName = "Common Data Model CredManCustRiskScoreEntity";
            KeyPrefix = "commonDataModel.credmancustriskscoreentity";
            KeySeparator = ".";
            Grouping = "/CredManCustRiskScoreEntity";

            AddGroup("Common Data Model CredManCustRiskScoreEntity Details", group =>
            {
                CustAccount = group.Add(new VocabularyKey(nameof(CustAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RiskScoreGroupId = group.Add(new VocabularyKey(nameof(RiskScoreGroupId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Value = group.Add(new VocabularyKey(nameof(Value), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CustAccount { get; private set; }
public VocabularyKey RiskScoreGroupId { get; private set; }
public VocabularyKey Value { get; private set; }


    }
}