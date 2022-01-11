using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class VendVendorExternalCodeClassEntityVocabulary : SimpleVocabulary
    {
        public VendVendorExternalCodeClassEntityVocabulary()
        {
            VocabularyName = "Common Data Model VendVendorExternalCodeClassEntity";
            KeyPrefix = "commonDataModel.vendvendorexternalcodeclassentity";
            KeySeparator = ".";
            Grouping = "/VendVendorExternalCodeClassEntity";

            AddGroup("Common Data Model VendVendorExternalCodeClassEntity Details", group =>
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