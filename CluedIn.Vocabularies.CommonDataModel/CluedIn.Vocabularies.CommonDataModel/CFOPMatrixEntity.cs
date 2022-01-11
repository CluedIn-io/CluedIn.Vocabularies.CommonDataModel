using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class CFOPMatrixEntityVocabulary : SimpleVocabulary
    {
        public CFOPMatrixEntityVocabulary()
        {
            VocabularyName = "Common Data Model CFOPMatrixEntity";
            KeyPrefix = "commonDataModel.cfopmatrixentity";
            KeySeparator = ".";
            Grouping = "/CFOPMatrixEntity";

            AddGroup("Common Data Model CFOPMatrixEntity Details", group =>
            {
                CFOPGroupRecId = group.Add(new VocabularyKey(nameof(CFOPGroupRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CFOPTableRecId = group.Add(new VocabularyKey(nameof(CFOPTableRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesPurchOperationTypeRecId = group.Add(new VocabularyKey(nameof(SalesPurchOperationTypeRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OptionalOperationType = group.Add(new VocabularyKey(nameof(OptionalOperationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CFOPCode = group.Add(new VocabularyKey(nameof(CFOPCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
TransactionType = group.Add(new VocabularyKey(nameof(TransactionType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationType = group.Add(new VocabularyKey(nameof(OperationType), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CFOPGroup = group.Add(new VocabularyKey(nameof(CFOPGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CFOPGroupRecId { get; private set; }
public VocabularyKey CFOPTableRecId { get; private set; }
public VocabularyKey SalesPurchOperationTypeRecId { get; private set; }
public VocabularyKey OptionalOperationType { get; private set; }
public VocabularyKey CFOPCode { get; private set; }
public VocabularyKey TransactionType { get; private set; }
public VocabularyKey OperationType { get; private set; }
public VocabularyKey CFOPGroup { get; private set; }


    }
}