using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CustCustomerExternalCodeClassEntityVocabulary : SimpleVocabulary
    {
        public CustCustomerExternalCodeClassEntityVocabulary()
        {
            VocabularyName = "Common Data Model CustCustomerExternalCodeClassEntity";
            KeyPrefix = "commonDataModel.custcustomerexternalcodeclassentity";
            KeySeparator = ".";
            Grouping = "/CustCustomerExternalCodeClassEntity";

            AddGroup("Common Data Model CustCustomerExternalCodeClassEntity Details", group =>
            {
                CodeClassId = group.Add(new VocabularyKey(nameof(CodeClassId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CodeClassDefinition = group.Add(new VocabularyKey(nameof(CodeClassDefinition), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
IsStandardizedCode = group.Add(new VocabularyKey(nameof(IsStandardizedCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CodeClassDescription = group.Add(new VocabularyKey(nameof(CodeClassDescription), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CodeClassTableId = group.Add(new VocabularyKey(nameof(CodeClassTableId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CodeClassId { get; private set; }
public VocabularyKey CodeClassDefinition { get; private set; }
public VocabularyKey IsStandardizedCode { get; private set; }
public VocabularyKey CodeClassDescription { get; private set; }
public VocabularyKey CodeClassTableId { get; private set; }


    }
}