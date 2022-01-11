using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PlSADDocumentLinePurchaseOrderEntityVocabulary : SimpleVocabulary
    {
        public PlSADDocumentLinePurchaseOrderEntityVocabulary()
        {
            VocabularyName = "Common Data Model PlSADDocumentLinePurchaseOrderEntity";
            KeyPrefix = "commonDataModel.plsaddocumentlinepurchaseorderentity";
            KeySeparator = ".";
            Grouping = "/PlSADDocumentLinePurchaseOrderEntity";

            AddGroup("Common Data Model PlSADDocumentLinePurchaseOrderEntity Details", group =>
            {
                Dimension = group.Add(new VocabularyKey(nameof(Dimension), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
BaseForSAD = group.Add(new VocabularyKey(nameof(BaseForSAD), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Duty = group.Add(new VocabularyKey(nameof(Duty), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Excise = group.Add(new VocabularyKey(nameof(Excise), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Position = group.Add(new VocabularyKey(nameof(Position), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DocumentCode = group.Add(new VocabularyKey(nameof(DocumentCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SADGroup = group.Add(new VocabularyKey(nameof(SADGroup), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
Transport = group.Add(new VocabularyKey(nameof(Transport), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxAmount = group.Add(new VocabularyKey(nameof(SalesTaxAmount), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
SalesTaxCode = group.Add(new VocabularyKey(nameof(SalesTaxCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
DimensionDisplayValue = group.Add(new VocabularyKey(nameof(DimensionDisplayValue), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey Dimension { get; private set; }
public VocabularyKey BaseForSAD { get; private set; }
public VocabularyKey Duty { get; private set; }
public VocabularyKey Excise { get; private set; }
public VocabularyKey Position { get; private set; }
public VocabularyKey DocumentCode { get; private set; }
public VocabularyKey SADGroup { get; private set; }
public VocabularyKey Transport { get; private set; }
public VocabularyKey SalesTaxAmount { get; private set; }
public VocabularyKey SalesTaxCode { get; private set; }
public VocabularyKey DimensionDisplayValue { get; private set; }


    }
}