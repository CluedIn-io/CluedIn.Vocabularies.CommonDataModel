using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class OperationTypeEntityVocabulary : SimpleVocabulary
    {
        public OperationTypeEntityVocabulary()
        {
            VocabularyName = "Common Data Model OperationTypeEntity";
            KeyPrefix = "commonDataModel.operationtypeentity";
            KeySeparator = ".";
            Grouping = "/OperationTypeEntity";

            AddGroup("Common Data Model OperationTypeEntity Details", group =>
            {
                CreateFinancialTrans = group.Add(new VocabularyKey(nameof(CreateFinancialTrans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CreateInventTrans = group.Add(new VocabularyKey(nameof(CreateInventTrans), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CustPostingProfile = group.Add(new VocabularyKey(nameof(CustPostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerDimension = group.Add(new VocabularyKey(nameof(LedgerDimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Name = group.Add(new VocabularyKey(nameof(Name), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
OperationTypeID = group.Add(new VocabularyKey(nameof(OperationTypeID), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
VendPostingProfile = group.Add(new VocabularyKey(nameof(VendPostingProfile), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LedgerDimensionDisplayValue = group.Add(new VocabularyKey(nameof(LedgerDimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey CreateFinancialTrans { get; private set; }
public VocabularyKey CreateInventTrans { get; private set; }
public VocabularyKey CustPostingProfile { get; private set; }
public VocabularyKey LedgerDimension { get; private set; }
public VocabularyKey Name { get; private set; }
public VocabularyKey OperationTypeID { get; private set; }
public VocabularyKey VendPostingProfile { get; private set; }
public VocabularyKey LedgerDimensionDisplayValue { get; private set; }


    }
}