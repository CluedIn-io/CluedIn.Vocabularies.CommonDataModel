using CluedIn.Core.Data;
using CluedIn.Core.Data.Vocabularies;

namespace CluedIn.Crawling.CommonDataModel.Vocabularies
{
    public class PurchPublishedRequestForQuotationLineEntityVocabulary : SimpleVocabulary
    {
        public PurchPublishedRequestForQuotationLineEntityVocabulary()
        {
            VocabularyName = "Common Data Model PurchPublishedRequestForQuotationLineEntity";
            KeyPrefix = "commonDataModel.purchpublishedrequestforquotationlineentity";
            KeySeparator = ".";
            Grouping = "/PurchPublishedRequestForQuotationLineEntity";

            AddGroup("Common Data Model PurchPublishedRequestForQuotationLineEntity Details", group =>
            {
                PublishedRFQCaseNumber = group.Add(new VocabularyKey(nameof(PublishedRFQCaseNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQCaseRecId = group.Add(new VocabularyKey(nameof(RFQCaseRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQCaseTableRecId = group.Add(new VocabularyKey(nameof(RFQCaseTableRecId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CategoryId = group.Add(new VocabularyKey(nameof(CategoryId), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
LineNumber = group.Add(new VocabularyKey(nameof(LineNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ItemNumber = group.Add(new VocabularyKey(nameof(ItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProductName = group.Add(new VocabularyKey(nameof(ProductName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ExternalItemNumber = group.Add(new VocabularyKey(nameof(ExternalItemNumber), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
ProcurementCategoryName = group.Add(new VocabularyKey(nameof(ProcurementCategoryName), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
CurrencyCode = group.Add(new VocabularyKey(nameof(CurrencyCode), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
RFQDeliveryDate = group.Add(new VocabularyKey(nameof(RFQDeliveryDate), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseQuantity = group.Add(new VocabularyKey(nameof(PurchaseQuantity), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
PurchaseUnitSymbol = group.Add(new VocabularyKey(nameof(PurchaseUnitSymbol), VocabularyKeyDataType.Text, VocabularyKeyVisibility.Visible)); 
             
            });
        }

       public VocabularyKey PublishedRFQCaseNumber { get; private set; }
public VocabularyKey RFQCaseRecId { get; private set; }
public VocabularyKey RFQCaseTableRecId { get; private set; }
public VocabularyKey CategoryId { get; private set; }
public VocabularyKey LineNumber { get; private set; }
public VocabularyKey ItemNumber { get; private set; }
public VocabularyKey ProductName { get; private set; }
public VocabularyKey ExternalItemNumber { get; private set; }
public VocabularyKey ProcurementCategoryName { get; private set; }
public VocabularyKey CurrencyCode { get; private set; }
public VocabularyKey RFQDeliveryDate { get; private set; }
public VocabularyKey PurchaseQuantity { get; private set; }
public VocabularyKey PurchaseUnitSymbol { get; private set; }


    }
}