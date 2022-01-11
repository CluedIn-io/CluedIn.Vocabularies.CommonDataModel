using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPurchaseOrderUpdateLinesParametersEntityVocabulary : SimpleVocabulary
    {
        public PurchPurchaseOrderUpdateLinesParametersEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPurchaseOrderUpdateLinesParametersEntity";
            KeyPrefix = "commonDataModel.purchpurchaseorderupdatelinesparametersentity";
            KeySeparator = ".";
            Grouping = "/PurchPurchaseOrderUpdateLinesParametersEntity";

            AddGroup("Common Data Model PurchPurchaseOrderUpdateLinesParametersEntity Details", group =>
            {
                PurchaseOrderHeaderFieldName = group.Add(new VocabularyKey(nameof(PurchaseOrderHeaderFieldName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseOrderLineUpdateRule = group.Add(new VocabularyKey(nameof(PurchaseOrderLineUpdateRule), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
FieldId = group.Add(new VocabularyKey(nameof(FieldId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PurchaseOrderHeaderFieldName { get; private set; }
public VocabularyKey PurchaseOrderLineUpdateRule { get; private set; }
public VocabularyKey FieldId { get; private set; }


    }
}