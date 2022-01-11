using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PaymentSurveyCodeEntityVocabulary : SimpleVocabulary
    {
        public PaymentSurveyCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model PaymentSurveyCodeEntity";
            KeyPrefix = "commonDataModel.paymentsurveycodeentity";
            KeySeparator = ".";
            Grouping = "/PaymentSurveyCodeEntity";

            AddGroup("Common Data Model PaymentSurveyCodeEntity Details", group =>
            {
                CountryRegionSummary = group.Add(new VocabularyKey(nameof(CountryRegionSummary), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SurveyCode = group.Add(new VocabularyKey(nameof(SurveyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Company = group.Add(new VocabularyKey(nameof(Company), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CentralBankPurposeCode = group.Add(new VocabularyKey(nameof(CentralBankPurposeCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CountryRegionSummary { get; private set; }
public VocabularyKey SurveyCode { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey Company { get; private set; }
public VocabularyKey CentralBankPurposeCode { get; private set; }


    }
}