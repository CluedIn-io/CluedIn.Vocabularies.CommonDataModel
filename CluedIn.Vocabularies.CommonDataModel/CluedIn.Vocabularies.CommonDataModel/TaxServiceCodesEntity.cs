using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxServiceCodesEntityVocabulary : SimpleVocabulary
    {
        public TaxServiceCodesEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxServiceCodesEntity";
            KeyPrefix = "commonDataModel.taxservicecodesentity";
            KeySeparator = ".";
            Grouping = "/TaxServiceCodesEntity";

            AddGroup("Common Data Model TaxServiceCodesEntity Details", group =>
            {
                MinorHead = group.Add(new VocabularyKey(nameof(MinorHead), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceAccountingCode = group.Add(new VocabularyKey(nameof(ServiceAccountingCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ServiceCode = group.Add(new VocabularyKey(nameof(ServiceCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey MinorHead { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey ServiceAccountingCode { get; private set; }
public VocabularyKey ServiceCode { get; private set; }


    }
}