using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxServiceCodeByLocationEntityVocabulary : SimpleVocabulary
    {
        public TaxServiceCodeByLocationEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxServiceCodeByLocationEntity";
            KeyPrefix = "commonDataModel.taxservicecodebylocationentity";
            KeySeparator = ".";
            Grouping = "/TaxServiceCodeByLocationEntity";

            AddGroup("Common Data Model TaxServiceCodeByLocationEntity Details", group =>
            {
                ParentServiceCode = group.Add(new VocabularyKey(nameof(ParentServiceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CountryRegion = group.Add(new VocabularyKey(nameof(CountryRegion), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
State = group.Add(new VocabularyKey(nameof(State), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
City = group.Add(new VocabularyKey(nameof(City), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceCode = group.Add(new VocabularyKey(nameof(ServiceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceCodeDescription = group.Add(new VocabularyKey(nameof(ServiceCodeDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey ParentServiceCode { get; private set; }
public VocabularyKey CountryRegion { get; private set; }
public VocabularyKey State { get; private set; }
public VocabularyKey City { get; private set; }
public VocabularyKey ServiceCode { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ServiceCodeDescription { get; private set; }


    }
}