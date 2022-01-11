using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TNVEDToCustomsPaymentsRelationsEntityVocabulary : SimpleVocabulary
    {
        public TNVEDToCustomsPaymentsRelationsEntityVocabulary()
        {
            VocabularyName = "Common Data Model TNVEDToCustomsPaymentsRelationsEntity";
            KeyPrefix = "commonDataModel.tnvedtocustomspaymentsrelationsentity";
            KeySeparator = ".";
            Grouping = "/TNVEDToCustomsPaymentsRelationsEntity";

            AddGroup("Common Data Model TNVEDToCustomsPaymentsRelationsEntity Details", group =>
            {
                TnVedCode = group.Add(new VocabularyKey(nameof(TnVedCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Direction = group.Add(new VocabularyKey(nameof(Direction), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustomsDuty = group.Add(new VocabularyKey(nameof(CustomsDuty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FromDate = group.Add(new VocabularyKey(nameof(FromDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Excise = group.Add(new VocabularyKey(nameof(Excise), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VAT = group.Add(new VocabularyKey(nameof(VAT), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey TnVedCode { get; private set; }
public VocabularyKey CountryRegionId { get; private set; }
public VocabularyKey Direction { get; private set; }
public VocabularyKey CustomsDuty { get; private set; }
public VocabularyKey FromDate { get; private set; }
public VocabularyKey Excise { get; private set; }
public VocabularyKey VAT { get; private set; }


    }
}