using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class MCRTaxGroupDefaultRulesEntityVocabulary : SimpleVocabulary
    {
        public MCRTaxGroupDefaultRulesEntityVocabulary()
        {
            VocabularyName = "Common Data Model MCRTaxGroupDefaultRulesEntity";
            KeyPrefix = "commonDataModel.mcrtaxgroupdefaultrulesentity";
            KeySeparator = ".";
            Grouping = "/MCRTaxGroupDefaultRulesEntity";

            AddGroup("Common Data Model MCRTaxGroupDefaultRulesEntity Details", group =>
            {
                IncludeCity = group.Add(new VocabularyKey(nameof(IncludeCity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeCountry = group.Add(new VocabularyKey(nameof(IncludeCountry), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeCounty = group.Add(new VocabularyKey(nameof(IncludeCounty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Priority = group.Add(new VocabularyKey(nameof(Priority), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeState = group.Add(new VocabularyKey(nameof(IncludeState), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IncludeZipCode = group.Add(new VocabularyKey(nameof(IncludeZipCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey IncludeCity { get; private set; }
public VocabularyKey IncludeCountry { get; private set; }
public VocabularyKey IncludeCounty { get; private set; }
public VocabularyKey Priority { get; private set; }
public VocabularyKey IncludeState { get; private set; }
public VocabularyKey IncludeZipCode { get; private set; }


    }
}