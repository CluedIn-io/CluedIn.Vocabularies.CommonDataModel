using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TaxServiceAccountingCodeEntityVocabulary : SimpleVocabulary
    {
        public TaxServiceAccountingCodeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TaxServiceAccountingCodeEntity";
            KeyPrefix = "commonDataModel.taxserviceaccountingcodeentity";
            KeySeparator = ".";
            Grouping = "/TaxServiceAccountingCodeEntity";

            AddGroup("Common Data Model TaxServiceAccountingCodeEntity Details", group =>
            {
                SAC = group.Add(new VocabularyKey(nameof(SAC), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey SAC { get; private set; }
public VocabularyKey Description { get; private set; }


    }
}