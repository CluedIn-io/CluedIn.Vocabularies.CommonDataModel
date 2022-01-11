using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class FiscalEstablishmentIEPerStateEntityVocabulary : SimpleVocabulary
    {
        public FiscalEstablishmentIEPerStateEntityVocabulary()
        {
            VocabularyName = "Common Data Model FiscalEstablishmentIEPerStateEntity";
            KeyPrefix = "commonDataModel.fiscalestablishmentieperstateentity";
            KeySeparator = ".";
            Grouping = "/FiscalEstablishmentIEPerStateEntity";

            AddGroup("Common Data Model FiscalEstablishmentIEPerStateEntity Details", group =>
            {
                CountryRegionId = group.Add(new VocabularyKey(nameof(CountryRegionId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalEstablishment = group.Add(new VocabularyKey(nameof(FiscalEstablishment), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IE = group.Add(new VocabularyKey(nameof(IE), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FiscalEstablishmentId = group.Add(new VocabularyKey(nameof(FiscalEstablishmentId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CountryRegionId { get; private set; }
public VocabularyKey FiscalEstablishment { get; private set; }
public VocabularyKey IE { get; private set; }
public VocabularyKey State { get; private set; }
public VocabularyKey FiscalEstablishmentId { get; private set; }


    }
}