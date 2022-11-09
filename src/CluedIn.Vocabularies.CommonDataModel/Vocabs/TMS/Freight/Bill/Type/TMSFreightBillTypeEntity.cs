using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class TMSFreightBillTypeEntityVocabulary : SimpleVocabulary
    {
        public TMSFreightBillTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model TMSFreightBillTypeEntity";
            KeyPrefix = "commonDataModel.tmsfreightbilltypeentity";
            KeySeparator = ".";
            Grouping = "/TMSFreightBillTypeEntity";

            AddGroup("Common Data Model TMSFreightBillTypeEntity Details", group =>
            {
                FreightEngineAssemblyName = group.Add(new VocabularyKey(nameof(FreightEngineAssemblyName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FreightEngineClassName = group.Add(new VocabularyKey(nameof(FreightEngineClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TypeId = group.Add(new VocabularyKey(nameof(TypeId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey FreightEngineAssemblyName { get; private set; }
public VocabularyKey FreightEngineClassName { get; private set; }
public VocabularyKey TypeId { get; private set; }


    }
}