using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class SalesQuotationPrognosisEntityVocabulary : SimpleVocabulary
    {
        public SalesQuotationPrognosisEntityVocabulary()
        {
            VocabularyName = "Common Data Model SalesQuotationPrognosisEntity";
            KeyPrefix = "commonDataModel.salesquotationprognosisentity";
            KeySeparator = ".";
            Grouping = "/SalesQuotationPrognosisEntity";

            AddGroup("Common Data Model SalesQuotationPrognosisEntity Details", group =>
            {
                PrognosisDescription = group.Add(new VocabularyKey(nameof(PrognosisDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrognosisFromDay = group.Add(new VocabularyKey(nameof(PrognosisFromDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrognosisCode = group.Add(new VocabularyKey(nameof(PrognosisCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PrognosisToDay = group.Add(new VocabularyKey(nameof(PrognosisToDay), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PrognosisDescription { get; private set; }
public VocabularyKey PrognosisFromDay { get; private set; }
public VocabularyKey PrognosisCode { get; private set; }
public VocabularyKey PrognosisToDay { get; private set; }


    }
}