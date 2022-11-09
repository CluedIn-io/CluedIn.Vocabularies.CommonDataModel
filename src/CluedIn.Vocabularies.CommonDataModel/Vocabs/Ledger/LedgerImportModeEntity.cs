using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class LedgerImportModeEntityVocabulary : SimpleVocabulary
    {
        public LedgerImportModeEntityVocabulary()
        {
            VocabularyName = "Common Data Model LedgerImportModeEntity";
            KeyPrefix = "commonDataModel.ledgerimportmodeentity";
            KeySeparator = ".";
            Grouping = "/LedgerImportModeEntity";

            AddGroup("Common Data Model LedgerImportModeEntity Details", group =>
            {
                BankAccount = group.Add(new VocabularyKey(nameof(BankAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClassID = group.Add(new VocabularyKey(nameof(ClassID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
MethodOfImport = group.Add(new VocabularyKey(nameof(MethodOfImport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BridgingAccount = group.Add(new VocabularyKey(nameof(BridgingAccount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Description = group.Add(new VocabularyKey(nameof(Description), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BridgingAccountDisplayValue = group.Add(new VocabularyKey(nameof(BridgingAccountDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ClassName = group.Add(new VocabularyKey(nameof(ClassName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey BankAccount { get; private set; }
public VocabularyKey ClassID { get; private set; }
public VocabularyKey MethodOfImport { get; private set; }
public VocabularyKey BridgingAccount { get; private set; }
public VocabularyKey Description { get; private set; }
public VocabularyKey BridgingAccountDisplayValue { get; private set; }
public VocabularyKey ClassName { get; private set; }


    }
}